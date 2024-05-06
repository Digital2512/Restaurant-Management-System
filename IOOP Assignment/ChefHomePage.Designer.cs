namespace IOOP_Assignment
{
    partial class PanelChefHomePage
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
            this.LabelChefHomePage = new System.Windows.Forms.TextBox();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.MenusidearButton = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ButtonHome = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonViewOrder = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonInventory = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.sidebar.SuspendLayout();
            this.MenusidearButton.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelChefHomePage
            // 
            this.LabelChefHomePage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LabelChefHomePage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LabelChefHomePage.Font = new System.Drawing.Font("Black Ops One", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelChefHomePage.Location = new System.Drawing.Point(304, 21);
            this.LabelChefHomePage.Name = "LabelChefHomePage";
            this.LabelChefHomePage.Size = new System.Drawing.Size(258, 34);
            this.LabelChefHomePage.TabIndex = 1;
            this.LabelChefHomePage.Text = "Chef Mene Page";
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sidebar.Controls.Add(this.MenusidearButton);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(193, 405);
            this.sidebar.MinimumSize = new System.Drawing.Size(48, 405);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(193, 405);
            this.sidebar.TabIndex = 2;
            // 
            // MenusidearButton
            // 
            this.MenusidearButton.Controls.Add(this.label1);
            this.MenusidearButton.Location = new System.Drawing.Point(3, 3);
            this.MenusidearButton.Name = "MenusidearButton";
            this.MenusidearButton.Size = new System.Drawing.Size(190, 57);
            this.MenusidearButton.TabIndex = 6;
            this.MenusidearButton.Paint += new System.Windows.Forms.PaintEventHandler(this.MenusidearButton_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Black Ops One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Menu";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ButtonHome);
            this.panel2.Location = new System.Drawing.Point(3, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 69);
            this.panel2.TabIndex = 4;
            // 
            // ButtonHome
            // 
            this.ButtonHome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonHome.Font = new System.Drawing.Font("Russo One", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonHome.Location = new System.Drawing.Point(-16, -7);
            this.ButtonHome.Name = "ButtonHome";
            this.ButtonHome.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ButtonHome.Size = new System.Drawing.Size(219, 83);
            this.ButtonHome.TabIndex = 4;
            this.ButtonHome.Text = "Home";
            this.ButtonHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonHome.UseMnemonic = false;
            this.ButtonHome.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonViewOrder);
            this.panel1.Location = new System.Drawing.Point(3, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 57);
            this.panel1.TabIndex = 5;
            // 
            // buttonViewOrder
            // 
            this.buttonViewOrder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonViewOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonViewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonViewOrder.Font = new System.Drawing.Font("Russo One", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonViewOrder.Location = new System.Drawing.Point(-16, -10);
            this.buttonViewOrder.Name = "buttonViewOrder";
            this.buttonViewOrder.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonViewOrder.Size = new System.Drawing.Size(228, 73);
            this.buttonViewOrder.TabIndex = 5;
            this.buttonViewOrder.Text = "Order Details";
            this.buttonViewOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonViewOrder.UseMnemonic = false;
            this.buttonViewOrder.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonInventory);
            this.panel3.Location = new System.Drawing.Point(3, 204);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(190, 57);
            this.panel3.TabIndex = 6;
            // 
            // buttonInventory
            // 
            this.buttonInventory.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInventory.Font = new System.Drawing.Font("Russo One", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInventory.Location = new System.Drawing.Point(-16, -16);
            this.buttonInventory.Name = "buttonInventory";
            this.buttonInventory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonInventory.Size = new System.Drawing.Size(228, 84);
            this.buttonInventory.TabIndex = 6;
            this.buttonInventory.Text = "Inventory stock";
            this.buttonInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonInventory.UseMnemonic = false;
            this.buttonInventory.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.buttonProfile);
            this.panel5.Location = new System.Drawing.Point(3, 267);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(190, 57);
            this.panel5.TabIndex = 6;
            // 
            // buttonProfile
            // 
            this.buttonProfile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProfile.Font = new System.Drawing.Font("Russo One", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProfile.Location = new System.Drawing.Point(-16, -9);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonProfile.Size = new System.Drawing.Size(228, 92);
            this.buttonProfile.TabIndex = 6;
            this.buttonProfile.Text = " Profile";
            this.buttonProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonProfile.UseMnemonic = false;
            this.buttonProfile.UseVisualStyleBackColor = false;
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // PanelChefHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(667, 404);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.LabelChefHomePage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PanelChefHomePage";
            this.Text = "ChefHomePage";
            this.sidebar.ResumeLayout(false);
            this.MenusidearButton.ResumeLayout(false);
            this.MenusidearButton.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox LabelChefHomePage;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ButtonHome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel MenusidearButton;
        private System.Windows.Forms.Button buttonViewOrder;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonInventory;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer sidebarTimer;
    }
}