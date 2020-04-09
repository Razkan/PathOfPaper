using PathOfPaper.Data.Common;
using PathOfPaper.Data.Common.Description;

namespace PathOfPaper.Data.Skill.Tag
{
    public class Guard : ITag
    {
        public IDescription Description { get; set; }

        public Guard()
        {
            Description = new TagDescription("Guard");
        }
}
}