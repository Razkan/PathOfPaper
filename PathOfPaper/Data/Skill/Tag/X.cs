using PathOfPaper.Data.Common;
using PathOfPaper.Data.Common.Description;

namespace PathOfPaper.Data.Skill.Tag
{
    public class X : ITag
    {
        public IDescription Description { get; set; }

        public X()
        {
            Description = new TagDescription("X");
        }
    }
}