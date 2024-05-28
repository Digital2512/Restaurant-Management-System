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
<<<<<<< HEAD
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerReservationPage));
            this.headerPnl = new System.Windows.Forms.Panel();
            this.backBtnPnl = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.searchTxtBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchButton = new System.Windows.Forms.Button();
            this.lblFilter = new System.Windows.Forms.Label();
            this.placeDisplayFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.productDisplayPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.eventsCListBox = new System.Windows.Forms.CheckedListBox();
            this.minOfPaxCBox = new System.Windows.Forms.ComboBox();
            this.headerPnl.SuspendLayout();
            this.backBtnPnl.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.searchTxtBox.Size = new System.Drawing.Size(651, 26);
            this.searchTxtBox.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSearch);
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Controls.Add(this.searchTxtBox);
            this.panel1.Location = new System.Drawing.Point(26, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 62);
            this.panel1.TabIndex = 13;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(739, 6);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(45, 42);
            this.searchButton.TabIndex = 8;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
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
            // placeDisplayFlowPanel
            // 
            this.placeDisplayFlowPanel.AutoSize = true;
            this.placeDisplayFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.placeDisplayFlowPanel.Location = new System.Drawing.Point(3, 0);
            this.placeDisplayFlowPanel.Name = "placeDisplayFlowPanel";
            this.placeDisplayFlowPanel.Size = new System.Drawing.Size(789, 407);
            this.placeDisplayFlowPanel.TabIndex = 10;
            // 
            // productDisplayPanel
            // 
            this.productDisplayPanel.AutoScroll = true;
            this.productDisplayPanel.Controls.Add(this.placeDisplayFlowPanel);
            this.productDisplayPanel.Location = new System.Drawing.Point(26, 132);
            this.productDisplayPanel.Name = "productDisplayPanel";
            this.productDisplayPanel.Size = new System.Drawing.Size(792, 389);
            this.productDisplayPanel.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(832, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Min of Pax";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(832, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Events";
            // 
            // eventsCListBox
            // 
            this.eventsCListBox.FormattingEnabled = true;
            this.eventsCListBox.Items.AddRange(new object[] {
            "Birthday",
            "Gathering",
            "Wedding Party",
            "Corporate Party"});
            this.eventsCListBox.Location = new System.Drawing.Point(832, 194);
            this.eventsCListBox.Name = "eventsCListBox";
            this.eventsCListBox.Size = new System.Drawing.Size(138, 211);
            this.eventsCListBox.TabIndex = 16;
            // 
            // minOfPaxCBox
            // 
            this.minOfPaxCBox.FormattingEnabled = true;
            this.minOfPaxCBox.Items.AddRange(new object[] {
            "> 5",
            "> 10",
            "> 15",
            "> 20",
            "> 25",
            ">30"});
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
            this.Controls.Add(this.label2);
            this.Controls.Add(this.eventsCListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.headerPnl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.productDisplayPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerReservationPage";
            this.Text = "customerReservation";
            this.headerPnl.ResumeLayout(false);
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
        private System.Windows.Forms.Panel backBtnPnl;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox searchTxtBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.FlowLayoutPanel placeDisplayFlowPanel;
        private System.Windows.Forms.Panel productDisplayPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox eventsCListBox;
        private System.Windows.Forms.ComboBox minOfPaxCBox;
=======
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "customerReservation";
        }

        #endregion
>>>>>>> Huey-Shin
    }
}