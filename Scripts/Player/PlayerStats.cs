using System;
using System.Runtime.Serialization;

namespace Nodebuster
{
    public class PlayerStats
    {
        #region Damage stats
        public float BaseDamage {get ; private set;} = 10f;
        public float FlatBonusDamage {get; private set;} = 0f;
        public float HealthPercentageBonusDamage { get; private set;} =0f;
        public float PercentagePerSecondBonusDamage { get ; private set ;} =0f;
        //computed property re-evaluated on every usage
        public float MaxDamage => (BaseDamage + FlatBonusDamage + HealthPercentageBonusDamage + PercentagePerSecondBonusDamage) ;
        #endregion

        #region Health stats
        public float BaseHealth {get; private set;} =15f;
        public float MaxBonusHealth {get; private set;} =0f;
        public float PerKillMaxBonusHealth {get; private set;} =0f;
        //computed property re-evaluated on every usage
        public float MaxHealth => ( BaseHealth + MaxBonusHealth);
        #endregion

        #region Damage buffs
        /*this methode is to be used when applying Flat damage bonus for example +1 damage*/
        public void AddFlatBonusDamage(float amount)
        {
            FlatBonusDamage += amount;
        }
        /*this methode is to be used when applying health based damage bonus 
        for example +0.1% max health as damage*/
        public void AddHealthPercentageBonusDamage(float amount)
        {
            HealthPercentageBonusDamage += (amount * MaxHealth) /100f;
        }
        #endregion

        #region Health buffs
        /*this methode is to be used when applying max health bonus for example +4 max health*/
        public void AddMaxBonusHealth(float amount)
        {
            MaxBonusHealth += amount;
        }
        /*this methode is to be used when applying max health bonus per kill 
        for example +1 permanent max HP per kill*/
        public void AddPerKillMaxBonusHealth(float amount)
        {
            PerKillMaxBonusHealth += amount;
        }        
        #endregion
    }
}