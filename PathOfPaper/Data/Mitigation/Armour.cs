namespace PathOfPaper.Data.Mitigation
{
    public class Armour : IMitigation
    {
        public int Value { get; set; }

        public Armour(int value)
        {
            Value = value;
        }
    }
}