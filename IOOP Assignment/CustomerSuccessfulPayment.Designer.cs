namespace IOOP_Assignment
{
    partial class CustomerSuccessfulPayment
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
            this.homePageBtn = new System.Windows.Forms.Button();
            this.lblPaymentSuccessfulTitle = new System.Windows.Forms.Label();
            this.approvedPBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.approvedPBox)).BeginInit();
            this.SuspendLayout();
            // 
            // homePageBtn
            // 
            this.homePageBtn.Location = new System.Drawing.Point(177, 358);
            this.homePageBtn.Name = "homePageBtn";
            this.homePageBtn.Size = new System.Drawing.Size(427, 45);
            this.homePageBtn.TabIndex = 1;
            this.homePageBtn.Text = "Go back to Home Page";
            this.homePageBtn.UseVisualStyleBackColor = true;
            this.homePageBtn.Click += new System.EventHandler(this.homePageBtn_Click);
            // 
            // lblPaymentSuccessfulTitle
            // 
            this.lblPaymentSuccessfulTitle.AutoSize = true;
            this.lblPaymentSuccessfulTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblPaymentSuccessfulTitle.Location = new System.Drawing.Point(207, 27);
            this.lblPaymentSuccessfulTitle.Name = "lblPaymentSuccessfulTitle";
            this.lblPaymentSuccessfulTitle.Size = new System.Drawing.Size(383, 46);
            this.lblPaymentSuccessfulTitle.TabIndex = 2;
            this.lblPaymentSuccessfulTitle.Text = "Payment Successful";
            // 
            // approvedPBox
            // 
            this.approvedPBox.Location = new System.Drawing.Point(288, 112);
            this.approvedPBox.Name = "approvedPBox";
            this.approvedPBox.Size = new System.Drawing.Size(204, 199);
            this.approvedPBox.TabIndex = 0;
            this.approvedPBox.TabStop = false;
            // 
            // CustomerSuccessfulPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPaymentSuccessfulTitle);
            this.Controls.Add(this.homePageBtn);
            this.Controls.Add(this.approvedPBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerSuccessfulPayment";
            this.Text = "CustomerSuccessfulPayment";
            ((System.ComponentModel.ISupportInitialize)(this.approvedPBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox approvedPBox;
        private System.Windows.Forms.Button homePageBtn;
        private System.Windows.Forms.Label lblPaymentSuccessfulTitle;
    }
}