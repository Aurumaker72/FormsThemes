namespace FormsThemes.Controls;

public class ThemedForm : Form
{
    protected override void OnShown(EventArgs e)
    {
        BackColor = ThemeManager.Instance!.VisualStyle.FormColor;
        base.OnShown(e);
    }
}