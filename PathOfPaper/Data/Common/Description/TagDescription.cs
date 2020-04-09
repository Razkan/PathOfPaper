namespace PathOfPaper.Data.Common.Description
{
    public class TagDescription : IDescription
    {
        public string Text { get; set; }

        public TagDescription(string text)
        {
            Text = text;
        }

        public string Get()
        {
            return $"({Text})";
        }
    }
}