namespace PathOfPaper.Data.Mitigation
{
    public class Block : IMitigation
    {
        public int Value { get; set; }

        public Block(int value)
        {
            Value = value;
        }
    }
}