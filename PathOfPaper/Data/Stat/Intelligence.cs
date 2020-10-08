namespace PathOfPaper.Data
{
    public class Intelligence : IStat
    {
        public string Name { get; } = nameof(Intelligence);
        public int Base { get; set; }
        public int Value { get; set; }
    }
}