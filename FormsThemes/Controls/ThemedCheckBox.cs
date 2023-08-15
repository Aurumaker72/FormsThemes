using FormsThemes.Enums;
using FormsThemes.Helpers;

namespace FormsThemes.Controls;

public class ThemedCheckBox : CheckBox
{
    private VisualState _visualState = VisualState.Normal;

    private VisualState EffectiveVisualState => this.GetOverridenVisualState(_visualState);


    protected override void OnCreateControl()
    {
        base.OnCreateControl();
        MouseEnter += ThemedCheckBox_MouseEnter;
        MouseLeave += ThemedCheckBox_MouseLeave;
        MouseDown += ThemedCheckBox_MouseDown;
        MouseUp += ThemedCheckBox_MouseUp;
    }

    private void ThemedCheckBox_MouseUp(object? sender, MouseEventArgs e)
    {
        _visualState = VisualState.Hovered;
        Invalidate();
    }

    private void ThemedCheckBox_MouseDown(object? sender, MouseEventArgs e)
    {
        _visualState = VisualState.Active;
        Invalidate();
    }

    private void ThemedCheckBox_MouseLeave(object? sender, EventArgs e)
    {
        _visualState = VisualState.Normal;
        Invalidate();
    }

    private void ThemedCheckBox_MouseEnter(object? sender, EventArgs e)
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

        var visualStateful = CheckState switch
        {
            CheckState.Unchecked => ThemeManager.Instance!.VisualStyle.CheckBoxUnchecked,
            CheckState.Checked => ThemeManager.Instance!.VisualStyle.CheckBoxChecked,
            CheckState.Indeterminate => ThemeManager.Instance!.VisualStyle.CheckBoxIndeterminate,
            _ => throw new ArgumentOutOfRangeException()
        };

        var rectangle = visualStateful.Get(EffectiveVisualState);

        e.Graphics.DrawImage(ThemeManager.Instance.VisualStyle.Image,
            new Rectangle(0, Bounds.Height / 2 - rectangle.Height / 2, rectangle.Height, rectangle.Height),
            rectangle, GraphicsUnit.Pixel);

        e.Graphics.DrawString(
            Text,
            ThemeManager.Instance.VisualStyle.Font,
            new SolidBrush(ThemeManager.Instance.VisualStyle.CheckBoxForegroundColor.Get(EffectiveVisualState)),
            e.ClipRectangle with { X = rectangle.Width + 1 },
            new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center }
        );
    }
}