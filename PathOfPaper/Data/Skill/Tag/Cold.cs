using PathOfPaper.Data.Common;
using PathOfPaper.Data.Common.Description;

namespace PathOfPaper.Data.Skill.Tag
{
    public class Cold : ITag
    {
        public IDescription Description { get; set; }

        public Cold()
        {
            Description = new TagDescription("Cold");
        }
    }
}