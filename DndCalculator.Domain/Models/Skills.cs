using System;
using System.Collections.Generic;
using System.Text;

namespace DndCalculator.Domain.Models
{
    public enum SkillsEnum
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

    public static class SkillsExt
    {
        private static readonly Dictionary<SkillsEnum, AbilityEnum> categories = new Dictionary<SkillsEnum, AbilityEnum> {
            { SkillsEnum.Acrobatics, AbilityEnum.Dexterity },
            { SkillsEnum.Acrobatics, AbilityEnum.Wisdom },
            { SkillsEnum.Arcana, AbilityEnum.Intelligence },
            { SkillsEnum.Athletics, AbilityEnum.Strength },
            { SkillsEnum.Deception, AbilityEnum.Charisma },
            { SkillsEnum.History, AbilityEnum.Intelligence },
            { SkillsEnum.Insight, AbilityEnum.Wisdom },
            { SkillsEnum.Intimidation, AbilityEnum.Charisma },
            { SkillsEnum.Investigation, AbilityEnum.Intelligence },
            { SkillsEnum.Medicine, AbilityEnum.Wisdom },
            { SkillsEnum.Nature, AbilityEnum.Intelligence },
            { SkillsEnum.Perception, AbilityEnum.Wisdom },
            { SkillsEnum.Performance, AbilityEnum.Charisma },
            { SkillsEnum.Persuasion, AbilityEnum.Charisma },
            { SkillsEnum.Religion, AbilityEnum.Intelligence },
            { SkillsEnum.SleightOfHand, AbilityEnum.Dexterity },
            { SkillsEnum.Stealth, AbilityEnum.Dexterity },
            { SkillsEnum.Survival, AbilityEnum.Wisdom },
        };

        public static AbilityEnum Category(this SkillsEnum e) => categories[e];
    }
}
