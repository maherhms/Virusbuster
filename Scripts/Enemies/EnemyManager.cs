using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace VirusBuster.Enemies;

public class EnemyManager
{
    private readonly List<Enemy> _enemies = new();
    public void AddEnemy(Enemy enemy)
    {
        if (enemy is null)
            throw new System.ArgumentNullException(nameof(enemy));
            
        _enemies.Add(enemy);
        enemy.LoadEnemyContent();
    }
    public void Update(GameTime gameTime)
    {
        foreach(var enemy in _enemies)
        {
            enemy.Update(gameTime);
        }
    }
    public void Draw(SpriteBatch spriteBatch)
    {
        foreach(var enemy in _enemies)
        {
            enemy.Draw(spriteBatch);
        }
    }
}