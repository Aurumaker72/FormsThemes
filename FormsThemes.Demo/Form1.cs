using FormsThemes.Controls;

namespace FormsThemes.Demo;

public partial class Form1 : ThemedForm
{
    public Form1()
    {
        InitializeComponent();

        themedButton1.Click += (sender, args) =>
        {
            var visualStyle = Program.Windows10VisualStyle;
            visualStyle.Image = Image.FromFile("windows-11-atlas.png");
            ThemeManager.Apply(visualStyle);
            
            new Form1().Show();
        };
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
        foreach (var item in Controls)
        {
            if (item != sender && item is Control control)
            {
                control.Enabled ^= true;
            }
        }
    }
}