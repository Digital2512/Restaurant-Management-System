﻿namespace IOOP_Assignment
{
    partial class ManagerUpdateProfilePage
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbbGender = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPsw = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblHeaderProfile = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblPsw = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.pickerDOB = new System.Windows.Forms.DateTimePicker();
            this.picManager = new System.Windows.Forms.PictureBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picManager)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(117, 462);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(68, 35);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(211, 462);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(73, 35);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbbGender
            // 
            this.cbbGender.FormattingEnabled = true;
            this.cbbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Prefer Not To Say"});
            this.cbbGender.Location = new System.Drawing.Point(186, 366);
            this.cbbGender.Name = "cbbGender";
            this.cbbGender.Size = new System.Drawing.Size(134, 28);
            this.cbbGender.TabIndex = 26;
            this.cbbGender.Text = "Select";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(186, 325);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 26);
            this.txtName.TabIndex = 27;
            // 
            // txtPsw
            // 
            this.txtPsw.Location = new System.Drawing.Point(186, 256);
            this.txtPsw.Name = "txtPsw";
            this.txtPsw.Size = new System.Drawing.Size(100, 26);
            this.txtPsw.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.lblHeaderProfile);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 61);
            this.panel2.TabIndex = 32;
            // 
            // lblHeaderProfile
            // 
            this.lblHeaderProfile.AutoSize = true;
            this.lblHeaderProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderProfile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHeaderProfile.Location = new System.Drawing.Point(155, 20);
            this.lblHeaderProfile.Name = "lblHeaderProfile";
            this.lblHeaderProfile.Size = new System.Drawing.Size(90, 29);
            this.lblHeaderProfile.TabIndex = 0;
            this.lblHeaderProfile.Text = "Profile";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(124, 292);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(46, 20);
            this.lblRole.TabIndex = 39;
            this.lblRole.Text = "Role:";
            // 
            // lblPsw
            // 
            this.lblPsw.AutoSize = true;
            this.lblPsw.Location = new System.Drawing.Point(88, 256);
            this.lblPsw.Name = "lblPsw";
            this.lblPsw.Size = new System.Drawing.Size(82, 20);
            this.lblPsw.TabIndex = 38;
            this.lblPsw.Text = "Password:";
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(98, 404);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(71, 20);
            this.lblBirthday.TabIndex = 37;
            this.lblBirthday.Text = "Birthday:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(102, 369);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(67, 20);
            this.lblGender.TabIndex = 36;
            this.lblGender.Text = "Gender:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(114, 328);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 35;
            this.lblName.Text = "Name:";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(102, 222);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(68, 20);
            this.lblUserID.TabIndex = 34;
            this.lblUserID.Text = "User ID:";
            // 
            // pickerDOB
            // 
            this.pickerDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickerDOB.Location = new System.Drawing.Point(186, 404);
            this.pickerDOB.Name = "pickerDOB";
            this.pickerDOB.Size = new System.Drawing.Size(121, 26);
            this.pickerDOB.TabIndex = 40;
            // 
            // picManager
            // 
            this.picManager.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picManager.Image = global::IOOP_Assignment.Properties.Resources.userIcon;
            this.picManager.Location = new System.Drawing.Point(142, 67);
            this.picManager.Name = "picManager";
            this.picManager.Size = new System.Drawing.Size(110, 110);
            this.picManager.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picManager.TabIndex = 33;
            this.picManager.TabStop = false;
            // 
            // btnUpload
            // 
            this.btnUpload.Image = global::IOOP_Assignment.Properties.Resources.editIcon4;
            this.btnUpload.Location = new System.Drawing.Point(258, 132);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(45, 45);
            this.btnUpload.TabIndex = 25;
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // ManagerUpdateProfilePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 510);
            this.Controls.Add(this.pickerDOB);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblPsw);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.picManager);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtPsw);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cbbGender);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagerUpdateProfilePage";
            this.Text = "UpcomingList";
            this.Load += new System.EventHandler(this.ManagerUpdateProfilePage_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.ComboBox cbbGender;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPsw;
        private System.Windows.Forms.PictureBox picManager;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblHeaderProfile;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblPsw;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.DateTimePicker pickerDOB;

    }
}