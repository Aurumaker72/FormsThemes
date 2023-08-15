using FormsThemes.Enums;
using FormsThemes.Helpers;

namespace FormsThemes.Controls;

public class ThemedRadioButton : RadioButton
{
    private VisualState _visualState = VisualState.Normal;

    private VisualState EffectiveVisualState => this.GetSimpleOverridenVisualState(_visualState);


    protected override void OnCreateControl()
    {
        base.OnCreateControl();
        MouseEnter += ThemedRadioButton_MouseEnter;
        MouseLeave += ThemedRadioButton_MouseLeave;
        MouseDown += ThemedRadioButton_MouseDown;
        MouseUp += ThemedRadioButton_MouseUp;
    }

    private void ThemedRadioButton_MouseUp(object? sender, MouseEventArgs e)
    {
        _visualState = VisualState.Hovered;
        Invalidate();
    }

    private void ThemedRadioButton_MouseDown(object? sender, MouseEventArgs e)
    {
        _visualState = VisualState.Active;
        Invalidate();
    }

    private void ThemedRadioButton_MouseLeave(object? sender, EventArgs e)
    {
        _visualState = VisualState.Normal;
        Invalidate();
    }

    private void ThemedRadioButton_MouseEnter(object? sender, EventArgs e)
    {
        _visualState = VisualState.Hovered;
        Invalidate();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        if (!this.EarlyPaint(e.Graphics, e.ClipRectangle, DesignMode))
        {
            return;
        }

        var visualStateful = Checked
            ? ThemeManager.Instance!.VisualStyle.RadioButtonChecked
            : ThemeManager.Instance!.VisualStyle.RadioButtonUnchecked;

        var rectangle = visualStateful.Get(EffectiveVisualState);

        e.Graphics.DrawImage(ThemeManager.Instance.VisualStyle.Image,
            new Rectangle(0, Bounds.Height / 2 - rectangle.Height / 2, rectangle.Width, rectangle.Height),
            rectangle, GraphicsUnit.Pixel);

        e.Graphics.DrawString(
            Text,
            ThemeManager.Instance.VisualStyle.Font,
            new SolidBrush(ThemeManager.Instance.VisualStyle.RadioButtonForegroundColor.Get(EffectiveVisualState)),
            e.ClipRectangle with { X = rectangle.Width + 1 },
            new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center }
        );
    }
}