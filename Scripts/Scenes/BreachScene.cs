using Microsoft.Xna.Framework;
using VirusBuster.Base;

namespace VirusBuster.Scenes;

public class BreachScene : Scene
{
    public override void Draw(GameTime gameTime)
    {
        GameCore.GraphicsDevice.Clear(Color.CornflowerBlue);
        base.Draw(gameTime);

    }
}
