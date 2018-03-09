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
    public partial class Problem5 : Form
    {
        public Problem5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Converts to F
            double x;
            double f;
            double c;

            x = 1.8;
            c = double.Parse(tbInput.Text);
            f = c * x + 32;

            rstTemp.Text = f.ToString() + " " + "F";
           
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            double x;
            double c;
            double f;

            x = 5.0 / 9.0;
            f = double.Parse(tbInput.Text);
            c = (f - 32) * x;

            rstTemp.Text = c.ToString("0.##") + " " + "C";

        }
    }
}
