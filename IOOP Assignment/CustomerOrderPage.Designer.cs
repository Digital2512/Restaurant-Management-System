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
            this.panel2 = new System.Windows.Forms.Panel();
            this.cartButton = new System.Windows.Forms.Button();
            this.backBtnPnl = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.searchTxtBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFilter = new System.Windows.Forms.Label();
            this.ratingsCBox = new System.Windows.Forms.ComboBox();
            this.priceRangeCBox = new System.Windows.Forms.ComboBox();
            this.cuisineCBox = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.productDisplayFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.productDisplayPanel = new System.Windows.Forms.Panel();
            this.headerPnl.SuspendLayout();
            this.panel2.SuspendLayout();
            this.backBtnPnl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.productDisplayPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPnl
            // 
            this.headerPnl.BackColor = System.Drawing.Color.DimGray;
            this.headerPnl.Controls.Add(this.panel2);
            this.headerPnl.Controls.Add(this.backBtnPnl);
            this.headerPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPnl.Location = new System.Drawing.Point(0, 0);
            this.headerPnl.Name = "headerPnl";
            this.headerPnl.Size = new System.Drawing.Size(800, 45);
            this.headerPnl.TabIndex = 5;
            this.headerPnl.Paint += new System.Windows.Forms.PaintEventHandler(this.headerPnl_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cartButton);
            this.panel2.Location = new System.Drawing.Point(673, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(127, 45);
            this.panel2.TabIndex = 3;
            // 
            // cartButton
            // 
            this.cartButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cartButton.Location = new System.Drawing.Point(5, 0);
            this.cartButton.Name = "cartButton";
            this.cartButton.Size = new System.Drawing.Size(157, 45);
            this.cartButton.TabIndex = 2;
            this.cartButton.Text = "Your Cart";
            this.cartButton.UseVisualStyleBackColor = true;
            this.cartButton.Click += new System.EventHandler(this.cartButton_Click);
            // 
            // backBtnPnl
            // 
            this.backBtnPnl.Controls.Add(this.backButton);
            this.backBtnPnl.Location = new System.Drawing.Point(1, 0);
            this.backBtnPnl.Name = "backBtnPnl";
            this.backBtnPnl.Size = new System.Drawing.Size(36, 55);
            this.backBtnPnl.TabIndex = 1;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.DimGray;
            this.backButton.ForeColor = System.Drawing.Color.Transparent;
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.Location = new System.Drawing.Point(-34, -7);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(104, 59);
            this.backButton.TabIndex = 0;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
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
            this.searchTxtBox.Location = new System.Drawing.Point(82, 13);
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.Size = new System.Drawing.Size(591, 26);
            this.searchTxtBox.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblFilter);
            this.panel1.Controls.Add(this.ratingsCBox);
            this.panel1.Controls.Add(this.priceRangeCBox);
            this.panel1.Controls.Add(this.cuisineCBox);
            this.panel1.Controls.Add(this.lblSearch);
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Controls.Add(this.searchTxtBox);
            this.panel1.Location = new System.Drawing.Point(26, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 99);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            // ratingsCBox
            // 
            this.ratingsCBox.FormattingEnabled = true;
            this.ratingsCBox.Items.AddRange(new object[] {
            "0.00 - 1.00",
            "1.00 - 2.00",
            "2.00 - 3.00",
            "3.00 - 4.00",
            "4.00 - 5.00"});
            this.ratingsCBox.Location = new System.Drawing.Point(512, 53);
            this.ratingsCBox.Name = "ratingsCBox";
            this.ratingsCBox.Size = new System.Drawing.Size(209, 28);
            this.ratingsCBox.TabIndex = 11;
            this.ratingsCBox.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
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
            this.priceRangeCBox.Location = new System.Drawing.Point(297, 53);
            this.priceRangeCBox.Name = "priceRangeCBox";
            this.priceRangeCBox.Size = new System.Drawing.Size(209, 28);
            this.priceRangeCBox.TabIndex = 10;
            // 
            // cuisineCBox
            // 
            this.cuisineCBox.FormattingEnabled = true;
            this.cuisineCBox.Items.AddRange(new object[] {
            "Japanese",
            "Western",
            "Korean",
            "Drinks"});
            this.cuisineCBox.Location = new System.Drawing.Point(82, 53);
            this.cuisineCBox.Name = "cuisineCBox";
            this.cuisineCBox.Size = new System.Drawing.Size(209, 28);
            this.cuisineCBox.TabIndex = 9;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(679, 3);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(45, 44);
            this.searchButton.TabIndex = 8;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // productDisplayFlowPanel
            // 
            this.productDisplayFlowPanel.AutoSize = true;
            this.productDisplayFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.productDisplayFlowPanel.Location = new System.Drawing.Point(3, 3);
            this.productDisplayFlowPanel.Name = "productDisplayFlowPanel";
            this.productDisplayFlowPanel.Size = new System.Drawing.Size(703, 355);
            this.productDisplayFlowPanel.TabIndex = 10;
            this.productDisplayFlowPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.productDisplayFlowPanel_Paint);
            // 
            // productDisplayPanel
            // 
            this.productDisplayPanel.AutoScroll = true;
            this.productDisplayPanel.Controls.Add(this.productDisplayFlowPanel);
            this.productDisplayPanel.Location = new System.Drawing.Point(26, 153);
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
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.headerPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerOrderPage";
            this.Text = "customerOrderPage";
            this.headerPnl.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.backBtnPnl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.productDisplayPanel.ResumeLayout(false);
            this.productDisplayPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Panel headerPnl;
        private System.Windows.Forms.Panel backBtnPnl;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox searchTxtBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox ratingsCBox;
        private System.Windows.Forms.ComboBox priceRangeCBox;
        private System.Windows.Forms.ComboBox cuisineCBox;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.FlowLayoutPanel productDisplayFlowPanel;
        private System.Windows.Forms.Panel productDisplayPanel;
        private System.Windows.Forms.Button cartButton;
        private System.Windows.Forms.Panel panel2;
    }
}