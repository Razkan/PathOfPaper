using PathOfPaper.Data.Common;
using PathOfPaper.Data.Common.Description;

namespace PathOfPaper.Data.Skill.Tag
{
    public class Projectile : ITag
    {
        public IDescription Description { get; set; }

        public Projectile()
        {
            Description = new TagDescription("Proj");
        }
}
}