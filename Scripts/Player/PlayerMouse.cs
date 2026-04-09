using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using VirusBuster.Base;

namespace VirusBuster.Player;

public class PlayerMouse
{
    Rectangle rectangle;
    Texture2D mouseTexture;
    private Texture2D mouseContourTexture;
    int contourThickness = 5;

    Color mouseColor = new Color(0, 255, 0, 20);
    public void LoadContent()
    {
        InitializeMouseTexture();
    }

    public void InitializeMouseTexture()
    {
        rectangle = new Rectangle(0, 0, (int)GameState.Instance.PlayerStats.CurrentAttackSize.X, (int)GameState.Instance.PlayerStats.CurrentAttackSize.Y);

        mouseTexture = new Texture2D(GameCore.GraphicsDevice, rectangle.Width, rectangle.Height);
        mouseContourTexture = mouseTexture;
        
        Color[] data = new Color[rectangle.Width * rectangle.Height];

        for (int i = 0; i < data.Length; ++i) 
            data[i] = Color.White;

        mouseTexture.SetData(data);
    }
    public Vector2 GetCenteredMousePosition()
    {
        return new Vector2(Mouse.GetState().X - rectangle.Width / 2f,Mouse.GetState().Y - rectangle.Height / 2f);
    }

    public Vector2 GetMousePosition()
    {
        return new Vector2(Mouse.GetState().X ,Mouse.GetState().Y);
    }

    public Texture2D GetPlayerMouseTexture()
    {
        return mouseTexture;
    }

    public Color GetPlayerMouseColor()
    {
        return mouseColor;
    }

    public void DrawPlayerMouse()
    {
        GameCore.SpriteBatch.Draw(mouseTexture, GetCenteredMousePosition(), mouseColor);
        DrawOutline(GameCore.SpriteBatch,GetCenteredMousePosition(), Color.White);
    }

    public void DrawOutline(SpriteBatch spriteBatch, Vector2 position, Color color)
    {

    // Top Left
    spriteBatch.Draw(mouseContourTexture, new Rectangle((int)position.X, (int)position.Y, rectangle.Width/5, contourThickness), color);

    // Top Right
    spriteBatch.Draw(mouseContourTexture, new Rectangle((int)position.X + (4 * rectangle.Width /5 ), (int)position.Y, rectangle.Width/5, contourThickness), color);

    // Bottom Left
    spriteBatch.Draw(mouseContourTexture, new Rectangle((int)position.X, (int)position.Y + rectangle.Height - contourThickness, rectangle.Width/5, contourThickness), color);

    // Bottom Right
    spriteBatch.Draw(mouseContourTexture, new Rectangle((int)position.X + (4 * rectangle.Width /5 ), (int)position.Y + rectangle.Height - contourThickness, rectangle.Width/5, contourThickness), color);

    // Left Up
    spriteBatch.Draw(mouseContourTexture, new Rectangle((int)position.X, (int)position.Y, contourThickness, rectangle.Height /5), color);

    // Left Bottom
    spriteBatch.Draw(mouseContourTexture, new Rectangle((int)position.X, (int)position.Y + ( 4* rectangle.Height /5), contourThickness, rectangle.Height /5), color);

    // Right Up
    spriteBatch.Draw(mouseContourTexture, new Rectangle((int)position.X + rectangle.Width - contourThickness, (int)position.Y, contourThickness, rectangle.Height /5), color);

    // Right
    spriteBatch.Draw(mouseContourTexture, new Rectangle((int)position.X + rectangle.Width - contourThickness, (int)position.Y + ( 4* rectangle.Height /5) , contourThickness, rectangle.Height /5), color);
}

}