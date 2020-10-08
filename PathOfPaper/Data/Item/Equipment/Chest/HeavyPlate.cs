using PathOfPaper.Data.Common.Interfaces;
using PathOfPaper.Data.Mitigation;

namespace PathOfPaper.Data.Item.Equipment.Chest
{
    public class HeavyPlate : IChest, IArmour
    {
        public Armour Armour { get; set; }
    }
}