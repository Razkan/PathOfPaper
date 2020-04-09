using PathOfPaper.Data.Common;
using PathOfPaper.Data.Common.Description;

namespace PathOfPaper.Data.Skill.Tag
{
    public class Warcry : ITag
    {
        public IDescription Description { get; set; }

        public Warcry()
        {
            Description = new TagDescription("Warcry");
        }
    }
}