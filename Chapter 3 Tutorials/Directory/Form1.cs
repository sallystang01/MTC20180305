using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace Directory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ThreeOne_Click(object sender, EventArgs e)
        {
            Chapter_3_Tutorials.BDS test = new Chapter_3_Tutorials.BDS();
            test.Show();
        }

        private void ThreeTwo_Click(object sender, EventArgs e)
        {
            _3_2_Tutorial.Form1 test1 = new _3_2_Tutorial.Form1();
            test1.Show();
        }

        private void ThreeThree_Click(object sender, EventArgs e)
        {
            _3_3_Tutorial.SalePriceCalc test2 = new _3_3_Tutorial.SalePriceCalc();
            test2.Show();
        }

        private void ThreeFour_Click(object sender, EventArgs e)
        {
            _3_4_Tutorial.Form1 test3 = new _3_4_Tutorial.Form1();
            test3.Show();
        }

        private void ThreeFive_Click(object sender, EventArgs e)
        {
            _3_5_Tutorial.ChangeCounter test4 = new _3_5_Tutorial.ChangeCounter();
            test4.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
