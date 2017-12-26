using DndCalculator.Domain.Models;
using System.Collections.Generic;

namespace DndCalculator.Domain.Contracts
{
    public interface ICharacter
    {
        string Name { get; set; }
        int ProficiencyBonus { get; set; }
        IEnumerable<Ability> Abilities { get; set; }
        IEnumerable<Skill> Skills { get; set; }
        int GetAbilityModifier(AbilityEnum ability);
        int GetSkillModifier(SkillEnum skill);
    }
}
