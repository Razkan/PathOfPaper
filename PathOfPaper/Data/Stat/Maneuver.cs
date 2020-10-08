namespace PathOfPaper.Data
{
    public class Maneuver : IStat
    {
        public string Name { get; } = nameof(Maneuver);
        public int Base { get; set; }
        public int Value { get; set; }
    }
}