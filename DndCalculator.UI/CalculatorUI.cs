using DndCalculator.Domain.Contracts;
using DndCalculator.Domain.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DndCalculator.UI
{
    public partial class CalculatorUI : Form
    {
        // DC
        private int difficultyClass;
        private int difficultyClassSuccessPercentage;
        private int difficultyClassModifier;
        private bool difficultyClassWithAdvantage;
        private bool difficultyClassWithDisadvantage;

        // EV
        private decimal expectedValueNumberOfDice;
        private decimal expectedValueNumberOfSides;
        private decimal expectedValueModifier;
        private decimal expectedValue;

        private ICalculatorService calculator;

        public CalculatorUI(ICalculatorService calculator)
        {
            // DC
            difficultyClass = 11;
            difficultyClassSuccessPercentage = 50;
            InitializeComponent();

            // EV
            expectedValueNumberOfDice = 1;
            expectedValueNumberOfSides = 20;
            expectedValue = 10.5m;

            this.calculator = calculator;
        }


        /************************************************
         *                  DC Calc
        ************************************************/
        private void successPercentageTrackbar_Scroll(object sender, EventArgs e)
        {
            difficultyClassSuccessPercentage = 5*successPercentageTrackbar.Value;
            successPercentageLabel.Text = difficultyClassSuccessPercentage.ToString();
            updateDifficultyClass();
        }

        private void advantageCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            difficultyClassWithAdvantage = advantageCheckbox.CheckState == CheckState.Checked ? true : false;
            updateDifficultyClass();
        }

        private void disadvantageCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            difficultyClassWithDisadvantage = disadvantageCheckbox.CheckState == CheckState.Checked ? true : false;
            updateDifficultyClass();
        }
        

        private void modifierUpDown_ValueChanged(object sender, EventArgs e)
        {
            difficultyClassModifier = (int)modifierUpDown.Value;
            updateDifficultyClass();
        }

        private void updateDifficultyClass()
        {
            difficultyClass = calculator.GetDifficultyClass(difficultyClassSuccessPercentage, difficultyClassModifier, difficultyClassWithAdvantage, difficultyClassWithDisadvantage);
            difficultyClassValueLabel.Text = difficultyClass.ToString();
        }


        /************************************************
         *              Expected Value Calc
        ************************************************/
        private void evNumDiceUpDown_ValueChanged(object sender, EventArgs e)
        {
            expectedValueNumberOfDice = evNumDiceUpDown.Value;
            updateExpectedValue();
        }

        private void evNumSidesUpDown_ValueChanged(object sender, EventArgs e)
        {
            expectedValueNumberOfSides = evNumSidesUpDown.Value;
            updateExpectedValue();
        }

        private void evModifierUpDown_ValueChanged(object sender, EventArgs e)
        {
            expectedValueModifier = evModifierUpDown.Value;
            updateExpectedValue();
        }

        private void updateExpectedValue()
        {
            expectedValue = calculator.GetExpectedValue(expectedValueNumberOfDice, expectedValueNumberOfSides, expectedValueModifier);
            evValueLabel.Text = expectedValue.ToString();
        }
    }
}
