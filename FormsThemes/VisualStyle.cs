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
    public Image Image { get; set; }
    public Font Font { get; set; }
    public Color FormColor { get; set; }
    public VisualStateful<Ninepatch> Button { get; set; }
    public VisualStateful<Color> ButtonForegroundColor { get; set; }
    public VisualStateful<Ninepatch> TextBox { get; set; }
    public VisualStateful<Color> TextBoxForegroundColor { get; set; }
    public VisualStateful<Rectangle> CheckBoxUnchecked { get; set; }
    public VisualStateful<Rectangle> CheckBoxChecked { get; set; }
    public VisualStateful<Rectangle> CheckBoxIndeterminate { get; set; }
    public VisualStateful<Color> CheckBoxForegroundColor { get; set; }
    public VisualStateful<Rectangle> RadioButtonUnchecked { get; set; }
    public VisualStateful<Rectangle> RadioButtonChecked { get; set; }
    public VisualStateful<Color> RadioButtonForegroundColor { get; set; }
    public VisualStateful<Ninepatch> ComboBox { get; set; }
    public VisualStateful<Rectangle> ComboBoxArrow { get; set; }
    public VisualStateful<Color> ComboBoxForegroundColor { get; set; }
}