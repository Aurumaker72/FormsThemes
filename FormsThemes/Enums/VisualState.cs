namespace FormsThemes.Enums;

/// <summary>
///     Describes visual states of a control
/// </summary>
public enum VisualState
{
    /// <summary>
    ///     The control is not being interacted with and is enabled
    /// </summary>
    Normal,

    /// <summary>
    ///     The mouse's position is inside the control's bounds
    /// </summary>
    Hovered,

    /// <summary>
    ///     The primary mouse button is being held down over the control
    /// </summary>
    Active,

    /// <summary>
    /// The control has input focus
    /// </summary>
    Focused,
    
    /// <summary>
    ///     The control is disabled
    /// </summary>
    Disabled
}