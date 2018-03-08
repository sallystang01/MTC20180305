namespace ProgramingProblems
{
    partial class NameFormatter
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
            this.FirstName = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.MiddleName = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.firstNameTB = new System.Windows.Forms.TextBox();
            this.middleNameTB = new System.Windows.Forms.TextBox();
            this.titleTB = new System.Windows.Forms.TextBox();
            this.lastNameTB = new System.Windows.Forms.TextBox();
            this.Generator = new System.Windows.Forms.Button();
            this.firstConcat = new System.Windows.Forms.Label();
            this.fourthConcat = new System.Windows.Forms.Label();
            this.secondConcat = new System.Windows.Forms.Label();
            this.thirdConcat = new System.Windows.Forms.Label();
            this.fifthConcat = new System.Windows.Forms.Label();
            this.sixthConcat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.Location = new System.Drawing.Point(58, 26);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(70, 15);
            this.FirstName.TabIndex = 0;
            this.FirstName.Text = "First Name:";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName.Location = new System.Drawing.Point(58, 74);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(70, 15);
            this.LastName.TabIndex = 1;
            this.LastName.Text = "Last Name:";
            // 
            // MiddleName
            // 
            this.MiddleName.AutoSize = true;
            this.MiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MiddleName.Location = new System.Drawing.Point(43, 48);
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.Size = new System.Drawing.Size(85, 15);
            this.MiddleName.TabIndex = 2;
            this.MiddleName.Text = "Middle Name:";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(95, 104);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(33, 15);
            this.Title.TabIndex = 3;
            this.Title.Text = "Title:";
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // firstNameTB
            // 
            this.firstNameTB.Location = new System.Drawing.Point(134, 21);
            this.firstNameTB.Name = "firstNameTB";
            this.firstNameTB.Size = new System.Drawing.Size(100, 20);
            this.firstNameTB.TabIndex = 4;
            this.firstNameTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // middleNameTB
            // 
            this.middleNameTB.Location = new System.Drawing.Point(134, 47);
            this.middleNameTB.Name = "middleNameTB";
            this.middleNameTB.Size = new System.Drawing.Size(100, 20);
            this.middleNameTB.TabIndex = 5;
            // 
            // titleTB
            // 
            this.titleTB.Location = new System.Drawing.Point(134, 99);
            this.titleTB.Name = "titleTB";
            this.titleTB.Size = new System.Drawing.Size(100, 20);
            this.titleTB.TabIndex = 6;
            // 
            // lastNameTB
            // 
            this.lastNameTB.Location = new System.Drawing.Point(134, 73);
            this.lastNameTB.Name = "lastNameTB";
            this.lastNameTB.Size = new System.Drawing.Size(100, 20);
            this.lastNameTB.TabIndex = 6;
            // 
            // Generator
            // 
            this.Generator.Location = new System.Drawing.Point(98, 146);
            this.Generator.Name = "Generator";
            this.Generator.Size = new System.Drawing.Size(75, 23);
            this.Generator.TabIndex = 7;
            this.Generator.Text = "Generate";
            this.Generator.UseVisualStyleBackColor = true;
            this.Generator.Click += new System.EventHandler(this.Generator_Click);
            // 
            // firstConcat
            // 
            this.firstConcat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.firstConcat.Location = new System.Drawing.Point(61, 184);
            this.firstConcat.Name = "firstConcat";
            this.firstConcat.Size = new System.Drawing.Size(256, 25);
            this.firstConcat.TabIndex = 8;
            // 
            // fourthConcat
            // 
            this.fourthConcat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fourthConcat.Location = new System.Drawing.Point(61, 290);
            this.fourthConcat.Name = "fourthConcat";
            this.fourthConcat.Size = new System.Drawing.Size(256, 25);
            this.fourthConcat.TabIndex = 9;
            // 
            // secondConcat
            // 
            this.secondConcat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.secondConcat.Location = new System.Drawing.Point(61, 218);
            this.secondConcat.Name = "secondConcat";
            this.secondConcat.Size = new System.Drawing.Size(256, 25);
            this.secondConcat.TabIndex = 9;
            // 
            // thirdConcat
            // 
            this.thirdConcat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.thirdConcat.Location = new System.Drawing.Point(61, 253);
            this.thirdConcat.Name = "thirdConcat";
            this.thirdConcat.Size = new System.Drawing.Size(256, 25);
            this.thirdConcat.TabIndex = 10;
            // 
            // fifthConcat
            // 
            this.fifthConcat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fifthConcat.Location = new System.Drawing.Point(61, 325);
            this.fifthConcat.Name = "fifthConcat";
            this.fifthConcat.Size = new System.Drawing.Size(256, 25);
            this.fifthConcat.TabIndex = 11;
            // 
            // sixthConcat
            // 
            this.sixthConcat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sixthConcat.Location = new System.Drawing.Point(61, 366);
            this.sixthConcat.Name = "sixthConcat";
            this.sixthConcat.Size = new System.Drawing.Size(256, 25);
            this.sixthConcat.TabIndex = 12;
            // 
            // NameFormatter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 400);
            this.Controls.Add(this.sixthConcat);
            this.Controls.Add(this.fifthConcat);
            this.Controls.Add(this.thirdConcat);
            this.Controls.Add(this.secondConcat);
            this.Controls.Add(this.fourthConcat);
            this.Controls.Add(this.firstConcat);
            this.Controls.Add(this.Generator);
            this.Controls.Add(this.lastNameTB);
            this.Controls.Add(this.titleTB);
            this.Controls.Add(this.middleNameTB);
            this.Controls.Add(this.firstNameTB);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.MiddleName);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Name = "NameFormatter";
            this.Text = "Name Formatter";
            this.Load += new System.EventHandler(this.NameFormatter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label MiddleName;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox firstNameTB;
        private System.Windows.Forms.TextBox middleNameTB;
        private System.Windows.Forms.TextBox titleTB;
        private System.Windows.Forms.TextBox lastNameTB;
        private System.Windows.Forms.Button Generator;
        private System.Windows.Forms.Label firstConcat;
        private System.Windows.Forms.Label fourthConcat;
        private System.Windows.Forms.Label secondConcat;
        private System.Windows.Forms.Label thirdConcat;
        private System.Windows.Forms.Label fifthConcat;
        private System.Windows.Forms.Label sixthConcat;
    }
}

