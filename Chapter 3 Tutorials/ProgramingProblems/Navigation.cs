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
    public partial class Navigation : Form
    {
        public Navigation()
        {
            InitializeComponent();
        }

        private void sol1_Click(object sender, EventArgs e)
        {
            ProgramingProblems.NameFormatter test = new ProgramingProblems.NameFormatter();
            test.Show();
        }

        private void sol2_Click(object sender, EventArgs e)
        {
            ProgramingProblems.Problem2 test1 = new ProgramingProblems.Problem2();
            test1.Show();
        }

        private void sol3_Click(object sender, EventArgs e)
        {
            Problem_3 test3 = new Problem_3();
            test3.Show();
        }

        private void sol4_Click(object sender, EventArgs e)
        {
            Problem_4 test4 = new Problem_4();
            test4.Show();
        }

        private void sol5_Click(object sender, EventArgs e)
        {
            Problem5 test5 = new Problem5();
            test5.Show();
        }

        private void sol6_Click(object sender, EventArgs e)
        {
            Problem6 test6 = new Problem6();
            test6.Show();
        }
    }
}
