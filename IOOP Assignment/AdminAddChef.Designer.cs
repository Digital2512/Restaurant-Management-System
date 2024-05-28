namespace IOOP_Assignment
{
    partial class AdminAddChef
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
            this.lblChefIDTitle = new System.Windows.Forms.Label();
            this.lblphoneNumber = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblDob = new System.Windows.Forms.Label();
            this.lblChefID = new System.Windows.Forms.Label();
            this.txtfullName = new System.Windows.Forms.TextBox();
            this.dtpDob = new System.Windows.Forms.DateTimePicker();
            this.grpboxGender = new System.Windows.Forms.GroupBox();
            this.rdbtnFemale = new System.Windows.Forms.RadioButton();
            this.rdbtnMale = new System.Windows.Forms.RadioButton();
            this.txtphoneNumber = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.grpboxSkills = new System.Windows.Forms.GroupBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lstchefPosition = new System.Windows.Forms.ListBox();
            this.lblchefPosition = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.grpboxGender.SuspendLayout();
            this.grpboxSkills.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(433, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Chef";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblChefIDTitle
            // 
            this.lblChefIDTitle.AutoSize = true;
            this.lblChefIDTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChefIDTitle.Location = new System.Drawing.Point(102, 87);
            this.lblChefIDTitle.Name = "lblChefIDTitle";
            this.lblChefIDTitle.Size = new System.Drawing.Size(79, 20);
            this.lblChefIDTitle.TabIndex = 1;
            this.lblChefIDTitle.Text = "Chef ID:";
            // 
            // lblphoneNumber
            // 
            this.lblphoneNumber.AutoSize = true;
            this.lblphoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphoneNumber.Location = new System.Drawing.Point(102, 397);
            this.lblphoneNumber.Name = "lblphoneNumber";
            this.lblphoneNumber.Size = new System.Drawing.Size(138, 20);
            this.lblphoneNumber.TabIndex = 2;
            this.lblphoneNumber.Text = "Phone Number:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(102, 439);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(62, 20);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email:";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(102, 140);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(100, 20);
            this.lblFullName.TabIndex = 5;
            this.lblFullName.Text = "Full Name:";
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDob.Location = new System.Drawing.Point(101, 198);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(124, 20);
            this.lblDob.TabIndex = 6;
            this.lblDob.Text = "Date of Birth:";
            // 
            // lblChefID
            // 
            this.lblChefID.AutoSize = true;
            this.lblChefID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblChefID.Location = new System.Drawing.Point(246, 87);
            this.lblChefID.Name = "lblChefID";
            this.lblChefID.Size = new System.Drawing.Size(2, 18);
            this.lblChefID.TabIndex = 7;
            // 
            // txtfullName
            // 
            this.txtfullName.Location = new System.Drawing.Point(246, 134);
            this.txtfullName.Name = "txtfullName";
            this.txtfullName.Size = new System.Drawing.Size(200, 22);
            this.txtfullName.TabIndex = 8;
            // 
            // dtpDob
            // 
            this.dtpDob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDob.Location = new System.Drawing.Point(246, 198);
            this.dtpDob.Name = "dtpDob";
            this.dtpDob.Size = new System.Drawing.Size(200, 22);
            this.dtpDob.TabIndex = 9;
            // 
            // grpboxGender
            // 
            this.grpboxGender.Controls.Add(this.rdbtnFemale);
            this.grpboxGender.Controls.Add(this.rdbtnMale);
            this.grpboxGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxGender.Location = new System.Drawing.Point(106, 256);
            this.grpboxGender.Name = "grpboxGender";
            this.grpboxGender.Size = new System.Drawing.Size(200, 100);
            this.grpboxGender.TabIndex = 10;
            this.grpboxGender.TabStop = false;
            this.grpboxGender.Text = "Gender";
            // 
            // rdbtnFemale
            // 
            this.rdbtnFemale.AutoSize = true;
            this.rdbtnFemale.Location = new System.Drawing.Point(17, 49);
            this.rdbtnFemale.Name = "rdbtnFemale";
            this.rdbtnFemale.Size = new System.Drawing.Size(91, 24);
            this.rdbtnFemale.TabIndex = 1;
            this.rdbtnFemale.TabStop = true;
            this.rdbtnFemale.Text = "Female";
            this.rdbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rdbtnMale
            // 
            this.rdbtnMale.AutoSize = true;
            this.rdbtnMale.Location = new System.Drawing.Point(17, 22);
            this.rdbtnMale.Name = "rdbtnMale";
            this.rdbtnMale.Size = new System.Drawing.Size(70, 24);
            this.rdbtnMale.TabIndex = 0;
            this.rdbtnMale.TabStop = true;
            this.rdbtnMale.Text = "Male";
            this.rdbtnMale.UseVisualStyleBackColor = true;
            // 
            // txtphoneNumber
            // 
            this.txtphoneNumber.Location = new System.Drawing.Point(246, 397);
            this.txtphoneNumber.Name = "txtphoneNumber";
            this.txtphoneNumber.Size = new System.Drawing.Size(200, 22);
            this.txtphoneNumber.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(246, 439);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 22);
            this.txtEmail.TabIndex = 12;
            // 
            // grpboxSkills
            // 
            this.grpboxSkills.Controls.Add(this.checkBox5);
            this.grpboxSkills.Controls.Add(this.checkBox4);
            this.grpboxSkills.Controls.Add(this.checkBox3);
            this.grpboxSkills.Controls.Add(this.checkBox2);
            this.grpboxSkills.Controls.Add(this.checkBox1);
            this.grpboxSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxSkills.Location = new System.Drawing.Point(570, 198);
            this.grpboxSkills.Name = "grpboxSkills";
            this.grpboxSkills.Size = new System.Drawing.Size(362, 185);
            this.grpboxSkills.TabIndex = 13;
            this.grpboxSkills.TabStop = false;
            this.grpboxSkills.Text = "Skills";
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(18, 137);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(141, 24);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "Plating Skills";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(18, 110);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(210, 24);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Ingredient Knowledge";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(18, 84);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(204, 24);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Recipe Development";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(18, 58);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(200, 24);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Cooking Techniques";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(18, 31);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(126, 24);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Knife Skills";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // lstchefPosition
            // 
            this.lstchefPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstchefPosition.FormattingEnabled = true;
            this.lstchefPosition.ItemHeight = 20;
            this.lstchefPosition.Items.AddRange(new object[] {
            "Executive chef",
            "Head chef",
            "Sous chef",
            "Sushi chef"});
            this.lstchefPosition.Location = new System.Drawing.Point(735, 140);
            this.lstchefPosition.Name = "lstchefPosition";
            this.lstchefPosition.Size = new System.Drawing.Size(197, 44);
            this.lstchefPosition.TabIndex = 14;
            // 
            // lblchefPosition
            // 
            this.lblchefPosition.AutoSize = true;
            this.lblchefPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchefPosition.Location = new System.Drawing.Point(566, 140);
            this.lblchefPosition.Name = "lblchefPosition";
            this.lblchefPosition.Size = new System.Drawing.Size(128, 20);
            this.lblchefPosition.TabIndex = 15;
            this.lblchefPosition.Text = "Chef Position:";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(-1, 502);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(1027, 41);
            this.btnRegister.TabIndex = 16;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.DimGray;
            this.panelHeader.Controls.Add(this.btnBack);
            this.panelHeader.Location = new System.Drawing.Point(-1, -1);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1027, 34);
            this.panelHeader.TabIndex = 17;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(45, 34);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // AdminAddChef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 541);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblchefPosition);
            this.Controls.Add(this.lstchefPosition);
            this.Controls.Add(this.grpboxSkills);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtphoneNumber);
            this.Controls.Add(this.grpboxGender);
            this.Controls.Add(this.dtpDob);
            this.Controls.Add(this.txtfullName);
            this.Controls.Add(this.lblChefID);
            this.Controls.Add(this.lblDob);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblphoneNumber);
            this.Controls.Add(this.lblChefIDTitle);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminAddChef";
            this.Text = "AdminAddChef";
            this.Load += new System.EventHandler(this.AdminAddChef_Load);
            this.grpboxGender.ResumeLayout(false);
            this.grpboxGender.PerformLayout();
            this.grpboxSkills.ResumeLayout(false);
            this.grpboxSkills.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblChefIDTitle;
        private System.Windows.Forms.Label lblphoneNumber;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.Label lblChefID;
        private System.Windows.Forms.TextBox txtfullName;
        private System.Windows.Forms.DateTimePicker dtpDob;
        private System.Windows.Forms.GroupBox grpboxGender;
        private System.Windows.Forms.RadioButton rdbtnFemale;
        private System.Windows.Forms.RadioButton rdbtnMale;
        private System.Windows.Forms.TextBox txtphoneNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox grpboxSkills;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListBox lstchefPosition;
        private System.Windows.Forms.Label lblchefPosition;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnBack;
    }
}