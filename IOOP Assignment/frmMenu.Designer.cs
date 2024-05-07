namespace IOOP_Assignment
{
    partial class frmMenu
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
            this.components = new System.ComponentModel.Container();
            this.txtSearchMenu = new System.Windows.Forms.TextBox();
            this.lblMenu = new System.Windows.Forms.Label();
            this.menuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iOOPDatabaseDataSet1 = new IOOP_Assignment.IOOPDatabaseDataSet1();
            this.iOOPDatabaseDataSet = new IOOP_Assignment.IOOPDatabaseDataSet();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtProID = new System.Windows.Forms.TextBox();
            this.lblProID = new System.Windows.Forms.Label();
            this.txtCat = new System.Windows.Forms.TextBox();
            this.lblProCat = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblProPrice = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblProDesc = new System.Windows.Forms.Label();
            this.txtProName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.menuTableAdapter = new IOOP_Assignment.IOOPDatabaseDataSetTableAdapters.MenuTableAdapter();
            this.btnUpload = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.picProfile = new System.Windows.Forms.PictureBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.menuTableAdapter1 = new IOOP_Assignment.IOOPDatabaseDataSet1TableAdapters.MenuTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOPDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOPDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchMenu
            // 
            this.txtSearchMenu.Location = new System.Drawing.Point(904, 19);
            this.txtSearchMenu.Name = "txtSearchMenu";
            this.txtSearchMenu.Size = new System.Drawing.Size(100, 26);
            this.txtSearchMenu.TabIndex = 0;
            this.txtSearchMenu.Text = "Search";
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(77, 14);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(89, 32);
            this.lblMenu.TabIndex = 1;
            this.lblMenu.Text = "Menu";
            // 
            // menuBindingSource
            // 
            this.menuBindingSource.DataMember = "Menu";
            this.menuBindingSource.DataSource = this.iOOPDatabaseDataSet1;
            // 
            // iOOPDatabaseDataSet1
            // 
            this.iOOPDatabaseDataSet1.DataSetName = "IOOPDatabaseDataSet1";
            this.iOOPDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iOOPDatabaseDataSet
            // 
            this.iOOPDatabaseDataSet.DataSetName = "IOOPDatabaseDataSet";
            this.iOOPDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(856, 609);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(77, 32);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // txtProID
            // 
            this.txtProID.Location = new System.Drawing.Point(523, 438);
            this.txtProID.Name = "txtProID";
            this.txtProID.Size = new System.Drawing.Size(100, 26);
            this.txtProID.TabIndex = 32;
            // 
            // lblProID
            // 
            this.lblProID.AutoSize = true;
            this.lblProID.Location = new System.Drawing.Point(423, 438);
            this.lblProID.Name = "lblProID";
            this.lblProID.Size = new System.Drawing.Size(85, 20);
            this.lblProID.TabIndex = 31;
            this.lblProID.Text = "ProductID:";
            // 
            // txtCat
            // 
            this.txtCat.Location = new System.Drawing.Point(846, 488);
            this.txtCat.Name = "txtCat";
            this.txtCat.Size = new System.Drawing.Size(100, 26);
            this.txtCat.TabIndex = 29;
            // 
            // lblProCat
            // 
            this.lblProCat.AutoSize = true;
            this.lblProCat.Location = new System.Drawing.Point(741, 491);
            this.lblProCat.Name = "lblProCat";
            this.lblProCat.Size = new System.Drawing.Size(90, 20);
            this.lblProCat.TabIndex = 28;
            this.lblProCat.Text = "Categories:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(846, 435);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 26);
            this.txtPrice.TabIndex = 27;
            // 
            // lblProPrice
            // 
            this.lblProPrice.AutoSize = true;
            this.lblProPrice.Location = new System.Drawing.Point(783, 438);
            this.lblProPrice.Name = "lblProPrice";
            this.lblProPrice.Size = new System.Drawing.Size(48, 20);
            this.lblProPrice.TabIndex = 26;
            this.lblProPrice.Text = "Price:";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(523, 533);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(142, 26);
            this.txtDesc.TabIndex = 25;
            // 
            // lblProDesc
            // 
            this.lblProDesc.AutoSize = true;
            this.lblProDesc.Location = new System.Drawing.Point(415, 536);
            this.lblProDesc.Name = "lblProDesc";
            this.lblProDesc.Size = new System.Drawing.Size(93, 20);
            this.lblProDesc.TabIndex = 24;
            this.lblProDesc.Text = "Description:";
            // 
            // txtProName
            // 
            this.txtProName.Location = new System.Drawing.Point(523, 477);
            this.txtProName.Name = "txtProName";
            this.txtProName.Size = new System.Drawing.Size(100, 26);
            this.txtProName.TabIndex = 23;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(453, 480);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(55, 20);
            this.lblProductName.TabIndex = 22;
            this.lblProductName.Text = "Name:";
            // 
            // menuTableAdapter
            // 
            this.menuTableAdapter.ClearBeforeFill = true;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(158, 612);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(91, 29);
            this.btnUpload.TabIndex = 35;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // picProfile
            // 
            this.picProfile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picProfile.Image = global::IOOP_Assignment.Properties.Resources.foodIcon2;
            this.picProfile.Location = new System.Drawing.Point(105, 455);
            this.picProfile.Name = "picProfile";
            this.picProfile.Size = new System.Drawing.Size(200, 150);
            this.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picProfile.TabIndex = 30;
            this.picProfile.TabStop = false;
            this.picProfile.Click += new System.EventHandler(this.picProfile_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(698, 609);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(77, 32);
            this.btnUpdate.TabIndex = 37;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(556, 610);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(77, 32);
            this.btnAddProduct.TabIndex = 38;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // menuTableAdapter1
            // 
            this.menuTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(83, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(977, 277);
            this.dataGridView1.TabIndex = 39;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Product ID";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Description";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Category";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Recipe ID";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 699);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.txtProID);
            this.Controls.Add(this.lblProID);
            this.Controls.Add(this.picProfile);
            this.Controls.Add(this.txtCat);
            this.Controls.Add(this.lblProCat);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblProPrice);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.lblProDesc);
            this.Controls.Add(this.txtProName);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.txtSearchMenu);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOPDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOPDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchMenu;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtProID;
        private System.Windows.Forms.Label lblProID;
        private System.Windows.Forms.PictureBox picProfile;
        private System.Windows.Forms.TextBox txtCat;
        private System.Windows.Forms.Label lblProCat;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblProPrice;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblProDesc;
        private System.Windows.Forms.TextBox txtProName;
        private System.Windows.Forms.Label lblProductName;
        private IOOPDatabaseDataSet iOOPDatabaseDataSet;
        private IOOPDatabaseDataSetTableAdapters.MenuTableAdapter menuTableAdapter;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddProduct;
        private IOOPDatabaseDataSet1 iOOPDatabaseDataSet1;
        private System.Windows.Forms.BindingSource menuBindingSource;
        private IOOPDatabaseDataSet1TableAdapters.MenuTableAdapter menuTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}