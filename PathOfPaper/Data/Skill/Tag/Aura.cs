using PathOfPaper.Data.Common;
using PathOfPaper.Data.Common.Description;

namespace PathOfPaper.Data.Skill.Tag
{
    public class Aura : ITag
    {
        public IDescription Description { get; set; }

        public Aura()
        {
            Description = new TagDescription("Aura");
        }
    }
}