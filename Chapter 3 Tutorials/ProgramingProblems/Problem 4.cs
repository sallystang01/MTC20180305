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
    public partial class Problem_4 : Form
    {
        public Problem_4()
        {
           
            InitializeComponent();
            //Constant Values
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Tries the following assuming it has values
            try
            {
                //Variables
                const decimal stateTaxPercent = 0.04m;
                const decimal federalTaxPercent = 0.02m;
                decimal purchaseAmount;
                decimal stateTax;
                decimal federalTax;
                decimal totalTax;
                decimal totalAmount;

                //Defines Variables
                purchaseAmount = decimal.Parse(tbPurchaseAmount.Text);
                stateTax = (purchaseAmount * stateTaxPercent);
                federalTax = (purchaseAmount * federalTaxPercent);
                totalTax = (stateTax + federalTax);
                totalAmount = (purchaseAmount + totalTax);

                //Places Variables in Text Property of Labels
                rstFederalTax.Text = federalTax.ToString();
                rstPurchaseAmount.Text = purchaseAmount.ToString();
                rstStateSalesTax.Text = stateTax.ToString();
                rstTotalPurchase.Text = totalAmount.ToString();
                rstTotalTax.Text = totalTax.ToString();
            }
            //No values, gives this message instead of crashing
            catch
            {
                MessageBox.Show("Please Submit a Total Amount");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clears All Fields
            rstTotalTax.Text = "";
            rstTotalPurchase.Text = "";
            rstStateSalesTax.Text = "";
            rstFederalTax.Text = "";
            rstPurchaseAmount.Text = "";
            tbPurchaseAmount.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closes Form
            this.Close();
        }
    }
}
