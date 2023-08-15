using FormsThemes.Enums;

namespace FormsThemes.Helpers;

internal static class ControlVisualStateHelper
{
    internal static VisualState GetOverridenVisualState(this Control control, VisualState visualState)
    {
        if (!control.Enabled || control is TextBox { ReadOnly: true })
        {
            return VisualState.Disabled;
        }

        if (visualState == VisualState.Normal && control.Focused)
        {
            return VisualState.Focused;
        }

        return visualState;
    }
    internal static VisualState GetOverridenVisualState(this TextBox textBox, VisualState visualState)
    {
        if (!textBox.Enabled || textBox.ReadOnly)
        {
            return VisualState.Disabled;
        }

        if (textBox.Focused)
        {
            return VisualState.Focused;
        }

        return visualState;
    }
    internal static VisualState GetOverridenVisualState(this CheckBox checkBox, VisualState visualState)
    {
        return !checkBox.Enabled ? VisualState.Disabled : visualState;
    }
}