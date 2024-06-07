namespace IOOP_Assignment
{
    partial class CustomerHomePage
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
            this.components = new System.ComponentModel.Container();
            this.headerPnl = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.sidebarFlowLayoutPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.reservationPnl = new System.Windows.Forms.Panel();
            this.orderPnl = new System.Windows.Forms.Panel();
            this.feedbackPnl = new System.Windows.Forms.Panel();
            this.logoutPnl = new System.Windows.Forms.Panel();
            this.emptyPnl = new System.Windows.Forms.Panel();
            this.profilePnl = new System.Windows.Forms.Panel();
            this.menuTransition = new System.Windows.Forms.Timer(this.components);
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.lblOrderStatusHeader = new System.Windows.Forms.Label();
            this.lblReservationStatusHeader = new System.Windows.Forms.Label();
            this.orderStatusPnl = new System.Windows.Forms.Panel();
            this.refreshOrderBtn = new System.Windows.Forms.Button();
            this.lblOrderStatus = new System.Windows.Forms.Label();
            this.lblOrderStatusTitle = new System.Windows.Forms.Label();
            this.lblEstimatedTime = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.lblEstimatedTimeLeftTitle = new System.Windows.Forms.Label();
            this.lblOrderIDTitle = new System.Windows.Forms.Label();
            this.reservationStatusPnl = new System.Windows.Forms.Panel();
            this.refreshReservationBtn = new System.Windows.Forms.Button();
            this.lblReservationStatus = new System.Windows.Forms.Label();
            this.lblReservationStatusTitle = new System.Windows.Forms.Label();
            this.lblPlaceName = new System.Windows.Forms.Label();
            this.lblPlaceNameTitle = new System.Windows.Forms.Label();
            this.lblDateTimeRange = new System.Windows.Forms.Label();
            this.lblReservationID = new System.Windows.Forms.Label();
            this.cc = new System.Windows.Forms.Label();
            this.lblReservationIDTitle = new System.Windows.Forms.Label();
            this.reservationStatusPBox = new System.Windows.Forms.PictureBox();
            this.orderStatusPBox = new System.Windows.Forms.PictureBox();
            this.reservationBtn = new System.Windows.Forms.Button();
            this.orderBtn = new System.Windows.Forms.Button();
            this.feedbackBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.profileBtn = new System.Windows.Forms.Button();
            this.btnSidebar = new System.Windows.Forms.Button();
            this.headerPnl.SuspendLayout();
            this.sidebarFlowLayoutPnl.SuspendLayout();
            this.reservationPnl.SuspendLayout();
            this.orderPnl.SuspendLayout();
            this.feedbackPnl.SuspendLayout();
            this.logoutPnl.SuspendLayout();
            this.profilePnl.SuspendLayout();
            this.orderStatusPnl.SuspendLayout();
            this.reservationStatusPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationStatusPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderStatusPBox)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPnl
            // 
            this.headerPnl.BackColor = System.Drawing.Color.White;
            this.headerPnl.Controls.Add(this.lblWelcome);
            this.headerPnl.Controls.Add(this.btnSidebar);
            this.headerPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPnl.Location = new System.Drawing.Point(0, 0);
            this.headerPnl.Name = "headerPnl";
            this.headerPnl.Size = new System.Drawing.Size(954, 62);
            this.headerPnl.TabIndex = 0;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(66, 14);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(307, 37);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Welcome, Customer";
            // 
            // sidebarFlowLayoutPnl
            // 
            this.sidebarFlowLayoutPnl.BackColor = System.Drawing.Color.DimGray;
            this.sidebarFlowLayoutPnl.Controls.Add(this.reservationPnl);
            this.sidebarFlowLayoutPnl.Controls.Add(this.orderPnl);
            this.sidebarFlowLayoutPnl.Controls.Add(this.feedbackPnl);
            this.sidebarFlowLayoutPnl.Controls.Add(this.logoutPnl);
            this.sidebarFlowLayoutPnl.Controls.Add(this.emptyPnl);
            this.sidebarFlowLayoutPnl.Controls.Add(this.profilePnl);
            this.sidebarFlowLayoutPnl.Location = new System.Drawing.Point(0, 61);
            this.sidebarFlowLayoutPnl.Name = "sidebarFlowLayoutPnl";
            this.sidebarFlowLayoutPnl.Size = new System.Drawing.Size(188, 393);
            this.sidebarFlowLayoutPnl.TabIndex = 1;
            // 
            // reservationPnl
            // 
            this.reservationPnl.Controls.Add(this.reservationBtn);
            this.reservationPnl.Location = new System.Drawing.Point(3, 3);
            this.reservationPnl.Name = "reservationPnl";
            this.reservationPnl.Size = new System.Drawing.Size(179, 57);
            this.reservationPnl.TabIndex = 2;
            // 
            // orderPnl
            // 
            this.orderPnl.Controls.Add(this.orderBtn);
            this.orderPnl.Location = new System.Drawing.Point(3, 66);
            this.orderPnl.Name = "orderPnl";
            this.orderPnl.Size = new System.Drawing.Size(179, 53);
            this.orderPnl.TabIndex = 3;
            // 
            // feedbackPnl
            // 
            this.feedbackPnl.Controls.Add(this.feedbackBtn);
            this.feedbackPnl.Location = new System.Drawing.Point(3, 125);
            this.feedbackPnl.Name = "feedbackPnl";
            this.feedbackPnl.Size = new System.Drawing.Size(179, 57);
            this.feedbackPnl.TabIndex = 3;
            // 
            // logoutPnl
            // 
            this.logoutPnl.Controls.Add(this.logoutBtn);
            this.logoutPnl.Location = new System.Drawing.Point(3, 188);
            this.logoutPnl.Name = "logoutPnl";
            this.logoutPnl.Size = new System.Drawing.Size(179, 57);
            this.logoutPnl.TabIndex = 4;
            // 
            // emptyPnl
            // 
            this.emptyPnl.Location = new System.Drawing.Point(3, 251);
            this.emptyPnl.Name = "emptyPnl";
            this.emptyPnl.Size = new System.Drawing.Size(179, 57);
            this.emptyPnl.TabIndex = 5;
            // 
            // profilePnl
            // 
            this.profilePnl.Controls.Add(this.profileBtn);
            this.profilePnl.Location = new System.Drawing.Point(3, 314);
            this.profilePnl.Name = "profilePnl";
            this.profilePnl.Size = new System.Drawing.Size(179, 57);
            this.profilePnl.TabIndex = 6;
            // 
            // menuTransition
            // 
            this.menuTransition.Interval = 10;
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // lblOrderStatusHeader
            // 
            this.lblOrderStatusHeader.AutoSize = true;
            this.lblOrderStatusHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderStatusHeader.Location = new System.Drawing.Point(231, 75);
            this.lblOrderStatusHeader.Name = "lblOrderStatusHeader";
            this.lblOrderStatusHeader.Size = new System.Drawing.Size(211, 37);
            this.lblOrderStatusHeader.TabIndex = 2;
            this.lblOrderStatusHeader.Text = "Order Status";
            // 
            // lblReservationStatusHeader
            // 
            this.lblReservationStatusHeader.AutoSize = true;
            this.lblReservationStatusHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservationStatusHeader.Location = new System.Drawing.Point(232, 238);
            this.lblReservationStatusHeader.Name = "lblReservationStatusHeader";
            this.lblReservationStatusHeader.Size = new System.Drawing.Size(303, 37);
            this.lblReservationStatusHeader.TabIndex = 3;
            this.lblReservationStatusHeader.Text = "Reservation Status";
            // 
            // orderStatusPnl
            // 
            this.orderStatusPnl.Controls.Add(this.refreshOrderBtn);
            this.orderStatusPnl.Controls.Add(this.lblOrderStatus);
            this.orderStatusPnl.Controls.Add(this.lblOrderStatusTitle);
            this.orderStatusPnl.Controls.Add(this.lblEstimatedTime);
            this.orderStatusPnl.Controls.Add(this.lblOrderID);
            this.orderStatusPnl.Controls.Add(this.orderStatusPBox);
            this.orderStatusPnl.Controls.Add(this.lblEstimatedTimeLeftTitle);
            this.orderStatusPnl.Controls.Add(this.lblOrderIDTitle);
            this.orderStatusPnl.Location = new System.Drawing.Point(237, 119);
            this.orderStatusPnl.Name = "orderStatusPnl";
            this.orderStatusPnl.Size = new System.Drawing.Size(694, 104);
            this.orderStatusPnl.TabIndex = 4;
            // 
            // refreshOrderBtn
            // 
            this.refreshOrderBtn.Location = new System.Drawing.Point(458, 58);
            this.refreshOrderBtn.Name = "refreshOrderBtn";
            this.refreshOrderBtn.Size = new System.Drawing.Size(96, 34);
            this.refreshOrderBtn.TabIndex = 14;
            this.refreshOrderBtn.Text = "REFRESH";
            this.refreshOrderBtn.UseVisualStyleBackColor = true;
            this.refreshOrderBtn.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // lblOrderStatus
            // 
            this.lblOrderStatus.AutoSize = true;
            this.lblOrderStatus.Location = new System.Drawing.Point(205, 72);
            this.lblOrderStatus.Name = "lblOrderStatus";
            this.lblOrderStatus.Size = new System.Drawing.Size(35, 20);
            this.lblOrderStatus.TabIndex = 6;
            this.lblOrderStatus.Text = "N/A";
            // 
            // lblOrderStatusTitle
            // 
            this.lblOrderStatusTitle.AutoSize = true;
            this.lblOrderStatusTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblOrderStatusTitle.Location = new System.Drawing.Point(4, 69);
            this.lblOrderStatusTitle.Name = "lblOrderStatusTitle";
            this.lblOrderStatusTitle.Size = new System.Drawing.Size(79, 25);
            this.lblOrderStatusTitle.TabIndex = 5;
            this.lblOrderStatusTitle.Text = "Status: ";
            // 
            // lblEstimatedTime
            // 
            this.lblEstimatedTime.AutoSize = true;
            this.lblEstimatedTime.Location = new System.Drawing.Point(205, 41);
            this.lblEstimatedTime.Name = "lblEstimatedTime";
            this.lblEstimatedTime.Size = new System.Drawing.Size(35, 20);
            this.lblEstimatedTime.TabIndex = 4;
            this.lblEstimatedTime.Text = "N/A";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(205, 10);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(35, 20);
            this.lblOrderID.TabIndex = 3;
            this.lblOrderID.Text = "N/A";
            // 
            // lblEstimatedTimeLeftTitle
            // 
            this.lblEstimatedTimeLeftTitle.AutoSize = true;
            this.lblEstimatedTimeLeftTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblEstimatedTimeLeftTitle.Location = new System.Drawing.Point(4, 37);
            this.lblEstimatedTimeLeftTitle.Name = "lblEstimatedTimeLeftTitle";
            this.lblEstimatedTimeLeftTitle.Size = new System.Drawing.Size(195, 25);
            this.lblEstimatedTimeLeftTitle.TabIndex = 1;
            this.lblEstimatedTimeLeftTitle.Text = "Estimated Time Left: ";
            // 
            // lblOrderIDTitle
            // 
            this.lblOrderIDTitle.AutoSize = true;
            this.lblOrderIDTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblOrderIDTitle.Location = new System.Drawing.Point(4, 6);
            this.lblOrderIDTitle.Name = "lblOrderIDTitle";
            this.lblOrderIDTitle.Size = new System.Drawing.Size(97, 25);
            this.lblOrderIDTitle.TabIndex = 0;
            this.lblOrderIDTitle.Text = "Order ID: ";
            // 
            // reservationStatusPnl
            // 
            this.reservationStatusPnl.Controls.Add(this.refreshReservationBtn);
            this.reservationStatusPnl.Controls.Add(this.lblReservationStatus);
            this.reservationStatusPnl.Controls.Add(this.lblReservationStatusTitle);
            this.reservationStatusPnl.Controls.Add(this.lblPlaceName);
            this.reservationStatusPnl.Controls.Add(this.lblPlaceNameTitle);
            this.reservationStatusPnl.Controls.Add(this.lblDateTimeRange);
            this.reservationStatusPnl.Controls.Add(this.lblReservationID);
            this.reservationStatusPnl.Controls.Add(this.cc);
            this.reservationStatusPnl.Controls.Add(this.lblReservationIDTitle);
            this.reservationStatusPnl.Controls.Add(this.reservationStatusPBox);
            this.reservationStatusPnl.Location = new System.Drawing.Point(237, 281);
            this.reservationStatusPnl.Name = "reservationStatusPnl";
            this.reservationStatusPnl.Size = new System.Drawing.Size(694, 151);
            this.reservationStatusPnl.TabIndex = 5;
            // 
            // refreshReservationBtn
            // 
            this.refreshReservationBtn.Location = new System.Drawing.Point(458, 107);
            this.refreshReservationBtn.Name = "refreshReservationBtn";
            this.refreshReservationBtn.Size = new System.Drawing.Size(96, 34);
            this.refreshReservationBtn.TabIndex = 13;
            this.refreshReservationBtn.Text = "REFRESH";
            this.refreshReservationBtn.UseVisualStyleBackColor = true;
            this.refreshReservationBtn.Click += new System.EventHandler(this.notedButton_Click);
            // 
            // lblReservationStatus
            // 
            this.lblReservationStatus.AutoSize = true;
            this.lblReservationStatus.Location = new System.Drawing.Point(159, 121);
            this.lblReservationStatus.Name = "lblReservationStatus";
            this.lblReservationStatus.Size = new System.Drawing.Size(35, 20);
            this.lblReservationStatus.TabIndex = 12;
            this.lblReservationStatus.Text = "N/A";
            // 
            // lblReservationStatusTitle
            // 
            this.lblReservationStatusTitle.AutoSize = true;
            this.lblReservationStatusTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblReservationStatusTitle.Location = new System.Drawing.Point(4, 116);
            this.lblReservationStatusTitle.Name = "lblReservationStatusTitle";
            this.lblReservationStatusTitle.Size = new System.Drawing.Size(79, 25);
            this.lblReservationStatusTitle.TabIndex = 11;
            this.lblReservationStatusTitle.Text = "Status: ";
            // 
            // lblPlaceName
            // 
            this.lblPlaceName.AutoSize = true;
            this.lblPlaceName.Location = new System.Drawing.Point(159, 46);
            this.lblPlaceName.Name = "lblPlaceName";
            this.lblPlaceName.Size = new System.Drawing.Size(35, 20);
            this.lblPlaceName.TabIndex = 10;
            this.lblPlaceName.Text = "N/A";
            // 
            // lblPlaceNameTitle
            // 
            this.lblPlaceNameTitle.AutoSize = true;
            this.lblPlaceNameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPlaceNameTitle.Location = new System.Drawing.Point(5, 42);
            this.lblPlaceNameTitle.Name = "lblPlaceNameTitle";
            this.lblPlaceNameTitle.Size = new System.Drawing.Size(124, 25);
            this.lblPlaceNameTitle.TabIndex = 9;
            this.lblPlaceNameTitle.Text = "Place Name:";
            // 
            // lblDateTimeRange
            // 
            this.lblDateTimeRange.AutoSize = true;
            this.lblDateTimeRange.Location = new System.Drawing.Point(159, 84);
            this.lblDateTimeRange.Name = "lblDateTimeRange";
            this.lblDateTimeRange.Size = new System.Drawing.Size(35, 20);
            this.lblDateTimeRange.TabIndex = 8;
            this.lblDateTimeRange.Text = "N/A";
            // 
            // lblReservationID
            // 
            this.lblReservationID.AutoSize = true;
            this.lblReservationID.Location = new System.Drawing.Point(159, 10);
            this.lblReservationID.Name = "lblReservationID";
            this.lblReservationID.Size = new System.Drawing.Size(35, 20);
            this.lblReservationID.TabIndex = 7;
            this.lblReservationID.Text = "N/A";
            // 
            // cc
            // 
            this.cc.AutoSize = true;
            this.cc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cc.Location = new System.Drawing.Point(4, 80);
            this.cc.Name = "cc";
            this.cc.Size = new System.Drawing.Size(146, 25);
            this.cc.TabIndex = 6;
            this.cc.Text = "Date and Time:";
            // 
            // lblReservationIDTitle
            // 
            this.lblReservationIDTitle.AutoSize = true;
            this.lblReservationIDTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblReservationIDTitle.Location = new System.Drawing.Point(3, 6);
            this.lblReservationIDTitle.Name = "lblReservationIDTitle";
            this.lblReservationIDTitle.Size = new System.Drawing.Size(150, 25);
            this.lblReservationIDTitle.TabIndex = 5;
            this.lblReservationIDTitle.Text = "Reservation ID: ";
            // 
            // reservationStatusPBox
            // 
            this.reservationStatusPBox.Image = global::IOOP_Assignment.Properties.Resources.pendingIcon;
            this.reservationStatusPBox.Location = new System.Drawing.Point(571, 0);
            this.reservationStatusPBox.Name = "reservationStatusPBox";
            this.reservationStatusPBox.Size = new System.Drawing.Size(123, 151);
            this.reservationStatusPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.reservationStatusPBox.TabIndex = 2;
            this.reservationStatusPBox.TabStop = false;
            this.reservationStatusPBox.Click += new System.EventHandler(this.reservationStatusPBox_Click);
            // 
            // orderStatusPBox
            // 
            this.orderStatusPBox.Image = global::IOOP_Assignment.Properties.Resources.pendingIcon;
            this.orderStatusPBox.Location = new System.Drawing.Point(571, 0);
            this.orderStatusPBox.Name = "orderStatusPBox";
            this.orderStatusPBox.Size = new System.Drawing.Size(123, 104);
            this.orderStatusPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.orderStatusPBox.TabIndex = 2;
            this.orderStatusPBox.TabStop = false;
            // 
            // reservationBtn
            // 
            this.reservationBtn.BackColor = System.Drawing.Color.DimGray;
            this.reservationBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationBtn.ForeColor = System.Drawing.Color.White;
            this.reservationBtn.Image = global::IOOP_Assignment.Properties.Resources.reservationIcon;
            this.reservationBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reservationBtn.Location = new System.Drawing.Point(-3, -10);
            this.reservationBtn.Name = "reservationBtn";
            this.reservationBtn.Size = new System.Drawing.Size(198, 75);
            this.reservationBtn.TabIndex = 2;
            this.reservationBtn.Text = "        Reservation";
            this.reservationBtn.UseVisualStyleBackColor = false;
            this.reservationBtn.Click += new System.EventHandler(this.reservationBtn_Click);
            // 
            // orderBtn
            // 
            this.orderBtn.BackColor = System.Drawing.Color.DimGray;
            this.orderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderBtn.ForeColor = System.Drawing.Color.White;
            this.orderBtn.Image = global::IOOP_Assignment.Properties.Resources.orderIcon;
            this.orderBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.orderBtn.Location = new System.Drawing.Point(-3, -7);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(198, 69);
            this.orderBtn.TabIndex = 1;
            this.orderBtn.Text = "Order";
            this.orderBtn.UseVisualStyleBackColor = false;
            this.orderBtn.Click += new System.EventHandler(this.orderBtn_Click);
            // 
            // feedbackBtn
            // 
            this.feedbackBtn.BackColor = System.Drawing.Color.DimGray;
            this.feedbackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedbackBtn.ForeColor = System.Drawing.Color.White;
            this.feedbackBtn.Image = global::IOOP_Assignment.Properties.Resources.feedbackIcon;
            this.feedbackBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.feedbackBtn.Location = new System.Drawing.Point(-3, -7);
            this.feedbackBtn.Name = "feedbackBtn";
            this.feedbackBtn.Size = new System.Drawing.Size(198, 74);
            this.feedbackBtn.TabIndex = 2;
            this.feedbackBtn.Text = "      Feedback";
            this.feedbackBtn.UseVisualStyleBackColor = false;
            this.feedbackBtn.Click += new System.EventHandler(this.feedbackBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.DimGray;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.White;
            this.logoutBtn.Image = global::IOOP_Assignment.Properties.Resources.logoutIcon;
            this.logoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.Location = new System.Drawing.Point(-3, -6);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(198, 69);
            this.logoutBtn.TabIndex = 3;
            this.logoutBtn.Text = "  Logout";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // profileBtn
            // 
            this.profileBtn.BackColor = System.Drawing.Color.DimGray;
            this.profileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileBtn.ForeColor = System.Drawing.Color.White;
            this.profileBtn.Image = global::IOOP_Assignment.Properties.Resources.profileIcon;
            this.profileBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profileBtn.Location = new System.Drawing.Point(-3, -6);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.Size = new System.Drawing.Size(198, 70);
            this.profileBtn.TabIndex = 0;
            this.profileBtn.Text = "  Profile";
            this.profileBtn.UseVisualStyleBackColor = false;
            this.profileBtn.Click += new System.EventHandler(this.profileBtn_Click);
            // 
            // btnSidebar
            // 
            this.btnSidebar.Image = global::IOOP_Assignment.Properties.Resources.sidebarIcon;
            this.btnSidebar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSidebar.Location = new System.Drawing.Point(0, 0);
            this.btnSidebar.Name = "btnSidebar";
            this.btnSidebar.Size = new System.Drawing.Size(51, 62);
            this.btnSidebar.TabIndex = 1;
            this.btnSidebar.UseVisualStyleBackColor = true;
            this.btnSidebar.Click += new System.EventHandler(this.btnSidebar_Click);
            // 
            // CustomerHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 450);
            this.Controls.Add(this.reservationStatusPnl);
            this.Controls.Add(this.orderStatusPnl);
            this.Controls.Add(this.lblReservationStatusHeader);
            this.Controls.Add(this.lblOrderStatusHeader);
            this.Controls.Add(this.sidebarFlowLayoutPnl);
            this.Controls.Add(this.headerPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerHomePage";
            this.Text = "CustomerHomePage";
            this.Load += new System.EventHandler(this.CustomerHomePage_Load);
            this.headerPnl.ResumeLayout(false);
            this.headerPnl.PerformLayout();
            this.sidebarFlowLayoutPnl.ResumeLayout(false);
            this.reservationPnl.ResumeLayout(false);
            this.orderPnl.ResumeLayout(false);
            this.feedbackPnl.ResumeLayout(false);
            this.logoutPnl.ResumeLayout(false);
            this.profilePnl.ResumeLayout(false);
            this.orderStatusPnl.ResumeLayout(false);
            this.orderStatusPnl.PerformLayout();
            this.reservationStatusPnl.ResumeLayout(false);
            this.reservationStatusPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationStatusPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderStatusPBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel headerPnl;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnSidebar;
        private System.Windows.Forms.FlowLayoutPanel sidebarFlowLayoutPnl;
        private System.Windows.Forms.Panel reservationPnl;
        private System.Windows.Forms.Panel orderPnl;
        private System.Windows.Forms.Panel feedbackPnl;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.Button feedbackBtn;
        private System.Windows.Forms.Button reservationBtn;
        private System.Windows.Forms.Panel logoutPnl;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Label lblOrderStatusHeader;
        private System.Windows.Forms.Label lblReservationStatusHeader;
        private System.Windows.Forms.Panel orderStatusPnl;
        private System.Windows.Forms.Label lblEstimatedTime;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.PictureBox orderStatusPBox;
        private System.Windows.Forms.Label lblEstimatedTimeLeftTitle;
        private System.Windows.Forms.Label lblOrderIDTitle;
        private System.Windows.Forms.Panel reservationStatusPnl;
        private System.Windows.Forms.PictureBox reservationStatusPBox;
        private System.Windows.Forms.Panel emptyPnl;
        private System.Windows.Forms.Panel profilePnl;
        private System.Windows.Forms.Button profileBtn;
        private System.Windows.Forms.Label lblDateTimeRange;
        private System.Windows.Forms.Label lblReservationID;
        private System.Windows.Forms.Label cc;
        private System.Windows.Forms.Label lblReservationIDTitle;
        private System.Windows.Forms.Label lblPlaceName;
        private System.Windows.Forms.Label lblPlaceNameTitle;
        private System.Windows.Forms.Label lblOrderStatus;
        private System.Windows.Forms.Label lblOrderStatusTitle;
        private System.Windows.Forms.Label lblReservationStatus;
        private System.Windows.Forms.Label lblReservationStatusTitle;
        private System.Windows.Forms.Button refreshReservationBtn;
        private System.Windows.Forms.Button refreshOrderBtn;
    }
}