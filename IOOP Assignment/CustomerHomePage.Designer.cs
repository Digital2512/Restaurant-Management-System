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
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.reservationPnl = new System.Windows.Forms.Panel();
            this.orderPnl = new System.Windows.Forms.Panel();
            this.feedbackPnl = new System.Windows.Forms.Panel();
            this.menuTransition = new System.Windows.Forms.Timer(this.components);
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.logoutPnl = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.orderStatusPnl = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pastOrderPnl = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.profilePnl = new System.Windows.Forms.Panel();
            this.profileBtn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.reservationBtn = new System.Windows.Forms.Button();
            this.orderBtn = new System.Windows.Forms.Button();
            this.feedbackBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.btnSidebar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.reservationPnl.SuspendLayout();
            this.orderPnl.SuspendLayout();
            this.feedbackPnl.SuspendLayout();
            this.logoutPnl.SuspendLayout();
            this.orderStatusPnl.SuspendLayout();
            this.pastOrderPnl.SuspendLayout();
            this.profilePnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // menuTransition
            // 
            this.menuTransition.Interval = 10;
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // logoutPnl
            // 
            this.logoutPnl.Controls.Add(this.logoutBtn);
            this.logoutPnl.Location = new System.Drawing.Point(3, 188);
            this.logoutPnl.Name = "logoutPnl";
            this.logoutPnl.Size = new System.Drawing.Size(179, 57);
            this.logoutPnl.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(231, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Order Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(232, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "Past Order";
            // 
            // orderStatusPnl
            // 
            this.orderStatusPnl.Controls.Add(this.label6);
            this.orderStatusPnl.Controls.Add(this.lblOrderNumber);
            this.orderStatusPnl.Controls.Add(this.pictureBox1);
            this.orderStatusPnl.Controls.Add(this.label5);
            this.orderStatusPnl.Controls.Add(this.label4);
            this.orderStatusPnl.Location = new System.Drawing.Point(237, 139);
            this.orderStatusPnl.Name = "orderStatusPnl";
            this.orderStatusPnl.Size = new System.Drawing.Size(462, 104);
            this.orderStatusPnl.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Order Number: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Estimated Time Left: ";
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.AutoSize = true;
            this.lblOrderNumber.Location = new System.Drawing.Point(16, 30);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(105, 20);
            this.lblOrderNumber.TabIndex = 3;
            this.lblOrderNumber.Text = "OrderNumber";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "EstimatedTime";
            // 
            // pastOrderPnl
            // 
            this.pastOrderPnl.Controls.Add(this.pictureBox3);
            this.pastOrderPnl.Controls.Add(this.label8);
            this.pastOrderPnl.Controls.Add(this.pictureBox2);
            this.pastOrderPnl.Controls.Add(this.label10);
            this.pastOrderPnl.Location = new System.Drawing.Point(237, 306);
            this.pastOrderPnl.Name = "pastOrderPnl";
            this.pastOrderPnl.Size = new System.Drawing.Size(462, 104);
            this.pastOrderPnl.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Food\'s Price";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(4, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Food\'s Title";
            this.label10.Click += new System.EventHandler(this.label10_Click);
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
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(6, 62);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(172, 36);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(339, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(123, 104);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(339, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 104);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
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
            // btnSidebar
            // 
            this.btnSidebar.Image = global::IOOP_Assignment.Properties.Resources._3LinesSidebarIconResized;
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
            this.orderStatusPnl.ResumeLayout(false);
            this.orderStatusPnl.PerformLayout();
            this.pastOrderPnl.ResumeLayout(false);
            this.pastOrderPnl.PerformLayout();
            this.profilePnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.Button feedbackBtn;
        private System.Windows.Forms.Button reservationBtn;
        private System.Windows.Forms.Panel logoutPnl;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel orderStatusPnl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblOrderNumber;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pastOrderPnl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel profilePnl;
        private System.Windows.Forms.Button profileBtn;
    }
}