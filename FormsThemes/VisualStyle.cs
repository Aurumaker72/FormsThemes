using FormsThemes.Enums;

namespace FormsThemes;

public readonly record struct Ninepatch(Rectangle Source, Rectangle Center);

public readonly record struct VisualStateful<T>(T Normal, T Hovered, T Active, T Focused, T Disabled) where T : struct
{
    /// <summary>
    ///     Gets a member associated with the <paramref name="visualState" />
    /// </summary>
    /// <param name="visualState">The <see cref="VisualState" /> to search for</param>
    /// <returns>The <typeparamref name="T" /> member associated with the <paramref name="visualState" /></returns>
    /// <exception cref="ArgumentException">Thrown when the <paramref name="visualState" /> can't be resolved</exception>
    public T Get(VisualState visualState)
    {
        return visualState switch
        {
            VisualState.Normal => Normal,
            VisualState.Hovered => Hovered,
            VisualState.Active => Active,
            VisualState.Focused => Focused,
            VisualState.Disabled => Disabled,
            _ => throw new ArgumentException($"Couldn't resolve {visualState}")
        };
    }
}

public record struct VisualStyle
{
    public required Image Image { get; set; }
    public required Font Font { get; set; }
    public required Color FormColor { get; set; }
    public required VisualStateful<Ninepatch> Button { get; set; }
    public required VisualStateful<Color> ButtonForegroundColor { get; set; }
    public required VisualStateful<Ninepatch> TextBox { get; set; }
    public required VisualStateful<Color> TextBoxForegroundColor { get; set; }
    public required VisualStateful<Rectangle> CheckBoxUnchecked { get; set; }
    public required VisualStateful<Rectangle> CheckBoxChecked { get; set; }
    public required VisualStateful<Rectangle> CheckBoxIndeterminate { get; set; }
    public required VisualStateful<Color> CheckBoxForegroundColor { get; set; }
    public required VisualStateful<Rectangle> RadioButtonUnchecked { get; set; }
    public required VisualStateful<Rectangle> RadioButtonChecked { get; set; }
    public required VisualStateful<Color> RadioButtonForegroundColor { get; set; }
    public required VisualStateful<Ninepatch> ComboBox { get; set; }
    public required VisualStateful<Rectangle> ComboBoxArrow { get; set; }
    public required VisualStateful<Color> ComboBoxForegroundColor { get; set; }
    public required VisualStateful<Ninepatch> ListBox { get; set; }
    public required VisualStateful<Ninepatch> ListBoxItem { get; set; }
    public required VisualStateful<Color> ListBoxForegroundColor { get; set; }


}