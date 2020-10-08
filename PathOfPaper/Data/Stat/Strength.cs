namespace PathOfPaper.Data
{
    public class Strength : IStat
    {
        public string Name { get; } = nameof(Strength);
        public int Base { get; set; }
        public int Value { get; set; }
    }
}