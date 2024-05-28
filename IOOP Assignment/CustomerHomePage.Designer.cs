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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnSidebar = new System.Windows.Forms.Button();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.reservationPnl = new System.Windows.Forms.Panel();
            this.reservationBtn = new System.Windows.Forms.Button();
            this.orderPnl = new System.Windows.Forms.Panel();
            this.orderBtn = new System.Windows.Forms.Button();
            this.feedbackPnl = new System.Windows.Forms.Panel();
            this.feedbackBtn = new System.Windows.Forms.Button();
            this.logoutPnl = new System.Windows.Forms.Panel();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.profilePnl = new System.Windows.Forms.Panel();
            this.profileBtn = new System.Windows.Forms.Button();
            this.menuTransition = new System.Windows.Forms.Timer(this.components);
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.orderStatusPnl = new System.Windows.Forms.Panel();
            this.lblOrderStatus = new System.Windows.Forms.Label();
            this.lblOrderStatusTitle = new System.Windows.Forms.Label();
            this.lblEstimatedTime = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.orderStatusPBox = new System.Windows.Forms.PictureBox();
            this.lblEstimatedTimeLeftTitle = new System.Windows.Forms.Label();
            this.lblOrderIDTitle = new System.Windows.Forms.Label();
            this.pastOrderPnl = new System.Windows.Forms.Panel();
            this.lblReservationStatus = new System.Windows.Forms.Label();
            this.lblReservationStatusTitle = new System.Windows.Forms.Label();
            this.lblPlaceName = new System.Windows.Forms.Label();
            this.lblPlaceNameTitle = new System.Windows.Forms.Label();
            this.lblPlaceID = new System.Windows.Forms.Label();
            this.lblReservationID = new System.Windows.Forms.Label();
            this.lblPlaceIDTitle = new System.Windows.Forms.Label();
            this.lblReservationIDTitle = new System.Windows.Forms.Label();
            this.reservationStatusPBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.reservationPnl.SuspendLayout();
            this.orderPnl.SuspendLayout();
            this.feedbackPnl.SuspendLayout();
            this.logoutPnl.SuspendLayout();
            this.profilePnl.SuspendLayout();
            this.orderStatusPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderStatusPBox)).BeginInit();
            this.pastOrderPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationStatusPBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblWelcome);
            this.panel1.Controls.Add(this.btnSidebar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 62);
            this.panel1.TabIndex = 0;
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
            // btnSidebar
            // 
            this.btnSidebar.Location = new System.Drawing.Point(0, 0);
            this.btnSidebar.Name = "btnSidebar";
            this.btnSidebar.Size = new System.Drawing.Size(51, 62);
            this.btnSidebar.TabIndex = 1;
            this.btnSidebar.UseVisualStyleBackColor = true;
            this.btnSidebar.Click += new System.EventHandler(this.btnSidebar_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.DimGray;
            this.sidebar.Controls.Add(this.reservationPnl);
            this.sidebar.Controls.Add(this.orderPnl);
            this.sidebar.Controls.Add(this.feedbackPnl);
            this.sidebar.Controls.Add(this.logoutPnl);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.profilePnl);
            this.sidebar.Location = new System.Drawing.Point(0, 61);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(188, 393);
            this.sidebar.TabIndex = 1;
            // 
            // reservationPnl
            // 
            this.reservationPnl.Controls.Add(this.reservationBtn);
            this.reservationPnl.Location = new System.Drawing.Point(3, 3);
            this.reservationPnl.Name = "reservationPnl";
            this.reservationPnl.Size = new System.Drawing.Size(179, 57);
            this.reservationPnl.TabIndex = 2;
            // 
            // reservationBtn
            // 
            this.reservationBtn.BackColor = System.Drawing.Color.DimGray;
            this.reservationBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationBtn.ForeColor = System.Drawing.Color.White;
            this.reservationBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reservationBtn.Location = new System.Drawing.Point(-3, -10);
            this.reservationBtn.Name = "reservationBtn";
            this.reservationBtn.Size = new System.Drawing.Size(198, 75);
            this.reservationBtn.TabIndex = 2;
            this.reservationBtn.Text = "        Reservation";
            this.reservationBtn.UseVisualStyleBackColor = false;
            this.reservationBtn.Click += new System.EventHandler(this.reservationBtn_Click);
            // 
            // orderPnl
            // 
            this.orderPnl.Controls.Add(this.orderBtn);
            this.orderPnl.Location = new System.Drawing.Point(3, 66);
            this.orderPnl.Name = "orderPnl";
            this.orderPnl.Size = new System.Drawing.Size(179, 53);
            this.orderPnl.TabIndex = 3;
            // 
            // orderBtn
            // 
            this.orderBtn.BackColor = System.Drawing.Color.DimGray;
            this.orderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderBtn.ForeColor = System.Drawing.Color.White;
            this.orderBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.orderBtn.Location = new System.Drawing.Point(-3, -7);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(198, 69);
            this.orderBtn.TabIndex = 1;
            this.orderBtn.Text = "Order";
            this.orderBtn.UseVisualStyleBackColor = false;
            this.orderBtn.Click += new System.EventHandler(this.orderBtn_Click);
            // 
            // feedbackPnl
            // 
            this.feedbackPnl.Controls.Add(this.feedbackBtn);
            this.feedbackPnl.Location = new System.Drawing.Point(3, 125);
            this.feedbackPnl.Name = "feedbackPnl";
            this.feedbackPnl.Size = new System.Drawing.Size(179, 57);
            this.feedbackPnl.TabIndex = 3;
            // 
            // feedbackBtn
            // 
            this.feedbackBtn.BackColor = System.Drawing.Color.DimGray;
            this.feedbackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedbackBtn.ForeColor = System.Drawing.Color.White;
            this.feedbackBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.feedbackBtn.Location = new System.Drawing.Point(-3, -7);
            this.feedbackBtn.Name = "feedbackBtn";
            this.feedbackBtn.Size = new System.Drawing.Size(198, 74);
            this.feedbackBtn.TabIndex = 2;
            this.feedbackBtn.Text = "      Feedback";
            this.feedbackBtn.UseVisualStyleBackColor = false;
            this.feedbackBtn.Click += new System.EventHandler(this.feedbackBtn_Click);
            // 
            // logoutPnl
            // 
            this.logoutPnl.Controls.Add(this.logoutBtn);
            this.logoutPnl.Location = new System.Drawing.Point(3, 188);
            this.logoutPnl.Name = "logoutPnl";
            this.logoutPnl.Size = new System.Drawing.Size(179, 57);
            this.logoutPnl.TabIndex = 4;
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.DimGray;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.White;
            this.logoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.Location = new System.Drawing.Point(-3, -6);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(198, 69);
            this.logoutBtn.TabIndex = 3;
            this.logoutBtn.Text = "  Logout";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 251);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(179, 57);
            this.panel2.TabIndex = 5;
            // 
            // profilePnl
            // 
            this.profilePnl.Controls.Add(this.profileBtn);
            this.profilePnl.Location = new System.Drawing.Point(3, 314);
            this.profilePnl.Name = "profilePnl";
            this.profilePnl.Size = new System.Drawing.Size(179, 57);
            this.profilePnl.TabIndex = 6;
            // 
            // profileBtn
            // 
            this.profileBtn.BackColor = System.Drawing.Color.DimGray;
            this.profileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileBtn.ForeColor = System.Drawing.Color.White;
            this.profileBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profileBtn.Location = new System.Drawing.Point(-3, -6);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.Size = new System.Drawing.Size(198, 70);
            this.profileBtn.TabIndex = 0;
            this.profileBtn.Text = "  Profile";
            this.profileBtn.UseVisualStyleBackColor = false;
            this.profileBtn.Click += new System.EventHandler(this.profileBtn_Click);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(231, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Order Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(232, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(303, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "Reservation Status";
            // 
            // orderStatusPnl
            // 
            this.orderStatusPnl.Controls.Add(this.lblOrderStatus);
            this.orderStatusPnl.Controls.Add(this.lblOrderStatusTitle);
            this.orderStatusPnl.Controls.Add(this.lblEstimatedTime);
            this.orderStatusPnl.Controls.Add(this.lblOrderID);
            this.orderStatusPnl.Controls.Add(this.orderStatusPBox);
            this.orderStatusPnl.Controls.Add(this.lblEstimatedTimeLeftTitle);
            this.orderStatusPnl.Controls.Add(this.lblOrderIDTitle);
            this.orderStatusPnl.Location = new System.Drawing.Point(237, 119);
            this.orderStatusPnl.Name = "orderStatusPnl";
            this.orderStatusPnl.Size = new System.Drawing.Size(462, 104);
            this.orderStatusPnl.TabIndex = 4;
            // 
            // lblOrderStatus
            // 
            this.lblOrderStatus.AutoSize = true;
            this.lblOrderStatus.Location = new System.Drawing.Point(205, 72);
            this.lblOrderStatus.Name = "lblOrderStatus";
            this.lblOrderStatus.Size = new System.Drawing.Size(72, 20);
            this.lblOrderStatus.TabIndex = 6;
            this.lblOrderStatus.Text = "MAKING";
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
            this.lblEstimatedTime.Size = new System.Drawing.Size(115, 20);
            this.lblEstimatedTime.TabIndex = 4;
            this.lblEstimatedTime.Text = "EstimatedTime";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(205, 10);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(66, 20);
            this.lblOrderID.TabIndex = 3;
            this.lblOrderID.Text = "OrderID";
            // 
            // orderStatusPBox
            // 
            this.orderStatusPBox.Location = new System.Drawing.Point(339, 0);
            this.orderStatusPBox.Name = "orderStatusPBox";
            this.orderStatusPBox.Size = new System.Drawing.Size(123, 104);
            this.orderStatusPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.orderStatusPBox.TabIndex = 2;
            this.orderStatusPBox.TabStop = false;
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
            // pastOrderPnl
            // 
            this.pastOrderPnl.Controls.Add(this.lblReservationStatus);
            this.pastOrderPnl.Controls.Add(this.lblReservationStatusTitle);
            this.pastOrderPnl.Controls.Add(this.lblPlaceName);
            this.pastOrderPnl.Controls.Add(this.lblPlaceNameTitle);
            this.pastOrderPnl.Controls.Add(this.lblPlaceID);
            this.pastOrderPnl.Controls.Add(this.lblReservationID);
            this.pastOrderPnl.Controls.Add(this.lblPlaceIDTitle);
            this.pastOrderPnl.Controls.Add(this.lblReservationIDTitle);
            this.pastOrderPnl.Controls.Add(this.reservationStatusPBox);
            this.pastOrderPnl.Location = new System.Drawing.Point(237, 281);
            this.pastOrderPnl.Name = "pastOrderPnl";
            this.pastOrderPnl.Size = new System.Drawing.Size(462, 151);
            this.pastOrderPnl.TabIndex = 5;
            // 
            // lblReservationStatus
            // 
            this.lblReservationStatus.AutoSize = true;
            this.lblReservationStatus.Location = new System.Drawing.Point(161, 121);
            this.lblReservationStatus.Name = "lblReservationStatus";
            this.lblReservationStatus.Size = new System.Drawing.Size(82, 20);
            this.lblReservationStatus.TabIndex = 12;
            this.lblReservationStatus.Text = "PENDING";
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
            this.lblPlaceName.Location = new System.Drawing.Point(160, 85);
            this.lblPlaceName.Name = "lblPlaceName";
            this.lblPlaceName.Size = new System.Drawing.Size(94, 20);
            this.lblPlaceName.TabIndex = 10;
            this.lblPlaceName.Text = "Place Name";
            // 
            // lblPlaceNameTitle
            // 
            this.lblPlaceNameTitle.AutoSize = true;
            this.lblPlaceNameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPlaceNameTitle.Location = new System.Drawing.Point(3, 80);
            this.lblPlaceNameTitle.Name = "lblPlaceNameTitle";
            this.lblPlaceNameTitle.Size = new System.Drawing.Size(124, 25);
            this.lblPlaceNameTitle.TabIndex = 9;
            this.lblPlaceNameTitle.Text = "Place Name:";
            // 
            // lblPlaceID
            // 
            this.lblPlaceID.AutoSize = true;
            this.lblPlaceID.Location = new System.Drawing.Point(160, 46);
            this.lblPlaceID.Name = "lblPlaceID";
            this.lblPlaceID.Size = new System.Drawing.Size(69, 20);
            this.lblPlaceID.TabIndex = 8;
            this.lblPlaceID.Text = "Place ID";
            // 
            // lblReservationID
            // 
            this.lblReservationID.AutoSize = true;
            this.lblReservationID.Location = new System.Drawing.Point(160, 10);
            this.lblReservationID.Name = "lblReservationID";
            this.lblReservationID.Size = new System.Drawing.Size(115, 20);
            this.lblReservationID.TabIndex = 7;
            this.lblReservationID.Text = "Reservation ID";
            // 
            // lblPlaceIDTitle
            // 
            this.lblPlaceIDTitle.AutoSize = true;
            this.lblPlaceIDTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPlaceIDTitle.Location = new System.Drawing.Point(4, 42);
            this.lblPlaceIDTitle.Name = "lblPlaceIDTitle";
            this.lblPlaceIDTitle.Size = new System.Drawing.Size(91, 25);
            this.lblPlaceIDTitle.TabIndex = 6;
            this.lblPlaceIDTitle.Text = "Place ID:";
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
            this.reservationStatusPBox.Location = new System.Drawing.Point(339, 0);
            this.reservationStatusPBox.Name = "reservationStatusPBox";
            this.reservationStatusPBox.Size = new System.Drawing.Size(123, 151);
            this.reservationStatusPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.reservationStatusPBox.TabIndex = 2;
            this.reservationStatusPBox.TabStop = false;
            // 
            // CustomerHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 450);
            this.Controls.Add(this.pastOrderPnl);
            this.Controls.Add(this.orderStatusPnl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.Name = "CustomerHomePage";
            this.Text = "CustomerHomePage";
            this.Load += new System.EventHandler(this.CustomerHomePage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.sidebar.ResumeLayout(false);
            this.reservationPnl.ResumeLayout(false);
            this.orderPnl.ResumeLayout(false);
            this.feedbackPnl.ResumeLayout(false);
            this.logoutPnl.ResumeLayout(false);
            this.profilePnl.ResumeLayout(false);
            this.orderStatusPnl.ResumeLayout(false);
            this.orderStatusPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderStatusPBox)).EndInit();
            this.pastOrderPnl.ResumeLayout(false);
            this.pastOrderPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationStatusPBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnSidebar;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel orderStatusPnl;
        private System.Windows.Forms.Label lblEstimatedTime;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.PictureBox orderStatusPBox;
        private System.Windows.Forms.Label lblEstimatedTimeLeftTitle;
        private System.Windows.Forms.Label lblOrderIDTitle;
        private System.Windows.Forms.Panel pastOrderPnl;
        private System.Windows.Forms.PictureBox reservationStatusPBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel profilePnl;
        private System.Windows.Forms.Button profileBtn;
        private System.Windows.Forms.Label lblPlaceID;
        private System.Windows.Forms.Label lblReservationID;
        private System.Windows.Forms.Label lblPlaceIDTitle;
        private System.Windows.Forms.Label lblReservationIDTitle;
        private System.Windows.Forms.Label lblPlaceName;
        private System.Windows.Forms.Label lblPlaceNameTitle;
        private System.Windows.Forms.Label lblOrderStatus;
        private System.Windows.Forms.Label lblOrderStatusTitle;
        private System.Windows.Forms.Label lblReservationStatus;
        private System.Windows.Forms.Label lblReservationStatusTitle;
    }
}