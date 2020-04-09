using PathOfPaper.Data.Common;
using PathOfPaper.Data.Common.Description;

namespace PathOfPaper.Data.Skill.Tag
{
    public class Lightning : ITag
    {
        public IDescription Description { get; set; }

        public Lightning()
        {
            Description = new TagDescription("Light");
        }
}
}