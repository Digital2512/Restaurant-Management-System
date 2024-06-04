namespace IOOP_Assignment
{
    partial class CustomerFeedbackPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerFeedbackPage));
            this.lblFeedbackForm = new System.Windows.Forms.Label();
            this.feedbackFormDetailsPnl = new System.Windows.Forms.Panel();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.descriptionRBox = new System.Windows.Forms.RichTextBox();
            this.topicCBox = new System.Windows.Forms.ComboBox();
            this.lblFeedbackDescription = new System.Windows.Forms.Label();
            this.titleTxtBox = new System.Windows.Forms.TextBox();
            this.lblFeedbackTitle = new System.Windows.Forms.Label();
            this.lblFeedbackTopic = new System.Windows.Forms.Label();
            this.lblFeedbackCustomerID = new System.Windows.Forms.Label();
            this.sendBtn = new System.Windows.Forms.Button();
            this.headerPnl = new System.Windows.Forms.Panel();
            this.backBtnPnl = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Button();
            this.feedbackFormDetailsPnl.SuspendLayout();
            this.headerPnl.SuspendLayout();
            this.backBtnPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFeedbackForm
            // 
            this.lblFeedbackForm.AutoSize = true;
            this.lblFeedbackForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedbackForm.Location = new System.Drawing.Point(237, 67);
            this.lblFeedbackForm.Name = "lblFeedbackForm";
            this.lblFeedbackForm.Size = new System.Drawing.Size(377, 46);
            this.lblFeedbackForm.TabIndex = 0;
            this.lblFeedbackForm.Text = "FEEDBACK FORM";
            // 
            // feedbackFormDetailsPnl
            // 
            this.feedbackFormDetailsPnl.Controls.Add(this.lblCustomerID);
            this.feedbackFormDetailsPnl.Controls.Add(this.descriptionRBox);
            this.feedbackFormDetailsPnl.Controls.Add(this.topicCBox);
            this.feedbackFormDetailsPnl.Controls.Add(this.lblFeedbackDescription);
            this.feedbackFormDetailsPnl.Controls.Add(this.titleTxtBox);
            this.feedbackFormDetailsPnl.Controls.Add(this.lblFeedbackTitle);
            this.feedbackFormDetailsPnl.Controls.Add(this.lblFeedbackTopic);
            this.feedbackFormDetailsPnl.Controls.Add(this.lblFeedbackCustomerID);
            this.feedbackFormDetailsPnl.Location = new System.Drawing.Point(26, 145);
            this.feedbackFormDetailsPnl.Name = "feedbackFormDetailsPnl";
            this.feedbackFormDetailsPnl.Size = new System.Drawing.Size(799, 391);
            this.feedbackFormDetailsPnl.TabIndex = 1;
            this.feedbackFormDetailsPnl.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCustomerID.Location = new System.Drawing.Point(30, 49);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(2, 27);
            this.lblCustomerID.TabIndex = 10;
            // 
            // descriptionRBox
            // 
            this.descriptionRBox.Location = new System.Drawing.Point(23, 271);
            this.descriptionRBox.Name = "descriptionRBox";
            this.descriptionRBox.Size = new System.Drawing.Size(751, 108);
            this.descriptionRBox.TabIndex = 9;
            this.descriptionRBox.Text = "";
            // 
            // topicCBox
            // 
            this.topicCBox.FormattingEnabled = true;
            this.topicCBox.Items.AddRange(new object[] {
            "Item 1",
            "Item 2"});
            this.topicCBox.Location = new System.Drawing.Point(23, 126);
            this.topicCBox.Name = "topicCBox";
            this.topicCBox.Size = new System.Drawing.Size(751, 28);
            this.topicCBox.TabIndex = 8;
            // 
            // lblFeedbackDescription
            // 
            this.lblFeedbackDescription.AutoSize = true;
            this.lblFeedbackDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedbackDescription.Location = new System.Drawing.Point(21, 239);
            this.lblFeedbackDescription.Name = "lblFeedbackDescription";
            this.lblFeedbackDescription.Size = new System.Drawing.Size(300, 25);
            this.lblFeedbackDescription.TabIndex = 6;
            this.lblFeedbackDescription.Text = "FEEDBACK\'S DESCRIPTION";
            // 
            // titleTxtBox
            // 
            this.titleTxtBox.Location = new System.Drawing.Point(23, 197);
            this.titleTxtBox.Name = "titleTxtBox";
            this.titleTxtBox.Size = new System.Drawing.Size(751, 26);
            this.titleTxtBox.TabIndex = 5;
            // 
            // lblFeedbackTitle
            // 
            this.lblFeedbackTitle.AutoSize = true;
            this.lblFeedbackTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedbackTitle.Location = new System.Drawing.Point(21, 169);
            this.lblFeedbackTitle.Name = "lblFeedbackTitle";
            this.lblFeedbackTitle.Size = new System.Drawing.Size(214, 25);
            this.lblFeedbackTitle.TabIndex = 4;
            this.lblFeedbackTitle.Text = "FEEDBACK\'S TITLE";
            // 
            // lblFeedbackTopic
            // 
            this.lblFeedbackTopic.AutoSize = true;
            this.lblFeedbackTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedbackTopic.Location = new System.Drawing.Point(21, 92);
            this.lblFeedbackTopic.Name = "lblFeedbackTopic";
            this.lblFeedbackTopic.Size = new System.Drawing.Size(221, 25);
            this.lblFeedbackTopic.TabIndex = 2;
            this.lblFeedbackTopic.Text = "FEEDBACK\'S TOPIC";
            // 
            // lblFeedbackCustomerID
            // 
            this.lblFeedbackCustomerID.AutoSize = true;
            this.lblFeedbackCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedbackCustomerID.Location = new System.Drawing.Point(18, 15);
            this.lblFeedbackCustomerID.Name = "lblFeedbackCustomerID";
            this.lblFeedbackCustomerID.Size = new System.Drawing.Size(162, 25);
            this.lblFeedbackCustomerID.TabIndex = 0;
            this.lblFeedbackCustomerID.Text = "CUSTOMER ID";
            // 
            // sendBtn
            // 
            this.sendBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sendBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.sendBtn.Location = new System.Drawing.Point(0, 542);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(853, 54);
            this.sendBtn.TabIndex = 2;
            this.sendBtn.Text = "SEND";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // headerPnl
            // 
            this.headerPnl.BackColor = System.Drawing.Color.DimGray;
            this.headerPnl.Controls.Add(this.backBtnPnl);
            this.headerPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPnl.Location = new System.Drawing.Point(0, 0);
            this.headerPnl.Name = "headerPnl";
            this.headerPnl.Size = new System.Drawing.Size(853, 45);
            this.headerPnl.TabIndex = 3;
            // 
            // backBtnPnl
            // 
            this.backBtnPnl.Controls.Add(this.backBtn);
            this.backBtnPnl.Location = new System.Drawing.Point(1, 0);
            this.backBtnPnl.Name = "backBtnPnl";
            this.backBtnPnl.Size = new System.Drawing.Size(36, 55);
            this.backBtnPnl.TabIndex = 1;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.DimGray;
            this.backBtn.ForeColor = System.Drawing.Color.Transparent;
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(-34, -7);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(104, 59);
            this.backBtn.TabIndex = 0;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backButton_Click);
            // 
            // CustomerFeedbackPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 596);
            this.Controls.Add(this.headerPnl);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.feedbackFormDetailsPnl);
            this.Controls.Add(this.lblFeedbackForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerFeedbackPage";
            this.Text = "CustomerFeedbackPage";
            this.feedbackFormDetailsPnl.ResumeLayout(false);
            this.feedbackFormDetailsPnl.PerformLayout();
            this.headerPnl.ResumeLayout(false);
            this.backBtnPnl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFeedbackForm;
        private System.Windows.Forms.Panel feedbackFormDetailsPnl;
        private System.Windows.Forms.RichTextBox descriptionRBox;
        private System.Windows.Forms.ComboBox topicCBox;
        private System.Windows.Forms.Label lblFeedbackDescription;
        private System.Windows.Forms.TextBox titleTxtBox;
        private System.Windows.Forms.Label lblFeedbackTitle;
        private System.Windows.Forms.Label lblFeedbackTopic;
        private System.Windows.Forms.Label lblFeedbackCustomerID;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Panel headerPnl;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Panel backBtnPnl;
        private System.Windows.Forms.Label lblCustomerID;
    }
}