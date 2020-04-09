using PathOfPaper.Data.Common;
using PathOfPaper.Data.Common.Description;

namespace PathOfPaper.Data.Skill.Tag
{
    public class Channeling : ITag
    {
        public IDescription Description { get; set; }

        public Channeling()
        {
            Description = new TagDescription("Channeling");
        }

    }
}