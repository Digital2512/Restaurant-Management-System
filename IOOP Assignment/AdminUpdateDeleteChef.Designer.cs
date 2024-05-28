namespace trial_2
{
    partial class AdminUpdateDeleteChef
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
            this.lblchefPosition = new System.Windows.Forms.Label();
            this.lstchefPosition = new System.Windows.Forms.ListBox();
            this.grpboxSkills = new System.Windows.Forms.GroupBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.grpboxGender = new System.Windows.Forms.GroupBox();
            this.rdbtnFemale = new System.Windows.Forms.RadioButton();
            this.rdbtnMale = new System.Windows.Forms.RadioButton();
            this.dtpDob = new System.Windows.Forms.DateTimePicker();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblDob = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblphoneNumber = new System.Windows.Forms.Label();
            this.lblChefIDTitle = new System.Windows.Forms.Label();
            this.lblUpdateDeleteChef = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbChefID = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.grpboxSkills.SuspendLayout();
            this.grpboxGender.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblchefPosition
            // 
            this.lblchefPosition.AutoSize = true;
            this.lblchefPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchefPosition.Location = new System.Drawing.Point(560, 173);
            this.lblchefPosition.Name = "lblchefPosition";
            this.lblchefPosition.Size = new System.Drawing.Size(128, 20);
            this.lblchefPosition.TabIndex = 29;
            this.lblchefPosition.Text = "Chef Position:";
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
            this.lstchefPosition.Location = new System.Drawing.Point(740, 173);
            this.lstchefPosition.Name = "lstchefPosition";
            this.lstchefPosition.Size = new System.Drawing.Size(197, 44);
            this.lstchefPosition.TabIndex = 28;
            // 
            // grpboxSkills
            // 
            this.grpboxSkills.Controls.Add(this.checkBox5);
            this.grpboxSkills.Controls.Add(this.checkBox4);
            this.grpboxSkills.Controls.Add(this.checkBox3);
            this.grpboxSkills.Controls.Add(this.checkBox2);
            this.grpboxSkills.Controls.Add(this.checkBox1);
            this.grpboxSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxSkills.Location = new System.Drawing.Point(564, 249);
            this.grpboxSkills.Name = "grpboxSkills";
            this.grpboxSkills.Size = new System.Drawing.Size(373, 185);
            this.grpboxSkills.TabIndex = 27;
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
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(256, 444);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 22);
            this.txtEmail.TabIndex = 26;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(256, 391);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(200, 22);
            this.txtPhoneNumber.TabIndex = 25;
            // 
            // grpboxGender
            // 
            this.grpboxGender.Controls.Add(this.rdbtnFemale);
            this.grpboxGender.Controls.Add(this.rdbtnMale);
            this.grpboxGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxGender.Location = new System.Drawing.Point(115, 269);
            this.grpboxGender.Name = "grpboxGender";
            this.grpboxGender.Size = new System.Drawing.Size(200, 100);
            this.grpboxGender.TabIndex = 24;
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
            // dtpDob
            // 
            this.dtpDob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDob.Location = new System.Drawing.Point(256, 220);
            this.dtpDob.Name = "dtpDob";
            this.dtpDob.Size = new System.Drawing.Size(200, 22);
            this.dtpDob.TabIndex = 23;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(256, 171);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(200, 22);
            this.txtFullName.TabIndex = 22;
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDob.Location = new System.Drawing.Point(111, 220);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(124, 20);
            this.lblDob.TabIndex = 20;
            this.lblDob.Text = "Date of Birth:";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(111, 171);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(100, 20);
            this.lblFullName.TabIndex = 19;
            this.lblFullName.Text = "Full Name:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(111, 444);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(62, 20);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "Email:";
            // 
            // lblphoneNumber
            // 
            this.lblphoneNumber.AutoSize = true;
            this.lblphoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphoneNumber.Location = new System.Drawing.Point(111, 391);
            this.lblphoneNumber.Name = "lblphoneNumber";
            this.lblphoneNumber.Size = new System.Drawing.Size(138, 20);
            this.lblphoneNumber.TabIndex = 17;
            this.lblphoneNumber.Text = "Phone Number:";
            // 
            // lblChefIDTitle
            // 
            this.lblChefIDTitle.AutoSize = true;
            this.lblChefIDTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChefIDTitle.Location = new System.Drawing.Point(111, 115);
            this.lblChefIDTitle.Name = "lblChefIDTitle";
            this.lblChefIDTitle.Size = new System.Drawing.Size(79, 20);
            this.lblChefIDTitle.TabIndex = 16;
            this.lblChefIDTitle.Text = "Chef ID:";
            // 
            // lblUpdateDeleteChef
            // 
            this.lblUpdateDeleteChef.AutoSize = true;
            this.lblUpdateDeleteChef.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateDeleteChef.Location = new System.Drawing.Point(333, 43);
            this.lblUpdateDeleteChef.Name = "lblUpdateDeleteChef";
            this.lblUpdateDeleteChef.Size = new System.Drawing.Size(404, 39);
            this.lblUpdateDeleteChef.TabIndex = 30;
            this.lblUpdateDeleteChef.Text = "Update and Delete Chef";
            this.lblUpdateDeleteChef.Click += new System.EventHandler(this.lblUpdateDeleteChef_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(428, 492);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(87, 35);
            this.btnUpdate.TabIndex = 31;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(551, 492);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 35);
            this.btnDelete.TabIndex = 32;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmbChefID
            // 
            this.cmbChefID.FormattingEnabled = true;
            this.cmbChefID.Location = new System.Drawing.Point(256, 115);
            this.cmbChefID.Name = "cmbChefID";
            this.cmbChefID.Size = new System.Drawing.Size(133, 24);
            this.cmbChefID.TabIndex = 33;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(411, 111);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 30);
            this.btnSearch.TabIndex = 34;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.DimGray;
            this.panelHeader.Controls.Add(this.btnBack);
            this.panelHeader.Location = new System.Drawing.Point(-1, -1);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1027, 34);
            this.panelHeader.TabIndex = 35;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(54, 34);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // AdminUpdateDeleteChef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 541);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbChefID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblUpdateDeleteChef);
            this.Controls.Add(this.lblchefPosition);
            this.Controls.Add(this.lstchefPosition);
            this.Controls.Add(this.grpboxSkills);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.grpboxGender);
            this.Controls.Add(this.dtpDob);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblDob);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblphoneNumber);
            this.Controls.Add(this.lblChefIDTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminUpdateDeleteChef";
            this.Text = "AdminUpdateDeleteChef";
            this.Load += new System.EventHandler(this.AdminUpdateDeleteChef_Load);
            this.grpboxSkills.ResumeLayout(false);
            this.grpboxSkills.PerformLayout();
            this.grpboxGender.ResumeLayout(false);
            this.grpboxGender.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblchefPosition;
        private System.Windows.Forms.ListBox lstchefPosition;
        private System.Windows.Forms.GroupBox grpboxSkills;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.GroupBox grpboxGender;
        private System.Windows.Forms.RadioButton rdbtnFemale;
        private System.Windows.Forms.RadioButton rdbtnMale;
        private System.Windows.Forms.DateTimePicker dtpDob;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblphoneNumber;
        private System.Windows.Forms.Label lblChefIDTitle;
        private System.Windows.Forms.Label lblUpdateDeleteChef;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbChefID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnBack;
    }
}