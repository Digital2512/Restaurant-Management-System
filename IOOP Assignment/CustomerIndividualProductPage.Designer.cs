namespace IOOP_Assignment
{
    partial class CustomerIndividualProductPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerIndividualProductPage));
            this.headerPnl = new System.Windows.Forms.Panel();
            this.backBtnPnl = new System.Windows.Forms.Panel();
            this.minusBtn = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.lblProductQuantity = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addToCartBtn = new System.Windows.Forms.Button();
            this.specialInstructionsRTxtBox = new System.Windows.Forms.RichTextBox();
            this.lblProductID = new System.Windows.Forms.Label();
            this.lblSpecialInstructions = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductDescription = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.productImagePBox = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.Button();
            this.headerPnl.SuspendLayout();
            this.backBtnPnl.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productImagePBox)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPnl
            // 
            this.headerPnl.BackColor = System.Drawing.Color.DimGray;
            this.headerPnl.Controls.Add(this.backBtnPnl);
            this.headerPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPnl.Location = new System.Drawing.Point(0, 0);
            this.headerPnl.Name = "headerPnl";
            this.headerPnl.Size = new System.Drawing.Size(594, 45);
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
            // minusBtn
            // 
            this.minusBtn.Location = new System.Drawing.Point(22, 705);
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.Size = new System.Drawing.Size(41, 34);
            this.minusBtn.TabIndex = 7;
            this.minusBtn.Text = "-";
            this.minusBtn.UseVisualStyleBackColor = true;
            this.minusBtn.Click += new System.EventHandler(this.minusBtn_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(145, 705);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(41, 34);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // lblProductQuantity
            // 
            this.lblProductQuantity.AutoSize = true;
            this.lblProductQuantity.Location = new System.Drawing.Point(94, 711);
            this.lblProductQuantity.Name = "lblProductQuantity";
            this.lblProductQuantity.Size = new System.Drawing.Size(18, 20);
            this.lblProductQuantity.TabIndex = 9;
            this.lblProductQuantity.Text = "1";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.addToCartBtn);
            this.panel2.Controls.Add(this.productImagePBox);
            this.panel2.Controls.Add(this.addButton);
            this.panel2.Controls.Add(this.lblProductQuantity);
            this.panel2.Controls.Add(this.specialInstructionsRTxtBox);
            this.panel2.Controls.Add(this.lblProductID);
            this.panel2.Controls.Add(this.minusBtn);
            this.panel2.Controls.Add(this.lblSpecialInstructions);
            this.panel2.Controls.Add(this.lblProductName);
            this.panel2.Controls.Add(this.lblProductDescription);
            this.panel2.Controls.Add(this.lblProductPrice);
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(596, 737);
            this.panel2.TabIndex = 10;
            // 
            // addToCartBtn
            // 
            this.addToCartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToCartBtn.Location = new System.Drawing.Point(216, 697);
            this.addToCartBtn.Name = "addToCartBtn";
            this.addToCartBtn.Size = new System.Drawing.Size(352, 53);
            this.addToCartBtn.TabIndex = 15;
            this.addToCartBtn.Text = "ADD TO CART";
            this.addToCartBtn.UseVisualStyleBackColor = true;
            this.addToCartBtn.Click += new System.EventHandler(this.addToCartBtn_Click);
            // 
            // specialInstructionsRTxtBox
            // 
            this.specialInstructionsRTxtBox.Location = new System.Drawing.Point(20, 608);
            this.specialInstructionsRTxtBox.Name = "specialInstructionsRTxtBox";
            this.specialInstructionsRTxtBox.Size = new System.Drawing.Size(548, 91);
            this.specialInstructionsRTxtBox.TabIndex = 13;
            this.specialInstructionsRTxtBox.Text = "";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(16, 345);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(55, 20);
            this.lblProductID.TabIndex = 8;
            this.lblProductID.Text = "P0001";
            // 
            // lblSpecialInstructions
            // 
            this.lblSpecialInstructions.AutoSize = true;
            this.lblSpecialInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSpecialInstructions.Location = new System.Drawing.Point(17, 576);
            this.lblSpecialInstructions.Name = "lblSpecialInstructions";
            this.lblSpecialInstructions.Size = new System.Drawing.Size(192, 25);
            this.lblSpecialInstructions.TabIndex = 12;
            this.lblSpecialInstructions.Text = "Special Instructions: ";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblProductName.Location = new System.Drawing.Point(12, 368);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(125, 29);
            this.lblProductName.TabIndex = 9;
            this.lblProductName.Text = "Fried Rice";
            // 
            // lblProductDescription
            // 
            this.lblProductDescription.AutoSize = true;
            this.lblProductDescription.Location = new System.Drawing.Point(16, 477);
            this.lblProductDescription.MaximumSize = new System.Drawing.Size(550, 80);
            this.lblProductDescription.Name = "lblProductDescription";
            this.lblProductDescription.Size = new System.Drawing.Size(539, 80);
            this.lblProductDescription.TabIndex = 11;
            this.lblProductDescription.Text = resources.GetString("lblProductDescription.Text");
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblProductPrice.Location = new System.Drawing.Point(15, 408);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(80, 25);
            this.lblProductPrice.TabIndex = 10;
            this.lblProductPrice.Text = "RM5.00";
            // 
            // productImagePBox
            // 
            //this.productImagePBox.Image = global::IOOP_Assignment.Properties.Resources.errorImage;
            this.productImagePBox.Location = new System.Drawing.Point(0, 0);
            this.productImagePBox.Name = "productImagePBox";
            this.productImagePBox.Size = new System.Drawing.Size(596, 334);
            this.productImagePBox.TabIndex = 14;
            this.productImagePBox.TabStop = false;
            this.productImagePBox.Click += new System.EventHandler(this.productImagePBox_Click);
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
            // CustomerIndividualProductPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 775);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.headerPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerIndividualProductPage";
            this.Text = "customerIndividualProductView";
            this.headerPnl.ResumeLayout(false);
            this.backBtnPnl.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productImagePBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Panel headerPnl;
        private System.Windows.Forms.Panel backBtnPnl;
        private System.Windows.Forms.Button minusBtn;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label lblProductQuantity;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox productImagePBox;
        private System.Windows.Forms.RichTextBox specialInstructionsRTxtBox;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Label lblSpecialInstructions;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductDescription;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Button addToCartBtn;
    }
}