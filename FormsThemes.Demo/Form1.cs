using FormsThemes.Controls;
using FormsThemes.VisualStyles;

namespace FormsThemes.Demo;

public partial class Form1 : ThemedForm
{
    public Form1()
    {
        InitializeComponent();
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


    private void themedButton1_Click(object sender, EventArgs e)
    {
        ThemeManager.Apply(Resources.Windows7);
    }

    private void themedButton2_Click(object sender, EventArgs e)
    {
        ThemeManager.Apply(Resources.Windows10);
    }

    private void themedButton3_Click(object sender, EventArgs e)
    {
        ThemeManager.Apply(Resources.Windows11);
    }

    private void themedButton4_Click(object sender, EventArgs e)
    {
        ThemeManager.Apply(Resources.Windows10Dark);
    }
}