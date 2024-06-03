namespace IOOP
{
    partial class ManagerViewProfilePage
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
            this.lblHeaderProfile = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblPsw = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.picManager = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picManager)).BeginInit();
            this.SuspendLayout();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.lblHeaderProfile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 61);
            this.panel1.TabIndex = 2;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(116, 209);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(68, 20);
            this.lblUserID.TabIndex = 12;
            this.lblUserID.Text = "User ID:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(116, 312);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "Name:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(117, 348);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(67, 20);
            this.lblGender.TabIndex = 15;
            this.lblGender.Text = "Gender:";
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(117, 383);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(71, 20);
            this.lblBirthday.TabIndex = 16;
            this.lblBirthday.Text = "Birthday:";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(160, 448);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(68, 35);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblPsw
            // 
            this.lblPsw.AutoSize = true;
            this.lblPsw.Location = new System.Drawing.Point(116, 243);
            this.lblPsw.Name = "lblPsw";
            this.lblPsw.Size = new System.Drawing.Size(82, 20);
            this.lblPsw.TabIndex = 19;
            this.lblPsw.Text = "Password:";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(116, 278);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(46, 20);
            this.lblRole.TabIndex = 20;
            this.lblRole.Text = "Role:";
            // 
            // picManager
            // 
            this.picManager.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picManager.Location = new System.Drawing.Point(143, 67);
            this.picManager.Name = "picManager";
            this.picManager.Size = new System.Drawing.Size(110, 110);
            this.picManager.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picManager.TabIndex = 18;
            this.picManager.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(358, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.TabIndex = 4;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ManagerViewProfilePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 510);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblPsw);
            this.Controls.Add(this.picManager);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagerViewProfilePage";
            this.Text = "managerViewProfile";
            this.Load += new System.EventHandler(this.ManagerViewProfilePage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHeaderProfile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.PictureBox picManager;
        private System.Windows.Forms.Label lblPsw;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Button btnExit;
    }
}