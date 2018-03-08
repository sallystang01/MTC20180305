namespace ProgramingProblems
{
    partial class Problem2
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
            this.lblCostofFood = new System.Windows.Forms.Label();
            this.tbCostofFood = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.gbCalculations = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rstCostofFood = new System.Windows.Forms.Label();
            this.rstTip = new System.Windows.Forms.Label();
            this.rstTax = new System.Windows.Forms.Label();
            this.rstTotal = new System.Windows.Forms.Label();
            this.gbCalculations.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCostofFood
            // 
            this.lblCostofFood.AutoSize = true;
            this.lblCostofFood.Location = new System.Drawing.Point(62, 37);
            this.lblCostofFood.Name = "lblCostofFood";
            this.lblCostofFood.Size = new System.Drawing.Size(67, 13);
            this.lblCostofFood.TabIndex = 0;
            this.lblCostofFood.Text = "Cost of Food";
            // 
            // tbCostofFood
            // 
            this.tbCostofFood.Location = new System.Drawing.Point(158, 34);
            this.tbCostofFood.Name = "tbCostofFood";
            this.tbCostofFood.Size = new System.Drawing.Size(100, 20);
            this.tbCostofFood.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(183, 60);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // gbCalculations
            // 
            this.gbCalculations.Controls.Add(this.rstTotal);
            this.gbCalculations.Controls.Add(this.rstTax);
            this.gbCalculations.Controls.Add(this.rstTip);
            this.gbCalculations.Controls.Add(this.rstCostofFood);
            this.gbCalculations.Controls.Add(this.label4);
            this.gbCalculations.Controls.Add(this.label3);
            this.gbCalculations.Controls.Add(this.label2);
            this.gbCalculations.Controls.Add(this.label1);
            this.gbCalculations.Location = new System.Drawing.Point(40, 129);
            this.gbCalculations.Name = "gbCalculations";
            this.gbCalculations.Size = new System.Drawing.Size(200, 100);
            this.gbCalculations.TabIndex = 3;
            this.gbCalculations.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cost of Food:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tip:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tax:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total:";
            // 
            // rstCostofFood
            // 
            this.rstCostofFood.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rstCostofFood.Location = new System.Drawing.Point(106, 26);
            this.rstCostofFood.Name = "rstCostofFood";
            this.rstCostofFood.Size = new System.Drawing.Size(70, 13);
            this.rstCostofFood.TabIndex = 8;
            // 
            // rstTip
            // 
            this.rstTip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rstTip.Location = new System.Drawing.Point(106, 39);
            this.rstTip.Name = "rstTip";
            this.rstTip.Size = new System.Drawing.Size(70, 13);
            this.rstTip.TabIndex = 9;
            // 
            // rstTax
            // 
            this.rstTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rstTax.Location = new System.Drawing.Point(106, 52);
            this.rstTax.Name = "rstTax";
            this.rstTax.Size = new System.Drawing.Size(70, 13);
            this.rstTax.TabIndex = 10;
            // 
            // rstTotal
            // 
            this.rstTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rstTotal.Location = new System.Drawing.Point(106, 65);
            this.rstTotal.Name = "rstTotal";
            this.rstTotal.Size = new System.Drawing.Size(70, 13);
            this.rstTotal.TabIndex = 11;
            // 
            // Problem2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.gbCalculations);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tbCostofFood);
            this.Controls.Add(this.lblCostofFood);
            this.Name = "Problem2";
            this.Text = "Problem2";
            this.gbCalculations.ResumeLayout(false);
            this.gbCalculations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCostofFood;
        private System.Windows.Forms.TextBox tbCostofFood;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox gbCalculations;
        private System.Windows.Forms.Label rstTotal;
        private System.Windows.Forms.Label rstTax;
        private System.Windows.Forms.Label rstTip;
        private System.Windows.Forms.Label rstCostofFood;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}