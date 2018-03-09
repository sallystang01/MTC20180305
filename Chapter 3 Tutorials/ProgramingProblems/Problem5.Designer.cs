namespace ProgramingProblems
{
    partial class Problem5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.btnF = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rstTemp = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temperature Converter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter the Temperature:";
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(261, 42);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(100, 20);
            this.tbInput.TabIndex = 2;
            // 
            // btnF
            // 
            this.btnF.Location = new System.Drawing.Point(94, 77);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(140, 23);
            this.btnF.TabIndex = 3;
            this.btnF.Text = "Convert to Fahrenheit";
            this.btnF.UseVisualStyleBackColor = true;
            this.btnF.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(251, 77);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(140, 23);
            this.btnC.TabIndex = 4;
            this.btnC.Text = "Convert to Celsius";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rstTemp);
            this.groupBox1.Location = new System.Drawing.Point(116, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Converted Temperature:";
            // 
            // rstTemp
            // 
            this.rstTemp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rstTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rstTemp.Location = new System.Drawing.Point(51, 39);
            this.rstTemp.Name = "rstTemp";
            this.rstTemp.Size = new System.Drawing.Size(194, 23);
            this.rstTemp.TabIndex = 0;
            // 
            // Problem5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 262);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnF);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Problem5";
            this.Text = "Problem5";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Button btnF;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label rstTemp;
    }
}