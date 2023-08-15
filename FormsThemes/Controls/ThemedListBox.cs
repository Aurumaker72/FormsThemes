using System.Diagnostics;
using System.Drawing.Drawing2D;
using FormsThemes.Enums;
using FormsThemes.Helpers;

namespace FormsThemes.Controls;

public class ThemedListBox : ListBox
{
    public ThemedListBox()
    {
        SetStyle(ControlStyles.DoubleBuffer, true);
    }

    protected override void OnCreateControl()
    {
        base.OnCreateControl();
        DrawMode = DrawMode.OwnerDrawFixed;
        DrawItem += OnDrawItem;
        Invalidate();
    }

    private void OnDrawItem(object? sender, DrawItemEventArgs e)
    {
        var visualState = EffectiveVisualState;

        if (e.State.HasFlag(DrawItemState.Selected))
        {
            visualState = VisualState.Active;
        }


        // The nineslice routine doesn't like drawing from non (0, 0) origin

        e.Graphics.TranslateTransform(0, e.Bounds.Y);
        e.Graphics.DrawImage(ThemeManager.Instance!.VisualStyle.Image,
            ThemeManager.Instance.VisualStyle.ListBoxItem.Get(visualState), e.Bounds with { X = 0, Y = 0 });
        e.Graphics.DrawString(Items[e.Index].ToString(),
            ThemeManager.Instance.VisualStyle.Font,
            new SolidBrush(ThemeManager.Instance.VisualStyle.ListBoxForegroundColor.Get(visualState)),
            e.Bounds with { X = 0, Y = 0 },
            StringFormat.GenericDefault);
        e.Graphics.TranslateTransform(0, -e.Bounds.Y);
    }

    private VisualState EffectiveVisualState => this.GetOverridenVisualState(VisualState.Normal);
}