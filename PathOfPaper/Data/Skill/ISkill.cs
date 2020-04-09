using System.Collections.Generic;
using PathOfPaper.Data.Common;
using PathOfPaper.Data.Common.Description;
using PathOfPaper.Data.Skill.Tag;

namespace PathOfPaper.Data.Skill
{
    public interface ISkill
    {
        string Name { get; set; }
        IDescription Description { get; set; }
    }
}