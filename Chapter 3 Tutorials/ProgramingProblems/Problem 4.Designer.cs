namespace ProgramingProblems
{
    partial class Problem_4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPurchaseAmount = new System.Windows.Forms.Label();
            this.tbPurchaseAmount = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.gbCalculations = new System.Windows.Forms.GroupBox();
            this.rstTotalTax = new System.Windows.Forms.Label();
            this.rstFederalTax = new System.Windows.Forms.Label();
            this.rstStateSalesTax = new System.Windows.Forms.Label();
            this.rstPurchaseAmount = new System.Windows.Forms.Label();
            this.lblTotalTaxRst = new System.Windows.Forms.Label();
            this.lblFedSalesTaxRst = new System.Windows.Forms.Label();
            this.lblStateSalesTaxRst = new System.Windows.Forms.Label();
            this.lblPurchaseAmountRst = new System.Windows.Forms.Label();
            this.rstTotalPurchase = new System.Windows.Forms.Label();
            this.lblTotalPurchaseAmountRst = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbCalculations.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPurchaseAmount
            // 
            this.lblPurchaseAmount.AutoSize = true;
            this.lblPurchaseAmount.Location = new System.Drawing.Point(38, 30);
            this.lblPurchaseAmount.Name = "lblPurchaseAmount";
            this.lblPurchaseAmount.Size = new System.Drawing.Size(94, 13);
            this.lblPurchaseAmount.TabIndex = 1;
            this.lblPurchaseAmount.Text = "Purchase Amount:";
            // 
            // tbPurchaseAmount
            // 
            this.tbPurchaseAmount.Location = new System.Drawing.Point(147, 27);
            this.tbPurchaseAmount.Name = "tbPurchaseAmount";
            this.tbPurchaseAmount.Size = new System.Drawing.Size(100, 20);
            this.tbPurchaseAmount.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(158, 53);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // gbCalculations
            // 
            this.gbCalculations.Controls.Add(this.lblTotalPurchaseAmountRst);
            this.gbCalculations.Controls.Add(this.rstTotalPurchase);
            this.gbCalculations.Controls.Add(this.rstTotalTax);
            this.gbCalculations.Controls.Add(this.rstFederalTax);
            this.gbCalculations.Controls.Add(this.rstStateSalesTax);
            this.gbCalculations.Controls.Add(this.rstPurchaseAmount);
            this.gbCalculations.Controls.Add(this.lblTotalTaxRst);
            this.gbCalculations.Controls.Add(this.lblFedSalesTaxRst);
            this.gbCalculations.Controls.Add(this.lblStateSalesTaxRst);
            this.gbCalculations.Controls.Add(this.lblPurchaseAmountRst);
            this.gbCalculations.Location = new System.Drawing.Point(12, 134);
            this.gbCalculations.Name = "gbCalculations";
            this.gbCalculations.Size = new System.Drawing.Size(260, 100);
            this.gbCalculations.TabIndex = 4;
            this.gbCalculations.TabStop = false;
            // 
            // rstTotalTax
            // 
            this.rstTotalTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rstTotalTax.Location = new System.Drawing.Point(165, 66);
            this.rstTotalTax.Name = "rstTotalTax";
            this.rstTotalTax.Size = new System.Drawing.Size(70, 13);
            this.rstTotalTax.TabIndex = 11;
            // 
            // rstFederalTax
            // 
            this.rstFederalTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rstFederalTax.Location = new System.Drawing.Point(165, 53);
            this.rstFederalTax.Name = "rstFederalTax";
            this.rstFederalTax.Size = new System.Drawing.Size(70, 13);
            this.rstFederalTax.TabIndex = 10;
            // 
            // rstStateSalesTax
            // 
            this.rstStateSalesTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rstStateSalesTax.Location = new System.Drawing.Point(165, 40);
            this.rstStateSalesTax.Name = "rstStateSalesTax";
            this.rstStateSalesTax.Size = new System.Drawing.Size(70, 13);
            this.rstStateSalesTax.TabIndex = 9;
            // 
            // rstPurchaseAmount
            // 
            this.rstPurchaseAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rstPurchaseAmount.Location = new System.Drawing.Point(165, 27);
            this.rstPurchaseAmount.Name = "rstPurchaseAmount";
            this.rstPurchaseAmount.Size = new System.Drawing.Size(70, 13);
            this.rstPurchaseAmount.TabIndex = 8;
            // 
            // lblTotalTaxRst
            // 
            this.lblTotalTaxRst.AutoSize = true;
            this.lblTotalTaxRst.Location = new System.Drawing.Point(67, 67);
            this.lblTotalTaxRst.Name = "lblTotalTaxRst";
            this.lblTotalTaxRst.Size = new System.Drawing.Size(94, 13);
            this.lblTotalTaxRst.TabIndex = 7;
            this.lblTotalTaxRst.Text = "Total Tax Amount:";
            this.lblTotalTaxRst.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblFedSalesTaxRst
            // 
            this.lblFedSalesTaxRst.AutoSize = true;
            this.lblFedSalesTaxRst.Location = new System.Drawing.Point(66, 54);
            this.lblFedSalesTaxRst.Name = "lblFedSalesTaxRst";
            this.lblFedSalesTaxRst.Size = new System.Drawing.Size(95, 13);
            this.lblFedSalesTaxRst.TabIndex = 6;
            this.lblFedSalesTaxRst.Text = "Federal Sales Tax:";
            // 
            // lblStateSalesTaxRst
            // 
            this.lblStateSalesTaxRst.AutoSize = true;
            this.lblStateSalesTaxRst.Location = new System.Drawing.Point(76, 41);
            this.lblStateSalesTaxRst.Name = "lblStateSalesTaxRst";
            this.lblStateSalesTaxRst.Size = new System.Drawing.Size(85, 13);
            this.lblStateSalesTaxRst.TabIndex = 5;
            this.lblStateSalesTaxRst.Text = "State Sales Tax:";
            // 
            // lblPurchaseAmountRst
            // 
            this.lblPurchaseAmountRst.AutoSize = true;
            this.lblPurchaseAmountRst.Location = new System.Drawing.Point(67, 27);
            this.lblPurchaseAmountRst.Name = "lblPurchaseAmountRst";
            this.lblPurchaseAmountRst.Size = new System.Drawing.Size(94, 13);
            this.lblPurchaseAmountRst.TabIndex = 4;
            this.lblPurchaseAmountRst.Text = "Purchase Amount:";
            // 
            // rstTotalPurchase
            // 
            this.rstTotalPurchase.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rstTotalPurchase.Location = new System.Drawing.Point(165, 79);
            this.rstTotalPurchase.Name = "rstTotalPurchase";
            this.rstTotalPurchase.Size = new System.Drawing.Size(70, 13);
            this.rstTotalPurchase.TabIndex = 12;
            // 
            // lblTotalPurchaseAmountRst
            // 
            this.lblTotalPurchaseAmountRst.AutoSize = true;
            this.lblTotalPurchaseAmountRst.Location = new System.Drawing.Point(40, 80);
            this.lblTotalPurchaseAmountRst.Name = "lblTotalPurchaseAmountRst";
            this.lblTotalPurchaseAmountRst.Size = new System.Drawing.Size(121, 13);
            this.lblTotalPurchaseAmountRst.TabIndex = 13;
            this.lblTotalPurchaseAmountRst.Text = "Total Purchase Amount:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(146, 243);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(60, 24);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(212, 243);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(60, 24);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Problem_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 279);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.gbCalculations);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tbPurchaseAmount);
            this.Controls.Add(this.lblPurchaseAmount);
            this.Name = "Problem_4";
            this.Text = "Problem_4";
            this.gbCalculations.ResumeLayout(false);
            this.gbCalculations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPurchaseAmount;
        private System.Windows.Forms.TextBox tbPurchaseAmount;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox gbCalculations;
        private System.Windows.Forms.Label rstTotalTax;
        private System.Windows.Forms.Label rstFederalTax;
        private System.Windows.Forms.Label rstStateSalesTax;
        private System.Windows.Forms.Label rstPurchaseAmount;
        private System.Windows.Forms.Label lblTotalTaxRst;
        private System.Windows.Forms.Label lblFedSalesTaxRst;
        private System.Windows.Forms.Label lblStateSalesTaxRst;
        private System.Windows.Forms.Label lblPurchaseAmountRst;
        private System.Windows.Forms.Label lblTotalPurchaseAmountRst;
        private System.Windows.Forms.Label rstTotalPurchase;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}