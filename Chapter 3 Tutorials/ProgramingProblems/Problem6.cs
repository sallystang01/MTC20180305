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
    public partial class Problem6 : Form
    {
        public Problem6()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                //Declare Variables
                double weight;
                double height;
                double BMI;

                //Assigns Variables
                weight = double.Parse(tbWeight.Text);
                height = double.Parse(tbHeight.Text);
                BMI = (weight * 703.0) / (height * weight);

                lblBMI.Text = BMI.ToString("0.##");
            }
            catch
            {
                MessageBox.Show("You must enter a weight and height");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbHeight.Text = "";
            tbWeight.Text = "";
            lblBMI.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
