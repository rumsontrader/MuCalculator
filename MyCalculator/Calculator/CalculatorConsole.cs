using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorConsoleForm : Form
    {
        /// <summary>
        /// string to hold user input
        /// </summary>
        string input = string.Empty;

        /// <summary>
        /// string to hold the first operand
        /// </summary>
        string operand = string.Empty;

        /// <summary>
        /// string to hold the second operand
        /// </summary>
        string operand2 = string.Empty;

        /// <summary>
        /// char to hold operation
        /// </summary>
        char operation;

        /// <summary>
        /// output to be sent to display
        /// </summary>
        double output = 0.0;          

        public CalculatorConsoleForm()
        {
            InitializeComponent();
        }

        private void CalculatorConsole_Load(object sender, EventArgs e)
        {

        }

        private void oneButton_Click(object sender, EventArgs e)
        {

        }
        
        private void divisionButton_Click(object sender, EventArgs e)
        {

        }

        private void minusButton_Click(object sender, EventArgs e)
        {

        }
    }
}
