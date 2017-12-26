using DndCalculator.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DndCalculator.Domain.Models
{
    public class Ability
    {
        public Ability(AbilityEnum name, int score, bool isProficient = false)
        {
            Name = name;
            Score = score;
            IsProficient = isProficient;
        }

        public AbilityEnum Name { get; set; }
        public int Score { get; set; }
        public int Modifier
        {
            get
            {
                return (Score - 10) / 2;
            }
        }
        public bool IsProficient { get; set; }
    }
}
