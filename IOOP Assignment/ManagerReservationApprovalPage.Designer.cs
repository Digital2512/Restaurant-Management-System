namespace IOOP_Assignment
{
    partial class ManagerReservationApprovalPage
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
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPlaceName = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblPax = new System.Windows.Forms.Label();
            this.lblResvDate = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reservation";
            // 
            // btnApprove
            // 
            this.btnApprove.BackColor = System.Drawing.Color.LightGreen;
            this.btnApprove.Location = new System.Drawing.Point(78, 330);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(85, 40);
            this.btnApprove.TabIndex = 18;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = false;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnReject
            // 
            this.btnReject.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnReject.Location = new System.Drawing.Point(208, 330);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(85, 40);
            this.btnReject.TabIndex = 19;
            this.btnReject.Text = "Reject";
            this.btnReject.UseVisualStyleBackColor = false;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightPink;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 53);
            this.panel1.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 49;
            this.label3.Text = "Date";
            // 
            // lblPlaceName
            // 
            this.lblPlaceName.AutoSize = true;
            this.lblPlaceName.Location = new System.Drawing.Point(68, 86);
            this.lblPlaceName.Name = "lblPlaceName";
            this.lblPlaceName.Size = new System.Drawing.Size(69, 20);
            this.lblPlaceName.TabIndex = 48;
            this.lblPlaceName.Text = "PlaceID:";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(220, 244);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(74, 20);
            this.lblDuration.TabIndex = 47;
            this.lblDuration.Text = "Duration:";
            // 
            // lblPax
            // 
            this.lblPax.AutoSize = true;
            this.lblPax.Location = new System.Drawing.Point(68, 244);
            this.lblPax.Name = "lblPax";
            this.lblPax.Size = new System.Drawing.Size(112, 20);
            this.lblPax.TabIndex = 46;
            this.lblPax.Text = "Customer Pax:";
            // 
            // lblResvDate
            // 
            this.lblResvDate.AutoSize = true;
            this.lblResvDate.Location = new System.Drawing.Point(220, 164);
            this.lblResvDate.Name = "lblResvDate";
            this.lblResvDate.Size = new System.Drawing.Size(43, 20);
            this.lblResvDate.TabIndex = 45;
            this.lblResvDate.Text = "Time";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(220, 86);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(99, 20);
            this.lblCustomerID.TabIndex = 44;
            this.lblCustomerID.Text = "CustomerID:";
            // 
            // btnExit
            // 
            this.btnExit.Image = global::IOOP_Assignment.Properties.Resources.exitButton;
            this.btnExit.Location = new System.Drawing.Point(333, 14);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.TabIndex = 3;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ManagerReservationApprovalPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(381, 401);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPlaceName);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblPax);
            this.Controls.Add(this.lblResvDate);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.btnApprove);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagerReservationApprovalPage";
            this.Text = "ManagerReservationApprovalPage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPlaceName;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblPax;
        private System.Windows.Forms.Label lblResvDate;
        private System.Windows.Forms.Label lblCustomerID;
    }
}