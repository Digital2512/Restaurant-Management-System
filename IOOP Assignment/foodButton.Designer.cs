namespace IOOP_Assignment
{
    partial class foodButton
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(foodButton));
            this.lblProductID = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductDescription = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.productImagePBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.productImagePBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.lblProductID.Location = new System.Drawing.Point(21, 10);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(64, 15);
            this.lblProductID.TabIndex = 1;
            this.lblProductID.Text = "Product ID";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblProductName.Location = new System.Drawing.Point(16, 33);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(150, 25);
            this.lblProductName.TabIndex = 2;
            this.lblProductName.Text = "Product\'s Name";
            // 
            // lblProductDescription
            // 
            this.lblProductDescription.AutoSize = true;
            this.lblProductDescription.Location = new System.Drawing.Point(18, 114);
            this.lblProductDescription.MaximumSize = new System.Drawing.Size(250, 100);
            this.lblProductDescription.Name = "lblProductDescription";
            this.lblProductDescription.Size = new System.Drawing.Size(247, 100);
            this.lblProductDescription.TabIndex = 3;
            this.lblProductDescription.Text = resources.GetString("lblProductDescription.Text");
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblProductPrice.Location = new System.Drawing.Point(17, 67);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(114, 20);
            this.lblProductPrice.TabIndex = 4;
            this.lblProductPrice.Text = "Product\'s Price";
            // 
            // productImagePBox
            // 
            this.productImagePBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.productImagePBox.Image = global::IOOP_Assignment.Properties.Resources.pastaImage;
            this.productImagePBox.Location = new System.Drawing.Point(325, 0);
            this.productImagePBox.Name = "productImagePBox";
            this.productImagePBox.Size = new System.Drawing.Size(150, 150);
            this.productImagePBox.TabIndex = 0;
            this.productImagePBox.TabStop = false;
            this.productImagePBox.Click += new System.EventHandler(this.productImagePBox_Click);
            // 
            // foodButton
            // 
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.lblProductPrice);
            this.Controls.Add(this.lblProductDescription);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.productImagePBox);
            this.Name = "foodButton";
            this.Size = new System.Drawing.Size(475, 150);
            this.Load += new System.EventHandler(this.foodButton_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productImagePBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductDescription;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.PictureBox productImagePBox;
    }
}
