using System.Collections.Generic;

namespace DndCalculator.Domain.Models
{
    public enum SkillEnum
    {
        Undefined,
        Acrobatics,
        AnimalHandling,
        Arcana,
        Athletics,
        Deception,
        History,
        Insight,
        Intimidation,
        Investigation,
        Medicine,
        Nature,
        Perception,
        Performance,
        Persuasion,
        Religion,
        SleightOfHand,
        Stealth,
        Survival
    }

    public static class SkillEnumExt
    {
        private static readonly Dictionary<SkillEnum, AbilityEnum> skillMapper = new Dictionary<SkillEnum, AbilityEnum> {
            { SkillEnum.Acrobatics, AbilityEnum.Dexterity },
            { SkillEnum.AnimalHandling, AbilityEnum.Wisdom },
            { SkillEnum.Arcana, AbilityEnum.Intelligence },
            { SkillEnum.Athletics, AbilityEnum.Strength },
            { SkillEnum.Deception, AbilityEnum.Charisma },
            { SkillEnum.History, AbilityEnum.Intelligence },
            { SkillEnum.Insight, AbilityEnum.Wisdom },
            { SkillEnum.Intimidation, AbilityEnum.Charisma },
            { SkillEnum.Investigation, AbilityEnum.Intelligence },
            { SkillEnum.Medicine, AbilityEnum.Wisdom },
            { SkillEnum.Nature, AbilityEnum.Intelligence },
            { SkillEnum.Perception, AbilityEnum.Wisdom },
            { SkillEnum.Performance, AbilityEnum.Charisma },
            { SkillEnum.Persuasion, AbilityEnum.Charisma },
            { SkillEnum.Religion, AbilityEnum.Intelligence },
            { SkillEnum.SleightOfHand, AbilityEnum.Dexterity },
            { SkillEnum.Stealth, AbilityEnum.Dexterity },
            { SkillEnum.Survival, AbilityEnum.Wisdom },
        };

        public static AbilityEnum Category(this SkillEnum s) => skillMapper[s];
    }
}
