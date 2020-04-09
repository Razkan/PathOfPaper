using PathOfPaper.Data.Common;
using PathOfPaper.Data.Common.Description;

namespace PathOfPaper.Data.Skill.Tag
{
    public interface ITag
    {
        IDescription Description { get; set; }
    }
}