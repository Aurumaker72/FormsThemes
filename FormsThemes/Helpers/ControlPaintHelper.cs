using System.Diagnostics;

namespace FormsThemes.Helpers;

internal static class ControlPaintHelper
{
    internal static bool EarlyPaint(this Control control, Graphics graphics, Rectangle rectangle, bool designMode)
    {
        graphics.Clear(control.Parent?.BackColor ?? Color.Red);

        if (!designMode)
        {
            if (ThemeManager.Instance == null)
            {
                throw new ApplicationException(
                    $"{nameof(ThemeManager)} needs to be initialized with {nameof(ThemeManager.Apply)} before any controls are painted");
            }

            return true;
        }

        // ThemeManager isn't initialized in the designer, so we use fallback graphics
        graphics.FillRectangle(Brushes.DimGray, rectangle);

        return false;
    }
}