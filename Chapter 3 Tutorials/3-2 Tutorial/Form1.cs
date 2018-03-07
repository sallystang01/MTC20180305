using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_2_Tutorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Closes form
            this.Close();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double miles; //Miles Driven
            double gallons; //Gallons used
            double mpg; //MPG

            //Get miles driven and assign it to
            //the miles variable
            miles = double.Parse(milesTextBox.Text);

            //Get the gallons used and assign it to
            //the gallons variable
            gallons = double.Parse(gallonsTextBox.Text);

            //Calculate MPG.
            mpg = miles / gallons;

            //Displays MPG in label
            mpgLabel.Text = mpg.ToString();
        }
    }
}
