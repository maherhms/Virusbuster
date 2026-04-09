using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using VirusBuster.Base;

namespace VirusBuster.Player;

public class PlayerMouse
{
    Rectangle rectangle;
    Texture2D mouseTexture;
    public void LoadContent()
    {
        InitializeMouseTexture();
    }

    public void InitializeMouseTexture()
    {
        rectangle = new Rectangle(0, 0, (int)GameState.Instance.PlayerStats.CurrentAttackSize.X, (int)GameState.Instance.PlayerStats.CurrentAttackSize.Y);

        mouseTexture = new Texture2D(GameCore.GraphicsDevice, rectangle.Width, rectangle.Height);
        
        Color[] data = new Color[rectangle.Width * rectangle.Height];

        for (int i = 0; i < data.Length; ++i) 
            data[i] = Color.White;

        mouseTexture.SetData(data);
    }
    public Vector2 GetCenteredMousePosition()
{
        return new Vector2(Mouse.GetState().X - rectangle.Width / 2f,Mouse.GetState().Y - rectangle.Height / 2f);
}

    public Texture2D GetPlayerMouseTexture()
    {
        return mouseTexture;
    }
}