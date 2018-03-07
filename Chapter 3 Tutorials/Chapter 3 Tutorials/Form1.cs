using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_3_Tutorials
{
    public partial class BDS : Form
    {
        public BDS()
        {
            InitializeComponent();
        }

        private void NDoM_Click(object sender, EventArgs e)
        {


        }

        private void mTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void BDS_Load(object sender, EventArgs e)
        {

        }

        private void showDateButtonshowDateButton_Click(object sender, EventArgs e)
        {
            //Declares Variable
            string output;
            //Sets variable to a concatenate of the text inputed through the form.
            output = DoWTextBox.Text + ", " +
                NoMTextBox.Text + " " +
                DoMTextBox.Text + " " +
                EtYTextBox.Text;
            //Displays the variable after concatenate 
            dateOutputLabel.Text = output;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clears the textboxes
            DoWTextBox.Text = "";
            NoMTextBox.Text = "";
            DoMTextBox.Text = "";
            EtYTextBox.Text = "";

            //Clear the label

            dateOutputLabel.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Closes the form
            this.Close();
        }
    }
}
