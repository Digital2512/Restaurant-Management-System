namespace IOOP_Assignment
{
    partial class AdminUpdateDeleteCustomer
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtphoneNumber = new System.Windows.Forms.TextBox();
            this.dtpDob = new System.Windows.Forms.DateTimePicker();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.grpboxGender = new System.Windows.Forms.GroupBox();
            this.rdbtnFemale = new System.Windows.Forms.RadioButton();
            this.rdbtnMale = new System.Windows.Forms.RadioButton();
            this.lblphoneNumber = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDob = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblCustomerIDTitle = new System.Windows.Forms.Label();
            this.lblUpdateDeleteCustomer = new System.Windows.Forms.Label();
            this.cmbCustomerID = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.grpboxGender.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(739, 280);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(187, 22);
            this.txtEmail.TabIndex = 23;
            // 
            // txtphoneNumber
            // 
            this.txtphoneNumber.Location = new System.Drawing.Point(739, 220);
            this.txtphoneNumber.Name = "txtphoneNumber";
            this.txtphoneNumber.Size = new System.Drawing.Size(187, 22);
            this.txtphoneNumber.TabIndex = 22;
            // 
            // dtpDob
            // 
            this.dtpDob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDob.Location = new System.Drawing.Point(272, 278);
            this.dtpDob.Name = "dtpDob";
            this.dtpDob.Size = new System.Drawing.Size(200, 22);
            this.dtpDob.TabIndex = 21;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(274, 220);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(198, 22);
            this.txtFullName.TabIndex = 20;
            // 
            // grpboxGender
            // 
            this.grpboxGender.Controls.Add(this.rdbtnFemale);
            this.grpboxGender.Controls.Add(this.rdbtnMale);
            this.grpboxGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxGender.Location = new System.Drawing.Point(120, 345);
            this.grpboxGender.Name = "grpboxGender";
            this.grpboxGender.Size = new System.Drawing.Size(266, 113);
            this.grpboxGender.TabIndex = 19;
            this.grpboxGender.TabStop = false;
            this.grpboxGender.Text = "Gender";
            // 
            // rdbtnFemale
            // 
            this.rdbtnFemale.AutoSize = true;
            this.rdbtnFemale.Location = new System.Drawing.Point(7, 49);
            this.rdbtnFemale.Name = "rdbtnFemale";
            this.rdbtnFemale.Size = new System.Drawing.Size(91, 24);
            this.rdbtnFemale.TabIndex = 1;
            this.rdbtnFemale.TabStop = true;
            this.rdbtnFemale.Text = "Female";
            this.rdbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rdbtnMale
            // 
            this.rdbtnMale.AutoSize = true;
            this.rdbtnMale.Location = new System.Drawing.Point(7, 22);
            this.rdbtnMale.Name = "rdbtnMale";
            this.rdbtnMale.Size = new System.Drawing.Size(70, 24);
            this.rdbtnMale.TabIndex = 0;
            this.rdbtnMale.TabStop = true;
            this.rdbtnMale.Text = "Male";
            this.rdbtnMale.UseVisualStyleBackColor = true;
            // 
            // lblphoneNumber
            // 
            this.lblphoneNumber.AutoSize = true;
            this.lblphoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphoneNumber.Location = new System.Drawing.Point(575, 220);
            this.lblphoneNumber.Name = "lblphoneNumber";
            this.lblphoneNumber.Size = new System.Drawing.Size(138, 20);
            this.lblphoneNumber.TabIndex = 18;
            this.lblphoneNumber.Text = "Phone Number:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(575, 280);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(62, 20);
            this.lblEmail.TabIndex = 17;
            this.lblEmail.Text = "Email:";
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDob.Location = new System.Drawing.Point(116, 278);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(128, 20);
            this.lblDob.TabIndex = 16;
            this.lblDob.Text = "Date Of Birth:";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(118, 220);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(100, 20);
            this.lblFullName.TabIndex = 15;
            this.lblFullName.Text = "Full Name:";
            // 
            // lblCustomerIDTitle
            // 
            this.lblCustomerIDTitle.AutoSize = true;
            this.lblCustomerIDTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerIDTitle.Location = new System.Drawing.Point(116, 150);
            this.lblCustomerIDTitle.Name = "lblCustomerIDTitle";
            this.lblCustomerIDTitle.Size = new System.Drawing.Size(121, 20);
            this.lblCustomerIDTitle.TabIndex = 13;
            this.lblCustomerIDTitle.Text = "Customer ID:";
            // 
            // lblUpdateDeleteCustomer
            // 
            this.lblUpdateDeleteCustomer.AutoSize = true;
            this.lblUpdateDeleteCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateDeleteCustomer.Location = new System.Drawing.Point(289, 63);
            this.lblUpdateDeleteCustomer.Name = "lblUpdateDeleteCustomer";
            this.lblUpdateDeleteCustomer.Size = new System.Drawing.Size(483, 39);
            this.lblUpdateDeleteCustomer.TabIndex = 12;
            this.lblUpdateDeleteCustomer.Text = "Update and Delete Customer";
            // 
            // cmbCustomerID
            // 
            this.cmbCustomerID.FormattingEnabled = true;
            this.cmbCustomerID.Location = new System.Drawing.Point(272, 150);
            this.cmbCustomerID.Name = "cmbCustomerID";
            this.cmbCustomerID.Size = new System.Drawing.Size(147, 24);
            this.cmbCustomerID.TabIndex = 24;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(458, 150);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 30);
            this.btnSearch.TabIndex = 25;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(412, 481);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(87, 35);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(536, 481);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 35);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.DimGray;
            this.panelHeader.Controls.Add(this.btnBack);
            this.panelHeader.Location = new System.Drawing.Point(-1, -1);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1027, 34);
            this.panelHeader.TabIndex = 28;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(0, -2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(53, 36);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // AdminUpdateDeleteCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 541);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbCustomerID);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtphoneNumber);
            this.Controls.Add(this.dtpDob);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.grpboxGender);
            this.Controls.Add(this.lblphoneNumber);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblDob);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblCustomerIDTitle);
            this.Controls.Add(this.lblUpdateDeleteCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminUpdateDeleteCustomer";
            this.Text = "AdminUpdateDeleteCustomer";
            this.Load += new System.EventHandler(this.AdminUpdateDeleteCustomer_Load);
            this.grpboxGender.ResumeLayout(false);
            this.grpboxGender.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtphoneNumber;
        private System.Windows.Forms.DateTimePicker dtpDob;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.GroupBox grpboxGender;
        private System.Windows.Forms.RadioButton rdbtnFemale;
        private System.Windows.Forms.RadioButton rdbtnMale;
        private System.Windows.Forms.Label lblphoneNumber;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblCustomerIDTitle;
        private System.Windows.Forms.Label lblUpdateDeleteCustomer;
        private System.Windows.Forms.ComboBox cmbCustomerID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnBack;
    }
}