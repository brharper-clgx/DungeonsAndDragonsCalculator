using DndCalculator.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DndCalculator.UI.Forms
{
    public partial class DifficultyClassForm : Form
    {
        private int difficultyClass;
        private int difficultyClassSuccessPercentage;
        private int difficultyClassModifier;
        private bool difficultyClassWithAdvantage;
        private bool difficultyClassWithDisadvantage;

        private ICalculatorService calculator;

        public DifficultyClassForm(ICalculatorService calculator)
        {
            // DC
            difficultyClass = 11;
            difficultyClassSuccessPercentage = 50;
            this.calculator = calculator;
            InitializeComponent();
        }

        private void successPercentageTrackbar_Scroll(object sender, EventArgs e)
        {
            difficultyClassSuccessPercentage = 5 * successPercentageTrackbar.Value;
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
    }
}
