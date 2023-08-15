using System.Diagnostics;
using System.Runtime.InteropServices;
using FormsThemes.Enums;
using FormsThemes.Helpers;

namespace FormsThemes.Controls;

public class ThemedTextBox : TextBox
{
    public ThemedTextBox()
    {
        SetStyle(ControlStyles.SupportsTransparentBackColor, true);
    }
    
    private VisualState _visualState = VisualState.Normal;
    private VisualState EffectiveVisualState => this.GetOverridenVisualState(_visualState);

    protected override void OnCreateControl()
    {
        base.OnCreateControl();
        BackColor = Color.Transparent;
        DoubleBuffered = true;
        MouseEnter += ThemedButton_MouseEnter;
        MouseLeave += ThemedButton_MouseLeave;
        UpdateForeColor();
    }

    private void UpdateForeColor()
    {
        ForeColor = ThemeManager.Instance!.VisualStyle.TextBoxForegroundColor.Get(EffectiveVisualState);
        Invalidate();
    }

    private void ThemedButton_MouseLeave(object? sender, EventArgs e)
    {
        Debug.Print("Mouse leave");
        _visualState = VisualState.Normal;
        UpdateForeColor();
    }

    private void ThemedButton_MouseEnter(object? sender, EventArgs e)
    {
        Debug.Print("Mouse enter");
        _visualState = VisualState.Hovered;
        UpdateForeColor();
    }

    [DllImport("user32")]
    private static extern IntPtr GetWindowDC(IntPtr hwnd);

    protected override void WndProc(ref Message m)
    {
        if (m.Msg == 0x85) //WM_NCPAINT    
        {
            
            using var graphics = Graphics.FromHdc(GetWindowDC(Handle));


            
            var bounds = Bounds with { X = 0, Y = 0 };

            if (!this.EarlyPaint(graphics, bounds, DesignMode))
            {
                return;
            }
            
            graphics.DrawImage(ThemeManager.Instance!.VisualStyle.Image,
                ThemeManager.Instance.VisualStyle.TextBox.Get(EffectiveVisualState), bounds);

            return;
        }

        base.WndProc(ref m);
    }
}