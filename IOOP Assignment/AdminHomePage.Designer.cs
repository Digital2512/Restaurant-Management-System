namespace IOOP_Assignment
{
    partial class AdminHomePage
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.btnViewSalesReport = new System.Windows.Forms.Button();
            this.btnViewFeedback = new System.Windows.Forms.Button();
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(369, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMIN HOME PAGE";
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnManageUsers.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageUsers.Location = new System.Drawing.Point(277, 160);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(471, 72);
            this.btnManageUsers.TabIndex = 1;
            this.btnManageUsers.Text = "MANAGE USERS";
            this.btnManageUsers.UseVisualStyleBackColor = false;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // btnViewSalesReport
            // 
            this.btnViewSalesReport.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnViewSalesReport.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewSalesReport.Location = new System.Drawing.Point(277, 253);
            this.btnViewSalesReport.Name = "btnViewSalesReport";
            this.btnViewSalesReport.Size = new System.Drawing.Size(471, 70);
            this.btnViewSalesReport.TabIndex = 2;
            this.btnViewSalesReport.Text = "VIEW SALES REPORT";
            this.btnViewSalesReport.UseVisualStyleBackColor = false;
            this.btnViewSalesReport.Click += new System.EventHandler(this.btnViewSalesReport_Click);
            // 
            // btnViewFeedback
            // 
            this.btnViewFeedback.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnViewFeedback.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewFeedback.Location = new System.Drawing.Point(277, 348);
            this.btnViewFeedback.Name = "btnViewFeedback";
            this.btnViewFeedback.Size = new System.Drawing.Size(471, 74);
            this.btnViewFeedback.TabIndex = 3;
            this.btnViewFeedback.Text = "VIEW FEEDBACK";
            this.btnViewFeedback.UseVisualStyleBackColor = false;
            this.btnViewFeedback.Click += new System.EventHandler(this.btnViewFeedback_Click);
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnUpdateProfile.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProfile.Location = new System.Drawing.Point(277, 445);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(471, 74);
            this.btnUpdateProfile.TabIndex = 4;
            this.btnUpdateProfile.Text = "UPDATE PROFILE";
            this.btnUpdateProfile.UseVisualStyleBackColor = false;
            this.btnUpdateProfile.Click += new System.EventHandler(this.btnUpdateProfile_Click_1);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Lavender;
            this.panelHeader.Location = new System.Drawing.Point(-1, -1);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1027, 34);
            this.panelHeader.TabIndex = 5;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(903, 498);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(94, 31);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // AdminHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1025, 541);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.btnUpdateProfile);
            this.Controls.Add(this.btnViewFeedback);
            this.Controls.Add(this.btnViewSalesReport);
            this.Controls.Add(this.btnManageUsers);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminHomePage";
            this.Text = "AdminHomePage";
            this.Load += new System.EventHandler(this.AdminHomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Button btnViewSalesReport;
        private System.Windows.Forms.Button btnViewFeedback;
        private System.Windows.Forms.Button btnUpdateProfile;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnLogout;
    }
}