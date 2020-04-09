using PathOfPaper.Data.Common;
using PathOfPaper.Data.Common.Description;

namespace PathOfPaper.Data.Skill.Tag
{
    public class Chain : ITag
    {
        public IDescription Description { get; set; }

        public Chain()
        {
            Description = new TagDescription("Chain");
        }
    }
}