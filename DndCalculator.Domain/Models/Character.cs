using DndCalculator.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace DndCalculator.Domain.Models
{
    public class Character
    {
        public Character()
        {

        }

        public Character(string json)
        {
            var character = JsonConvert.DeserializeObject<Character>(json);
            Name = character.Name;
            ProficiencyBonus = character.ProficiencyBonus;
            Abilities = character.Abilities;
            Skills = character.Skills;
        }

        public string Name { get; set; }
        public int ProficiencyBonus { get; set; }
        public IEnumerable<Ability> Abilities { get; set; }
        public IEnumerable<Skill> Skills { get; set; }

        public int GetAbilityModifier(AbilityEnum ability)
        {
            var ab = Abilities.First(a => a.Name == ability);
            return ab.IsProficient ? ab.Modifier + ProficiencyBonus : ab.Modifier;
        }


        public int GetSkillModifier(SkillEnum skill)
        {
            var sk = Skills.First(a => a.Name == skill);
            var ab = Abilities.First(a => a.Name == sk.Category);
            return sk.IsProficient ? ab.Modifier + ProficiencyBonus : ab.Modifier;
        }

        public string GetJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
