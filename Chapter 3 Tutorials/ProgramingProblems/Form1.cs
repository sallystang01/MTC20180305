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
    public partial class NameFormatter : Form
    {
        public NameFormatter()
        {
            InitializeComponent();
        }

        private void NameFormatter_Load(object sender, EventArgs e)
        {

        }

        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void Generator_Click(object sender, EventArgs e)
        {
            firstConcat.Text = titleTB.Text + " " + firstNameTB.Text + " " +
                middleNameTB.Text + " " + lastNameTB.Text;
            secondConcat.Text = firstNameTB.Text + " " + middleNameTB.Text + " " + lastNameTB.Text;
            thirdConcat.Text = firstNameTB.Text + " " + lastNameTB.Text;
            fourthConcat.Text = lastNameTB.Text + ", " + firstNameTB.Text + " " + middleNameTB.Text + ", " + titleTB.Text;
            fifthConcat.Text = lastNameTB.Text + ", " + firstNameTB.Text + " " + middleNameTB.Text;
            sixthConcat.Text = lastNameTB.Text + ", " + firstNameTB.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
