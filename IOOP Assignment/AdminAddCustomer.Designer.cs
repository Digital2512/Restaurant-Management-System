namespace IOOP_Assignment
{
    partial class AdminAddCustomer
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
            this.lblAddCustomer = new System.Windows.Forms.Label();
            this.lblCustomerIDTitle = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblDob = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblphoneNumber = new System.Windows.Forms.Label();
            this.grpboxGender = new System.Windows.Forms.GroupBox();
            this.rdbtnFemale = new System.Windows.Forms.RadioButton();
            this.rdbtnMale = new System.Windows.Forms.RadioButton();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.dtpDob = new System.Windows.Forms.DateTimePicker();
            this.txtphoneNumber = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.grpboxGender.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAddCustomer
            // 
            this.lblAddCustomer.AutoSize = true;
            this.lblAddCustomer.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCustomer.ForeColor = System.Drawing.Color.Navy;
            this.lblAddCustomer.Location = new System.Drawing.Point(442, 80);
            this.lblAddCustomer.Name = "lblAddCustomer";
            this.lblAddCustomer.Size = new System.Drawing.Size(301, 48);
            this.lblAddCustomer.TabIndex = 0;
            this.lblAddCustomer.Text = "ADD CUSTOMER";
            // 
            // lblCustomerIDTitle
            // 
            this.lblCustomerIDTitle.AutoSize = true;
            this.lblCustomerIDTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerIDTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblCustomerIDTitle.Location = new System.Drawing.Point(123, 188);
            this.lblCustomerIDTitle.Name = "lblCustomerIDTitle";
            this.lblCustomerIDTitle.Size = new System.Drawing.Size(141, 30);
            this.lblCustomerIDTitle.TabIndex = 1;
            this.lblCustomerIDTitle.Text = "Customer ID:";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCustomerID.Location = new System.Drawing.Point(298, 188);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(2, 22);
            this.lblCustomerID.TabIndex = 2;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.ForeColor = System.Drawing.Color.Navy;
            this.lblFullName.Location = new System.Drawing.Point(123, 266);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(119, 30);
            this.lblFullName.TabIndex = 3;
            this.lblFullName.Text = "Full Name:";
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDob.ForeColor = System.Drawing.Color.Navy;
            this.lblDob.Location = new System.Drawing.Point(123, 332);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(149, 30);
            this.lblDob.TabIndex = 4;
            this.lblDob.Text = "Date Of Birth:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Navy;
            this.lblEmail.Location = new System.Drawing.Point(636, 331);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(72, 30);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email:";
            // 
            // lblphoneNumber
            // 
            this.lblphoneNumber.AutoSize = true;
            this.lblphoneNumber.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphoneNumber.ForeColor = System.Drawing.Color.Navy;
            this.lblphoneNumber.Location = new System.Drawing.Point(636, 261);
            this.lblphoneNumber.Name = "lblphoneNumber";
            this.lblphoneNumber.Size = new System.Drawing.Size(170, 30);
            this.lblphoneNumber.TabIndex = 6;
            this.lblphoneNumber.Text = "Phone Number:";
            // 
            // grpboxGender
            // 
            this.grpboxGender.Controls.Add(this.rdbtnFemale);
            this.grpboxGender.Controls.Add(this.rdbtnMale);
            this.grpboxGender.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxGender.ForeColor = System.Drawing.Color.Navy;
            this.grpboxGender.Location = new System.Drawing.Point(127, 412);
            this.grpboxGender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpboxGender.Name = "grpboxGender";
            this.grpboxGender.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpboxGender.Size = new System.Drawing.Size(299, 141);
            this.grpboxGender.TabIndex = 3;
            this.grpboxGender.TabStop = false;
            this.grpboxGender.Text = "Gender";
            // 
            // rdbtnFemale
            // 
            this.rdbtnFemale.AutoSize = true;
            this.rdbtnFemale.Location = new System.Drawing.Point(8, 71);
            this.rdbtnFemale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbtnFemale.Name = "rdbtnFemale";
            this.rdbtnFemale.Size = new System.Drawing.Size(107, 34);
            this.rdbtnFemale.TabIndex = 3;
            this.rdbtnFemale.Text = "Female";
            this.rdbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rdbtnMale
            // 
            this.rdbtnMale.AutoSize = true;
            this.rdbtnMale.Location = new System.Drawing.Point(8, 32);
            this.rdbtnMale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbtnMale.Name = "rdbtnMale";
            this.rdbtnMale.Size = new System.Drawing.Size(86, 34);
            this.rdbtnMale.TabIndex = 2;
            this.rdbtnMale.Text = "Male";
            this.rdbtnMale.UseVisualStyleBackColor = true;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(298, 261);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(222, 26);
            this.txtFullName.TabIndex = 1;
            this.txtFullName.TextChanged += new System.EventHandler(this.txtFullName_TextChanged);
            // 
            // dtpDob
            // 
            this.dtpDob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDob.Location = new System.Drawing.Point(298, 332);
            this.dtpDob.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDob.Name = "dtpDob";
            this.dtpDob.Size = new System.Drawing.Size(226, 26);
            this.dtpDob.TabIndex = 2;
            // 
            // txtphoneNumber
            // 
            this.txtphoneNumber.Location = new System.Drawing.Point(825, 259);
            this.txtphoneNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtphoneNumber.Name = "txtphoneNumber";
            this.txtphoneNumber.Size = new System.Drawing.Size(210, 26);
            this.txtphoneNumber.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(825, 335);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(210, 26);
            this.txtEmail.TabIndex = 5;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(0, 621);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(1154, 58);
            this.btnRegister.TabIndex = 12;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Lavender;
            this.panelHeader.Controls.Add(this.btnBack);
            this.panelHeader.Location = new System.Drawing.Point(-1, -1);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1155, 42);
            this.panelHeader.TabIndex = 13;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1, 0);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(47, 42);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // AdminAddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1153, 676);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtphoneNumber);
            this.Controls.Add(this.dtpDob);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.grpboxGender);
            this.Controls.Add(this.lblphoneNumber);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblDob);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.lblCustomerIDTitle);
            this.Controls.Add(this.lblAddCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdminAddCustomer";
            this.Text = "AdminAddCustomer";
            this.Load += new System.EventHandler(this.AdminAddCustomer_Load);
            this.grpboxGender.ResumeLayout(false);
            this.grpboxGender.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddCustomer;
        private System.Windows.Forms.Label lblCustomerIDTitle;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblphoneNumber;
        private System.Windows.Forms.GroupBox grpboxGender;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.DateTimePicker dtpDob;
        private System.Windows.Forms.TextBox txtphoneNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.RadioButton rdbtnMale;
        private System.Windows.Forms.RadioButton rdbtnFemale;
    }
}