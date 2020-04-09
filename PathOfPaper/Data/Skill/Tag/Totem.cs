using PathOfPaper.Data.Common;
using PathOfPaper.Data.Common.Description;

namespace PathOfPaper.Data.Skill.Tag
{
    public class Totem : ITag
    {
        public IDescription Description { get; set; }

        public Totem()
        {
            Description = new TagDescription("Totem");
        }
    }
}