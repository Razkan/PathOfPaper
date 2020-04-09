using PathOfPaper.Data.Mitigation;

namespace PathOfPaper.Data.Character
{
    public class Character
    {
        public Level Level { get; set; }

        #region Stat

        public Strength Strength { get; set; }
        public Dexterity Dexterity { get; set; }
        public Intelligence Intelligence { get; set; }

        #endregion

        #region Base

        public Life Life { get; set; }
        public Mana Mana { get; set; }
        public EnergyShield EnergyShield { get; set; }

        public Threshold Threshold { get; set; }

        public Initiative Initiative { get; set; }

        public Fatigue Fatigue { get; set; }
        #endregion

        #region Mitigation

        public Armour Armour { get; set; }
        public ElementalResistance ElementalResistance { get; set; }

        #endregion

        #region Damage

        public WeaponAttackMultiplier WeaponAttackMultiplier { get; set; }
        public BonusDamage BonusDamage { get; set; }

        #endregion
    }
}