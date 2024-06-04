namespace IOOP_Assignment
{
    partial class CustomerProfilePage
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
            this.headerPnl = new System.Windows.Forms.Panel();
            this.lblViewProfile = new System.Windows.Forms.Label();
            this.backBtnPnl = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Button();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblPasswordValue = new System.Windows.Forms.Label();
            this.updatePnl = new System.Windows.Forms.Panel();
            this.updateBtn = new System.Windows.Forms.Button();
            this.passwordShowBtn = new System.Windows.Forms.Button();
            this.genderGBox = new System.Windows.Forms.GroupBox();
            this.ratherNotSayRBtn = new System.Windows.Forms.RadioButton();
            this.femaleRBtn = new System.Windows.Forms.RadioButton();
            this.maleRBtn = new System.Windows.Forms.RadioButton();
            this.lblBirthdayTitle = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblUserIDTitle = new System.Windows.Forms.Label();
            this.lblFullNameTitle = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblCustomerIDTitle = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.profilePBox = new System.Windows.Forms.PictureBox();
            this.headerPnl.SuspendLayout();
            this.backBtnPnl.SuspendLayout();
            this.updatePnl.SuspendLayout();
            this.genderGBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePBox)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPnl
            // 
            this.headerPnl.BackColor = System.Drawing.Color.DimGray;
            this.headerPnl.Controls.Add(this.lblViewProfile);
            this.headerPnl.Controls.Add(this.backBtnPnl);
            this.headerPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPnl.Location = new System.Drawing.Point(0, 0);
            this.headerPnl.Name = "headerPnl";
            this.headerPnl.Size = new System.Drawing.Size(800, 45);
            this.headerPnl.TabIndex = 4;
            // 
            // lblViewProfile
            // 
            this.lblViewProfile.AutoSize = true;
            this.lblViewProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewProfile.Location = new System.Drawing.Point(311, 10);
            this.lblViewProfile.Name = "lblViewProfile";
            this.lblViewProfile.Size = new System.Drawing.Size(90, 29);
            this.lblViewProfile.TabIndex = 2;
            this.lblViewProfile.Text = "Profile";
            // 
            // backBtnPnl
            // 
            this.backBtnPnl.Controls.Add(this.backBtn);
            this.backBtnPnl.Location = new System.Drawing.Point(0, 0);
            this.backBtnPnl.Name = "backBtnPnl";
            this.backBtnPnl.Size = new System.Drawing.Size(36, 55);
            this.backBtnPnl.TabIndex = 1;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.DimGray;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.Color.Transparent;
            this.backBtn.Location = new System.Drawing.Point(-34, -7);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(104, 59);
            this.backBtn.TabIndex = 0;
            this.backBtn.Text = "<";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backButton_Click);
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFullName.Location = new System.Drawing.Point(40, 265);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(2, 22);
            this.lblFullName.TabIndex = 6;
            // 
            // lblPasswordValue
            // 
            this.lblPasswordValue.AutoSize = true;
            this.lblPasswordValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPasswordValue.Location = new System.Drawing.Point(41, 343);
            this.lblPasswordValue.Name = "lblPasswordValue";
            this.lblPasswordValue.Size = new System.Drawing.Size(2, 22);
            this.lblPasswordValue.TabIndex = 8;
            // 
            // updatePnl
            // 
            this.updatePnl.Controls.Add(this.updateBtn);
            this.updatePnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.updatePnl.Location = new System.Drawing.Point(0, 449);
            this.updatePnl.Name = "updatePnl";
            this.updatePnl.Size = new System.Drawing.Size(800, 47);
            this.updatePnl.TabIndex = 16;
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(0, 0);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(800, 47);
            this.updateBtn.TabIndex = 0;
            this.updateBtn.Text = "UPDATE";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // passwordShowBtn
            // 
            this.passwordShowBtn.BackColor = System.Drawing.Color.Transparent;
            this.passwordShowBtn.Location = new System.Drawing.Point(317, 320);
            this.passwordShowBtn.Name = "passwordShowBtn";
            this.passwordShowBtn.Size = new System.Drawing.Size(35, 24);
            this.passwordShowBtn.TabIndex = 48;
            this.passwordShowBtn.UseVisualStyleBackColor = false;
            this.passwordShowBtn.Click += new System.EventHandler(this.passwordShowBtn_Click);
            // 
            // genderGBox
            // 
            this.genderGBox.Controls.Add(this.ratherNotSayRBtn);
            this.genderGBox.Controls.Add(this.femaleRBtn);
            this.genderGBox.Controls.Add(this.maleRBtn);
            this.genderGBox.Location = new System.Drawing.Point(509, 290);
            this.genderGBox.Name = "genderGBox";
            this.genderGBox.Size = new System.Drawing.Size(252, 144);
            this.genderGBox.TabIndex = 44;
            this.genderGBox.TabStop = false;
            this.genderGBox.Text = "Gender: ";
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
            // lblBirthdayTitle
            // 
            this.lblBirthdayTitle.AutoSize = true;
            this.lblBirthdayTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblBirthdayTitle.ForeColor = System.Drawing.Color.Black;
            this.lblBirthdayTitle.Location = new System.Drawing.Point(31, 377);
            this.lblBirthdayTitle.Name = "lblBirthdayTitle";
            this.lblBirthdayTitle.Size = new System.Drawing.Size(106, 29);
            this.lblBirthdayTitle.TabIndex = 43;
            this.lblBirthdayTitle.Text = "Birthday:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPassword.Location = new System.Drawing.Point(34, 304);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(132, 29);
            this.lblPassword.TabIndex = 42;
            this.lblPassword.Text = "Password: ";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUserID.Location = new System.Drawing.Point(41, 116);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(2, 22);
            this.lblUserID.TabIndex = 40;
            // 
            // lblUserIDTitle
            // 
            this.lblUserIDTitle.AutoSize = true;
            this.lblUserIDTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblUserIDTitle.ForeColor = System.Drawing.Color.Black;
            this.lblUserIDTitle.Location = new System.Drawing.Point(30, 82);
            this.lblUserIDTitle.Name = "lblUserIDTitle";
            this.lblUserIDTitle.Size = new System.Drawing.Size(99, 29);
            this.lblUserIDTitle.TabIndex = 39;
            this.lblUserIDTitle.Text = "UserID: ";
            // 
            // lblFullNameTitle
            // 
            this.lblFullNameTitle.AutoSize = true;
            this.lblFullNameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFullNameTitle.ForeColor = System.Drawing.Color.Black;
            this.lblFullNameTitle.Location = new System.Drawing.Point(33, 229);
            this.lblFullNameTitle.Name = "lblFullNameTitle";
            this.lblFullNameTitle.Size = new System.Drawing.Size(136, 29);
            this.lblFullNameTitle.TabIndex = 41;
            this.lblFullNameTitle.Text = "Full Name: ";
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBirthday.Location = new System.Drawing.Point(41, 413);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(2, 22);
            this.lblBirthday.TabIndex = 10;
            // 
            // lblCustomerIDTitle
            // 
            this.lblCustomerIDTitle.AutoSize = true;
            this.lblCustomerIDTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCustomerIDTitle.ForeColor = System.Drawing.Color.Black;
            this.lblCustomerIDTitle.Location = new System.Drawing.Point(29, 155);
            this.lblCustomerIDTitle.Name = "lblCustomerIDTitle";
            this.lblCustomerIDTitle.Size = new System.Drawing.Size(158, 29);
            this.lblCustomerIDTitle.TabIndex = 45;
            this.lblCustomerIDTitle.Text = "Customer ID: ";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCustomerID.Location = new System.Drawing.Point(41, 192);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(2, 22);
            this.lblCustomerID.TabIndex = 46;
            // 
            // profilePBox
            // 
            this.profilePBox.Location = new System.Drawing.Point(512, 59);
            this.profilePBox.Name = "profilePBox";
            this.profilePBox.Size = new System.Drawing.Size(249, 180);
            this.profilePBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePBox.TabIndex = 53;
            this.profilePBox.TabStop = false;
            // 
            // CustomerProfilePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.profilePBox);
            this.Controls.Add(this.passwordShowBtn);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.lblCustomerIDTitle);
            this.Controls.Add(this.genderGBox);
            this.Controls.Add(this.lblBirthdayTitle);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.lblUserIDTitle);
            this.Controls.Add(this.lblFullNameTitle);
            this.Controls.Add(this.updatePnl);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.lblPasswordValue);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.headerPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerProfilePage";
            this.Text = "CustomerProfilePage";
            this.Load += new System.EventHandler(this.CustomerProfilePage_Load);
            this.headerPnl.ResumeLayout(false);
            this.headerPnl.PerformLayout();
            this.backBtnPnl.ResumeLayout(false);
            this.updatePnl.ResumeLayout(false);
            this.genderGBox.ResumeLayout(false);
            this.genderGBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel headerPnl;
        private System.Windows.Forms.Panel backBtnPnl;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblPasswordValue;
        private System.Windows.Forms.Panel updatePnl;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.PictureBox profilePBox;
        private System.Windows.Forms.Button passwordShowBtn;
        private System.Windows.Forms.GroupBox genderGBox;
        private System.Windows.Forms.RadioButton ratherNotSayRBtn;
        private System.Windows.Forms.RadioButton femaleRBtn;
        private System.Windows.Forms.RadioButton maleRBtn;
        private System.Windows.Forms.Label lblBirthdayTitle;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblUserIDTitle;
        private System.Windows.Forms.Label lblFullNameTitle;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblCustomerIDTitle;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblViewProfile;
    }
}