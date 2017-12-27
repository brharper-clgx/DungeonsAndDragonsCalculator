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
    public partial class DifficultyClassUI : Form
    {
        private int difficultyClass;
        private int successPercentage;
        private int modifier;
        private bool withAdvantage;
        private bool withDisadvantage;
        private ICalculatorService calculator;

        public DifficultyClassUI(ICalculatorService calculator)
        {
            difficultyClass = 11;
            successPercentage = 50;
            InitializeComponent();
            this.calculator = calculator;
        }

        private void successPercentageTrackbar_Scroll(object sender, EventArgs e)
        {
            successPercentage = 5*successPercentageTrackbar.Value;
            successPercentageLabel.Text = successPercentage.ToString();
            updateDifficultyClass();
        }

        private void advantageCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            withAdvantage = advantageCheckbox.CheckState == CheckState.Checked ? true : false;
            updateDifficultyClass();
        }

        private void disadvantageCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            withDisadvantage = disadvantageCheckbox.CheckState == CheckState.Checked ? true : false;
            updateDifficultyClass();
        }
        

        private void modifierUpDown_ValueChanged(object sender, EventArgs e)
        {
            modifier = (int)modifierUpDown.Value;
            updateDifficultyClass();
        }



        private void updateDifficultyClass()
        {
            difficultyClass = calculator.GetDifficultyClass(successPercentage, modifier, withAdvantage, withDisadvantage);
            difficultyClassValueLabel.Text = difficultyClass.ToString();
        }
    }
}
