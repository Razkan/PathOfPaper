using PathOfPaper.Data.Common.Interfaces;
using PathOfPaper.Data.Mitigation;

namespace PathOfPaper.Data.Item.Equipment.Shield
{
    public class MetalShield : IShield, IArmour, IManeuver, IAthletic
    {
        public Block Block { get; set; }
        public Armour Armour { get; set; }

        public Maneuver Maneuver { get; set; }
        public Athletic Athletic { get; set; }

        public MetalShield()
        {
            Block = new Block(1);
            Armour = new Armour(6);
            Maneuver = new Maneuver { Value = -2};
            Athletic = new Athletic{Value = -2};
        }
    }
}