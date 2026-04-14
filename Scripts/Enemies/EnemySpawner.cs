using System;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using VirusBuster.Base;
using VirusBuster.Utility;

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
            var (w, h) = RedRectangularEnemy.GetSize();
            var spawnPos = ScreenUtility.GetRandomOffscreenPosition(w, h);
            _enemyManager.AddEnemy(new RedRectangularEnemy(spawnPos,GameState.Instance.EnemyStats.CurrentHealth,GameState.Instance.EnemyStats.MaxSpeed));
        }
    }
}