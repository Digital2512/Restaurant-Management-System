namespace IOOP_Assignment
{
    partial class AdminViewChef
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
            this.lblviewChef = new System.Windows.Forms.Label();
            this.lblChefID = new System.Windows.Forms.Label();
            this.cmbChefID = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvViewChef = new System.Windows.Forms.DataGridView();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewChef)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblviewChef
            // 
            this.lblviewChef.AutoSize = true;
            this.lblviewChef.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblviewChef.ForeColor = System.Drawing.Color.Navy;
            this.lblviewChef.Location = new System.Drawing.Point(426, 48);
            this.lblviewChef.Name = "lblviewChef";
            this.lblviewChef.Size = new System.Drawing.Size(177, 41);
            this.lblviewChef.TabIndex = 0;
            this.lblviewChef.Text = "VIEW CHEF";
            // 
            // lblChefID
            // 
            this.lblChefID.AutoSize = true;
            this.lblChefID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChefID.ForeColor = System.Drawing.Color.Navy;
            this.lblChefID.Location = new System.Drawing.Point(265, 124);
            this.lblChefID.Name = "lblChefID";
            this.lblChefID.Size = new System.Drawing.Size(75, 23);
            this.lblChefID.TabIndex = 1;
            this.lblChefID.Text = "Chef ID:";
            // 
            // cmbChefID
            // 
            this.cmbChefID.FormattingEnabled = true;
            this.cmbChefID.Location = new System.Drawing.Point(400, 124);
            this.cmbChefID.Name = "cmbChefID";
            this.cmbChefID.Size = new System.Drawing.Size(236, 24);
            this.cmbChefID.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(706, 122);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(98, 29);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvViewChef
            // 
            this.dgvViewChef.BackgroundColor = System.Drawing.Color.Ivory;
            this.dgvViewChef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewChef.Location = new System.Drawing.Point(88, 168);
            this.dgvViewChef.Name = "dgvViewChef";
            this.dgvViewChef.RowHeadersWidth = 51;
            this.dgvViewChef.RowTemplate.Height = 24;
            this.dgvViewChef.Size = new System.Drawing.Size(837, 338);
            this.dgvViewChef.TabIndex = 4;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Lavender;
            this.panelHeader.Controls.Add(this.btnBack);
            this.panelHeader.Location = new System.Drawing.Point(-1, -1);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1027, 34);
            this.panelHeader.TabIndex = 5;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(53, 34);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // AdminViewChef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1025, 541);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.dgvViewChef);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbChefID);
            this.Controls.Add(this.lblChefID);
            this.Controls.Add(this.lblviewChef);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminViewChef";
            this.Text = "AdminViewChef";
            this.Load += new System.EventHandler(this.AdminViewChef_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewChef)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblviewChef;
        private System.Windows.Forms.Label lblChefID;
        private System.Windows.Forms.ComboBox cmbChefID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvViewChef;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnBack;
    }
}