namespace IOOP_Assignment
{
    partial class CustomerUpdateProfilePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerUpdateProfilePage));
            this.updatePnl = new System.Windows.Forms.Panel();
            this.updateBtn = new System.Windows.Forms.Button();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.ratherNotSayRBtn = new System.Windows.Forms.RadioButton();
            this.femaleRBtn = new System.Windows.Forms.RadioButton();
            this.maleRBtn = new System.Windows.Forms.RadioButton();
            this.lblCustomerIDTitle = new System.Windows.Forms.Label();
            this.genderGBox = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblUserIDTitle = new System.Windows.Forms.Label();
            this.backBtnPnl = new System.Windows.Forms.Panel();
            this.lblFullName = new System.Windows.Forms.Label();
            this.headerPnl = new System.Windows.Forms.Panel();
            this.lblUpdateProfile = new System.Windows.Forms.Label();
            this.passwordMTextBox = new System.Windows.Forms.MaskedTextBox();
            this.fullNameTxtBox = new System.Windows.Forms.TextBox();
            this.confirmPasswordMTextBox = new System.Windows.Forms.MaskedTextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.birthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.profilePBox = new System.Windows.Forms.PictureBox();
            this.confirmPasswordShowHideBtn = new System.Windows.Forms.Button();
            this.passwordShowBtn = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.updatePnl.SuspendLayout();
            this.genderGBox.SuspendLayout();
            this.backBtnPnl.SuspendLayout();
            this.headerPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePBox)).BeginInit();
            this.SuspendLayout();
            // 
            // updatePnl
            // 
            this.updatePnl.Controls.Add(this.updateBtn);
            this.updatePnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.updatePnl.Location = new System.Drawing.Point(0, 515);
            this.updatePnl.Name = "updatePnl";
            this.updatePnl.Size = new System.Drawing.Size(800, 47);
            this.updatePnl.TabIndex = 29;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(0, 0);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(800, 47);
            this.updateBtn.TabIndex = 0;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCustomerID.Location = new System.Drawing.Point(508, 130);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(2, 22);
            this.lblCustomerID.TabIndex = 28;
            // 
            // ratherNotSayRBtn
            // 
            this.ratherNotSayRBtn.AutoSize = true;
            this.ratherNotSayRBtn.Location = new System.Drawing.Point(26, 103);
            this.ratherNotSayRBtn.Name = "ratherNotSayRBtn";
            this.ratherNotSayRBtn.Size = new System.Drawing.Size(143, 24);
            this.ratherNotSayRBtn.TabIndex = 2;
            this.ratherNotSayRBtn.TabStop = true;
            this.ratherNotSayRBtn.Text = "Rather Not Say";
            this.ratherNotSayRBtn.UseVisualStyleBackColor = true;
            // 
            // femaleRBtn
            // 
            this.femaleRBtn.AutoSize = true;
            this.femaleRBtn.Location = new System.Drawing.Point(26, 64);
            this.femaleRBtn.Name = "femaleRBtn";
            this.femaleRBtn.Size = new System.Drawing.Size(87, 24);
            this.femaleRBtn.TabIndex = 1;
            this.femaleRBtn.TabStop = true;
            this.femaleRBtn.Text = "Female";
            this.femaleRBtn.UseVisualStyleBackColor = true;
            // 
            // maleRBtn
            // 
            this.maleRBtn.AutoSize = true;
            this.maleRBtn.Location = new System.Drawing.Point(26, 26);
            this.maleRBtn.Name = "maleRBtn";
            this.maleRBtn.Size = new System.Drawing.Size(68, 24);
            this.maleRBtn.TabIndex = 0;
            this.maleRBtn.TabStop = true;
            this.maleRBtn.Text = "Male";
            this.maleRBtn.UseVisualStyleBackColor = true;
            // 
            // lblCustomerIDTitle
            // 
            this.lblCustomerIDTitle.AutoSize = true;
            this.lblCustomerIDTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCustomerIDTitle.ForeColor = System.Drawing.Color.Black;
            this.lblCustomerIDTitle.Location = new System.Drawing.Point(344, 128);
            this.lblCustomerIDTitle.Name = "lblCustomerIDTitle";
            this.lblCustomerIDTitle.Size = new System.Drawing.Size(158, 29);
            this.lblCustomerIDTitle.TabIndex = 27;
            this.lblCustomerIDTitle.Text = "Customer ID: ";
            // 
            // genderGBox
            // 
            this.genderGBox.Controls.Add(this.ratherNotSayRBtn);
            this.genderGBox.Controls.Add(this.femaleRBtn);
            this.genderGBox.Controls.Add(this.maleRBtn);
            this.genderGBox.Location = new System.Drawing.Point(444, 322);
            this.genderGBox.Name = "genderGBox";
            this.genderGBox.Size = new System.Drawing.Size(200, 144);
            this.genderGBox.TabIndex = 26;
            this.genderGBox.TabStop = false;
            this.genderGBox.Text = "Gender: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(435, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 29);
            this.label7.TabIndex = 24;
            this.label7.Text = "Birthday:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPassword.Location = new System.Drawing.Point(38, 322);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(132, 29);
            this.lblPassword.TabIndex = 22;
            this.lblPassword.Text = "Password: ";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUserID.Location = new System.Drawing.Point(440, 73);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(2, 22);
            this.lblUserID.TabIndex = 19;
            this.lblUserID.Click += new System.EventHandler(this.lblUserID_Click);
            // 
            // lblUserIDTitle
            // 
            this.lblUserIDTitle.AutoSize = true;
            this.lblUserIDTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblUserIDTitle.ForeColor = System.Drawing.Color.Black;
            this.lblUserIDTitle.Location = new System.Drawing.Point(344, 73);
            this.lblUserIDTitle.Name = "lblUserIDTitle";
            this.lblUserIDTitle.Size = new System.Drawing.Size(99, 29);
            this.lblUserIDTitle.TabIndex = 18;
            this.lblUserIDTitle.Text = "UserID: ";
            this.lblUserIDTitle.Click += new System.EventHandler(this.lblUserIDTitle_Click);
            // 
            // backBtnPnl
            // 
            this.backBtnPnl.Controls.Add(this.backButton);
            this.backBtnPnl.Location = new System.Drawing.Point(1, 0);
            this.backBtnPnl.Name = "backBtnPnl";
            this.backBtnPnl.Size = new System.Drawing.Size(36, 55);
            this.backBtnPnl.TabIndex = 1;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFullName.ForeColor = System.Drawing.Color.Black;
            this.lblFullName.Location = new System.Drawing.Point(34, 241);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(136, 29);
            this.lblFullName.TabIndex = 20;
            this.lblFullName.Text = "Full Name: ";
            // 
            // headerPnl
            // 
            this.headerPnl.BackColor = System.Drawing.Color.DimGray;
            this.headerPnl.Controls.Add(this.lblUpdateProfile);
            this.headerPnl.Controls.Add(this.backBtnPnl);
            this.headerPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPnl.Location = new System.Drawing.Point(0, 0);
            this.headerPnl.Name = "headerPnl";
            this.headerPnl.Size = new System.Drawing.Size(800, 45);
            this.headerPnl.TabIndex = 17;
            // 
            // lblUpdateProfile
            // 
            this.lblUpdateProfile.AutoSize = true;
            this.lblUpdateProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateProfile.Location = new System.Drawing.Point(307, 7);
            this.lblUpdateProfile.Name = "lblUpdateProfile";
            this.lblUpdateProfile.Size = new System.Drawing.Size(181, 29);
            this.lblUpdateProfile.TabIndex = 2;
            this.lblUpdateProfile.Text = "Update Profile";
            // 
            // passwordMTextBox
            // 
            this.passwordMTextBox.Location = new System.Drawing.Point(39, 354);
            this.passwordMTextBox.Name = "passwordMTextBox";
            this.passwordMTextBox.PasswordChar = '*';
            this.passwordMTextBox.Size = new System.Drawing.Size(308, 26);
            this.passwordMTextBox.TabIndex = 31;
            // 
            // fullNameTxtBox
            // 
            this.fullNameTxtBox.Location = new System.Drawing.Point(35, 277);
            this.fullNameTxtBox.Name = "fullNameTxtBox";
            this.fullNameTxtBox.Size = new System.Drawing.Size(312, 26);
            this.fullNameTxtBox.TabIndex = 33;
            this.fullNameTxtBox.TextChanged += new System.EventHandler(this.fullNameTxtBox_TextChanged);
            // 
            // confirmPasswordMTextBox
            // 
            this.confirmPasswordMTextBox.Location = new System.Drawing.Point(39, 440);
            this.confirmPasswordMTextBox.Name = "confirmPasswordMTextBox";
            this.confirmPasswordMTextBox.PasswordChar = '*';
            this.confirmPasswordMTextBox.Size = new System.Drawing.Size(308, 26);
            this.confirmPasswordMTextBox.TabIndex = 35;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.Black;
            this.lblConfirmPassword.Location = new System.Drawing.Point(38, 408);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(222, 29);
            this.lblConfirmPassword.TabIndex = 34;
            this.lblConfirmPassword.Text = "Confirm Password: ";
            // 
            // birthdayDateTimePicker
            // 
            this.birthdayDateTimePicker.Location = new System.Drawing.Point(440, 275);
            this.birthdayDateTimePicker.Name = "birthdayDateTimePicker";
            this.birthdayDateTimePicker.Size = new System.Drawing.Size(307, 26);
            this.birthdayDateTimePicker.TabIndex = 38;
            // 
            // profilePBox
            // 
            this.profilePBox.Image = global::IOOP_Assignment.Properties.Resources.profile_userResized;
            this.profilePBox.Location = new System.Drawing.Point(43, 58);
            this.profilePBox.Name = "profilePBox";
            this.profilePBox.Size = new System.Drawing.Size(249, 180);
            this.profilePBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePBox.TabIndex = 37;
            this.profilePBox.TabStop = false;
            this.profilePBox.Click += new System.EventHandler(this.profilePBox_Click);
            // 
            // confirmPasswordShowHideBtn
            // 
            this.confirmPasswordShowHideBtn.BackColor = System.Drawing.Color.Transparent;
            this.confirmPasswordShowHideBtn.Image = global::IOOP_Assignment.Properties.Resources.passwordlHideIconResized;
            this.confirmPasswordShowHideBtn.Location = new System.Drawing.Point(353, 442);
            this.confirmPasswordShowHideBtn.Name = "confirmPasswordShowHideBtn";
            this.confirmPasswordShowHideBtn.Size = new System.Drawing.Size(35, 24);
            this.confirmPasswordShowHideBtn.TabIndex = 36;
            this.confirmPasswordShowHideBtn.UseVisualStyleBackColor = false;
            this.confirmPasswordShowHideBtn.Click += new System.EventHandler(this.confirmPasswordShowHideBtn_Click);
            // 
            // passwordShowBtn
            // 
            this.passwordShowBtn.BackColor = System.Drawing.Color.Transparent;
            this.passwordShowBtn.Image = global::IOOP_Assignment.Properties.Resources.passwordlHideIconResized;
            this.passwordShowBtn.Location = new System.Drawing.Point(352, 355);
            this.passwordShowBtn.Name = "passwordShowBtn";
            this.passwordShowBtn.Size = new System.Drawing.Size(35, 24);
            this.passwordShowBtn.TabIndex = 32;
            this.passwordShowBtn.UseVisualStyleBackColor = false;
            this.passwordShowBtn.Click += new System.EventHandler(this.passwordShowHideBtn_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.DimGray;
            this.backButton.ForeColor = System.Drawing.Color.Transparent;
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.Location = new System.Drawing.Point(-34, -7);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(104, 59);
            this.backButton.TabIndex = 0;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // CustomerUpdateProfilePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.birthdayDateTimePicker);
            this.Controls.Add(this.profilePBox);
            this.Controls.Add(this.confirmPasswordShowHideBtn);
            this.Controls.Add(this.confirmPasswordMTextBox);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.fullNameTxtBox);
            this.Controls.Add(this.passwordShowBtn);
            this.Controls.Add(this.passwordMTextBox);
            this.Controls.Add(this.updatePnl);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.lblCustomerIDTitle);
            this.Controls.Add(this.genderGBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.lblUserIDTitle);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.headerPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerUpdateProfilePage";
            this.Text = "CustomerUpdateProfilePage";
            this.updatePnl.ResumeLayout(false);
            this.genderGBox.ResumeLayout(false);
            this.genderGBox.PerformLayout();
            this.backBtnPnl.ResumeLayout(false);
            this.headerPnl.ResumeLayout(false);
            this.headerPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel updatePnl;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.RadioButton ratherNotSayRBtn;
        private System.Windows.Forms.RadioButton femaleRBtn;
        private System.Windows.Forms.RadioButton maleRBtn;
        private System.Windows.Forms.Label lblCustomerIDTitle;
        private System.Windows.Forms.GroupBox genderGBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblUserIDTitle;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Panel backBtnPnl;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Panel headerPnl;
        private System.Windows.Forms.MaskedTextBox passwordMTextBox;
        private System.Windows.Forms.Button passwordShowBtn;
        private System.Windows.Forms.Label lblUpdateProfile;
        private System.Windows.Forms.TextBox fullNameTxtBox;
        private System.Windows.Forms.Button confirmPasswordShowHideBtn;
        private System.Windows.Forms.MaskedTextBox confirmPasswordMTextBox;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.PictureBox profilePBox;
        private System.Windows.Forms.DateTimePicker birthdayDateTimePicker;
    }
}