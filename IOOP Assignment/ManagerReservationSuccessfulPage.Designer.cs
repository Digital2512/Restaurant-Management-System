namespace IOOP_Assignment
{
    partial class ManagerReservationSuccessfulPage
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
            this.btnExit = new System.Windows.Forms.Button();
            this.lblResvID = new System.Windows.Forms.Label();
            this.lblPlaceName = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblPax = new System.Windows.Forms.Label();
            this.lblResvDate = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(358, 14);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.TabIndex = 3;
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // lblResvID
            // 
            this.lblResvID.AutoSize = true;
            this.lblResvID.Location = new System.Drawing.Point(154, 141);
            this.lblResvID.Name = "lblResvID";
            this.lblResvID.Size = new System.Drawing.Size(115, 20);
            this.lblResvID.TabIndex = 37;
            this.lblResvID.Text = "ReservationID:";
            // 
            // lblPlaceName
            // 
            this.lblPlaceName.AutoSize = true;
            this.lblPlaceName.Location = new System.Drawing.Point(251, 326);
            this.lblPlaceName.Name = "lblPlaceName";
            this.lblPlaceName.Size = new System.Drawing.Size(69, 20);
            this.lblPlaceName.TabIndex = 42;
            this.lblPlaceName.Text = "PlaceID:";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(251, 265);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(74, 20);
            this.lblDuration.TabIndex = 41;
            this.lblDuration.Text = "Duration:";
            // 
            // lblPax
            // 
            this.lblPax.AutoSize = true;
            this.lblPax.Location = new System.Drawing.Point(77, 326);
            this.lblPax.Name = "lblPax";
            this.lblPax.Size = new System.Drawing.Size(112, 20);
            this.lblPax.TabIndex = 40;
            this.lblPax.Text = "Customer Pax:";
            // 
            // lblResvDate
            // 
            this.lblResvDate.AutoSize = true;
            this.lblResvDate.Location = new System.Drawing.Point(77, 265);
            this.lblResvDate.Name = "lblResvDate";
            this.lblResvDate.Size = new System.Drawing.Size(43, 20);
            this.lblResvDate.TabIndex = 39;
            this.lblResvDate.Text = "Time";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(77, 192);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(99, 20);
            this.lblCustomerID.TabIndex = 38;
            this.lblCustomerID.Text = "CustomerID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "Date";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(222, 377);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 140);
            this.panel1.TabIndex = 44;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::IOOP_Assignment.Properties.Resources.DeliciousIcon;
            this.pictureBox1.Location = new System.Drawing.Point(-12, -15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // ManagerReservationSuccessfulPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(403, 518);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPlaceName);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblPax);
            this.Controls.Add(this.lblResvDate);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.lblResvID);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagerReservationSuccessfulPage";
            this.Text = "ManagerReservationApprovalPage";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblResvID;
        private System.Windows.Forms.Label lblPlaceName;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblPax;
        private System.Windows.Forms.Label lblResvDate;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}