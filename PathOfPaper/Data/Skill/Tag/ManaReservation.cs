using PathOfPaper.Data.Common;
using PathOfPaper.Data.Common.Description;

namespace PathOfPaper.Data.Skill.Tag
{
    public class ManaReservation : ITag
    {
        public IDescription Description { get; set; }

        public ManaReservation(int value)
        {
            Description = new TagDescription("r" + value);
        }
}
}