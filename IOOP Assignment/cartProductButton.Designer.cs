namespace IOOP_Assignment
{
    partial class cartProductButton
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductSpecialInstructions = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblProductQuantity = new System.Windows.Forms.Label();
            this.deleteBtnPnl = new System.Windows.Forms.Panel();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.productImagePBox = new System.Windows.Forms.PictureBox();
            this.deleteBtnPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productImagePBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblProductName.Location = new System.Drawing.Point(280, 25);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(125, 29);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Fried Rice";
            // 
            // lblProductSpecialInstructions
            // 
            this.lblProductSpecialInstructions.AutoSize = true;
            this.lblProductSpecialInstructions.Location = new System.Drawing.Point(288, 91);
            this.lblProductSpecialInstructions.MaximumSize = new System.Drawing.Size(300, 50);
            this.lblProductSpecialInstructions.Name = "lblProductSpecialInstructions";
            this.lblProductSpecialInstructions.Size = new System.Drawing.Size(96, 20);
            this.lblProductSpecialInstructions.TabIndex = 2;
            this.lblProductSpecialInstructions.Text = "More onions";
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblProductPrice.Location = new System.Drawing.Point(556, 60);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(80, 25);
            this.lblProductPrice.TabIndex = 3;
            this.lblProductPrice.Text = "RM5.00";
            // 
            // lblProductQuantity
            // 
            this.lblProductQuantity.AutoSize = true;
            this.lblProductQuantity.Location = new System.Drawing.Point(38, 64);
            this.lblProductQuantity.Name = "lblProductQuantity";
            this.lblProductQuantity.Size = new System.Drawing.Size(18, 20);
            this.lblProductQuantity.TabIndex = 4;
            this.lblProductQuantity.Text = "1";
            // 
            // deleteBtnPnl
            // 
            this.deleteBtnPnl.Controls.Add(this.deleteBtn);
            this.deleteBtnPnl.Location = new System.Drawing.Point(642, 45);
            this.deleteBtnPnl.Name = "deleteBtnPnl";
            this.deleteBtnPnl.Size = new System.Drawing.Size(46, 56);
            this.deleteBtnPnl.TabIndex = 6;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.DimGray;
            this.deleteBtn.Image = global::IOOP_Assignment.Properties.Resources.recycle_bin;
            this.deleteBtn.Location = new System.Drawing.Point(-3, -7);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(54, 66);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // productImagePBox
            // 
            this.productImagePBox.Image = global::IOOP_Assignment.Properties.Resources.burgerImage;
            this.productImagePBox.Location = new System.Drawing.Point(103, 0);
            this.productImagePBox.Name = "productImagePBox";
            this.productImagePBox.Size = new System.Drawing.Size(170, 150);
            this.productImagePBox.TabIndex = 0;
            this.productImagePBox.TabStop = false;
            // 
            // cartProductButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deleteBtnPnl);
            this.Controls.Add(this.lblProductQuantity);
            this.Controls.Add(this.lblProductPrice);
            this.Controls.Add(this.lblProductSpecialInstructions);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.productImagePBox);
            this.Name = "cartProductButton";
            this.Size = new System.Drawing.Size(700, 150);
            this.deleteBtnPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productImagePBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox productImagePBox;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductSpecialInstructions;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblProductQuantity;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Panel deleteBtnPnl;
    }
}
