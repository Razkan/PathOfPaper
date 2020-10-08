namespace PathOfPaper.Data
{
    public class Athletic : IStat
    {
        public string Name { get; } = nameof(Athletic);
        public int Base { get; set; }
        public int Value { get; set; }
    }
}