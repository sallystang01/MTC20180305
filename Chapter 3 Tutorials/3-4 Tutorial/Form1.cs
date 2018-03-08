using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_4_Tutorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void test3PromptLabel_Click(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double test1; //To hold test score #1
                double test2; //To hold test score #2
                double test3; //To hold test score #3
                double average; //To hold the average test score

                //Get the three test scores.
                test1 = double.Parse(test1TextBox.Text);
                test2 = double.Parse(test2TextBox.Text);
                test3 = double.Parse(test3TextBox.Text);

                //Calculate the average test score.
                average = (test1 + test2 + test2) / 3.0;

                averageLabel.Text = average.ToString("n1");
            }
            catch (Exception ex)
            {
                //Display the defualt error message
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear the input and output controls
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";
            averageLabel.Text = "";

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Closes the form
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
