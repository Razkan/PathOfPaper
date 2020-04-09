using PathOfPaper.Data.Common;
using PathOfPaper.Data.Common.Description;

namespace PathOfPaper.Data.Skill.Tag
{
    public class Brand : ITag
    {
        public IDescription Description { get; set; }

        public Brand()
        {
            Description = new TagDescription("Brand");
        }
    }
}