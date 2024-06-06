namespace IOOP_Assignment
{
    partial class ManagerReservationReportPage
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
            this.lblHeaderResv = new System.Windows.Forms.Label();
            this.dataGridViewResvReport = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbbMonth = new System.Windows.Forms.ComboBox();
            this.cbbEvent = new System.Windows.Forms.ComboBox();
            this.lblEvent = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.lblHeaderResv);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1052, 81);
            this.panel1.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1000, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 40);
            this.btnExit.TabIndex = 6;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblHeaderResv
            // 
            this.lblHeaderResv.AutoSize = true;
            this.lblHeaderResv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderResv.Location = new System.Drawing.Point(402, 26);
            this.lblHeaderResv.Name = "lblHeaderResv";
            this.lblHeaderResv.Size = new System.Drawing.Size(307, 37);
            this.lblHeaderResv.TabIndex = 0;
            this.lblHeaderResv.Text = "Reservation Report";
            // 
            // dataGridViewResvReport
            // 
            this.dataGridViewResvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResvReport.Location = new System.Drawing.Point(56, 152);
            this.dataGridViewResvReport.Name = "dataGridViewResvReport";
            this.dataGridViewResvReport.RowHeadersWidth = 62;
            this.dataGridViewResvReport.RowTemplate.Height = 28;
            this.dataGridViewResvReport.Size = new System.Drawing.Size(955, 374);
            this.dataGridViewResvReport.TabIndex = 3;
            // 
            // txtSearch
            // 
            this.txtSearch.ForeColor = System.Drawing.Color.DarkGray;
            this.txtSearch.Location = new System.Drawing.Point(819, 101);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(126, 26);
            this.txtSearch.TabIndex = 28;
            this.txtSearch.Text = "Search...";
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(951, 97);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(34, 34);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbbMonth
            // 
            this.cbbMonth.FormattingEnabled = true;
            this.cbbMonth.Items.AddRange(new object[] {
            "All",
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cbbMonth.Location = new System.Drawing.Point(429, 104);
            this.cbbMonth.Name = "cbbMonth";
            this.cbbMonth.Size = new System.Drawing.Size(121, 28);
            this.cbbMonth.TabIndex = 30;
            this.cbbMonth.SelectedIndexChanged += new System.EventHandler(this.cbbMonth_SelectedIndexChanged);
            // 
            // cbbEvent
            // 
            this.cbbEvent.FormattingEnabled = true;
            this.cbbEvent.Items.AddRange(new object[] {
            "All",
            "Birthday",
            "Corporate Party",
            "Private Dining",
            "Dining",
            "Gathering",
            "Wedding Party"});
            this.cbbEvent.Location = new System.Drawing.Point(682, 103);
            this.cbbEvent.Name = "cbbEvent";
            this.cbbEvent.Size = new System.Drawing.Size(121, 28);
            this.cbbEvent.TabIndex = 31;
            this.cbbEvent.TextChanged += new System.EventHandler(this.cbbEvent_TextChanged);
            // 
            // lblEvent
            // 
            this.lblEvent.AutoSize = true;
            this.lblEvent.Location = new System.Drawing.Point(584, 107);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(92, 20);
            this.lblEvent.TabIndex = 32;
            this.lblEvent.Text = "Event Type:";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(365, 107);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(58, 20);
            this.lblMonth.TabIndex = 33;
            this.lblMonth.Text = "Month:";
            // 
            // ManagerReservationReportPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1052, 578);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lblEvent);
            this.Controls.Add(this.cbbEvent);
            this.Controls.Add(this.cbbMonth);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewResvReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagerReservationReportPage";
            this.Text = "ManagerReservationPage";
            this.Load += new System.EventHandler(this.ManagerReservationReportPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResvReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHeaderResv;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dataGridViewResvReport;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbbMonth;
        private System.Windows.Forms.ComboBox cbbEvent;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.Label lblMonth;
    }
}