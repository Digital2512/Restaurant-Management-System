namespace IOOP_Assignment
{
    partial class frmAddPro
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
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProName = new System.Windows.Forms.TextBox();
            this.txtDesp = new System.Windows.Forms.TextBox();
            this.lblProDesc = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblProPrice = new System.Windows.Forms.Label();
            this.txtCat = new System.Windows.Forms.TextBox();
            this.lblProCat = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUdpatePro = new System.Windows.Forms.Button();
            this.btnCancelPro = new System.Windows.Forms.Button();
            this.lblProID = new System.Windows.Forms.Label();
            this.txtProID = new System.Windows.Forms.TextBox();
            this.txtRcpID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(36, 31);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(119, 32);
            this.lblProduct.TabIndex = 2;
            this.lblProduct.Text = "Product";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(345, 126);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(55, 20);
            this.lblProductName.TabIndex = 3;
            this.lblProductName.Text = "Name:";
            // 
            // txtProName
            // 
            this.txtProName.Location = new System.Drawing.Point(415, 123);
            this.txtProName.Name = "txtProName";
            this.txtProName.Size = new System.Drawing.Size(100, 26);
            this.txtProName.TabIndex = 4;
            // 
            // txtDesp
            // 
            this.txtDesp.Location = new System.Drawing.Point(415, 179);
            this.txtDesp.Name = "txtDesp";
            this.txtDesp.Size = new System.Drawing.Size(142, 26);
            this.txtDesp.TabIndex = 6;
            // 
            // lblProDesc
            // 
            this.lblProDesc.AutoSize = true;
            this.lblProDesc.Location = new System.Drawing.Point(307, 182);
            this.lblProDesc.Name = "lblProDesc";
            this.lblProDesc.Size = new System.Drawing.Size(93, 20);
            this.lblProDesc.TabIndex = 5;
            this.lblProDesc.Text = "Description:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(415, 236);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 26);
            this.txtPrice.TabIndex = 8;
            // 
            // lblProPrice
            // 
            this.lblProPrice.AutoSize = true;
            this.lblProPrice.Location = new System.Drawing.Point(352, 239);
            this.lblProPrice.Name = "lblProPrice";
            this.lblProPrice.Size = new System.Drawing.Size(48, 20);
            this.lblProPrice.TabIndex = 7;
            this.lblProPrice.Text = "Price:";
            // 
            // txtCat
            // 
            this.txtCat.Location = new System.Drawing.Point(415, 289);
            this.txtCat.Name = "txtCat";
            this.txtCat.Size = new System.Drawing.Size(100, 26);
            this.txtCat.TabIndex = 14;
            // 
            // lblProCat
            // 
            this.lblProCat.AutoSize = true;
            this.lblProCat.Location = new System.Drawing.Point(310, 292);
            this.lblProCat.Name = "lblProCat";
            this.lblProCat.Size = new System.Drawing.Size(90, 20);
            this.lblProCat.TabIndex = 13;
            this.lblProCat.Text = "Categories:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(51, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 98);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btnUdpatePro
            // 
            this.btnUdpatePro.Location = new System.Drawing.Point(349, 385);
            this.btnUdpatePro.Name = "btnUdpatePro";
            this.btnUdpatePro.Size = new System.Drawing.Size(78, 34);
            this.btnUdpatePro.TabIndex = 16;
            this.btnUdpatePro.Text = "Save";
            this.btnUdpatePro.UseVisualStyleBackColor = true;
            this.btnUdpatePro.Click += new System.EventHandler(this.btnSavePro_Click);
            // 
            // btnCancelPro
            // 
            this.btnCancelPro.Location = new System.Drawing.Point(464, 385);
            this.btnCancelPro.Name = "btnCancelPro";
            this.btnCancelPro.Size = new System.Drawing.Size(79, 34);
            this.btnCancelPro.TabIndex = 17;
            this.btnCancelPro.Text = "Cancel";
            this.btnCancelPro.UseVisualStyleBackColor = true;
            // 
            // lblProID
            // 
            this.lblProID.AutoSize = true;
            this.lblProID.Location = new System.Drawing.Point(315, 84);
            this.lblProID.Name = "lblProID";
            this.lblProID.Size = new System.Drawing.Size(85, 20);
            this.lblProID.TabIndex = 18;
            this.lblProID.Text = "ProductID:";
            // 
            // txtProID
            // 
            this.txtProID.Location = new System.Drawing.Point(415, 84);
            this.txtProID.Name = "txtProID";
            this.txtProID.Size = new System.Drawing.Size(100, 26);
            this.txtProID.TabIndex = 19;
            // 
            // txtRcpID
            // 
            this.txtRcpID.Location = new System.Drawing.Point(415, 330);
            this.txtRcpID.Name = "txtRcpID";
            this.txtRcpID.Size = new System.Drawing.Size(100, 26);
            this.txtRcpID.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "RecipeID:";
            // 
            // frmAddPro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRcpID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProID);
            this.Controls.Add(this.lblProID);
            this.Controls.Add(this.btnCancelPro);
            this.Controls.Add(this.btnUdpatePro);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtCat);
            this.Controls.Add(this.lblProCat);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblProPrice);
            this.Controls.Add(this.txtDesp);
            this.Controls.Add(this.lblProDesc);
            this.Controls.Add(this.txtProName);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblProduct);
            this.Name = "frmAddPro";
            this.Text = "Add Product";
            this.Load += new System.EventHandler(this.frmAddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProName;
        private System.Windows.Forms.TextBox txtDesp;
        private System.Windows.Forms.Label lblProDesc;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblProPrice;
        private System.Windows.Forms.TextBox txtCat;
        private System.Windows.Forms.Label lblProCat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnUdpatePro;
        private System.Windows.Forms.Button btnCancelPro;
        private System.Windows.Forms.Label lblProID;
        private System.Windows.Forms.TextBox txtProID;
        private System.Windows.Forms.TextBox txtRcpID;
        private System.Windows.Forms.Label label1;
    }
}