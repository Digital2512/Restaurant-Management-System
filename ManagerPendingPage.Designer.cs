namespace IOOP
{
    partial class ManagerPendingPage
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
            this.dataGridViewPending = new System.Windows.Forms.DataGridView();
            this.lblResvID = new System.Windows.Forms.Label();
            this.lblPlaceID = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblPax = new System.Windows.Forms.Label();
            this.lblResv = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.btnDeny = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblPending = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPending)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPending
            // 
            this.dataGridViewPending.BackgroundColor = System.Drawing.Color.OldLace;
            this.dataGridViewPending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPending.Location = new System.Drawing.Point(53, 60);
            this.dataGridViewPending.Name = "dataGridViewPending";
            this.dataGridViewPending.RowHeadersWidth = 62;
            this.dataGridViewPending.RowTemplate.Height = 28;
            this.dataGridViewPending.Size = new System.Drawing.Size(598, 179);
            this.dataGridViewPending.TabIndex = 1;
            this.dataGridViewPending.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewPending_RowHeaderMouseClick);
            // 
            // lblResvID
            // 
            this.lblResvID.AutoSize = true;
            this.lblResvID.Location = new System.Drawing.Point(88, 268);
            this.lblResvID.Name = "lblResvID";
            this.lblResvID.Size = new System.Drawing.Size(115, 20);
            this.lblResvID.TabIndex = 47;
            this.lblResvID.Text = "ReservationID:";
            // 
            // lblPlaceID
            // 
            this.lblPlaceID.AutoSize = true;
            this.lblPlaceID.Location = new System.Drawing.Point(88, 302);
            this.lblPlaceID.Name = "lblPlaceID";
            this.lblPlaceID.Size = new System.Drawing.Size(69, 20);
            this.lblPlaceID.TabIndex = 46;
            this.lblPlaceID.Text = "PlaceID:";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(353, 357);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(74, 20);
            this.lblDuration.TabIndex = 45;
            this.lblDuration.Text = "Duration:";
            // 
            // lblPax
            // 
            this.lblPax.AutoSize = true;
            this.lblPax.Location = new System.Drawing.Point(91, 374);
            this.lblPax.Name = "lblPax";
            this.lblPax.Size = new System.Drawing.Size(112, 20);
            this.lblPax.TabIndex = 44;
            this.lblPax.Text = "Customer Pax:";
            // 
            // lblResv
            // 
            this.lblResv.AutoSize = true;
            this.lblResv.Location = new System.Drawing.Point(353, 268);
            this.lblResv.Name = "lblResv";
            this.lblResv.Size = new System.Drawing.Size(137, 20);
            this.lblResv.TabIndex = 43;
            this.lblResv.Text = "Reservation Date:";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(88, 338);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(99, 20);
            this.lblCustomerID.TabIndex = 42;
            this.lblCustomerID.Text = "CustomerID:";
            // 
            // btnDeny
            // 
            this.btnDeny.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnDeny.Location = new System.Drawing.Point(357, 422);
            this.btnDeny.Name = "btnDeny";
            this.btnDeny.Size = new System.Drawing.Size(85, 40);
            this.btnDeny.TabIndex = 49;
            this.btnDeny.Text = "Deny";
            this.btnDeny.UseVisualStyleBackColor = false;
            this.btnDeny.Click += new System.EventHandler(this.btnDeny_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.BackColor = System.Drawing.Color.LightGreen;
            this.btnApprove.Location = new System.Drawing.Point(227, 422);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(85, 40);
            this.btnApprove.TabIndex = 48;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = false;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(353, 313);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(86, 20);
            this.lblTime.TabIndex = 61;
            this.lblTime.Text = "Start Time:";
            // 
            // lblPending
            // 
            this.lblPending.AutoSize = true;
            this.lblPending.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPending.Location = new System.Drawing.Point(49, 21);
            this.lblPending.Name = "lblPending";
            this.lblPending.Size = new System.Drawing.Size(99, 26);
            this.lblPending.TabIndex = 62;
            this.lblPending.Text = "Pending";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(659, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.TabIndex = 63;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ManagerPendingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 474);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblPending);
            this.Controls.Add(this.dataGridViewPending);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnDeny);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.lblResvID);
            this.Controls.Add(this.lblPlaceID);
            this.Controls.Add(this.lblResv);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblPax);
            this.Controls.Add(this.lblCustomerID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagerPendingPage";
            this.Text = "ManagerPendingPage";
            this.Load += new System.EventHandler(this.ManagerPendingPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPending)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewPending;
        private System.Windows.Forms.Label lblResvID;
        private System.Windows.Forms.Label lblPlaceID;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblPax;
        private System.Windows.Forms.Label lblResv;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Button btnDeny;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblPending;
        private System.Windows.Forms.Button btnExit;
    }
}