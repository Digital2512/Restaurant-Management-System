namespace IOOP_Assignment
{
    partial class AdminViewSalesReport
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
            this.lblViewSalesReport = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.dgvSalesReport = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblChefID = new System.Windows.Forms.Label();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbChefID = new System.Windows.Forms.ComboBox();
            this.lblTotalAmountTilte = new System.Windows.Forms.Label();
            this.lblOrderCountTitle = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblOrderCount = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesReport)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblViewSalesReport
            // 
            this.lblViewSalesReport.AutoSize = true;
            this.lblViewSalesReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewSalesReport.Location = new System.Drawing.Point(355, 57);
            this.lblViewSalesReport.Name = "lblViewSalesReport";
            this.lblViewSalesReport.Size = new System.Drawing.Size(303, 38);
            this.lblViewSalesReport.TabIndex = 0;
            this.lblViewSalesReport.Text = "View Sales Report";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.Location = new System.Drawing.Point(29, 120);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(66, 20);
            this.lblMonth.TabIndex = 1;
            this.lblMonth.Text = "Month:";
            // 
            // dgvSalesReport
            // 
            this.dgvSalesReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesReport.Location = new System.Drawing.Point(109, 159);
            this.dgvSalesReport.Name = "dgvSalesReport";
            this.dgvSalesReport.RowHeadersWidth = 51;
            this.dgvSalesReport.RowTemplate.Height = 24;
            this.dgvSalesReport.Size = new System.Drawing.Size(809, 311);
            this.dgvSalesReport.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(928, 116);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 31);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(312, 120);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(90, 20);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Category:";
            // 
            // lblChefID
            // 
            this.lblChefID.AutoSize = true;
            this.lblChefID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChefID.Location = new System.Drawing.Point(655, 120);
            this.lblChefID.Name = "lblChefID";
            this.lblChefID.Size = new System.Drawing.Size(79, 20);
            this.lblChefID.TabIndex = 5;
            this.lblChefID.Text = "Chef ID:";
            // 
            // cmbMonth
            // 
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(101, 120);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(171, 24);
            this.cmbMonth.TabIndex = 6;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(423, 120);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(179, 24);
            this.cmbCategory.TabIndex = 7;
            // 
            // cmbChefID
            // 
            this.cmbChefID.FormattingEnabled = true;
            this.cmbChefID.Location = new System.Drawing.Point(758, 120);
            this.cmbChefID.Name = "cmbChefID";
            this.cmbChefID.Size = new System.Drawing.Size(132, 24);
            this.cmbChefID.TabIndex = 8;
            // 
            // lblTotalAmountTilte
            // 
            this.lblTotalAmountTilte.AutoSize = true;
            this.lblTotalAmountTilte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmountTilte.Location = new System.Drawing.Point(708, 513);
            this.lblTotalAmountTilte.Name = "lblTotalAmountTilte";
            this.lblTotalAmountTilte.Size = new System.Drawing.Size(126, 20);
            this.lblTotalAmountTilte.TabIndex = 9;
            this.lblTotalAmountTilte.Text = "Total Amount:";
            // 
            // lblOrderCountTitle
            // 
            this.lblOrderCountTitle.AutoSize = true;
            this.lblOrderCountTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderCountTitle.Location = new System.Drawing.Point(708, 482);
            this.lblOrderCountTitle.Name = "lblOrderCountTitle";
            this.lblOrderCountTitle.Size = new System.Drawing.Size(118, 20);
            this.lblOrderCountTitle.TabIndex = 10;
            this.lblOrderCountTitle.Text = "Order Count:";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalAmount.Location = new System.Drawing.Point(852, 516);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(2, 18);
            this.lblTotalAmount.TabIndex = 11;
            // 
            // lblOrderCount
            // 
            this.lblOrderCount.AutoSize = true;
            this.lblOrderCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOrderCount.Location = new System.Drawing.Point(852, 484);
            this.lblOrderCount.Name = "lblOrderCount";
            this.lblOrderCount.Size = new System.Drawing.Size(2, 18);
            this.lblOrderCount.TabIndex = 12;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.DimGray;
            this.panelHeader.Controls.Add(this.btnBack);
            this.panelHeader.Location = new System.Drawing.Point(-1, -1);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1027, 34);
            this.panelHeader.TabIndex = 13;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(59, 34);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // AdminViewSalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 541);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.lblOrderCount);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblOrderCountTitle);
            this.Controls.Add(this.lblTotalAmountTilte);
            this.Controls.Add(this.cmbChefID);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.lblChefID);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvSalesReport);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lblViewSalesReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminViewSalesReport";
            this.Text = "AdminViewSalesReport";
            this.Load += new System.EventHandler(this.AdminViewSalesReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesReport)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblViewSalesReport;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.DataGridView dgvSalesReport;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblChefID;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbChefID;
        private System.Windows.Forms.Label lblTotalAmountTilte;
        private System.Windows.Forms.Label lblOrderCountTitle;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblOrderCount;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnBack;
    }
}