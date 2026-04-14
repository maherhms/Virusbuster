using System;

namespace VirusBuster.Enemies;

public class EnemyStats
{
    #region Enemy Spawn
    private float _baseSpawnRate = 5f;
    public float FlatBonusSpawnRate {get; private set;} =0.5f;
    public float CurrentSpawnRate
    {
        get
        {
            float clampedBonus = Math.Clamp(FlatBonusSpawnRate, -0.9f, 10f);
            float denominator = 1f + clampedBonus;

            return _baseSpawnRate / denominator;
        }
    }
    #endregion

    #region EnemyHealth
    private float _baseHealth=1f;
    public float CurrentHealth => _baseHealth;
    #endregion

    #region EnemySpeed
    private float _baseSpeed=50f;
    public float MaxSpeed => _baseSpeed;
    #endregion
}