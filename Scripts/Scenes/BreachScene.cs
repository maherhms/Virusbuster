using System.Diagnostics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using VirusBuster.Base;
using VirusBuster.Enemies;
using VirusBuster.Player;

namespace VirusBuster.Scenes;

public class BreachScene : Scene
{
    private PlayerMouse _playerMouse;
    private PlayerAttackManager _playerAttackManager;
    private EnemyManager _enemyManager;
    private EnemySpawner _enemySpawner;
    public BreachScene()
    {
        _enemyManager = new EnemyManager();
        _enemySpawner = new EnemySpawner(_enemyManager);
    }
    public override void Initialize()
    {
        _playerMouse = new PlayerMouse();
        _playerAttackManager = new PlayerAttackManager(_playerMouse);
        
        
        base.Initialize();
    }

    public override void LoadContent()
    {
        _playerMouse.LoadPlayerMouseContent();

        base.LoadContent();
    }
    public override void Draw(GameTime gameTime)
    {
        GameCore.GraphicsDevice.Clear(Color.Gray);

        GameCore.SpriteBatch.Begin(blendState: BlendState.NonPremultiplied);
        _playerMouse.DrawPlayerMouse(GameCore.SpriteBatch);
        _enemyManager.Draw(GameCore.SpriteBatch);
        GameCore.SpriteBatch.End();

        base.Draw(gameTime);
    }

    public override void Update(GameTime gameTime)
    {
        _enemySpawner.Update(gameTime);
        _enemyManager.Update(gameTime);

        base.Update(gameTime);
    }
}
