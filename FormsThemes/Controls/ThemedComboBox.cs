using System.Runtime.InteropServices;
using FormsThemes.Enums;
using FormsThemes.Helpers;

namespace FormsThemes.Controls;

public class ThemedComboBox : ComboBox
{
    private VisualState _visualState = VisualState.Normal;

    private VisualState EffectiveVisualState => this.GetOverridenVisualState(_visualState);


    protected override void OnCreateControl()
    {
        base.OnCreateControl();
        MouseEnter += ThemedButton_MouseEnter;
        MouseLeave += ThemedButton_MouseLeave;
        MouseDown += ThemedButton_MouseDown;
        MouseUp += ThemedButton_MouseUp;
    }

    private void ThemedButton_MouseUp(object? sender, MouseEventArgs e)
    {
        _visualState = VisualState.Hovered;
        Invalidate();
    }

    private void ThemedButton_MouseDown(object? sender, MouseEventArgs e)
    {
        _visualState = VisualState.Active;
        Invalidate();
    }

    private void ThemedButton_MouseLeave(object? sender, EventArgs e)
    {
        _visualState = VisualState.Normal;
        Invalidate();
    }

    private void ThemedButton_MouseEnter(object? sender, EventArgs e)
    {
        _visualState = VisualState.Hovered;
        Invalidate();
    }


    // protected override void OnPaint(PaintEventArgs e)
    // {
    //     if (!this.EarlyPaint(e, DesignMode))
    //     {
    //         return;
    //     }
    //
    //     e.Graphics.DrawImage(ThemeManager.Instance!.VisualStyle.Image,
    //         ThemeManager.Instance.VisualStyle.Button.Get(EffectiveVisualState), e.ClipRectangle);
    //
    //     e.Graphics.DrawString(
    //         Text,
    //         ThemeManager.Instance.VisualStyle.Font,
    //         new SolidBrush(ThemeManager.Instance.VisualStyle.ButtonForegroundColor.Get(EffectiveVisualState)),
    //         e.ClipRectangle,
    //         new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center }
    //     );
    // }
   
}