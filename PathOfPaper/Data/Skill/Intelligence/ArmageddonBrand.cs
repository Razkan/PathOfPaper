using PathOfPaper.Data.Common;
using PathOfPaper.Data.Common.Description;
using PathOfPaper.Data.Skill.Tag;

namespace PathOfPaper.Data.Skill.Intelligence
{
    public class ArmageddonBrand : IIntelligenceSkill 
    {
        public string Name { get; set; }
        public IDescription Description { get; set; }

        public ArmageddonBrand()
        {
            Name = "Armageddon Brand";

            var tags = new ITag[]
            {
                new ManaCost(2),
                new Fire(),
                new Spell(),
                new Brand()
            };

            var text = new[]
            {
                "Creates a magical Brand which can attach to an enemy. " ,
                "While the Brand is attached, it will deal your damage ,2 as Fire damage to all enemies in the attached target’s Zone. " ,
                "Armageddon Brand lasts 2 turns and deals damage at the end of your turn. " ,
                "If the target the Brand is attached to dies, it will seek a target in its Zone or a nearby Zone and attach to them." ,
                "You may have 1 Brand active at maximum." ,
                "Tier bonus: +2 damage, +1 additional turn, +2 mana"
            };

            Description = new SkillDescription(tags, text);
        }
    }
}