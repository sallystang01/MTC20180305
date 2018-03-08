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
            rstCostofFood.Text = tbCostofFood.Text;
        }
    }
}
