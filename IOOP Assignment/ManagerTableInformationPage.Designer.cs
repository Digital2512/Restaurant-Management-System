namespace IOOP_Assignment
{
    partial class ManagerTableInformationPage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPlaceID = new System.Windows.Forms.Label();
            this.btnReserve = new System.Windows.Forms.Button();
            this.lblMinOfPax = new System.Windows.Forms.Label();
            this.lblEventType = new System.Windows.Forms.Label();
            this.lblReservationID = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblReservedDateTime = new System.Windows.Forms.Label();
            this.lblPlaceName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.lblDescription);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 53);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Image = global::IOOP_Assignment.Properties.Resources.exitButton;
            this.btnExit.Location = new System.Drawing.Point(338, 14);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.TabIndex = 3;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(135, 12);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(141, 29);
            this.lblDescription.TabIndex = 33;
            this.lblDescription.Text = "Description:";
            // 
            // lblPlaceID
            // 
            this.lblPlaceID.AutoSize = true;
            this.lblPlaceID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaceID.Location = new System.Drawing.Point(141, 74);
            this.lblPlaceID.Name = "lblPlaceID";
            this.lblPlaceID.Size = new System.Drawing.Size(25, 26);
            this.lblPlaceID.TabIndex = 3;
            this.lblPlaceID.Text = "#";
            // 
            // btnReserve
            // 
            this.btnReserve.BackColor = System.Drawing.Color.LightGreen;
            this.btnReserve.Location = new System.Drawing.Point(146, 309);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(85, 40);
            this.btnReserve.TabIndex = 19;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = false;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // lblMinOfPax
            // 
            this.lblMinOfPax.AutoSize = true;
            this.lblMinOfPax.Location = new System.Drawing.Point(138, 125);
            this.lblMinOfPax.Name = "lblMinOfPax";
            this.lblMinOfPax.Size = new System.Drawing.Size(81, 20);
            this.lblMinOfPax.TabIndex = 31;
            this.lblMinOfPax.Text = "MinOfPax:";
            // 
            // lblEventType
            // 
            this.lblEventType.AutoSize = true;
            this.lblEventType.Location = new System.Drawing.Point(74, 159);
            this.lblEventType.Name = "lblEventType";
            this.lblEventType.Size = new System.Drawing.Size(92, 20);
            this.lblEventType.TabIndex = 32;
            this.lblEventType.Text = "Event Type:";
            // 
            // lblReservationID
            // 
            this.lblReservationID.AutoSize = true;
            this.lblReservationID.Location = new System.Drawing.Point(104, 105);
            this.lblReservationID.Name = "lblReservationID";
            this.lblReservationID.Size = new System.Drawing.Size(115, 20);
            this.lblReservationID.TabIndex = 34;
            this.lblReservationID.Text = "ReservationID:";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(104, 139);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(99, 20);
            this.lblCustomerID.TabIndex = 35;
            this.lblCustomerID.Text = "CustomerID:";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(104, 220);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(74, 20);
            this.lblDuration.TabIndex = 36;
            this.lblDuration.Text = "Duration:";
            // 
            // lblReservedDateTime
            // 
            this.lblReservedDateTime.AutoSize = true;
            this.lblReservedDateTime.Location = new System.Drawing.Point(104, 190);
            this.lblReservedDateTime.Name = "lblReservedDateTime";
            this.lblReservedDateTime.Size = new System.Drawing.Size(82, 20);
            this.lblReservedDateTime.TabIndex = 37;
            this.lblReservedDateTime.Text = "Date Time";
            // 
            // lblPlaceName
            // 
            this.lblPlaceName.AutoSize = true;
            this.lblPlaceName.Location = new System.Drawing.Point(136, 262);
            this.lblPlaceName.Name = "lblPlaceName";
            this.lblPlaceName.Size = new System.Drawing.Size(98, 20);
            this.lblPlaceName.TabIndex = 38;
            this.lblPlaceName.Text = "Place Name:";
            // 
            // ManagerTableInformationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 378);
            this.Controls.Add(this.lblPlaceID);
            this.Controls.Add(this.lblPlaceName);
            this.Controls.Add(this.lblReservedDateTime);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.lblReservationID);
            this.Controls.Add(this.lblEventType);
            this.Controls.Add(this.lblMinOfPax);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagerTableInformationPage";
            this.Text = "ManagerTableInformationPage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPlaceID;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Label lblMinOfPax;
        private System.Windows.Forms.Label lblEventType;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblReservationID;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblReservedDateTime;
        private System.Windows.Forms.Label lblPlaceName;
    }
}