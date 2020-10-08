using PathOfPaper.Data.Common.Interfaces;

namespace PathOfPaper.Data.Character
{
    public interface ICharacter : 
        IEnergyShield,
        IArmour,
        IElementalResistance
    {
        
    }
}