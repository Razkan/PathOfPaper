using PathOfPaper.Data.Item.Equipment;
using PathOfPaper.Data.Item.Equipment.Chest;

namespace PathOfPaper.Data.Character
{
    public class Equipment
    {
        public Head Head { get; set; }
        public IChest Chest { get; set; }
        public Boots Boots { get; set; }

        public IWeapon Mainhand { get; set; }
        public IWeapon Offhand { get; set; }

        public Amulet Amulet { get; set; }

        public Ring LeftRing { get; set; }
        public Ring RightRing { get; set; }
    }
}