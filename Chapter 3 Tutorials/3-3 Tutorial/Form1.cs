using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_3_Tutorial
{
    public partial class SalePriceCalc : Form
    {
        public SalePriceCalc()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal originalPrice; //Item's original price
            decimal discountPercentage; //The discount percentage
            decimal discountAmount; //The amount of discount
            decimal salesPrice; // This item's sales price

            //Get the item's original price.
            originalPrice = decimal.Parse(originalPriceTextBox.Text);

            //Get the discount percentage
            discountPercentage = decimal.Parse(discountPercentageTextbox.Text);

            //Move's decimal place over to the left two places
            discountPercentage = discountPercentage / 100;

            //Calculate the amount of the discount
            discountAmount = originalPrice * discountPercentage;

            //Calculate the sale price.
            salesPrice = originalPrice - discountAmount;

            //Display the sale price.
            salePriceLabel.Text = salesPrice.ToString("c");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Closes form
            this.Close();
        }

        private void SalePriceCalc_Load(object sender, EventArgs e)
        {

        }
    }
}
