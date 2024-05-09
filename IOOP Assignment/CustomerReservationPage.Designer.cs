namespace IOOP_Assignment
{
    partial class CustomerReservationPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerReservationPage));
            this.searchButton = new System.Windows.Forms.Button();
            this.headerPnl = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cartButton = new System.Windows.Forms.Button();
            this.backBtnPnl = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.searchTxtBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFilter = new System.Windows.Forms.Label();
            this.placeDisplayFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.productDisplayPanel = new System.Windows.Forms.Panel();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.headerPnl.SuspendLayout();
            this.panel2.SuspendLayout();
            this.backBtnPnl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.productDisplayPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Image = global::IOOP_Assignment.Properties.Resources.searchIcon;
            this.searchButton.Location = new System.Drawing.Point(679, 13);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(45, 34);
            this.searchButton.TabIndex = 8;
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // headerPnl
            // 
            this.headerPnl.BackColor = System.Drawing.Color.DimGray;
            this.headerPnl.Controls.Add(this.panel2);
            this.headerPnl.Controls.Add(this.backBtnPnl);
            this.headerPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPnl.Location = new System.Drawing.Point(0, 0);
            this.headerPnl.Name = "headerPnl";
            this.headerPnl.Size = new System.Drawing.Size(897, 45);
            this.headerPnl.TabIndex = 12;
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
            this.cartButton.Location = new System.Drawing.Point(-11, 0);
            this.cartButton.Name = "cartButton";
            this.cartButton.Size = new System.Drawing.Size(148, 45);
            this.cartButton.TabIndex = 2;
            this.cartButton.Text = "Your Cart";
            this.cartButton.UseVisualStyleBackColor = true;
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
            this.panel1.Controls.Add(this.lblSearch);
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Controls.Add(this.searchTxtBox);
            this.panel1.Location = new System.Drawing.Point(26, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 62);
            this.panel1.TabIndex = 13;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(767, 64);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(70, 20);
            this.lblFilter.TabIndex = 12;
            this.lblFilter.Text = "Filter By:";
            // 
            // placeDisplayFlowPanel
            // 
            this.placeDisplayFlowPanel.AutoSize = true;
            this.placeDisplayFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.placeDisplayFlowPanel.Location = new System.Drawing.Point(3, 1);
            this.placeDisplayFlowPanel.Name = "placeDisplayFlowPanel";
            this.placeDisplayFlowPanel.Size = new System.Drawing.Size(703, 355);
            this.placeDisplayFlowPanel.TabIndex = 10;
            // 
            // productDisplayPanel
            // 
            this.productDisplayPanel.AutoScroll = true;
            this.productDisplayPanel.Controls.Add(this.placeDisplayFlowPanel);
            this.productDisplayPanel.Location = new System.Drawing.Point(26, 166);
            this.productDisplayPanel.Name = "productDisplayPanel";
            this.productDisplayPanel.Size = new System.Drawing.Size(735, 355);
            this.productDisplayPanel.TabIndex = 14;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(767, 90);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 418);
            this.checkedListBox1.TabIndex = 0;
            // 
            // CustomerReservationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 526);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.headerPnl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.productDisplayPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerReservationPage";
            this.Text = "customerReservation";
            this.headerPnl.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.backBtnPnl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.productDisplayPanel.ResumeLayout(false);
            this.productDisplayPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Panel headerPnl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cartButton;
        private System.Windows.Forms.Panel backBtnPnl;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox searchTxtBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.FlowLayoutPanel placeDisplayFlowPanel;
        private System.Windows.Forms.Panel productDisplayPanel;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}