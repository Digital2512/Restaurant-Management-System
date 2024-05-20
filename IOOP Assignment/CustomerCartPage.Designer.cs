namespace IOOP_Assignment
{
    partial class CustomerCartPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerCartPage));
            this.headerPnl = new System.Windows.Forms.Panel();
            this.backBtnPnl = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.cartDetailsPnl = new System.Windows.Forms.Panel();
            this.cartProductShowFlowPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSubtotalAmountTitle = new System.Windows.Forms.Label();
            this.lblTaxAmountNaming = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblTotalAmountNaming = new System.Windows.Forms.Label();
            this.lblSubtotalAmount = new System.Windows.Forms.Label();
            this.lblTaxAmount = new System.Windows.Forms.Label();
            this.payBtn = new System.Windows.Forms.Button();
            this.headerPnl.SuspendLayout();
            this.backBtnPnl.SuspendLayout();
            this.cartDetailsPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPnl
            // 
            this.headerPnl.BackColor = System.Drawing.Color.DimGray;
            this.headerPnl.Controls.Add(this.backBtnPnl);
            this.headerPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPnl.Location = new System.Drawing.Point(0, 0);
            this.headerPnl.Name = "headerPnl";
            this.headerPnl.Size = new System.Drawing.Size(800, 45);
            this.headerPnl.TabIndex = 4;
            // 
            // backBtnPnl
            // 
            this.backBtnPnl.Controls.Add(this.backButton);
            this.backBtnPnl.Location = new System.Drawing.Point(1, 0);
            this.backBtnPnl.Name = "backBtnPnl";
            this.backBtnPnl.Size = new System.Drawing.Size(36, 55);
            this.backBtnPnl.TabIndex = 1;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.DimGray;
            this.backButton.ForeColor = System.Drawing.Color.Transparent;
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.Location = new System.Drawing.Point(-34, -7);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(104, 59);
            this.backButton.TabIndex = 0;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // cartDetailsPnl
            // 
            this.cartDetailsPnl.AutoScroll = true;
            this.cartDetailsPnl.Controls.Add(this.cartProductShowFlowPnl);
            this.cartDetailsPnl.Location = new System.Drawing.Point(13, 62);
            this.cartDetailsPnl.Name = "cartDetailsPnl";
            this.cartDetailsPnl.Size = new System.Drawing.Size(775, 253);
            this.cartDetailsPnl.TabIndex = 5;
            // 
            // cartProductShowFlowPnl
            // 
            this.cartProductShowFlowPnl.AutoSize = true;
            this.cartProductShowFlowPnl.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.cartProductShowFlowPnl.Location = new System.Drawing.Point(0, 0);
            this.cartProductShowFlowPnl.Name = "cartProductShowFlowPnl";
            this.cartProductShowFlowPnl.Size = new System.Drawing.Size(784, 250);
            this.cartProductShowFlowPnl.TabIndex = 0;
            // 
            // lblSubtotalAmountTitle
            // 
            this.lblSubtotalAmountTitle.AutoSize = true;
            this.lblSubtotalAmountTitle.Location = new System.Drawing.Point(16, 322);
            this.lblSubtotalAmountTitle.Name = "lblSubtotalAmountTitle";
            this.lblSubtotalAmountTitle.Size = new System.Drawing.Size(137, 20);
            this.lblSubtotalAmountTitle.TabIndex = 6;
            this.lblSubtotalAmountTitle.Text = "Subtotal Amount: ";
            // 
            // lblTaxAmountNaming
            // 
            this.lblTaxAmountNaming.AutoSize = true;
            this.lblTaxAmountNaming.Location = new System.Drawing.Point(16, 356);
            this.lblTaxAmountNaming.Name = "lblTaxAmountNaming";
            this.lblTaxAmountNaming.Size = new System.Drawing.Size(108, 20);
            this.lblTaxAmountNaming.TabIndex = 7;
            this.lblTaxAmountNaming.Text = "Tax (GST 6%)";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalAmount.Location = new System.Drawing.Point(688, 440);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(2, 22);
            this.lblTotalAmount.TabIndex = 9;
            // 
            // lblTotalAmountNaming
            // 
            this.lblTotalAmountNaming.AutoSize = true;
            this.lblTotalAmountNaming.Location = new System.Drawing.Point(565, 440);
            this.lblTotalAmountNaming.Name = "lblTotalAmountNaming";
            this.lblTotalAmountNaming.Size = new System.Drawing.Size(112, 20);
            this.lblTotalAmountNaming.TabIndex = 10;
            this.lblTotalAmountNaming.Text = "Total Amount: ";
            // 
            // lblSubtotalAmount
            // 
            this.lblSubtotalAmount.AutoSize = true;
            this.lblSubtotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSubtotalAmount.Location = new System.Drawing.Point(688, 322);
            this.lblSubtotalAmount.Name = "lblSubtotalAmount";
            this.lblSubtotalAmount.Size = new System.Drawing.Size(2, 22);
            this.lblSubtotalAmount.TabIndex = 11;
            // 
            // lblTaxAmount
            // 
            this.lblTaxAmount.AutoSize = true;
            this.lblTaxAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTaxAmount.Location = new System.Drawing.Point(688, 356);
            this.lblTaxAmount.Name = "lblTaxAmount";
            this.lblTaxAmount.Size = new System.Drawing.Size(2, 22);
            this.lblTaxAmount.TabIndex = 12;
            // 
            // payBtn
            // 
            this.payBtn.Location = new System.Drawing.Point(-4, 482);
            this.payBtn.Name = "payBtn";
            this.payBtn.Size = new System.Drawing.Size(804, 62);
            this.payBtn.TabIndex = 13;
            this.payBtn.Text = "Pay";
            this.payBtn.UseVisualStyleBackColor = true;
            this.payBtn.Click += new System.EventHandler(this.payBtn_Click);
            // 
            // CustomerCartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 542);
            this.Controls.Add(this.payBtn);
            this.Controls.Add(this.lblTaxAmount);
            this.Controls.Add(this.lblSubtotalAmount);
            this.Controls.Add(this.lblTotalAmountNaming);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblTaxAmountNaming);
            this.Controls.Add(this.lblSubtotalAmountTitle);
            this.Controls.Add(this.cartDetailsPnl);
            this.Controls.Add(this.headerPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerCartPage";
            this.Text = "CustomerCartPage";
            this.headerPnl.ResumeLayout(false);
            this.backBtnPnl.ResumeLayout(false);
            this.cartDetailsPnl.ResumeLayout(false);
            this.cartDetailsPnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Panel headerPnl;
        private System.Windows.Forms.Panel backBtnPnl;
        private System.Windows.Forms.Panel cartDetailsPnl;
        private System.Windows.Forms.FlowLayoutPanel cartProductShowFlowPnl;
        private System.Windows.Forms.Label lblSubtotalAmountTitle;
        private System.Windows.Forms.Label lblTaxAmountNaming;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblTotalAmountNaming;
        private System.Windows.Forms.Label lblSubtotalAmount;
        private System.Windows.Forms.Label lblTaxAmount;
        private System.Windows.Forms.Button payBtn;
    }
}