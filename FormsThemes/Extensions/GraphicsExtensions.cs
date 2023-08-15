using System.Drawing.Drawing2D;

namespace FormsThemes.Helpers;

/// <summary>
///     An extension <see langword="class" />, which provides additional functionality for the <see cref="Graphics" />
///     <see langword="class" />
/// </summary>
public static class GraphicsExtensions
{
    /// <summary>
    ///     Draws a ninepatch-scaled <see cref="Image" /> to the specified destination
    /// </summary>
    /// <param name="graphics">The <see cref="Graphics" /> context to draw with</param>
    /// <param name="image">The <see cref="Image" /> to draw with</param>
    /// <param name="ninepatch">
    ///     A <see cref="Ninepatch" /> <see langword="struct" />, containing data about how the
    ///     <paramref name="image" /> should be clipped and scaled
    /// </param>
    /// <param name="destination">The destination <see cref="Rectangle" /> of the <paramref name="image" /></param>
    public static void DrawImage(this Graphics graphics, Image image, Ninepatch ninepatch, Rectangle destination)
    {
        ArgumentNullException.ThrowIfNull(graphics);
        ArgumentNullException.ThrowIfNull(image);
        
        var centerRectangle = ninepatch.Center;
        var sourceRectangle = ninepatch.Source;

        Size cornerSize = new(Math.Abs(centerRectangle.X - sourceRectangle.X),
            Math.Abs(centerRectangle.Y - sourceRectangle.Y));

        Rectangle topLeft = new(sourceRectangle.X, sourceRectangle.Y, cornerSize.Width, cornerSize.Height);
        Rectangle bottomLeft = new(sourceRectangle.X, sourceRectangle.Bottom - cornerSize.Height, cornerSize.Width,
            cornerSize.Height);
        Rectangle topRight = new(sourceRectangle.Right - cornerSize.Width, sourceRectangle.Y, cornerSize.Width,
            cornerSize.Height);
        Rectangle bottomRight = new(sourceRectangle.Right - cornerSize.Width,
            sourceRectangle.Bottom - cornerSize.Height,
            cornerSize.Width, cornerSize.Height);
        Rectangle left = new(sourceRectangle.X, centerRectangle.Y, cornerSize.Width,
            sourceRectangle.Height - cornerSize.Height * 2);
        Rectangle right = new(sourceRectangle.Right - cornerSize.Width, centerRectangle.Y, cornerSize.Width,
            sourceRectangle.Height - cornerSize.Height * 2);
        Rectangle top = new(centerRectangle.X, sourceRectangle.Y, centerRectangle.Width, cornerSize.Height);
        Rectangle bottom = new(centerRectangle.X, sourceRectangle.Bottom - cornerSize.Height, centerRectangle.Width,
            cornerSize.Height);
        Rectangle center = new(centerRectangle.X, centerRectangle.Y, centerRectangle.Width, centerRectangle.Height);

        graphics.DrawImage(image, new Rectangle(destination.Left, destination.Top, cornerSize.Width, cornerSize.Height),
            topLeft, GraphicsUnit.Pixel);
        graphics.DrawImage(image,
            new Rectangle(destination.Right - cornerSize.Width, destination.Top, cornerSize.Width, cornerSize.Height),
            topRight, GraphicsUnit.Pixel);
        graphics.DrawImage(image,
            new Rectangle(destination.Left, destination.Bottom - cornerSize.Height, cornerSize.Width,
                cornerSize.Height), bottomLeft, GraphicsUnit.Pixel);
        graphics.DrawImage(image,
            new Rectangle(destination.Right - cornerSize.Width, destination.Bottom - cornerSize.Height,
                cornerSize.Width, cornerSize.Height), bottomRight, GraphicsUnit.Pixel);
        graphics.DrawImage(image,
            new Rectangle(destination.Left, destination.Top + cornerSize.Height, cornerSize.Width,
                destination.Bottom - cornerSize.Height * 2), left, GraphicsUnit.Pixel);
        graphics.DrawImage(image,
            new Rectangle(destination.Right - cornerSize.Width, destination.Top + cornerSize.Height, cornerSize.Width,
                destination.Bottom - cornerSize.Height * 2), right, GraphicsUnit.Pixel);
        graphics.DrawImage(image,
            new Rectangle(destination.Left + cornerSize.Width, destination.Top,
                destination.Right - cornerSize.Width * 2, cornerSize.Height), top, GraphicsUnit.Pixel);
        graphics.DrawImage(image,
            new Rectangle(destination.Left + cornerSize.Width, destination.Bottom - cornerSize.Height,
                destination.Right - cornerSize.Width * 2, cornerSize.Height), bottom, GraphicsUnit.Pixel);
        graphics.DrawImage(image,
            new Rectangle(destination.Left + cornerSize.Width, destination.Top + cornerSize.Height,
                destination.Right - cornerSize.Width * 2, destination.Bottom - cornerSize.Height * 2), center,
            GraphicsUnit.Pixel);
    }
}