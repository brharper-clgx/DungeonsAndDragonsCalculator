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
    public partial class ExpectedValueForm : Form
    {
        private decimal expectedValueNumberOfDice;
        private decimal expectedValueNumberOfSides;
        private decimal expectedValueModifier;
        private decimal expectedValue;

        private ICalculatorService calculator;

        public ExpectedValueForm(ICalculatorService calculator)
        {
            this.calculator = calculator;
            expectedValueNumberOfDice = 1;
            expectedValueNumberOfSides = 20;
            expectedValue = 10.5m;
            InitializeComponent();
        }

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
