namespace IOOP_Assignment
{
    partial class ChefProfileForm
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
            this.components = new System.ComponentModel.Container();
            this.ProfileUserID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxFemale = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.checkBoxMale = new System.Windows.Forms.CheckBox();
            this.monthCalendarBirthday = new System.Windows.Forms.MonthCalendar();
            this.txtName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.ProfileBirthday = new System.Windows.Forms.Label();
            this.ProfileGender = new System.Windows.Forms.Label();
            this.ProfilePassword = new System.Windows.Forms.Label();
            this.ProfileName = new System.Windows.Forms.Label();
            this.ProfileRole = new System.Windows.Forms.Label();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnPassword = new System.Windows.Forms.Button();
            this.BtnUsername = new System.Windows.Forms.Button();
            this.BtnGender = new System.Windows.Forms.Button();
            this.BtnBirthday = new System.Windows.Forms.Button();
            this.ButtonProfileCancel = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BtnProfilePicture = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProfileUserID
            // 
            this.ProfileUserID.AutoSize = true;
            this.ProfileUserID.Location = new System.Drawing.Point(137, 209);
            this.ProfileUserID.Name = "ProfileUserID";
            this.ProfileUserID.Size = new System.Drawing.Size(68, 20);
            this.ProfileUserID.TabIndex = 0;
            this.ProfileUserID.Text = "UserID: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxFemale);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.checkBoxMale);
            this.groupBox1.Controls.Add(this.monthCalendarBirthday);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lblBirthday);
            this.groupBox1.Controls.Add(this.lblGender);
            this.groupBox1.Controls.Add(this.lblUsername);
            this.groupBox1.Controls.Add(this.lblRole);
            this.groupBox1.Controls.Add(this.lblPassword);
            this.groupBox1.Controls.Add(this.lblUserID);
            this.groupBox1.Controls.Add(this.ProfileBirthday);
            this.groupBox1.Controls.Add(this.ProfileUserID);
            this.groupBox1.Controls.Add(this.ProfileGender);
            this.groupBox1.Controls.Add(this.ProfilePassword);
            this.groupBox1.Controls.Add(this.ProfileName);
            this.groupBox1.Controls.Add(this.ProfileRole);
            this.groupBox1.Location = new System.Drawing.Point(14, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(590, 668);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Profile";
            // 
            // checkBoxFemale
            // 
            this.checkBoxFemale.AutoSize = true;
            this.checkBoxFemale.Location = new System.Drawing.Point(330, 364);
            this.checkBoxFemale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxFemale.Name = "checkBoxFemale";
            this.checkBoxFemale.Size = new System.Drawing.Size(88, 24);
            this.checkBoxFemale.TabIndex = 30;
            this.checkBoxFemale.Text = "Female";
            this.checkBoxFemale.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(236, 242);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(112, 26);
            this.txtPassword.TabIndex = 31;
            // 
            // checkBoxMale
            // 
            this.checkBoxMale.AutoSize = true;
            this.checkBoxMale.Location = new System.Drawing.Point(236, 364);
            this.checkBoxMale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxMale.Name = "checkBoxMale";
            this.checkBoxMale.Size = new System.Drawing.Size(69, 24);
            this.checkBoxMale.TabIndex = 28;
            this.checkBoxMale.Text = "Male";
            this.checkBoxMale.UseVisualStyleBackColor = true;
            // 
            // monthCalendarBirthday
            // 
            this.monthCalendarBirthday.Location = new System.Drawing.Point(236, 401);
            this.monthCalendarBirthday.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.monthCalendarBirthday.Name = "monthCalendarBirthday";
            this.monthCalendarBirthday.TabIndex = 29;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(236, 320);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(112, 26);
            this.txtName.TabIndex = 33;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(141, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(233, 402);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(51, 20);
            this.lblBirthday.TabIndex = 11;
            this.lblBirthday.Text = "label6";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(233, 364);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(51, 20);
            this.lblGender.TabIndex = 10;
            this.lblGender.Text = "label5";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(233, 328);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(51, 20);
            this.lblUsername.TabIndex = 9;
            this.lblUsername.Text = "label4";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(233, 289);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(51, 20);
            this.lblRole.TabIndex = 8;
            this.lblRole.Text = "label3";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(233, 250);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(51, 20);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "label2";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(233, 209);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(51, 20);
            this.lblUserID.TabIndex = 2;
            this.lblUserID.Text = "label1";
            // 
            // ProfileBirthday
            // 
            this.ProfileBirthday.AutoSize = true;
            this.ProfileBirthday.Location = new System.Drawing.Point(137, 402);
            this.ProfileBirthday.Name = "ProfileBirthday";
            this.ProfileBirthday.Size = new System.Drawing.Size(75, 20);
            this.ProfileBirthday.TabIndex = 6;
            this.ProfileBirthday.Text = "Birthday: ";
            // 
            // ProfileGender
            // 
            this.ProfileGender.AutoSize = true;
            this.ProfileGender.Location = new System.Drawing.Point(137, 364);
            this.ProfileGender.Name = "ProfileGender";
            this.ProfileGender.Size = new System.Drawing.Size(71, 20);
            this.ProfileGender.TabIndex = 5;
            this.ProfileGender.Text = "Gender: ";
            // 
            // ProfilePassword
            // 
            this.ProfilePassword.AutoSize = true;
            this.ProfilePassword.Location = new System.Drawing.Point(137, 250);
            this.ProfilePassword.Name = "ProfilePassword";
            this.ProfilePassword.Size = new System.Drawing.Size(86, 20);
            this.ProfilePassword.TabIndex = 2;
            this.ProfilePassword.Text = "Password: ";
            // 
            // ProfileName
            // 
            this.ProfileName.AutoSize = true;
            this.ProfileName.Location = new System.Drawing.Point(137, 328);
            this.ProfileName.Name = "ProfileName";
            this.ProfileName.Size = new System.Drawing.Size(59, 20);
            this.ProfileName.TabIndex = 4;
            this.ProfileName.Text = "Name: ";
            // 
            // ProfileRole
            // 
            this.ProfileRole.AutoSize = true;
            this.ProfileRole.Location = new System.Drawing.Point(137, 289);
            this.ProfileRole.Name = "ProfileRole";
            this.ProfileRole.Size = new System.Drawing.Size(50, 20);
            this.ProfileRole.TabIndex = 3;
            this.ProfileRole.Text = "Role: ";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(677, 478);
            this.BtnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(84, 29);
            this.BtnUpdate.TabIndex = 20;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(899, 646);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(84, 29);
            this.ButtonBack.TabIndex = 21;
            this.ButtonBack.Text = "Back";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(646, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Choose the information that you want to change";
            // 
            // BtnPassword
            // 
            this.BtnPassword.Location = new System.Drawing.Point(755, 309);
            this.BtnPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnPassword.Name = "BtnPassword";
            this.BtnPassword.Size = new System.Drawing.Size(106, 29);
            this.BtnPassword.TabIndex = 23;
            this.BtnPassword.Text = "Password";
            this.BtnPassword.UseVisualStyleBackColor = true;
            this.BtnPassword.Click += new System.EventHandler(this.BtnPassword_Click);
            // 
            // BtnUsername
            // 
            this.BtnUsername.Location = new System.Drawing.Point(755, 345);
            this.BtnUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnUsername.Name = "BtnUsername";
            this.BtnUsername.Size = new System.Drawing.Size(106, 29);
            this.BtnUsername.TabIndex = 24;
            this.BtnUsername.Text = "Username";
            this.BtnUsername.UseVisualStyleBackColor = true;
            this.BtnUsername.Click += new System.EventHandler(this.BtnUsername_Click);
            // 
            // BtnGender
            // 
            this.BtnGender.Location = new System.Drawing.Point(755, 381);
            this.BtnGender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnGender.Name = "BtnGender";
            this.BtnGender.Size = new System.Drawing.Size(106, 29);
            this.BtnGender.TabIndex = 25;
            this.BtnGender.Text = "Gender";
            this.BtnGender.UseVisualStyleBackColor = true;
            this.BtnGender.Click += new System.EventHandler(this.BtnGender_Click);
            // 
            // BtnBirthday
            // 
            this.BtnBirthday.Location = new System.Drawing.Point(755, 418);
            this.BtnBirthday.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnBirthday.Name = "BtnBirthday";
            this.BtnBirthday.Size = new System.Drawing.Size(106, 29);
            this.BtnBirthday.TabIndex = 26;
            this.BtnBirthday.Text = "Birthday";
            this.BtnBirthday.UseVisualStyleBackColor = true;
            this.BtnBirthday.Click += new System.EventHandler(this.BtnBirthday_Click);
            // 
            // ButtonProfileCancel
            // 
            this.ButtonProfileCancel.Location = new System.Drawing.Point(840, 478);
            this.ButtonProfileCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonProfileCancel.Name = "ButtonProfileCancel";
            this.ButtonProfileCancel.Size = new System.Drawing.Size(84, 29);
            this.ButtonProfileCancel.TabIndex = 27;
            this.ButtonProfileCancel.Text = "Cancel";
            this.ButtonProfileCancel.UseVisualStyleBackColor = true;
            this.ButtonProfileCancel.Click += new System.EventHandler(this.ButtonProfileCancel_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // BtnProfilePicture
            // 
            this.BtnProfilePicture.Location = new System.Drawing.Point(739, 271);
            this.BtnProfilePicture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnProfilePicture.Name = "BtnProfilePicture";
            this.BtnProfilePicture.Size = new System.Drawing.Size(135, 35);
            this.BtnProfilePicture.TabIndex = 28;
            this.BtnProfilePicture.Text = "Profile picture";
            this.BtnProfilePicture.UseVisualStyleBackColor = true;
            this.BtnProfilePicture.Click += new System.EventHandler(this.BtnProfilePicture_Click);
            // 
            // ChefProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 698);
            this.Controls.Add(this.BtnProfilePicture);
            this.Controls.Add(this.ButtonProfileCancel);
            this.Controls.Add(this.BtnBirthday);
            this.Controls.Add(this.BtnGender);
            this.Controls.Add(this.BtnUsername);
            this.Controls.Add(this.BtnPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ChefProfileForm";
            this.Text = "Chef Profile ";
            this.Load += new System.EventHandler(this.ChefProfileForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProfileUserID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ProfilePassword;
        private System.Windows.Forms.Label ProfileRole;
        private System.Windows.Forms.Label ProfileName;
        private System.Windows.Forms.Label ProfileGender;
        private System.Windows.Forms.Label ProfileBirthday;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnPassword;
        private System.Windows.Forms.Button BtnUsername;
        private System.Windows.Forms.Button BtnGender;
        private System.Windows.Forms.Button BtnBirthday;
        private System.Windows.Forms.Button ButtonProfileCancel;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.CheckBox checkBoxMale;
        private System.Windows.Forms.MonthCalendar monthCalendarBirthday;
        private System.Windows.Forms.CheckBox checkBoxFemale;
        private System.Windows.Forms.Button BtnProfilePicture;
    }
}