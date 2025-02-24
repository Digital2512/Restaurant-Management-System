﻿namespace IOOP_Assignment
{
    partial class ManagerMenuPage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.picMenu = new System.Windows.Forms.PictureBox();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.dataGridViewMenu = new System.Windows.Forms.DataGridView();
            this.cbbCuisine = new System.Windows.Forms.ComboBox();
            this.txtProductDesc = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblCuisine = new System.Windows.Forms.Label();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.lblProPrice = new System.Windows.Forms.Label();
            this.lblProID = new System.Windows.Forms.Label();
            this.lblProDesc = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Controls.Add(this.picMenu);
            this.panel1.Controls.Add(this.txtSearchProduct);
            this.panel1.Controls.Add(this.dataGridViewMenu);
            this.panel1.Controls.Add(this.cbbCuisine);
            this.panel1.Controls.Add(this.txtProductDesc);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.lblCuisine);
            this.panel1.Controls.Add(this.txtProductPrice);
            this.panel1.Controls.Add(this.lblProPrice);
            this.panel1.Controls.Add(this.lblProID);
            this.panel1.Controls.Add(this.lblProDesc);
            this.panel1.Controls.Add(this.txtProductName);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.btnUpload);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 489);
            this.panel1.TabIndex = 1;
            // 
            // picMenu
            // 
            this.picMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMenu.Image = global::IOOP_Assignment.Properties.Resources.FoodIcon1;
            this.picMenu.Location = new System.Drawing.Point(86, 281);
            this.picMenu.Name = "picMenu";
            this.picMenu.Size = new System.Drawing.Size(140, 140);
            this.picMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMenu.TabIndex = 21;
            this.picMenu.TabStop = false;
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.ForeColor = System.Drawing.Color.DarkGray;
            this.txtSearchProduct.Location = new System.Drawing.Point(648, 13);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(126, 26);
            this.txtSearchProduct.TabIndex = 26;
            this.txtSearchProduct.Text = "Search...";
            this.txtSearchProduct.TextChanged += new System.EventHandler(this.txtSearchProduct_TextChanged);
            this.txtSearchProduct.Enter += new System.EventHandler(this.txtSearchProduct_Enter);
            this.txtSearchProduct.Leave += new System.EventHandler(this.txtSearchProduct_Leave);
            // 
            // dataGridViewMenu
            // 
            this.dataGridViewMenu.BackgroundColor = System.Drawing.Color.Bisque;
            this.dataGridViewMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMenu.Location = new System.Drawing.Point(63, 53);
            this.dataGridViewMenu.Name = "dataGridViewMenu";
            this.dataGridViewMenu.RowHeadersWidth = 62;
            this.dataGridViewMenu.RowTemplate.Height = 28;
            this.dataGridViewMenu.Size = new System.Drawing.Size(748, 201);
            this.dataGridViewMenu.TabIndex = 25;
            this.dataGridViewMenu.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewMenu_RowHeaderMouseClick);
            // 
            // cbbCuisine
            // 
            this.cbbCuisine.FormattingEnabled = true;
            this.cbbCuisine.Items.AddRange(new object[] {
            "Japanese",
            "Western",
            "Korean",
            "Beverages"});
            this.cbbCuisine.Location = new System.Drawing.Point(677, 379);
            this.cbbCuisine.Name = "cbbCuisine";
            this.cbbCuisine.Size = new System.Drawing.Size(117, 28);
            this.cbbCuisine.TabIndex = 24;
            this.cbbCuisine.Text = "Select";
            // 
            // txtProductDesc
            // 
            this.txtProductDesc.Location = new System.Drawing.Point(373, 379);
            this.txtProductDesc.Name = "txtProductDesc";
            this.txtProductDesc.Size = new System.Drawing.Size(167, 26);
            this.txtProductDesc.TabIndex = 23;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::IOOP_Assignment.Properties.Resources.searchIcon;
            this.btnSearch.Location = new System.Drawing.Point(780, 9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(34, 34);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.PeachPuff;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Location = new System.Drawing.Point(692, 434);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 38);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.PeachPuff;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Location = new System.Drawing.Point(373, 434);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 38);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.PeachPuff;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Location = new System.Drawing.Point(527, 434);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 38);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblCuisine
            // 
            this.lblCuisine.AutoSize = true;
            this.lblCuisine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuisine.Location = new System.Drawing.Point(590, 380);
            this.lblCuisine.Name = "lblCuisine";
            this.lblCuisine.Size = new System.Drawing.Size(75, 22);
            this.lblCuisine.TabIndex = 13;
            this.lblCuisine.Text = "Cuisine:";
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(677, 334);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(117, 26);
            this.txtProductPrice.TabIndex = 11;
            // 
            // lblProPrice
            // 
            this.lblProPrice.AutoSize = true;
            this.lblProPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProPrice.Location = new System.Drawing.Point(609, 335);
            this.lblProPrice.Name = "lblProPrice";
            this.lblProPrice.Size = new System.Drawing.Size(56, 22);
            this.lblProPrice.TabIndex = 10;
            this.lblProPrice.Text = "Price:";
            // 
            // lblProID
            // 
            this.lblProID.AutoSize = true;
            this.lblProID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProID.Location = new System.Drawing.Point(268, 290);
            this.lblProID.Name = "lblProID";
            this.lblProID.Size = new System.Drawing.Size(99, 22);
            this.lblProID.TabIndex = 8;
            this.lblProID.Text = "Product ID:";
            // 
            // lblProDesc
            // 
            this.lblProDesc.AutoSize = true;
            this.lblProDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProDesc.Location = new System.Drawing.Point(262, 379);
            this.lblProDesc.Name = "lblProDesc";
            this.lblProDesc.Size = new System.Drawing.Size(105, 22);
            this.lblProDesc.TabIndex = 7;
            this.lblProDesc.Text = "Description:";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(373, 333);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(167, 26);
            this.txtProductName.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(305, 334);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 22);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name:";
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.PeachPuff;
            this.btnUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpload.Location = new System.Drawing.Point(113, 427);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(90, 38);
            this.btnUpload.TabIndex = 2;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menu";
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = global::IOOP_Assignment.Properties.Resources.exitIcon1;
            this.btnExit.Location = new System.Drawing.Point(823, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 40);
            this.btnExit.TabIndex = 5;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SandyBrown;
            this.pictureBox1.Image = global::IOOP_Assignment.Properties.Resources.menuIcon1;
            this.pictureBox1.Location = new System.Drawing.Point(474, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ManagerMenuPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(875, 620);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagerMenuPage";
            this.Text = "ManagerMenu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label lblCuisine;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.Label lblProPrice;
        private System.Windows.Forms.Label lblProID;
        private System.Windows.Forms.Label lblProDesc;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.PictureBox picMenu;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtProductDesc;
        private System.Windows.Forms.ComboBox cbbCuisine;
        private System.Windows.Forms.DataGridView dataGridViewMenu;
        private System.Windows.Forms.TextBox txtSearchProduct;
    }
}