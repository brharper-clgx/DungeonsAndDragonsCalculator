namespace DndCalculator.Domain.Models
{
    public class Skill
    {
        public Skill(SkillEnum name, bool isProficient = false)
        {
            Name = name;
            IsProficient = isProficient;
        }

        public SkillEnum Name { get; set; }
        public AbilityEnum Category
        {
            get
            {
                return SkillEnumExt.Category(Name);
            }
        }
        public bool IsProficient { get; set; }
    }
}
