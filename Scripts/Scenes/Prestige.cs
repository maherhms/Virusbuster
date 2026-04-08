using Microsoft.Xna.Framework;
using MonoGameLibrary;
using MonoGameLibrary.Scenes;

namespace VirusBuster.Scenes;

public class Prestige : Scene
{
    public override void Draw(GameTime gameTime)
    {
        Core.GraphicsDevice.Clear(Color.CornflowerBlue);
        base.Draw(gameTime);
    }
}
