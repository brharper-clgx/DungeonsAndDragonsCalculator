using DndCalculator.Domain.Contracts;
using DndCalculator.UI.Forms;
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
    public partial class CalculatorRootUI : Form
    {
        private ICalculatorService calculator;

        public CalculatorRootUI(ICalculatorService calculator)
        {
            this.calculator = calculator;
            InitializeComponent();
        }

        private void difficultyClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dcForm = new DifficultyClassForm(calculator);
            dcForm.MdiParent = this;
            dcForm.Show();
        }

        private void expectedValueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var evForm = new ExpectedValueForm(calculator);
            evForm.MdiParent = this;
            evForm.Show();
        }
    }
}
