namespace FormsThemes.VisualStyles;

public static partial class Resources
{
    public static VisualStyle Windows10Dark
    {
        get
        {
            var visualStyle = Windows10;
            visualStyle.ButtonForegroundColor = new()
            {
                Normal = Color.White,
                Active = Color.White,
                Hovered = Color.White,
                Focused = Color.White,
                Disabled = visualStyle.ButtonForegroundColor.Disabled
            };
            visualStyle.CheckBoxForegroundColor = new()
            {
                Normal = Color.White,
                Active = Color.White,
                Hovered = Color.White,
                Focused = Color.White,
                Disabled = visualStyle.CheckBoxForegroundColor.Disabled
            };
            visualStyle.RadioButtonForegroundColor = new()
            {
                Normal = Color.White,
                Active = Color.White,
                Hovered = Color.White,
                Focused = Color.White,
                Disabled = visualStyle.RadioButtonForegroundColor.Disabled
            };
            visualStyle.TextBoxForegroundColor = new()
            {
                Normal = Color.White,
                Active = Color.White,
                Hovered = Color.White,
                Focused = Color.White,
                Disabled = visualStyle.TextBoxForegroundColor.Disabled
            };
            visualStyle.ComboBoxForegroundColor = new()
            {
                Normal = Color.White,
                Active = Color.White,
                Hovered = Color.White,
                Focused = Color.White,
                Disabled = visualStyle.ComboBoxForegroundColor.Disabled
            };
            visualStyle.FormColor = Color.FromArgb(25, 25, 25);
            visualStyle.Image.Dispose();
            visualStyle.Image = Image.FromFile("Assets/windows-10-dark-atlas.png");
            return visualStyle;
        }
    }
}