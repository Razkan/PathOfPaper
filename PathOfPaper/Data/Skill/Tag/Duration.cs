using PathOfPaper.Data.Common;
using PathOfPaper.Data.Common.Description;

namespace PathOfPaper.Data.Skill.Tag
{
    public class Duration : ITag
    {
        public IDescription Description { get; set; }

        public Duration()
        {
            Description = new TagDescription("Duration");
        }
    }
}