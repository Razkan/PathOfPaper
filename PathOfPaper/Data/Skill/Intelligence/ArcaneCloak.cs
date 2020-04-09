using System.Collections.Generic;
using PathOfPaper.Data.Common;
using PathOfPaper.Data.Common.Description;
using PathOfPaper.Data.Skill.Tag;

namespace PathOfPaper.Data.Skill.Intelligence
{
    public class ArcaneCloak : IIntelligenceSkill
    {
        public string Name { get; set; }
        public IDescription Description { get; set; }

        public ArcaneCloak()
        {
            Name = "Arcane Cloak";

            var tags = new ITag[]
            {
                new X(),
                new Guard()
            };

            var text = new[]
            {
                "Gain a shining blue barrier that lasts until the start of your next turn. ",
                "This barrier absorbs damage equal to 14 per point of mana used to cast it. ",
                "In addition, increases your damage by 4 per point of mana used. ",
                "You may only have one Guard skill active at one time. Casting Guard skills is a minor action. ",
                "Guard skills can only be cast once every 5 minutes.",
                "Tier Bonus: Barrier hp increased by 14 per point of mana spent. ",
                "Damage increased by 4 per point of mana spent.No additional mana cost."
            };

            Description = new SkillDescription(tags, text);
        }
    }
}