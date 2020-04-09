using PathOfPaper.Data.Common;
using PathOfPaper.Data.Common.Description;

namespace PathOfPaper.Data.Skill.Tag
{
    public class Pierce : ITag
    {
        public IDescription Description { get; set; }

        public Pierce()
        {
            Description = new TagDescription("Pierce");
        }
    }
}