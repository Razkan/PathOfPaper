using PathOfPaper.Data.Common;
using PathOfPaper.Data.Common.Description;

namespace PathOfPaper.Data.Skill.Tag
{
    public class ManaCost : ITag
    {
        public IDescription Description { get; set; }

        public ManaCost(int value)
        {
            Description = new TagDescription(value.ToString());
        }
    }
}