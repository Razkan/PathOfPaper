namespace PathOfPaper.Data
{
    public class Dexterity : IStat
    {
        public string Name { get; } = nameof(Dexterity);
        public int Base { get; set; }
        public int Value { get; set; }
    }
}