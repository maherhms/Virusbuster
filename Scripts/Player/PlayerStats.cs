using System;
using System.Runtime.Serialization;

namespace Nodebuster
{
    public class PlayerStats
    {
        #region Damage stats
        public float BaseDamage {get ; private set;} = 10f;
        public float FlatBonusDamage {get; private set;} = 0f;
        public float HealthPercentageAsBonusDamage { get; private set;} =0f;
        public float PercentagePerSecondBonusDamage { get ; private set ;} =0f;
        public float AccumulatedPercentagePerSecondBonusDamage {get ; private set;} =0f;
        //computed property re-evaluated on every usage
        public float CurrentDamage => (BaseDamage + FlatBonusDamage + HealthPercentageAsBonusDamage ) * (1f + AccumulatedPercentagePerSecondBonusDamage) ;
        #endregion

        #region Health stats
        public float BaseHealth {get; private set;} =15f;
        public float MaxBonusHealth {get; private set;} =0f;
        public float PerKillMaxBonusHealth {get; private set;} =0f;
        public float AccumulatedPerKillMaxBonusHealth {get ; private set;} =0f;
        //computed property re-evaluated on every usage
        public float MaxHealth => ( BaseHealth + MaxBonusHealth + AccumulatedPerKillMaxBonusHealth);
        #endregion

        #region Damage buffs
        /*this methode is to be used when applying Flat damage bonus for example +1 damage*/
        public void SetFlatBonusDamage(float amount)
        {
            FlatBonusDamage = amount;
        }
        /*this methode is to be used when applying health based damage bonus 
        for example +0.1% max health as damage*/
        public void SetHealthPercentageAsBonusDamage(float amount)
        {
            HealthPercentageAsBonusDamage = (amount * MaxHealth) /100f;
        }
        public void SetPercentagePerSecondBonusDamage(float amount)
        {
            PercentagePerSecondBonusDamage = amount;
        }
        // TODO: use in an update methode
        public void CountAccumulatedPercentagePerSecondBonusDamage()
        {
            AccumulatedPercentagePerSecondBonusDamage += PercentagePerSecondBonusDamage;
        }
        #endregion

        #region Health buffs
        /*this methode is to be used when applying max health bonus for example +4 max health*/
        public void SetMaxBonusHealth(float amount)
        {
            MaxBonusHealth = amount;
        }
        /*this methode is to be used when applying max health bonus per kill 
        for example +1 permanent max HP per kill*/
        public void SetPerKillMaxBonusHealth(float amount)
        {
            PerKillMaxBonusHealth = amount;
        }   
        public void CountAccumulatedPerKillMaxBonusHealth()
        {
            AccumulatedPerKillMaxBonusHealth += PerKillMaxBonusHealth;
        } 
        #endregion
    }
}