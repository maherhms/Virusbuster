using System;
using System.Runtime;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

namespace VirusBuster.Player;

public class PlayerStats
{
    #region Damage stats
    private float _baseDamage = 10f;
    public float FlatBonusDamage { get; private set; } = 0f;
    public float HealthPercentageAsBonusDamage { get; private set; } = 0f;
    public float PercentagePerSecondBonusDamage { get; private set; } = 0f;
    public float AccumulatedPercentagePerSecondBonusDamage { get; private set; } = 0f;
    /// <summary>
    /// computed property re-evaluated on every usage
    /// </summary>
    public float CurrentDamage => (_baseDamage + FlatBonusDamage + HealthPercentageAsBonusDamage) * (1f + AccumulatedPercentagePerSecondBonusDamage);
    #endregion

    #region Health stats
    private float _baseHealth = 15f;
    public float MaxBonusHealth { get; private set; } = 0f;
    public float PerKillMaxBonusHealth { get; private set; } = 0f;
    public float AccumulatedPerKillMaxBonusHealth { get; private set; } = 0f;
    /// <summary>
    /// computed property re-evaluated on every usage
    /// </summary>
    public float MaxHealth => (_baseHealth + MaxBonusHealth + AccumulatedPerKillMaxBonusHealth);
    #endregion

    #region Attack Size
    private Vector2 _baseAttackSize = new Vector2(100, 100);
    public float PercentageBonusAttackSize { get; private set; } = 0f;
    public Vector2 CurrentAttackSize => (_baseAttackSize) * (1f + PercentageBonusAttackSize);
    #endregion

    #region Attack Speed
    public float _baseAttackSpeed { get; private set; } = 1f;
    #endregion

    #region Damage buffs
    /// <summary>
    ///  this method is to be used when applying Flat damage bonus for example +1 damage*/
    /// </summary>
    /// <param name="amount"></param>
    public void SetFlatBonusDamage(float amount)
    {
        FlatBonusDamage = amount;
    }
    /// <summary>
    /// this method is to be used when applying health based damage bonus for example +0.1% max health as damage
    /// </summary>
    /// <param name="amount"></param>
    public void SetHealthPercentageAsBonusDamage(float amount)
    {
        HealthPercentageAsBonusDamage = (amount * MaxHealth) / 100f;
    }
    public void SetPercentagePerSecondBonusDamage(float amount)
    {
        PercentagePerSecondBonusDamage = amount;
    }
    // TODO: use in an update method
    public void CountAccumulatedPercentagePerSecondBonusDamage()
    {
        AccumulatedPercentagePerSecondBonusDamage += PercentagePerSecondBonusDamage;
    }
    #endregion

    #region Health buffs
    /// <summary>
    /// this method is to be used when applying max health bonus for example +4 max health
    /// </summary>
    /// <param name="amount"></param>
    public void SetMaxBonusHealth(float amount)
    {
        MaxBonusHealth = amount;
    }
    /// <summary>
    /// this  is to be used when applying max health bonus per kill for example +1 permanent max HP per kill
    /// </summary>
    /// <param name="amount"></param>
    public void SetPerKillMaxBonusHealth(float amount)
    {
        PerKillMaxBonusHealth = amount;
    }
    public void CountAccumulatedPerKillMaxBonusHealth()
    {
        AccumulatedPerKillMaxBonusHealth += PerKillMaxBonusHealth;
    }
    #endregion

    #region Attack size buffs
    public void SetPercentageBonusAttackSize(float amount)
    {
        PercentageBonusAttackSize = amount;
    }
    #endregion
}