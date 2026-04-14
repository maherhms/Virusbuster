using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace VirusBuster.Utility;

/// <summary>
/// Creates a texture of given width/height filled with a single color.
/// </summary>
public static class GeometryFactory
{
    public static Texture2D CreateFilledTexture(GraphicsDevice device, int width, int height, Color fillColor)
    {
        Texture2D texture = new Texture2D(device, width, height);

        Color[] data = new Color[width * height];
        for (int i = 0; i < data.Length; i++)
            data[i] = fillColor;

        texture.SetData(data);
        return texture;
    }
}
