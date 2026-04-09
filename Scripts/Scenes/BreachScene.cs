using System.Diagnostics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
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
        playerMouse.LoadContent(); 

        base.LoadContent();
    }
    public override void Draw(GameTime gameTime)
    {
        GameCore.GraphicsDevice.Clear(Color.Gray);

        GameCore.SpriteBatch.Begin(blendState: BlendState.NonPremultiplied);
        playerMouse.DrawPlayerMouse();
        GameCore.SpriteBatch.End();
        
        base.Draw(gameTime);
    }

    public override void Update(GameTime gameTime)
    {
        base.Update(gameTime);
    }
}
