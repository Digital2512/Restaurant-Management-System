namespace IOOP_Assignment
{
    partial class frmViewProfile
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEditPro = new System.Windows.Forms.Button();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblPW = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblFN = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(345, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 118);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnEditPro
            // 
            this.btnEditPro.Location = new System.Drawing.Point(345, 383);
            this.btnEditPro.Name = "btnEditPro";
            this.btnEditPro.Size = new System.Drawing.Size(81, 32);
            this.btnEditPro.TabIndex = 5;
            this.btnEditPro.Text = "Edit";
            this.btnEditPro.UseVisualStyleBackColor = true;
            this.btnEditPro.Click += new System.EventHandler(this.btnEditPro_Click);
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(295, 175);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(64, 20);
            this.lblUserID.TabIndex = 6;
            this.lblUserID.Text = "UserID:";
            // 
            // lblPW
            // 
            this.lblPW.AutoSize = true;
            this.lblPW.Location = new System.Drawing.Point(295, 207);
            this.lblPW.Name = "lblPW";
            this.lblPW.Size = new System.Drawing.Size(82, 20);
            this.lblPW.TabIndex = 7;
            this.lblPW.Text = "Password:";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(295, 239);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(46, 20);
            this.lblRole.TabIndex = 8;
            this.lblRole.Text = "Role:";
            // 
            // lblFN
            // 
            this.lblFN.AutoSize = true;
            this.lblFN.Location = new System.Drawing.Point(295, 272);
            this.lblFN.Name = "lblFN";
            this.lblFN.Size = new System.Drawing.Size(84, 20);
            this.lblFN.TabIndex = 9;
            this.lblFN.Text = "Full Name:";
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(295, 335);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(71, 20);
            this.lblBirthday.TabIndex = 11;
            this.lblBirthday.Text = "Birthday:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(295, 302);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(67, 20);
            this.lblGender.TabIndex = 10;
            this.lblGender.Text = "Gender:";
            // 
            // frmViewProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblFN);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblPW);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.btnEditPro);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmViewProfile";
            this.Text = "frmProfile";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEditPro;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblPW;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblFN;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblGender;
    }
}