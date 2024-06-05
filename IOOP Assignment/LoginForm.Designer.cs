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
            this.lblLoginForm = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordMTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(100, 112);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(87, 20);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(100, 160);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(86, 20);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password: ";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(196, 105);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(195, 26);
            this.txtUsername.TabIndex = 2;
            // 
            // lblLoginForm
            // 
            this.lblLoginForm.AutoSize = true;
            this.lblLoginForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginForm.Location = new System.Drawing.Point(188, 33);
            this.lblLoginForm.Name = "lblLoginForm";
            this.lblLoginForm.Size = new System.Drawing.Size(118, 46);
            this.lblLoginForm.TabIndex = 4;
            this.lblLoginForm.Text = "Login";
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(108, 209);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(283, 34);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "LOGIN";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordMTxtBox
            // 
            this.passwordMTxtBox.Location = new System.Drawing.Point(196, 160);
            this.passwordMTxtBox.Name = "passwordMTxtBox";
            this.passwordMTxtBox.PasswordChar = '*';
            this.passwordMTxtBox.Size = new System.Drawing.Size(195, 26);
            this.passwordMTxtBox.TabIndex = 7;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 314);
            this.Controls.Add(this.passwordMTxtBox);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.lblLoginForm);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Name = "loginForm";
            this.Text = "Login Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblLoginForm;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.MaskedTextBox passwordMTxtBox;
    }
}