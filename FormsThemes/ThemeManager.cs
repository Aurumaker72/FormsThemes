﻿using FormsThemes.Controls;

namespace FormsThemes;

public class ThemeManager
{
    internal static ThemeManager? Instance { get; private set; }

    internal VisualStyle VisualStyle { get; private init; }
    
    public static void Apply(VisualStyle visualStyle)
    {
        Instance = new ThemeManager
        {
            VisualStyle = visualStyle
        };
    }
}