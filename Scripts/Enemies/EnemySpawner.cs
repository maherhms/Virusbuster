using System;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using VirusBuster.Base;

namespace VirusBuster.Enemies;

public class EnemySpawner
{
    private float _timer =0f;
    private EnemyManager _enemyManager;
    public EnemySpawner(EnemyManager enemyManager)
    {
        _enemyManager = enemyManager;
    }
    public void Update(GameTime gameTime)
    {
        _timer += (float)gameTime.ElapsedGameTime.TotalSeconds;

        if (_timer > GameState.Instance.EnemyStats.CurrentSpawnRate)
        {
            Console.WriteLine($"Spawned at time: {_timer}");
            _timer=0f;

            //spawn Red Rectangular Enemy
            //TODO
            var pos= new Vector2(100f,100f);
            //TODO
            _enemyManager.AddEnemy(new RedRectangularEnemy(pos,10f,50f));
        }
    }
}