namespace IOOP_Assignment
{
    partial class CustomerOrderPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerOrderPage));
            this.headerPnl = new System.Windows.Forms.Panel();
            this.cartPnl = new System.Windows.Forms.Panel();
            this.cartBtn = new System.Windows.Forms.Button();
            this.backBtnPnl = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.searchTxtBox = new System.Windows.Forms.TextBox();
            this.searchAndFilterPnl = new System.Windows.Forms.Panel();
            this.lblFilter = new System.Windows.Forms.Label();
            this.priceRangeCBox = new System.Windows.Forms.ComboBox();
            this.cuisineCBox = new System.Windows.Forms.ComboBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.productDisplayFlowPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.productDisplayPanel = new System.Windows.Forms.Panel();
            this.headerPnl.SuspendLayout();
            this.cartPnl.SuspendLayout();
            this.backBtnPnl.SuspendLayout();
            this.searchAndFilterPnl.SuspendLayout();
            this.productDisplayPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPnl
            // 
            this.headerPnl.BackColor = System.Drawing.Color.DimGray;
            this.headerPnl.Controls.Add(this.cartPnl);
            this.headerPnl.Controls.Add(this.backBtnPnl);
            this.headerPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPnl.Location = new System.Drawing.Point(0, 0);
            this.headerPnl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.headerPnl.Name = "headerPnl";
            this.headerPnl.Size = new System.Drawing.Size(800, 45);
            this.headerPnl.TabIndex = 5;
            this.headerPnl.Paint += new System.Windows.Forms.PaintEventHandler(this.headerPnl_Paint);
            // 
            // cartPnl
            // 
            this.cartPnl.Controls.Add(this.cartBtn);
            this.cartPnl.Location = new System.Drawing.Point(687, 0);
            this.cartPnl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cartPnl.Name = "cartPnl";
            this.cartPnl.Size = new System.Drawing.Size(213, 56);
            this.cartPnl.TabIndex = 3;
            // 
            // cartBtn
            // 
            this.cartBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cartBtn.Location = new System.Drawing.Point(-34, -9);
            this.cartBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cartBtn.Name = "cartBtn";
            this.cartBtn.Size = new System.Drawing.Size(177, 56);
            this.cartBtn.TabIndex = 2;
            this.cartBtn.Text = "Your Cart";
            this.cartBtn.UseVisualStyleBackColor = true;
            this.cartBtn.Click += new System.EventHandler(this.cartButton_Click);
            // 
            // backBtnPnl
            // 
            this.backBtnPnl.Controls.Add(this.backBtn);
            this.backBtnPnl.Location = new System.Drawing.Point(1, 0);
            this.backBtnPnl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backBtnPnl.Name = "backBtnPnl";
            this.backBtnPnl.Size = new System.Drawing.Size(36, 55);
            this.backBtnPnl.TabIndex = 1;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.DimGray;
            this.backBtn.ForeColor = System.Drawing.Color.Transparent;
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(-38, -9);
            this.backBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(117, 74);
            this.backBtn.TabIndex = 0;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backButton_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.Location = new System.Drawing.Point(9, 16);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(68, 20);
            this.lblSearch.TabIndex = 6;
            this.lblSearch.Text = "Search: ";
            // 
            // searchTxtBox
            // 
            this.searchTxtBox.Location = new System.Drawing.Point(82, 12);
            this.searchTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.Size = new System.Drawing.Size(591, 26);
            this.searchTxtBox.TabIndex = 7;
            // 
            // searchAndFilterPnl
            // 
            this.searchAndFilterPnl.Controls.Add(this.lblFilter);
            this.searchAndFilterPnl.Controls.Add(this.priceRangeCBox);
            this.searchAndFilterPnl.Controls.Add(this.cuisineCBox);
            this.searchAndFilterPnl.Controls.Add(this.lblSearch);
            this.searchAndFilterPnl.Controls.Add(this.searchBtn);
            this.searchAndFilterPnl.Controls.Add(this.searchTxtBox);
            this.searchAndFilterPnl.Location = new System.Drawing.Point(26, 51);
            this.searchAndFilterPnl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchAndFilterPnl.Name = "searchAndFilterPnl";
            this.searchAndFilterPnl.Size = new System.Drawing.Size(735, 99);
            this.searchAndFilterPnl.TabIndex = 9;
            this.searchAndFilterPnl.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(8, 56);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(70, 20);
            this.lblFilter.TabIndex = 12;
            this.lblFilter.Text = "Filter By:";
            // 
            // priceRangeCBox
            // 
            this.priceRangeCBox.FormattingEnabled = true;
            this.priceRangeCBox.Items.AddRange(new object[] {
            "RM1.00 - 10.00",
            "RM10.00 - 20.00",
            "RM20.00 - 30.00",
            "RM30.00 - 40.00",
            "RM40.00 - 50.00",
            "RM50.00- 60.00",
            "RM60.00 - 70.00",
            "RM70.00 - 80.00",
            "RM80.00 - 90.00",
            "RM90.00 - 100.00"});
            this.priceRangeCBox.Location = new System.Drawing.Point(393, 52);
            this.priceRangeCBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.priceRangeCBox.Name = "priceRangeCBox";
            this.priceRangeCBox.Size = new System.Drawing.Size(280, 28);
            this.priceRangeCBox.TabIndex = 10;
            this.priceRangeCBox.SelectedIndexChanged += new System.EventHandler(this.priceRangeCBox_SelectedIndexChanged);
            // 
            // cuisineCBox
            // 
            this.cuisineCBox.FormattingEnabled = true;
            this.cuisineCBox.Items.AddRange(new object[] {
            "Japanese",
            "Western",
            "Korean",
            "Drinks"});
            this.cuisineCBox.Location = new System.Drawing.Point(82, 52);
            this.cuisineCBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cuisineCBox.Name = "cuisineCBox";
            this.cuisineCBox.Size = new System.Drawing.Size(305, 28);
            this.cuisineCBox.TabIndex = 9;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(679, 10);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(51, 80);
            this.searchBtn.TabIndex = 8;
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // productDisplayFlowPnl
            // 
            this.productDisplayFlowPnl.AutoSize = true;
            this.productDisplayFlowPnl.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.productDisplayFlowPnl.Location = new System.Drawing.Point(3, 2);
            this.productDisplayFlowPnl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productDisplayFlowPnl.Name = "productDisplayFlowPnl";
            this.productDisplayFlowPnl.Size = new System.Drawing.Size(703, 355);
            this.productDisplayFlowPnl.TabIndex = 10;
            this.productDisplayFlowPnl.Paint += new System.Windows.Forms.PaintEventHandler(this.productDisplayFlowPanel_Paint);
            // 
            // productDisplayPanel
            // 
            this.productDisplayPanel.AutoScroll = true;
            this.productDisplayPanel.Controls.Add(this.productDisplayFlowPnl);
            this.productDisplayPanel.Location = new System.Drawing.Point(26, 152);
            this.productDisplayPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productDisplayPanel.Name = "productDisplayPanel";
            this.productDisplayPanel.Size = new System.Drawing.Size(735, 355);
            this.productDisplayPanel.TabIndex = 11;
            // 
            // CustomerOrderPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.productDisplayPanel);
            this.Controls.Add(this.searchAndFilterPnl);
            this.Controls.Add(this.headerPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CustomerOrderPage";
            this.Text = "customerOrderPage";
            this.headerPnl.ResumeLayout(false);
            this.cartPnl.ResumeLayout(false);
            this.backBtnPnl.ResumeLayout(false);
            this.searchAndFilterPnl.ResumeLayout(false);
            this.searchAndFilterPnl.PerformLayout();
            this.productDisplayPanel.ResumeLayout(false);
            this.productDisplayPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Panel headerPnl;
        private System.Windows.Forms.Panel backBtnPnl;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox searchTxtBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Panel searchAndFilterPnl;
        private System.Windows.Forms.ComboBox priceRangeCBox;
        private System.Windows.Forms.ComboBox cuisineCBox;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.FlowLayoutPanel productDisplayFlowPnl;
        private System.Windows.Forms.Panel productDisplayPanel;
        private System.Windows.Forms.Button cartBtn;
        private System.Windows.Forms.Panel cartPnl;
    }
}