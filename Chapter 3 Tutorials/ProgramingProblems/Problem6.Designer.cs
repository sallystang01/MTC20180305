namespace ProgramingProblems
{
    partial class Problem6
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.lblLBs = new System.Windows.Forms.Label();
            this.lblInches = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.BMI = new System.Windows.Forms.GroupBox();
            this.lblBMI = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.BMI.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(76, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(128, 18);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Body Mass Index";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(12, 55);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(72, 13);
            this.lblWeight.TabIndex = 1;
            this.lblWeight.Text = "Enter Weight:";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(12, 88);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(69, 13);
            this.lblHeight.TabIndex = 2;
            this.lblHeight.Text = "Enter Height:";
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(90, 52);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(100, 20);
            this.tbWeight.TabIndex = 3;
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(90, 85);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(100, 20);
            this.tbHeight.TabIndex = 4;
            // 
            // lblLBs
            // 
            this.lblLBs.AutoSize = true;
            this.lblLBs.Location = new System.Drawing.Point(196, 55);
            this.lblLBs.Name = "lblLBs";
            this.lblLBs.Size = new System.Drawing.Size(20, 13);
            this.lblLBs.TabIndex = 5;
            this.lblLBs.Text = "lbs";
            // 
            // lblInches
            // 
            this.lblInches.AutoSize = true;
            this.lblInches.Location = new System.Drawing.Point(196, 88);
            this.lblInches.Name = "lblInches";
            this.lblInches.Size = new System.Drawing.Size(38, 13);
            this.lblInches.TabIndex = 6;
            this.lblInches.Text = "inches";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(103, 121);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // BMI
            // 
            this.BMI.Controls.Add(this.lblBMI);
            this.BMI.Location = new System.Drawing.Point(34, 150);
            this.BMI.Name = "BMI";
            this.BMI.Size = new System.Drawing.Size(200, 100);
            this.BMI.TabIndex = 8;
            this.BMI.TabStop = false;
            this.BMI.Text = "BMI:";
            // 
            // lblBMI
            // 
            this.lblBMI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBMI.Location = new System.Drawing.Point(42, 46);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(128, 18);
            this.lblBMI.TabIndex = 9;
            this.lblBMI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(143, 258);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(61, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(210, 258);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(61, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Problem6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 293);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.BMI);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblInches);
            this.Controls.Add(this.lblLBs);
            this.Controls.Add(this.tbHeight);
            this.Controls.Add(this.tbWeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblTitle);
            this.Name = "Problem6";
            this.Text = "Problem6";
            this.BMI.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.Label lblLBs;
        private System.Windows.Forms.Label lblInches;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox BMI;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}