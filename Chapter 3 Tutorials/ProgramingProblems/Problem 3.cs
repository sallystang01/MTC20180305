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
    public partial class Problem_3 : Form
    {
        public Problem_3()
        {
            InitializeComponent();
        }
        
        private void btnFive_Click(object sender, EventArgs e)
        {
            try
            {


                decimal Speed;
                decimal Time;
                decimal Distance;

                Time = 5;
                Speed = decimal.Parse(tbInput.Text);
                Distance = Speed * Time;

                lblResult.Text = Distance.ToString() + " " + "Miles";

            }

            catch
            {
                MessageBox.Show("Please Enter a Valid Value");
            }
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            try
            {
                decimal Speed;
                decimal Time;
                decimal Distance;

                Time = 8;
                Speed = decimal.Parse(tbInput.Text);
                Distance = Speed * Time;

                lblResult.Text = Distance.ToString() +  " " + "Miles";
            }
            catch
            {
                MessageBox.Show("Please Enter a Valid Value");
            }
        }

        private void btnTwelve_Click(object sender, EventArgs e)
        {
            try
            {
                decimal Speed;
                decimal Time;
                decimal Distance;

                Time = 12;
                Speed = decimal.Parse(tbInput.Text);
                Distance = Speed * Time;

                lblResult.Text = Distance.ToString() + " " + "Miles";
            }
            catch
            {
                MessageBox.Show("Please Enter a Valid Value");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblResult.Text = null;
            tbInput.Text = null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
