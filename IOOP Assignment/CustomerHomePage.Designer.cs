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
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnSidebar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.reservationPnl.SuspendLayout();
            this.orderPnl.SuspendLayout();
            this.feedbackPnl.SuspendLayout();
            this.logoutPnl.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(800, 62);
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
            this.sidebar.Location = new System.Drawing.Point(0, 61);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(188, 393);
            this.sidebar.TabIndex = 1;
            // 
            // reservationPnl
            // 
            this.reservationPnl.Controls.Add(this.button4);
            this.reservationPnl.Location = new System.Drawing.Point(3, 3);
            this.reservationPnl.Name = "reservationPnl";
            this.reservationPnl.Size = new System.Drawing.Size(179, 57);
            this.reservationPnl.TabIndex = 2;
            // 
            // orderPnl
            // 
            this.orderPnl.Controls.Add(this.button2);
            this.orderPnl.Location = new System.Drawing.Point(3, 66);
            this.orderPnl.Name = "orderPnl";
            this.orderPnl.Size = new System.Drawing.Size(179, 53);
            this.orderPnl.TabIndex = 3;
            // 
            // feedbackPnl
            // 
            this.feedbackPnl.Controls.Add(this.button3);
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
            this.logoutPnl.Controls.Add(this.button5);
            this.logoutPnl.Location = new System.Drawing.Point(3, 188);
            this.logoutPnl.Name = "logoutPnl";
            this.logoutPnl.Size = new System.Drawing.Size(179, 57);
            this.logoutPnl.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DimGray;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::IOOP_Assignment.Properties.Resources.reservationIcon;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(-3, -10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(198, 75);
            this.button4.TabIndex = 2;
            this.button4.Text = "        Reservation";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::IOOP_Assignment.Properties.Resources.orderIcon;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(-3, -7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 69);
            this.button2.TabIndex = 1;
            this.button2.Text = "Order";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DimGray;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::IOOP_Assignment.Properties.Resources.feedbackIcon;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(-3, -7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(198, 74);
            this.button3.TabIndex = 2;
            this.button3.Text = "      Feedback";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DimGray;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::IOOP_Assignment.Properties.Resources.logoutIcon;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(-3, -6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(198, 69);
            this.button5.TabIndex = 3;
            this.button5.Text = "  Logout";
            this.button5.UseVisualStyleBackColor = false;
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
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel logoutPnl;
        private System.Windows.Forms.Button button5;
    }
}