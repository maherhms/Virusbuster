using System.Diagnostics;
using Microsoft.Xna.Framework;
using VirusBuster.Base;
using VirusBuster.Player;

namespace VirusBuster.Scenes;

public class BreachScene : Scene
{
    PlayerMouse playerMouse = new PlayerMouse();

    public override void Initialize()
    {
        base.Initialize();
    }

    public override void LoadContent()
    {
        base.LoadContent();
        playerMouse.LoadContent();     
    }
    public override void Draw(GameTime gameTime)
    {
        GameCore.GraphicsDevice.Clear(Color.Black);

        GameCore.SpriteBatch.Begin();
        GameCore.SpriteBatch.Draw(playerMouse.GetPlayerMouseTexture(), playerMouse.GetCenteredMousePosition(), Color.CornflowerBlue);
        GameCore.SpriteBatch.End();
        
        base.Draw(gameTime);
    }

    public override void Update(GameTime gameTime)
    {
        base.Update(gameTime);
    }
}
