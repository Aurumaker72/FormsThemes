namespace FormsThemes.VisualStyles;

public static partial class Resources
{
    public static VisualStyle Windows7 => new VisualStyle
    {
        Image = Image.FromFile("Assets/windows-7-atlas.png"),
        Font = SystemFonts.MessageBoxFont!,
        FormColor = Color.FromArgb(234, 235, 236),
        Button = new VisualStateful<Ninepatch>
        {
            Normal = new Ninepatch
            {
                Source = new Rectangle(1, 1, 11, 21),
                Center = new Rectangle(4, 4, 5, 15)
            },
            Hovered = new Ninepatch
            {
                Source = new Rectangle(1, 24, 11, 21),
                Center = new Rectangle(4, 27, 5, 15)
            },
            Active = new Ninepatch
            {
                Source = new Rectangle(1, 47, 11, 21),
                Center = new Rectangle(4, 50, 5, 15)
            },
            Focused = new Ninepatch
            {
                Source = new Rectangle(1, 93, 11, 21),
                Center = new Rectangle(4, 96, 5, 15)
            },
            Disabled = new Ninepatch
            {
                Source = new Rectangle(1, 70, 11, 21),
                Center = new Rectangle(4, 73, 5, 15)
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
                Source = new Rectangle(34, 1, 5, 5),
                Center = new Rectangle(36, 3, 1, 1)
            },
            Hovered = new Ninepatch
            {
                Source = new Rectangle(34, 6, 5, 5),
                Center = new Rectangle(36, 8, 1, 1)
            },
            Active = new Ninepatch
            {
                Source = new Rectangle(34, 11, 5, 5),
                Center = new Rectangle(36, 13, 1, 1)
            },
            Focused = new Ninepatch
            {
                Source = new Rectangle(34, 6, 5, 5),
                Center = new Rectangle(36, 8, 1, 1)
            },
            Disabled = new Ninepatch
            {
                Source = new Rectangle(34, 16, 5, 5),
                Center = new Rectangle(36, 18, 1, 1)
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
            Normal = new(82, 1, 13, 13),
            Hovered = new(82, 14, 13, 13),
            Active = new(82, 27, 13, 13),
            Focused = new(82, 14, 13, 13),
            Disabled = new(82, 40, 13, 13),
        },
        CheckBoxChecked = new VisualStateful<Rectangle>
        {
            Normal = new(82, 53, 13, 13),
            Hovered = new(82, 66, 13, 13),
            Active = new(82, 79, 13, 13),
            Focused = new(82, 66, 13, 13),
            Disabled = new(82, 92, 13, 13),
        },
        CheckBoxIndeterminate = new VisualStateful<Rectangle>
        {
            Normal = new(82, 105, 13, 13),
            Hovered = new(82, 118, 13, 13),
            Active = new(82, 131, 13, 13),
            Focused = new(82, 118, 13, 13),
            Disabled = new(82, 144, 13, 13),
        },
        CheckBoxForegroundColor = new VisualStateful<Color>
        {
            Normal = Color.Black,
            Hovered = Color.Black,
            Active = Color.Black,
            Focused = Color.Black,
            Disabled = Color.FromArgb(109, 109, 109)
        },
        RadioButtonChecked = new VisualStateful<Rectangle>
        {
            Normal = new(13, 54, 12, 12),
            Hovered = new(13, 67, 12, 12),
            Active = new(13, 80, 12, 12),
            Focused = new(13, 67, 12, 12),
            Disabled = new(13, 93, 12, 12),
        },
        RadioButtonUnchecked = new VisualStateful<Rectangle>
        {
            Normal = new(13, 2, 12, 12),
            Hovered = new(13, 15, 12, 12),
            Active = new(13, 28, 12, 12),
            Focused = new(13, 15, 12, 12),
            Disabled = new(13, 41, 12, 12),
        },
        RadioButtonForegroundColor = new VisualStateful<Color>
        {
            Normal = Color.Black,
            Hovered = Color.Black,
            Active = Color.Black,
            Focused = Color.Black,
            Disabled = Color.FromArgb(109, 109, 109)
        },
        ComboBoxArrow = new VisualStateful<Rectangle>
        {
            Normal = new(28, 94, 7, 4),
            Hovered = new(28, 94, 7, 4),
            Active = new(28, 94, 7, 4),
            Focused = new(28, 94, 7, 4),
            Disabled = new(28, 151, 7, 4),
        },
        ComboBox = new VisualStateful<Ninepatch>
        {
            Normal = new Ninepatch
            {
                Source = new Rectangle(26, 1, 7, 21),
                Center = new Rectangle(29, 9, 1, 4)
            },
            Hovered = new Ninepatch
            {
                Source = new Rectangle(26, 22, 7, 21),
                Center = new Rectangle(29, 30, 1, 4)
            },
            Active = new Ninepatch
            {
                Source = new Rectangle(26, 43, 7, 21),
                Center = new Rectangle(29, 52, 1, 4)
            },
            Focused = new Ninepatch
            {
                Source = new Rectangle(26, 22, 7, 21),
                Center = new Rectangle(29, 30, 1, 4)
            },
            Disabled = new Ninepatch
            {
                Source = new Rectangle(26, 64, 7, 21),
                Center = new Rectangle(29, 72, 1, 4)
            }
        },
        ComboBoxForegroundColor = new VisualStateful<Color>
        {
            Normal = Color.Black,
            Hovered = Color.Black,
            Active = Color.Black,
            Focused = Color.Black,
            Disabled = Color.FromArgb(109, 109, 109)
        },
        ListBox = new()
        {
            Normal = new Ninepatch
            {
                Source = new Rectangle(34, 22, 3, 3),
                Center = new Rectangle(35, 23, 1, 1)
            },
            Hovered = new Ninepatch
            {
                Source = new Rectangle(34, 22, 3, 3),
                Center = new Rectangle(35, 23, 1, 1)
            },
            Active = new Ninepatch
            {
                Source = new Rectangle(34, 22, 3, 3),
                Center = new Rectangle(35, 23, 1, 1)
            },
            Focused = new Ninepatch
            {
                Source = new Rectangle(34, 22, 3, 3),
                Center = new Rectangle(35, 23, 1, 1)
            },
            Disabled = new Ninepatch
            {
                Source = new Rectangle(34, 31, 3, 3),
                Center = new Rectangle(35, 32, 1, 1)
            }
        },
        ListBoxItem = new()
        {
            Normal = new Ninepatch
            {
                Source = new Rectangle(34, 40, 3, 4),
                Center = new Rectangle(35, 41, 1, 2)
            },
            Hovered = new Ninepatch
            {
                Source = new Rectangle(34, 40, 3, 4),
                Center = new Rectangle(35, 41, 1, 2)
            },
            Active = new Ninepatch
            {
                Source = new Rectangle(34, 35, 3, 4),
                Center = new Rectangle(35, 36, 1, 2)
            },
            Focused = new Ninepatch
            {
                Source = new Rectangle(34, 40, 3, 4),
                Center = new Rectangle(35, 41, 1, 2)
            },
            Disabled = new Ninepatch
            {
                Source = new Rectangle(34, 40, 3, 4),
                Center = new Rectangle(35, 41, 1, 2)
            }
        },
        ListBoxForegroundColor = new VisualStateful<Color>
        {
            Normal = Color.Black,
            Hovered = Color.Black,
            Active = Color.White,
            Focused = Color.Black,
            Disabled = Color.FromArgb(109, 109, 109)
        },
    };
}