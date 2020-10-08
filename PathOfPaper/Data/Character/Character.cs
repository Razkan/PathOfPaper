using PathOfPaper.Data.Common;
using PathOfPaper.Data.Mitigation;

namespace PathOfPaper.Data.Character
{
    public class Character : ICharacter
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }

        public string Gender { get; set; }
        public string Class { get; set; }
        public string Ascendancy { get; set; }

        public string Image { get; set; }

        public Level Level { get; set; }

        public Strength Strength { get; set; }
        public Dexterity Dexterity { get; set; }
        public Intelligence Intelligence { get; set; }

        public Athletic Athletic { get; set; }
        public Maneuver Maneuver { get; set; }

        public Life Life { get; set; }
        public Mana Mana { get; set; }
        public EnergyShield EnergyShield { get; set; }

        public Initiative Initiative { get; set; }
        public Threshold Threshold { get; set; }
        public Fatigue Fatigue { get; set; }
        
        public Armour Armour { get; set; }
        public ElementalResistance ElementalResistance { get; set; }

        public WeaponAttackMultiplier WeaponAttackMultiplier { get; set; }
        public BonusDamage BonusDamage { get; set; }

        public Equipment Equipment { get; set; }
    }
}