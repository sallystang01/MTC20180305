using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramingProblems
{
    public partial class Problem2 : Form
    {
        public Problem2()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                decimal foodCostAmount;
                decimal tipAmount, tipPercent;
                decimal taxAmount, taxPercent;
                decimal totalAmount;

                tipPercent = 15;
                taxPercent = 7;
                foodCostAmount = decimal.Parse(tbCostofFood.Text);
                tipAmount = tipPercent * (foodCostAmount / 100);
                taxAmount = taxPercent * (foodCostAmount / 100);
                totalAmount = (foodCostAmount + tipAmount + taxAmount);

                rstCostofFood.Text = foodCostAmount.ToString();
                rstTax.Text = taxAmount.ToString();
                rstTip.Text = tipAmount.ToString();
                rstTotal.Text = totalAmount.ToString();
            }
            catch
            {
                MessageBox.Show("Please fill out all fields");
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbCostofFood.Text = null;
           rstCostofFood.Text = null;
            rstTax.Text = null;
            rstTip.Text = null;
            rstTotal.Text = null;
        }
    }
}
