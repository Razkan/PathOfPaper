using PathOfPaper.Data.Common;
using PathOfPaper.Data.Common.Description;

namespace PathOfPaper.Data.Skill.Tag
{
    public class Fire : ITag
    {
        public IDescription Description { get; set; }

        public Fire()
        {
            Description = new TagDescription("Fire");
        }
    }
}