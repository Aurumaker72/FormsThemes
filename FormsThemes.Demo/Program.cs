namespace FormsThemes.Demo;

internal static class Program
{
    public static VisualStyle Windows10VisualStyle => new VisualStyle
    {
        Image = Image.FromFile("windows-10-atlas.png"),
        Font = SystemFonts.MessageBoxFont!,
        FormColor = Color.FromArgb(240, 240, 240),
        Button = new VisualStateful<Ninepatch>
        {
            Normal = new Ninepatch
            {
                Source = new Rectangle(1, 1, 11, 9),
                Center = new Rectangle(6, 5, 1, 1)
            },
            Hovered = new Ninepatch
            {
                Source = new Rectangle(1, 12, 11, 9),
                Center = new Rectangle(6, 16, 1, 1)
            },
            Active = new Ninepatch
            {
                Source = new Rectangle(1, 23, 11, 9),
                Center = new Rectangle(6, 27, 1, 1)
            },
            Focused = new Ninepatch
            {
                Source = new Rectangle(1, 45, 11, 9),
                Center = new Rectangle(6, 49, 1, 1)
            },
            Disabled = new Ninepatch
            {
                Source = new Rectangle(1, 34, 11, 9),
                Center = new Rectangle(6, 38, 1, 1)
            }
        },
        ButtonForegroundColor = new VisualStateful<Color>
        {
            Normal = Color.Black,
            Hovered = Color.Black,
            Active = Color.Black,
            Focused = Color.Black,
            Disabled = Color.FromArgb(131, 131, 131)
        },
        TextBox = new VisualStateful<Ninepatch>
        {
            Normal = new Ninepatch
            {
                Source = new Rectangle(74, 1, 5, 5),
                Center = new Rectangle(76, 3, 1, 1)
            },
            Hovered = new Ninepatch
            {
                Source = new Rectangle(74, 6, 5, 5),
                Center = new Rectangle(76, 8, 1, 1)
            },
            Active = new Ninepatch
            {
                Source = new Rectangle(74, 11, 5, 5),
                Center = new Rectangle(76, 13, 1, 1)
            },
            Focused = new Ninepatch
            {
                Source = new Rectangle(74, 11, 5, 5),
                Center = new Rectangle(76, 13, 1, 1)
            },
            Disabled = new Ninepatch
            {
                Source = new Rectangle(74, 16, 5, 5),
                Center = new Rectangle(76, 18, 1, 1)
            }
        },
        TextBoxForegroundColor = new VisualStateful<Color>
        {
            Normal = Color.Black,
            Hovered = Color.Black,
            Active = Color.Black,
            Focused = Color.Black,
            Disabled = Color.FromArgb(109, 109, 109)
        },
        CheckBoxUnchecked = new VisualStateful<Rectangle>
        {
            Normal = new(86, 1, 13, 13),
            Hovered = new(86, 14, 13, 13),
            Active = new(86, 27, 13, 13),
            Focused = new(86, 14, 13, 13),
            Disabled = new(86, 40, 13, 13),
        },
        CheckBoxChecked = new VisualStateful<Rectangle>
        {
            Normal = new(86, 53, 13, 13),
            Hovered = new(86, 66, 13, 13),
            Active = new(86, 79, 13, 13),
            Focused = new(86, 66, 13, 13),
            Disabled = new(86, 92, 13, 13),
        },
        CheckBoxIndeterminate = new VisualStateful<Rectangle>
        {
            Normal = new(86, 105, 13, 13),
            Hovered = new(86, 118, 13, 13),
            Active = new(86, 131, 13, 13),
            Focused = new(86, 118, 13, 13),
            Disabled = new(86, 144, 13, 13),
        },
        CheckBoxForegroundColor = new VisualStateful<Color>
        {
            Normal = Color.Black,
            Hovered = Color.Black,
            Active = Color.Black,
            Focused = Color.Black,
            Disabled = Color.FromArgb(109, 109, 109)
        }
    };

    /// <summary>
    ///     The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        ThemeManager.Apply(Windows10VisualStyle);

        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());
    }
}