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
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            double FirstValue = 0;
            double SecondValue = 0;
            bool numeric = true;

            Error.Text = null;
            

            numeric = (double.TryParse(iv1.Text, out FirstValue) &&
                        double.TryParse(iv2.Text, out SecondValue));

            if (iv1.Text != null && iv2.Text != null && numeric)
            {
                Calculate.BackColor = Color.Green;
                iv1.BackColor = Color.White;
                iv2.BackColor = Color.White;
                if (rbAdd.Checked)
                {
                    resultValue.Text = (FirstValue + SecondValue).ToString();
                }
                if (rbSubtract.Checked)
                {
                    resultValue.Text = (FirstValue - SecondValue).ToString();
                }
                if (rbMultiply.Checked)
                {
                    resultValue.Text = (FirstValue * SecondValue).ToString();
                }
                if (rbDivide.Checked)
                {
                    resultValue.Text = (FirstValue / SecondValue).ToString();
                }

            }
            else
            {
                Error.Text = "**Cannot Calculate Letters**";
                Calculate.BackColor = Color.Red;
                Error.ForeColor = Color.Red;
                iv1.BackColor = Color.Red;
                iv2.BackColor = Color.Red;
                
            }
                
                   
        }
    }
}
