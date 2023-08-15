using System.Runtime.InteropServices;
using FormsThemes.Enums;
using FormsThemes.Helpers;

namespace FormsThemes.Controls;

public class ThemedComboBox : ComboBox
{
    private VisualState _visualState = VisualState.Normal;

    private VisualState EffectiveVisualState => this.GetSimpleOverridenVisualState(_visualState);

    public ThemedComboBox()
    {
        SetStyle(ControlStyles.UserPaint, true);
    }

    protected override void OnCreateControl()
    {
        base.OnCreateControl();
        DoubleBuffered = true;
        Invalidate();
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


    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        if (!this.EarlyPaint(e.Graphics, e.ClipRectangle, DesignMode))
        {
            return;
        }

        e.Graphics.DrawImage(ThemeManager.Instance!.VisualStyle.Image,
            ThemeManager.Instance.VisualStyle.ComboBox.Get(EffectiveVisualState), e.ClipRectangle);

        var rectangle = ThemeManager.Instance.VisualStyle.ComboBoxArrow.Get(EffectiveVisualState);

        e.Graphics.DrawImage(ThemeManager.Instance.VisualStyle.Image,
            new Rectangle(Bounds.Width - (rectangle.Width + 4), Bounds.Height / 2 - rectangle.Height / 2,
                rectangle.Width, rectangle.Height),
            rectangle, GraphicsUnit.Pixel);

        e.Graphics.DrawString(
            Text,
            ThemeManager.Instance.VisualStyle.Font,
            new SolidBrush(ThemeManager.Instance.VisualStyle.ComboBoxForegroundColor.Get(EffectiveVisualState)),
            e.ClipRectangle with { X = 2 },
            new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center }
        );
    }
}