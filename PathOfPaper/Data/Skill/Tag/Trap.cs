using PathOfPaper.Data.Common;
using PathOfPaper.Data.Common.Description;

namespace PathOfPaper.Data.Skill.Tag
{
    public class Trap : ITag
    {
        public IDescription Description { get; set; }

        public Trap()
        {
            Description = new TagDescription("Trap");
        }
    }
}