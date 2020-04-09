using PathOfPaper.Data.Common;
using PathOfPaper.Data.Common.Description;

namespace PathOfPaper.Data.Skill.Tag
{
    public class Attack : ITag
    {
        public IDescription Description { get; set; }

        public Attack()
        {
            Description = new TagDescription("Attack");
        }
    }
}