using PathOfPaper.Data.Common;
using PathOfPaper.Data.Common.Interfaces;

namespace PathOfPaper.Data.Item.Equipment.Chest
{
    public class ClothRobes : IChest, IEnergyShield
    {
        public EnergyShield EnergyShield { get; set; }
    }
}