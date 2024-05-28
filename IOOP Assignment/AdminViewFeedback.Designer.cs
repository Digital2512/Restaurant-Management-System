namespace trial_2
{
    partial class AdminViewFeedback
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
            this.lblViewFeedback = new System.Windows.Forms.Label();
            this.lblFeedbackID = new System.Windows.Forms.Label();
            this.cmbFeedbackID = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvViewFeedback = new System.Windows.Forms.DataGridView();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewFeedback)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblViewFeedback
            // 
            this.lblViewFeedback.AutoSize = true;
            this.lblViewFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewFeedback.Location = new System.Drawing.Point(388, 61);
            this.lblViewFeedback.Name = "lblViewFeedback";
            this.lblViewFeedback.Size = new System.Drawing.Size(264, 39);
            this.lblViewFeedback.TabIndex = 0;
            this.lblViewFeedback.Text = "View Feedback";
            // 
            // lblFeedbackID
            // 
            this.lblFeedbackID.AutoSize = true;
            this.lblFeedbackID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedbackID.Location = new System.Drawing.Point(235, 144);
            this.lblFeedbackID.Name = "lblFeedbackID";
            this.lblFeedbackID.Size = new System.Drawing.Size(120, 20);
            this.lblFeedbackID.TabIndex = 1;
            this.lblFeedbackID.Text = "Feedback ID:";
            // 
            // cmbFeedbackID
            // 
            this.cmbFeedbackID.FormattingEnabled = true;
            this.cmbFeedbackID.Location = new System.Drawing.Point(419, 140);
            this.cmbFeedbackID.Name = "cmbFeedbackID";
            this.cmbFeedbackID.Size = new System.Drawing.Size(219, 24);
            this.cmbFeedbackID.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(708, 140);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(111, 26);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvViewFeedback
            // 
            this.dgvViewFeedback.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewFeedback.Location = new System.Drawing.Point(95, 190);
            this.dgvViewFeedback.Name = "dgvViewFeedback";
            this.dgvViewFeedback.RowHeadersWidth = 51;
            this.dgvViewFeedback.RowTemplate.Height = 24;
            this.dgvViewFeedback.Size = new System.Drawing.Size(837, 313);
            this.dgvViewFeedback.TabIndex = 4;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.DimGray;
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
            this.btnBack.Size = new System.Drawing.Size(61, 34);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // AdminViewFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 541);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.dgvViewFeedback);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbFeedbackID);
            this.Controls.Add(this.lblFeedbackID);
            this.Controls.Add(this.lblViewFeedback);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminViewFeedback";
            this.Text = "AdminViewFeedback";
            this.Load += new System.EventHandler(this.AdminViewFeedback_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewFeedback)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblViewFeedback;
        private System.Windows.Forms.Label lblFeedbackID;
        private System.Windows.Forms.ComboBox cmbFeedbackID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvViewFeedback;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnBack;
    }
}