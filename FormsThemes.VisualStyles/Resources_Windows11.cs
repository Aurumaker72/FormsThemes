namespace FormsThemes.VisualStyles;

public static partial class Resources
{
    public static VisualStyle Windows11
    {
        get
        {
            var visualStyle = Resources.Windows10;
            visualStyle.Image.Dispose();
            visualStyle.Image = Image.FromFile("Assets/windows-11-atlas.png");
            return visualStyle;
        }
    }
}