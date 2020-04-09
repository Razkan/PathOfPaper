using PathOfPaper.Data.Common;
using PathOfPaper.Data.Common.Description;

namespace PathOfPaper.Data.Skill.Tag
{
    public class Spell : ITag
    {
        public IDescription Description { get; set; }

        public Spell()
        {
            Description = new TagDescription("Spell");
        }
    }
}