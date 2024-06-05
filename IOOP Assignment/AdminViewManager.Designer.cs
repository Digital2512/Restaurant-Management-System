namespace IOOP_Assignment
{
    partial class AdminViewManager
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblManagerID = new System.Windows.Forms.Label();
            this.cmbManagerID = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvViewManager = new System.Windows.Forms.DataGridView();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewManager)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(392, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "VIEW MANAGER";
            // 
            // lblManagerID
            // 
            this.lblManagerID.AutoSize = true;
            this.lblManagerID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagerID.ForeColor = System.Drawing.Color.Navy;
            this.lblManagerID.Location = new System.Drawing.Point(212, 120);
            this.lblManagerID.Name = "lblManagerID";
            this.lblManagerID.Size = new System.Drawing.Size(109, 23);
            this.lblManagerID.TabIndex = 2;
            this.lblManagerID.Text = "Manager ID:";
            // 
            // cmbManagerID
            // 
            this.cmbManagerID.FormattingEnabled = true;
            this.cmbManagerID.Location = new System.Drawing.Point(412, 120);
            this.cmbManagerID.Name = "cmbManagerID";
            this.cmbManagerID.Size = new System.Drawing.Size(218, 24);
            this.cmbManagerID.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(725, 120);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 24);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvViewManager
            // 
            this.dgvViewManager.BackgroundColor = System.Drawing.Color.Ivory;
            this.dgvViewManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewManager.Location = new System.Drawing.Point(104, 160);
            this.dgvViewManager.Name = "dgvViewManager";
            this.dgvViewManager.RowHeadersWidth = 51;
            this.dgvViewManager.RowTemplate.Height = 24;
            this.dgvViewManager.Size = new System.Drawing.Size(813, 345);
            this.dgvViewManager.TabIndex = 5;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Lavender;
            this.panelHeader.Controls.Add(this.btnBack);
            this.panelHeader.Location = new System.Drawing.Point(-1, -1);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1027, 34);
            this.panelHeader.TabIndex = 6;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(0, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(58, 31);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // AdminViewManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1025, 541);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.dgvViewManager);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbManagerID);
            this.Controls.Add(this.lblManagerID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminViewManager";
            this.Text = "ViewManager";
            this.Load += new System.EventHandler(this.AdminViewManager_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewManager)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblManagerID;
        private System.Windows.Forms.ComboBox cmbManagerID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvViewManager;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnBack;
    }
}