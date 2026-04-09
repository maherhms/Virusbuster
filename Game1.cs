using Microsoft.Xna.Framework.Media;
using VirusBuster.Scenes;
using VirusBuster.Base;

namespace VirusBuster;

public class Game1 : GameCore
{

    public Game1() : base("VirusBuster", 1280, 720, false)
    {

    }

    protected override void Initialize()
    {
        base.Initialize();

        GameState.Initialize();

        // Start the game with the title scene.
        ChangeScene(new BreachScene());
    }

    protected override void LoadContent()
    {
    }
}
