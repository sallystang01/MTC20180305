namespace Directory
{
    partial class Form1
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
            this.ThreeOne = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ThreeTwo = new System.Windows.Forms.Button();
            this.ThreeThree = new System.Windows.Forms.Button();
            this.ThreeFour = new System.Windows.Forms.Button();
            this.ThreeFive = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ThreeOne
            // 
            this.ThreeOne.Location = new System.Drawing.Point(34, 36);
            this.ThreeOne.Name = "ThreeOne";
            this.ThreeOne.Size = new System.Drawing.Size(152, 23);
            this.ThreeOne.TabIndex = 0;
            this.ThreeOne.Text = "3-1 Tutorial";
            this.ThreeOne.UseVisualStyleBackColor = true;
            this.ThreeOne.Click += new System.EventHandler(this.ThreeOne_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Main Directory";
            // 
            // ThreeTwo
            // 
            this.ThreeTwo.Location = new System.Drawing.Point(34, 65);
            this.ThreeTwo.Name = "ThreeTwo";
            this.ThreeTwo.Size = new System.Drawing.Size(152, 23);
            this.ThreeTwo.TabIndex = 2;
            this.ThreeTwo.Text = "3-2 Tutorial";
            this.ThreeTwo.UseVisualStyleBackColor = true;
            this.ThreeTwo.Click += new System.EventHandler(this.ThreeTwo_Click);
            // 
            // ThreeThree
            // 
            this.ThreeThree.Location = new System.Drawing.Point(34, 94);
            this.ThreeThree.Name = "ThreeThree";
            this.ThreeThree.Size = new System.Drawing.Size(152, 23);
            this.ThreeThree.TabIndex = 3;
            this.ThreeThree.Text = "3-3 Tutorial";
            this.ThreeThree.UseVisualStyleBackColor = true;
            this.ThreeThree.Click += new System.EventHandler(this.ThreeThree_Click);
            // 
            // ThreeFour
            // 
            this.ThreeFour.Location = new System.Drawing.Point(34, 123);
            this.ThreeFour.Name = "ThreeFour";
            this.ThreeFour.Size = new System.Drawing.Size(152, 23);
            this.ThreeFour.TabIndex = 4;
            this.ThreeFour.Text = "3-4 Tutorial";
            this.ThreeFour.UseVisualStyleBackColor = true;
            this.ThreeFour.Click += new System.EventHandler(this.ThreeFour_Click);
            // 
            // ThreeFive
            // 
            this.ThreeFive.Location = new System.Drawing.Point(34, 152);
            this.ThreeFive.Name = "ThreeFive";
            this.ThreeFive.Size = new System.Drawing.Size(152, 23);
            this.ThreeFive.TabIndex = 5;
            this.ThreeFive.Text = "3-5 Tutorial";
            this.ThreeFive.UseVisualStyleBackColor = true;
            this.ThreeFive.Click += new System.EventHandler(this.ThreeFive_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(88, 181);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(57, 36);
            this.button6.TabIndex = 6;
            this.button6.Text = "Exit";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 237);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.ThreeFive);
            this.Controls.Add(this.ThreeFour);
            this.Controls.Add(this.ThreeThree);
            this.Controls.Add(this.ThreeTwo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ThreeOne);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ThreeOne;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ThreeTwo;
        private System.Windows.Forms.Button ThreeThree;
        private System.Windows.Forms.Button ThreeFour;
        private System.Windows.Forms.Button ThreeFive;
        private System.Windows.Forms.Button button6;
    }
}

