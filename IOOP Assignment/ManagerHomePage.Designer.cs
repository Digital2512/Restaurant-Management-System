namespace IOOP_Assignment
{
    partial class ManagerHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerHomePage));
            this.label2 = new System.Windows.Forms.Label();
            this.lblGreetMng = new System.Windows.Forms.Label();
            this.lblResv = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnResvReport = new System.Windows.Forms.Button();
            this.btnTables = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picManager = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picManager)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(461, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "What would you like to do?";
            // 
            // lblGreetMng
            // 
            this.lblGreetMng.AutoSize = true;
            this.lblGreetMng.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreetMng.Location = new System.Drawing.Point(542, 204);
            this.lblGreetMng.Name = "lblGreetMng";
            this.lblGreetMng.Size = new System.Drawing.Size(158, 25);
            this.lblGreetMng.TabIndex = 2;
            this.lblGreetMng.Text = "Hello, Manager";
            // 
            // lblResv
            // 
            this.lblResv.AutoSize = true;
            this.lblResv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResv.Location = new System.Drawing.Point(36, 534);
            this.lblResv.Name = "lblResv";
            this.lblResv.Size = new System.Drawing.Size(165, 20);
            this.lblResv.TabIndex = 9;
            this.lblResv.Text = "Reservation Report";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(237, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 213);
            this.panel1.TabIndex = 17;
            // 
            // btnResvReport
            // 
            this.btnResvReport.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnResvReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResvReport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnResvReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResvReport.Location = new System.Drawing.Point(0, 388);
            this.btnResvReport.Name = "btnResvReport";
            this.btnResvReport.Size = new System.Drawing.Size(743, 50);
            this.btnResvReport.TabIndex = 18;
            this.btnResvReport.Text = "Reservation Report";
            this.btnResvReport.UseVisualStyleBackColor = false;
            this.btnResvReport.Click += new System.EventHandler(this.btnResvReport_Click);
            // 
            // btnTables
            // 
            this.btnTables.BackColor = System.Drawing.Color.LightGray;
            this.btnTables.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTables.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTables.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTables.Location = new System.Drawing.Point(0, 338);
            this.btnTables.Name = "btnTables";
            this.btnTables.Size = new System.Drawing.Size(743, 50);
            this.btnTables.TabIndex = 19;
            this.btnTables.Text = "Tables";
            this.btnTables.UseVisualStyleBackColor = false;
            this.btnTables.Click += new System.EventHandler(this.btnTables_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.DarkGray;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenu.Location = new System.Drawing.Point(0, 288);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(743, 50);
            this.btnMenu.TabIndex = 20;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-12, -15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(269, 231);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // picManager
            // 
            this.picManager.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picManager.Location = new System.Drawing.Point(554, 30);
            this.picManager.Name = "picManager";
            this.picManager.Size = new System.Drawing.Size(146, 140);
            this.picManager.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picManager.TabIndex = 15;
            this.picManager.TabStop = false;
            this.picManager.Click += new System.EventHandler(this.picManager_Click);
            // 
            // ManagerHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(743, 438);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnTables);
            this.Controls.Add(this.btnResvReport);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picManager);
            this.Controls.Add(this.lblResv);
            this.Controls.Add(this.lblGreetMng);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagerHomePage";
            this.Text = "ManagerHomePage";
            this.Load += new System.EventHandler(this.ManagerHomePage_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblGreetMng;
        private System.Windows.Forms.Label lblResv;
        private System.Windows.Forms.PictureBox picManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnResvReport;
        private System.Windows.Forms.Button btnTables;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}