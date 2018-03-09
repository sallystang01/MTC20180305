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
            try
            {


                firstConcat.Text = titleTB.Text + " " + firstNameTB.Text + " " +
                    middleNameTB.Text + " " + lastNameTB.Text;
                secondConcat.Text = firstNameTB.Text + " " + middleNameTB.Text + " " + lastNameTB.Text;
                thirdConcat.Text = firstNameTB.Text + " " + lastNameTB.Text;
                fourthConcat.Text = lastNameTB.Text + ", " + firstNameTB.Text + " " + middleNameTB.Text + ", " + titleTB.Text;
                fifthConcat.Text = lastNameTB.Text + ", " + firstNameTB.Text + " " + middleNameTB.Text;
                sixthConcat.Text = lastNameTB.Text + ", " + firstNameTB.Text;

            }
            catch
            {
                MessageBox.Show("Please Enter all fields");
            }
                     
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            firstNameTB.Text = null;
            middleNameTB.Text = null;
            lastNameTB.Text = null;
            titleTB.Text = null;

            firstConcat.Text = null;
            secondConcat.Text = null;
            thirdConcat.Text = null;
            fourthConcat.Text = null;
            fifthConcat.Text = null;
            sixthConcat.Text = null;


        }

       
    }
}
