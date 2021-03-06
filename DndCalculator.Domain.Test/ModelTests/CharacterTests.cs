﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using DndCalculator.Domain.Models;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace DndCalculator.Domain.Test
{
    [TestClass]
    public class CharacterTests
    {
        [TestMethod]
        public void Character_Ctor_ShouldBuildFromJson()
        {
            // Arrange
            var json = "{\"Name\":\"Egor\",\"ProficiencyBonus\":2,\"Abilities\":[{\"Name\":6,\"Score\":10,\"Modifier\":0,\"IsProficient\":false},{\"Name\":3,\"Score\":8,\"Modifier\":-1,\"IsProficient\":false}],\"Skills\":[{\"Name\":2,\"Category\":5,\"IsProficient\":true},{\"Name\":1,\"Category\":2,\"IsProficient\":false}]}";

            // Act
            var result = new Character(json);

            // Assert
            Assert.AreEqual("Egor", result.Name);
            Assert.AreEqual(AbilityEnum.Charisma, (AbilityEnum)result.Abilities.First().Name);
        }

        [TestMethod]
        public void Character_GetJson_ShouldReturnJson()
        {
            // Arrange
            Character target = GetTestCharacter();
            var name = target.Name;

            // Act
            var result = target.GetJson();
            Character characterFromResult = JsonConvert.DeserializeObject<Character>(result);

            // Assert
            Assert.AreEqual(name, characterFromResult.Name);
            Assert.AreEqual(AbilityEnum.Charisma, (AbilityEnum)characterFromResult.Abilities.First().Name);
        }

        [TestMethod]
        public void Character_GetAbilityModifier_ShouldReturnAbilityModifier()
        {
            // Arrange
            Character target = GetTestCharacter();

            // Act
            var charismaResult = target.GetAbilityModifier(AbilityEnum.Charisma);
            var constitutionResult = target.GetAbilityModifier(AbilityEnum.Constitution);

            // Assert
            Assert.AreEqual(1, charismaResult);
            Assert.AreEqual(-1, constitutionResult);
        }

        [TestMethod]
        public void Character_GetSkillModifier_ShouldReturnSkillModifier()
        {
            // Arrange
            Character target = GetTestCharacter();

            // Act
            var deceptionResult = target.GetSkillModifier(SkillEnum.Deception);
            var intimidationResult = target.GetSkillModifier(SkillEnum.Intimidation);

            // Assert
            Assert.AreEqual(3, deceptionResult);
            Assert.AreEqual(1, intimidationResult);
        }

        private Character GetTestCharacter()
        {
            return new Character
            {
                Abilities = new List<Ability>
                {
                    new Ability(AbilityEnum.Charisma, 12),
                    new Ability(AbilityEnum.Constitution, 8)
                },
                Name = "Egor",
                ProficiencyBonus = 2,
                Skills = new List<Skill>
                {
                    new Skill(SkillEnum.Deception, true),
                    new Skill(SkillEnum.Intimidation)
                }
            };
        }
    }
}
 