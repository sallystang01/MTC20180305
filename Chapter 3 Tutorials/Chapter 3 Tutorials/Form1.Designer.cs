namespace Chapter_3_Tutorials
{
    partial class BDS
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
            this.dow = new System.Windows.Forms.Label();
            this.NoM = new System.Windows.Forms.Label();
            this.DoM = new System.Windows.Forms.Label();
            this.EtY = new System.Windows.Forms.Label();
            this.DoWTextBox = new System.Windows.Forms.TextBox();
            this.NoMTextBox = new System.Windows.Forms.TextBox();
            this.DoMTextBox = new System.Windows.Forms.TextBox();
            this.EtYTextBox = new System.Windows.Forms.TextBox();
            this.dateOutputLabel = new System.Windows.Forms.Label();
            this.showDateButtonshowDateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dow
            // 
            this.dow.AutoSize = true;
            this.dow.Location = new System.Drawing.Point(45, 16);
            this.dow.Name = "dow";
            this.dow.Size = new System.Drawing.Size(129, 13);
            this.dow.TabIndex = 0;
            this.dow.Text = "Enter the day of the week";
            // 
            // NoM
            // 
            this.NoM.AutoSize = true;
            this.NoM.Location = new System.Drawing.Point(33, 47);
            this.NoM.Name = "NoM";
            this.NoM.Size = new System.Drawing.Size(141, 13);
            this.NoM.TabIndex = 1;
            this.NoM.Text = "Enter the name of the month";
            // 
            // DoM
            // 
            this.DoM.AutoSize = true;
            this.DoM.Location = new System.Drawing.Point(2, 78);
            this.DoM.Name = "DoM";
            this.DoM.Size = new System.Drawing.Size(172, 13);
            this.DoM.TabIndex = 2;
            this.DoM.Text = "Enter the numeric day of the month";
            this.DoM.Click += new System.EventHandler(this.NDoM_Click);
            // 
            // EtY
            // 
            this.EtY.AutoSize = true;
            this.EtY.Location = new System.Drawing.Point(99, 108);
            this.EtY.Name = "EtY";
            this.EtY.Size = new System.Drawing.Size(75, 13);
            this.EtY.TabIndex = 3;
            this.EtY.Text = "Enter the Year";
            // 
            // DoWTextBox
            // 
            this.DoWTextBox.Location = new System.Drawing.Point(180, 13);
            this.DoWTextBox.Name = "DoWTextBox";
            this.DoWTextBox.Size = new System.Drawing.Size(100, 20);
            this.DoWTextBox.TabIndex = 4;
            // 
            // NoMTextBox
            // 
            this.NoMTextBox.Location = new System.Drawing.Point(180, 44);
            this.NoMTextBox.Name = "NoMTextBox";
            this.NoMTextBox.Size = new System.Drawing.Size(100, 20);
            this.NoMTextBox.TabIndex = 5;
            this.NoMTextBox.TextChanged += new System.EventHandler(this.mTB_TextChanged);
            // 
            // DoMTextBox
            // 
            this.DoMTextBox.Location = new System.Drawing.Point(180, 75);
            this.DoMTextBox.Name = "DoMTextBox";
            this.DoMTextBox.Size = new System.Drawing.Size(100, 20);
            this.DoMTextBox.TabIndex = 6;
            // 
            // EtYTextBox
            // 
            this.EtYTextBox.Location = new System.Drawing.Point(180, 105);
            this.EtYTextBox.Name = "EtYTextBox";
            this.EtYTextBox.Size = new System.Drawing.Size(100, 20);
            this.EtYTextBox.TabIndex = 7;
            // 
            // dateOutputLabel
            // 
            this.dateOutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateOutputLabel.Location = new System.Drawing.Point(21, 163);
            this.dateOutputLabel.Name = "dateOutputLabel";
            this.dateOutputLabel.Size = new System.Drawing.Size(253, 30);
            this.dateOutputLabel.TabIndex = 8;
            this.dateOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showDateButtonshowDateButton
            // 
            this.showDateButtonshowDateButton.Location = new System.Drawing.Point(15, 217);
            this.showDateButtonshowDateButton.Name = "showDateButtonshowDateButton";
            this.showDateButtonshowDateButton.Size = new System.Drawing.Size(75, 23);
            this.showDateButtonshowDateButton.TabIndex = 9;
            this.showDateButtonshowDateButton.Text = "Show Date";
            this.showDateButtonshowDateButton.UseVisualStyleBackColor = true;
            this.showDateButtonshowDateButton.Click += new System.EventHandler(this.showDateButtonshowDateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(109, 217);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BDS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.showDateButtonshowDateButton);
            this.Controls.Add(this.dateOutputLabel);
            this.Controls.Add(this.EtYTextBox);
            this.Controls.Add(this.DoMTextBox);
            this.Controls.Add(this.NoMTextBox);
            this.Controls.Add(this.DoWTextBox);
            this.Controls.Add(this.EtY);
            this.Controls.Add(this.DoM);
            this.Controls.Add(this.NoM);
            this.Controls.Add(this.dow);
            this.Name = "BDS";
            this.Text = "Birth Date String";
            this.Load += new System.EventHandler(this.BDS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dow;
        private System.Windows.Forms.Label NoM;
        private System.Windows.Forms.Label DoM;
        private System.Windows.Forms.Label EtY;
        private System.Windows.Forms.TextBox DoWTextBox;
        private System.Windows.Forms.TextBox NoMTextBox;
        private System.Windows.Forms.TextBox DoMTextBox;
        private System.Windows.Forms.TextBox EtYTextBox;
        private System.Windows.Forms.Label dateOutputLabel;
        private System.Windows.Forms.Button showDateButtonshowDateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button button1;
    }
}

