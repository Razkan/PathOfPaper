using PathOfPaper.Data.Common.Interfaces;
using PathOfPaper.Data.Mitigation;

namespace PathOfPaper.Data.Item.Equipment.Chest
{
    public class LeatherArmour : IChest, IElementalResistance
    {
        public ElementalResistance ElementalResistance { get; set; }
    }
}