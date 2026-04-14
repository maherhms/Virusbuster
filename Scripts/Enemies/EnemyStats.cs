using System;

namespace VirusBuster.Enemies;

public class EnemyStats
{
    #region Enemy Spawn
    public float BaseSpawnRate {get; private set;} = 5f;
    public float FlatBonusSpawnRate {get; private set;} =0.5f;
    public float CurrentSpawnRate
    {
        get
        {
            float clampedBonus = Math.Clamp(FlatBonusSpawnRate, -0.9f, 10f);
            float denominator = 1f + clampedBonus;

            return BaseSpawnRate / denominator;
        }
    }
    #endregion
}