using System.Collections.Generic;
using PathOfPaper.Data.Common;
using PathOfPaper.Data.Common.Description;
using PathOfPaper.Data.Skill.Tag;

namespace PathOfPaper.Data.Skill.Intelligence
{
    public class Arc : IIntelligenceSkill
    {
        public string Name { get; set; }
        public IDescription Description { get; set; }

        public Arc()
        {
            Name = "Arc";

            var tags = new ITag[]
            {
                new ManaCost(2),
                new Projectile(),
                new Chain(),
                new Lightning(),
                new Spell()
            };

            var text = new[]
            {
                "Fires a beam of lightning that hits three targets increasing damage by 6.",
                "Arc reduces enemy threshold by 6. Next turn, Arc chains to three new targets of the caster's choice.",
                "Multiple separate Arcs cannot hit the same target.",
                "Tier bonus: +4 damage and adds an additional target. +2 mana cost."
            };

            Description = new SkillDescription(tags, text);
        }
    }
}