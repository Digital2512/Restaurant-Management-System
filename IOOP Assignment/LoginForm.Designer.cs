namespace IOOP_Assignment
{
    partial class loginForm
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordMTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.forgotPasswordLinkLbl = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.logoPBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoPBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(103, 255);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(87, 20);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(103, 303);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(86, 20);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password: ";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(199, 248);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(195, 26);
            this.txtUsername.TabIndex = 2;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(111, 352);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(283, 34);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "LOGIN";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordMTxtBox
            // 
            this.passwordMTxtBox.Location = new System.Drawing.Point(199, 303);
            this.passwordMTxtBox.Name = "passwordMTxtBox";
            this.passwordMTxtBox.PasswordChar = '*';
            this.passwordMTxtBox.Size = new System.Drawing.Size(195, 26);
            this.passwordMTxtBox.TabIndex = 7;
            // 
            // forgotPasswordLinkLbl
            // 
            this.forgotPasswordLinkLbl.AutoSize = true;
            this.forgotPasswordLinkLbl.Location = new System.Drawing.Point(111, 393);
            this.forgotPasswordLinkLbl.Name = "forgotPasswordLinkLbl";
            this.forgotPasswordLinkLbl.Size = new System.Drawing.Size(142, 20);
            this.forgotPasswordLinkLbl.TabIndex = 8;
            this.forgotPasswordLinkLbl.TabStop = true;
            this.forgotPasswordLinkLbl.Text = "Forgot Password? ";
            this.forgotPasswordLinkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgotPasswordLinkLbl_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(193, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 36);
            this.label1.TabIndex = 9;
            this.label1.Text = "LOGIN";
            // 
            // logoPBox
            // 
            this.logoPBox.Image = global::IOOP_Assignment.Properties.Resources.deliciousDinerLogo;
            this.logoPBox.Location = new System.Drawing.Point(143, 12);
            this.logoPBox.Name = "logoPBox";
            this.logoPBox.Size = new System.Drawing.Size(198, 166);
            this.logoPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPBox.TabIndex = 10;
            this.logoPBox.TabStop = false;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 453);
            this.Controls.Add(this.logoPBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.forgotPasswordLinkLbl);
            this.Controls.Add(this.passwordMTxtBox);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Name = "loginForm";
            this.Text = "Login Form";
            ((System.ComponentModel.ISupportInitialize)(this.logoPBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.MaskedTextBox passwordMTxtBox;
        private System.Windows.Forms.LinkLabel forgotPasswordLinkLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox logoPBox;
    }
}