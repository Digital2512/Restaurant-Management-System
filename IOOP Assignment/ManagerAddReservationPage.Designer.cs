namespace IOOP_Assignment
{
    partial class ManagerAddReservationPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerAddReservationPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResvID = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblResvDate = new System.Windows.Forms.Label();
            this.lblPax = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblPlaceName = new System.Windows.Forms.Label();
            this.cbbPlaceName = new System.Windows.Forms.ComboBox();
            this.cbbCustomerID = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbbPax = new System.Windows.Forms.ComboBox();
            this.cbbDuration = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightPink;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 53);
            this.panel1.TabIndex = 21;
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(460, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.TabIndex = 3;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reservation";
            // 
            // lblResvID
            // 
            this.lblResvID.AutoSize = true;
            this.lblResvID.Location = new System.Drawing.Point(116, 115);
            this.lblResvID.Name = "lblResvID";
            this.lblResvID.Size = new System.Drawing.Size(115, 20);
            this.lblResvID.TabIndex = 22;
            this.lblResvID.Text = "ReservationID:";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(130, 153);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(99, 20);
            this.lblCustomerID.TabIndex = 23;
            this.lblCustomerID.Text = "CustomerID:";
            // 
            // lblResvDate
            // 
            this.lblResvDate.AutoSize = true;
            this.lblResvDate.Location = new System.Drawing.Point(58, 294);
            this.lblResvDate.Name = "lblResvDate";
            this.lblResvDate.Size = new System.Drawing.Size(171, 20);
            this.lblResvDate.TabIndex = 25;
            this.lblResvDate.Text = "Reservation DateTime:";
            // 
            // lblPax
            // 
            this.lblPax.AutoSize = true;
            this.lblPax.Location = new System.Drawing.Point(114, 198);
            this.lblPax.Name = "lblPax";
            this.lblPax.Size = new System.Drawing.Size(112, 20);
            this.lblPax.TabIndex = 26;
            this.lblPax.Text = "Customer Pax:";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(155, 343);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(74, 20);
            this.lblDuration.TabIndex = 27;
            this.lblDuration.Text = "Duration:";
            // 
            // lblPlaceName
            // 
            this.lblPlaceName.AutoSize = true;
            this.lblPlaceName.Location = new System.Drawing.Point(130, 243);
            this.lblPlaceName.Name = "lblPlaceName";
            this.lblPlaceName.Size = new System.Drawing.Size(94, 20);
            this.lblPlaceName.TabIndex = 29;
            this.lblPlaceName.Text = "PlaceName:";
            // 
            // cbbPlaceName
            // 
            this.cbbPlaceName.FormattingEnabled = true;
            this.cbbPlaceName.Location = new System.Drawing.Point(235, 240);
            this.cbbPlaceName.Name = "cbbPlaceName";
            this.cbbPlaceName.Size = new System.Drawing.Size(121, 28);
            this.cbbPlaceName.TabIndex = 30;
            // 
            // cbbCustomerID
            // 
            this.cbbCustomerID.FormattingEnabled = true;
            this.cbbCustomerID.Location = new System.Drawing.Point(235, 150);
            this.cbbCustomerID.Name = "cbbCustomerID";
            this.cbbCustomerID.Size = new System.Drawing.Size(121, 28);
            this.cbbCustomerID.TabIndex = 31;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(235, 289);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(227, 26);
            this.dateTimePicker1.TabIndex = 32;
            // 
            // cbbPax
            // 
            this.cbbPax.FormattingEnabled = true;
            this.cbbPax.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbbPax.Location = new System.Drawing.Point(235, 195);
            this.cbbPax.Name = "cbbPax";
            this.cbbPax.Size = new System.Drawing.Size(121, 28);
            this.cbbPax.TabIndex = 33;
            // 
            // cbbDuration
            // 
            this.cbbDuration.FormattingEnabled = true;
            this.cbbDuration.Location = new System.Drawing.Point(236, 335);
            this.cbbDuration.Name = "cbbDuration";
            this.cbbDuration.Size = new System.Drawing.Size(121, 28);
            this.cbbDuration.TabIndex = 34;
            // 
            // ManagerAddReservationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 605);
            this.Controls.Add(this.cbbDuration);
            this.Controls.Add(this.cbbPax);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cbbCustomerID);
            this.Controls.Add(this.cbbPlaceName);
            this.Controls.Add(this.lblPlaceName);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblPax);
            this.Controls.Add(this.lblResvDate);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.lblResvID);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagerAddReservationPage";
            this.Text = "ManagerAddReservationPage";
            this.Load += new System.EventHandler(this.ManagerAddReservationPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResvID;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblResvDate;
        private System.Windows.Forms.Label lblPax;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblPlaceName;
        private System.Windows.Forms.ComboBox cbbPlaceName;
        private System.Windows.Forms.ComboBox cbbCustomerID;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbbPax;
        private System.Windows.Forms.ComboBox cbbDuration;
    }
}