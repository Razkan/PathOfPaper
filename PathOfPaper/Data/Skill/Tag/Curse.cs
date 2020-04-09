using PathOfPaper.Data.Common;
using PathOfPaper.Data.Common.Description;

namespace PathOfPaper.Data.Skill.Tag
{
    public class Curse : ITag
    {
        public IDescription Description { get; set; }

        public Curse()
        {
            Description = new TagDescription("Curse");
        }
    }
}