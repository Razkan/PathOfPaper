using PathOfPaper.Data.Common;
using PathOfPaper.Data.Common.Description;

namespace PathOfPaper.Data.Skill.Tag
{
    public class Minion : ITag
    {
        public IDescription Description { get; set; }

        public Minion()
        {
            Description = new TagDescription("Minion");
        }
    }
}