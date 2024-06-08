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
            this.headerPnl = new System.Windows.Forms.Panel();
            this.backBtnPnl = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.searchTxtBox = new System.Windows.Forms.TextBox();
            this.searchPnl = new System.Windows.Forms.Panel();
            this.searchBtn = new System.Windows.Forms.Button();
            this.lblFilter = new System.Windows.Forms.Label();
            this.placeDisplayFlowPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.productDisplayPanel = new System.Windows.Forms.Panel();
            this.lblMinOfPax = new System.Windows.Forms.Label();
            this.lblEvents = new System.Windows.Forms.Label();
            this.eventsCListBox = new System.Windows.Forms.CheckedListBox();
            this.minOfPaxCBox = new System.Windows.Forms.ComboBox();
            this.headerPnl.SuspendLayout();
            this.backBtnPnl.SuspendLayout();
            this.searchPnl.SuspendLayout();
            this.productDisplayPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPnl
            // 
            this.headerPnl.BackColor = System.Drawing.Color.DimGray;
            this.headerPnl.Controls.Add(this.backBtnPnl);
            this.headerPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPnl.Location = new System.Drawing.Point(0, 0);
            this.headerPnl.Name = "headerPnl";
            this.headerPnl.Size = new System.Drawing.Size(982, 45);
            this.headerPnl.TabIndex = 12;
            // 
            // backBtnPnl
            // 
            this.backBtnPnl.Controls.Add(this.backBtn);
            this.backBtnPnl.Location = new System.Drawing.Point(1, 0);
            this.backBtnPnl.Name = "backBtnPnl";
            this.backBtnPnl.Size = new System.Drawing.Size(36, 55);
            this.backBtnPnl.TabIndex = 1;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.DimGray;
            this.backBtn.ForeColor = System.Drawing.Color.Transparent;
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(-34, -7);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(104, 59);
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
            this.searchTxtBox.Location = new System.Drawing.Point(82, 13);
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.Size = new System.Drawing.Size(651, 26);
            this.searchTxtBox.TabIndex = 7;
            // 
            // searchPnl
            // 
            this.searchPnl.Controls.Add(this.lblSearch);
            this.searchPnl.Controls.Add(this.searchBtn);
            this.searchPnl.Controls.Add(this.searchTxtBox);
            this.searchPnl.Location = new System.Drawing.Point(26, 64);
            this.searchPnl.Name = "searchPnl";
            this.searchPnl.Size = new System.Drawing.Size(792, 62);
            this.searchPnl.TabIndex = 13;
            // 
            // searchBtn
            // 
            this.searchBtn.Image = global::IOOP_Assignment.Properties.Resources.searchIcon;
            this.searchBtn.Location = new System.Drawing.Point(739, 9);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(39, 37);
            this.searchBtn.TabIndex = 8;
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(832, 64);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(70, 20);
            this.lblFilter.TabIndex = 12;
            this.lblFilter.Text = "Filter By:";
            // 
            // placeDisplayFlowPnl
            // 
            this.placeDisplayFlowPnl.AutoSize = true;
            this.placeDisplayFlowPnl.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.placeDisplayFlowPnl.Location = new System.Drawing.Point(3, 0);
            this.placeDisplayFlowPnl.Name = "placeDisplayFlowPnl";
            this.placeDisplayFlowPnl.Size = new System.Drawing.Size(789, 407);
            this.placeDisplayFlowPnl.TabIndex = 10;
            // 
            // productDisplayPanel
            // 
            this.productDisplayPanel.AutoScroll = true;
            this.productDisplayPanel.Controls.Add(this.placeDisplayFlowPnl);
            this.productDisplayPanel.Location = new System.Drawing.Point(26, 132);
            this.productDisplayPanel.Name = "productDisplayPanel";
            this.productDisplayPanel.Size = new System.Drawing.Size(792, 389);
            this.productDisplayPanel.TabIndex = 14;
            // 
            // lblMinOfPax
            // 
            this.lblMinOfPax.AutoSize = true;
            this.lblMinOfPax.Location = new System.Drawing.Point(832, 94);
            this.lblMinOfPax.Name = "lblMinOfPax";
            this.lblMinOfPax.Size = new System.Drawing.Size(82, 20);
            this.lblMinOfPax.TabIndex = 15;
            this.lblMinOfPax.Text = "Min of Pax";
            // 
            // lblEvents
            // 
            this.lblEvents.AutoSize = true;
            this.lblEvents.Location = new System.Drawing.Point(832, 168);
            this.lblEvents.Name = "lblEvents";
            this.lblEvents.Size = new System.Drawing.Size(58, 20);
            this.lblEvents.TabIndex = 17;
            this.lblEvents.Text = "Events";
            // 
            // eventsCListBox
            // 
            this.eventsCListBox.FormattingEnabled = true;
            this.eventsCListBox.Items.AddRange(new object[] {
            "Birthday",
            "Gathering",
            "Wedding Party",
            "Corporate Party",
            "Dining",
            "Private Dining"});
            this.eventsCListBox.Location = new System.Drawing.Point(832, 194);
            this.eventsCListBox.Name = "eventsCListBox";
            this.eventsCListBox.Size = new System.Drawing.Size(138, 211);
            this.eventsCListBox.TabIndex = 16;
            // 
            // minOfPaxCBox
            // 
            this.minOfPaxCBox.FormattingEnabled = true;
            this.minOfPaxCBox.Items.AddRange(new object[] {
            ">= 1",
            ">= 3",
            ">= 6",
            ">= 8"});
            this.minOfPaxCBox.Location = new System.Drawing.Point(836, 122);
            this.minOfPaxCBox.Name = "minOfPaxCBox";
            this.minOfPaxCBox.Size = new System.Drawing.Size(121, 28);
            this.minOfPaxCBox.TabIndex = 18;
            // 
            // CustomerReservationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 526);
            this.Controls.Add(this.minOfPaxCBox);
            this.Controls.Add(this.lblEvents);
            this.Controls.Add(this.eventsCListBox);
            this.Controls.Add(this.lblMinOfPax);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.headerPnl);
            this.Controls.Add(this.searchPnl);
            this.Controls.Add(this.productDisplayPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerReservationPage";
            this.Text = "customerReservation";
            this.headerPnl.ResumeLayout(false);
            this.backBtnPnl.ResumeLayout(false);
            this.searchPnl.ResumeLayout(false);
            this.searchPnl.PerformLayout();
            this.productDisplayPanel.ResumeLayout(false);
            this.productDisplayPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Panel headerPnl;
        private System.Windows.Forms.Panel backBtnPnl;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox searchTxtBox;
        private System.Windows.Forms.Panel searchPnl;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.FlowLayoutPanel placeDisplayFlowPnl;
        private System.Windows.Forms.Panel productDisplayPanel;
        private System.Windows.Forms.Label lblMinOfPax;
        private System.Windows.Forms.Label lblEvents;
        private System.Windows.Forms.CheckedListBox eventsCListBox;
        private System.Windows.Forms.ComboBox minOfPaxCBox;
    }
}