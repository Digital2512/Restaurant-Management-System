namespace IOOP_Assignment
{
    partial class frmUpdateProfile
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
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblFN = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblPW = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.btnEditPro = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPsw = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnCancelPro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(301, 348);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(71, 20);
            this.lblBirthday.TabIndex = 19;
            this.lblBirthday.Text = "Birthday:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(304, 310);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(67, 20);
            this.lblGender.TabIndex = 18;
            this.lblGender.Text = "Gender:";
            // 
            // lblFN
            // 
            this.lblFN.AutoSize = true;
            this.lblFN.Location = new System.Drawing.Point(287, 272);
            this.lblFN.Name = "lblFN";
            this.lblFN.Size = new System.Drawing.Size(84, 20);
            this.lblFN.TabIndex = 17;
            this.lblFN.Text = "Full Name:";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(322, 170);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(46, 20);
            this.lblRole.TabIndex = 16;
            this.lblRole.Text = "Role:";
            // 
            // lblPW
            // 
            this.lblPW.AutoSize = true;
            this.lblPW.Location = new System.Drawing.Point(287, 235);
            this.lblPW.Name = "lblPW";
            this.lblPW.Size = new System.Drawing.Size(82, 20);
            this.lblPW.TabIndex = 15;
            this.lblPW.Text = "Password:";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(304, 203);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(64, 20);
            this.lblUserID.TabIndex = 14;
            this.lblUserID.Text = "UserID:";
            // 
            // btnEditPro
            // 
            this.btnEditPro.Location = new System.Drawing.Point(290, 392);
            this.btnEditPro.Name = "btnEditPro";
            this.btnEditPro.Size = new System.Drawing.Size(81, 32);
            this.btnEditPro.TabIndex = 13;
            this.btnEditPro.Text = "Update";
            this.btnEditPro.UseVisualStyleBackColor = true;
            this.btnEditPro.Click += new System.EventHandler(this.btnEditPro_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(346, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 118);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // txtPsw
            // 
            this.txtPsw.Location = new System.Drawing.Point(388, 232);
            this.txtPsw.Name = "txtPsw";
            this.txtPsw.Size = new System.Drawing.Size(100, 26);
            this.txtPsw.TabIndex = 22;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(391, 307);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(100, 26);
            this.txtGender.TabIndex = 25;
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(391, 342);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(100, 26);
            this.txtDOB.TabIndex = 24;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(391, 272);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 26);
            this.txtName.TabIndex = 23;
            // 
            // btnCancelPro
            // 
            this.btnCancelPro.Location = new System.Drawing.Point(391, 392);
            this.btnCancelPro.Name = "btnCancelPro";
            this.btnCancelPro.Size = new System.Drawing.Size(81, 32);
            this.btnCancelPro.TabIndex = 27;
            this.btnCancelPro.Text = "Cancel";
            this.btnCancelPro.UseVisualStyleBackColor = true;
            // 
            // frmUpdateProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelPro);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPsw);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblFN);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblPW);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.btnEditPro);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmUpdateProfile";
            this.Text = "frmUpdateProfile";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblFN;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblPW;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Button btnEditPro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPsw;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnCancelPro;
    }
}