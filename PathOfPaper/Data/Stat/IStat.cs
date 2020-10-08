namespace PathOfPaper.Data
{
    public interface IStat
    {
        string Name { get; }
        int Base { get; set; }
        int Value { get; set; }
    }
}