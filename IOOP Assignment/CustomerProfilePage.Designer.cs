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
            this.backButton = new System.Windows.Forms.Button();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblPasswordValue = new System.Windows.Forms.Label();
            this.updatePnl = new System.Windows.Forms.Panel();
            this.updateBtn = new System.Windows.Forms.Button();
            this.passwordShowBtn = new System.Windows.Forms.Button();
            this.genderGBox = new System.Windows.Forms.GroupBox();
            this.ratherNotSayRBtn = new System.Windows.Forms.RadioButton();
            this.femaleRBtn = new System.Windows.Forms.RadioButton();
            this.maleRBtn = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblUserIDTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.backBtnPnl.Controls.Add(this.backButton);
            this.backBtnPnl.Location = new System.Drawing.Point(1, 0);
            this.backBtnPnl.Name = "backBtnPnl";
            this.backBtnPnl.Size = new System.Drawing.Size(36, 55);
            this.backBtnPnl.TabIndex = 1;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.DimGray;
            this.backButton.ForeColor = System.Drawing.Color.Transparent;
            this.backButton.Location = new System.Drawing.Point(-34, -7);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(104, 59);
            this.backButton.TabIndex = 0;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(31, 377);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 29);
            this.label7.TabIndex = 43;
            this.label7.Text = "Birthday:";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(33, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 29);
            this.label1.TabIndex = 41;
            this.label1.Text = "Full Name: ";
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
            this.profilePBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
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
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.lblUserIDTitle);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Button backButton;
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblUserIDTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblCustomerIDTitle;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblViewProfile;
    }
}