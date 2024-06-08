namespace IOOP_Assignment
{
    partial class ChefInventoryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelTopicInventory = new System.Windows.Forms.Panel();
            this.LblTime = new System.Windows.Forms.Label();
            this.LblInventoryTop = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Btnback = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stockIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.individualPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iOOPDatabaseDataSet = new IOOP_Assignment.IOOPDatabaseDataSet();
            this.inventoryTableAdapter = new IOOP_Assignment.IOOPDatabaseDataSetTableAdapters.InventoryTableAdapter();
            this.BtnInventoryUpdate = new System.Windows.Forms.Button();
            this.BtnInventoryDelete = new System.Windows.Forms.Button();
            this.LblInventoryStockID = new System.Windows.Forms.Label();
            this.ButtonAddNewInventory = new System.Windows.Forms.Button();
            this.TBInventoryName = new System.Windows.Forms.TextBox();
            this.LblInventoryPrice = new System.Windows.Forms.Label();
            this.LblInventoryQuantity = new System.Windows.Forms.Label();
            this.LblInventoryName = new System.Windows.Forms.Label();
            this.LblInventoryStatus = new System.Windows.Forms.Label();
            this.LblinventoryStockIDShow = new System.Windows.Forms.Label();
            this.LblInventoryNameShow = new System.Windows.Forms.Label();
            this.LblInventoryQuantityShow = new System.Windows.Forms.Label();
            this.LblInventoryPriceShow = new System.Windows.Forms.Label();
            this.LblInventoryStatusShow = new System.Windows.Forms.Label();
            this.BtnDone = new System.Windows.Forms.Button();
            this.checkBoxAdequate = new System.Windows.Forms.CheckBox();
            this.checkBoxLack = new System.Windows.Forms.CheckBox();
            this.checkBoxOut = new System.Windows.Forms.CheckBox();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.BtnInventoryCancel = new System.Windows.Forms.Button();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.LblInventorySearch = new System.Windows.Forms.Label();
            this.TbSearch = new System.Windows.Forms.TextBox();
            this.BtnInventorySearch = new System.Windows.Forms.Button();
            this.PanelTopicInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOPDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTopicInventory
            // 
            this.PanelTopicInventory.BackColor = System.Drawing.Color.Silver;
            this.PanelTopicInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PanelTopicInventory.Controls.Add(this.LblTime);
            this.PanelTopicInventory.Controls.Add(this.LblInventoryTop);
            this.PanelTopicInventory.Controls.Add(this.flowLayoutPanel1);
            this.PanelTopicInventory.Location = new System.Drawing.Point(-8, -8);
            this.PanelTopicInventory.Name = "PanelTopicInventory";
            this.PanelTopicInventory.Size = new System.Drawing.Size(941, 77);
            this.PanelTopicInventory.TabIndex = 0;
            // 
            // LblTime
            // 
            this.LblTime.AutoSize = true;
            this.LblTime.Location = new System.Drawing.Point(538, 39);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(70, 16);
            this.LblTime.TabIndex = 1;
            this.LblTime.Text = "Date Time";
            // 
            // LblInventoryTop
            // 
            this.LblInventoryTop.AutoSize = true;
            this.LblInventoryTop.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInventoryTop.Location = new System.Drawing.Point(20, 30);
            this.LblInventoryTop.Name = "LblInventoryTop";
            this.LblInventoryTop.Size = new System.Drawing.Size(181, 25);
            this.LblInventoryTop.TabIndex = 1;
            this.LblInventoryTop.Text = "Inventory Stocks";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(413, 10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // Btnback
            // 
            this.Btnback.Location = new System.Drawing.Point(661, 595);
            this.Btnback.Name = "Btnback";
            this.Btnback.Size = new System.Drawing.Size(75, 23);
            this.Btnback.TabIndex = 1;
            this.Btnback.Text = "Back";
            this.Btnback.UseVisualStyleBackColor = true;
            this.Btnback.Click += new System.EventHandler(this.Btnback_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.individualPriceDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.inventoryBindingSource;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.PeachPuff;
            this.dataGridView1.Location = new System.Drawing.Point(12, 91);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(737, 254);
            this.dataGridView1.TabIndex = 2;
            // 
            // stockIDDataGridViewTextBoxColumn
            // 
            this.stockIDDataGridViewTextBoxColumn.DataPropertyName = "StockID";
            this.stockIDDataGridViewTextBoxColumn.HeaderText = "StockID";
            this.stockIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stockIDDataGridViewTextBoxColumn.Name = "stockIDDataGridViewTextBoxColumn";
            this.stockIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // individualPriceDataGridViewTextBoxColumn
            // 
            this.individualPriceDataGridViewTextBoxColumn.DataPropertyName = "IndividualPrice";
            this.individualPriceDataGridViewTextBoxColumn.HeaderText = "IndividualPrice";
            this.individualPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.individualPriceDataGridViewTextBoxColumn.Name = "individualPriceDataGridViewTextBoxColumn";
            this.individualPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "Inventory";
            this.inventoryBindingSource.DataSource = this.iOOPDatabaseDataSet;
            // 
            // iOOPDatabaseDataSet
            // 
            this.iOOPDatabaseDataSet.DataSetName = "IOOPDatabaseDataSet";
            this.iOOPDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // BtnInventoryUpdate
            // 
            this.BtnInventoryUpdate.AutoEllipsis = true;
            this.BtnInventoryUpdate.Location = new System.Drawing.Point(68, 494);
            this.BtnInventoryUpdate.Name = "BtnInventoryUpdate";
            this.BtnInventoryUpdate.Size = new System.Drawing.Size(96, 23);
            this.BtnInventoryUpdate.TabIndex = 3;
            this.BtnInventoryUpdate.Text = "Update";
            this.BtnInventoryUpdate.UseVisualStyleBackColor = true;
            this.BtnInventoryUpdate.Click += new System.EventHandler(this.BtnInventoryAdd_Click);
            // 
            // BtnInventoryDelete
            // 
            this.BtnInventoryDelete.Location = new System.Drawing.Point(68, 461);
            this.BtnInventoryDelete.Name = "BtnInventoryDelete";
            this.BtnInventoryDelete.Size = new System.Drawing.Size(84, 23);
            this.BtnInventoryDelete.TabIndex = 5;
            this.BtnInventoryDelete.Text = "DELETE";
            this.BtnInventoryDelete.UseVisualStyleBackColor = true;
            this.BtnInventoryDelete.Click += new System.EventHandler(this.BtnInventoryDelete_Click_1);
            // 
            // LblInventoryStockID
            // 
            this.LblInventoryStockID.AutoSize = true;
            this.LblInventoryStockID.Location = new System.Drawing.Point(213, 392);
            this.LblInventoryStockID.Name = "LblInventoryStockID";
            this.LblInventoryStockID.Size = new System.Drawing.Size(66, 16);
            this.LblInventoryStockID.TabIndex = 6;
            this.LblInventoryStockID.Text = "Stock ID : ";
            // 
            // ButtonAddNewInventory
            // 
            this.ButtonAddNewInventory.Location = new System.Drawing.Point(68, 424);
            this.ButtonAddNewInventory.Name = "ButtonAddNewInventory";
            this.ButtonAddNewInventory.Size = new System.Drawing.Size(84, 28);
            this.ButtonAddNewInventory.TabIndex = 8;
            this.ButtonAddNewInventory.Text = "NEW ITEM";
            this.ButtonAddNewInventory.UseVisualStyleBackColor = true;
            this.ButtonAddNewInventory.Click += new System.EventHandler(this.ButtonAddNewInventory_Click);
            // 
            // TBInventoryName
            // 
            this.TBInventoryName.Location = new System.Drawing.Point(333, 424);
            this.TBInventoryName.Name = "TBInventoryName";
            this.TBInventoryName.Size = new System.Drawing.Size(100, 22);
            this.TBInventoryName.TabIndex = 10;
            // 
            // LblInventoryPrice
            // 
            this.LblInventoryPrice.AutoSize = true;
            this.LblInventoryPrice.Location = new System.Drawing.Point(213, 495);
            this.LblInventoryPrice.Name = "LblInventoryPrice";
            this.LblInventoryPrice.Size = new System.Drawing.Size(101, 16);
            this.LblInventoryPrice.TabIndex = 11;
            this.LblInventoryPrice.Text = "Individual Price:";
            // 
            // LblInventoryQuantity
            // 
            this.LblInventoryQuantity.AutoSize = true;
            this.LblInventoryQuantity.Location = new System.Drawing.Point(213, 460);
            this.LblInventoryQuantity.Name = "LblInventoryQuantity";
            this.LblInventoryQuantity.Size = new System.Drawing.Size(58, 16);
            this.LblInventoryQuantity.TabIndex = 9;
            this.LblInventoryQuantity.Text = "Quantity:";
            // 
            // LblInventoryName
            // 
            this.LblInventoryName.AutoSize = true;
            this.LblInventoryName.Location = new System.Drawing.Point(213, 424);
            this.LblInventoryName.Name = "LblInventoryName";
            this.LblInventoryName.Size = new System.Drawing.Size(53, 16);
            this.LblInventoryName.TabIndex = 13;
            this.LblInventoryName.Text = "Name : ";
            // 
            // LblInventoryStatus
            // 
            this.LblInventoryStatus.AutoSize = true;
            this.LblInventoryStatus.Location = new System.Drawing.Point(213, 531);
            this.LblInventoryStatus.Name = "LblInventoryStatus";
            this.LblInventoryStatus.Size = new System.Drawing.Size(53, 16);
            this.LblInventoryStatus.TabIndex = 14;
            this.LblInventoryStatus.Text = "Status : ";
            // 
            // LblinventoryStockIDShow
            // 
            this.LblinventoryStockIDShow.AutoSize = true;
            this.LblinventoryStockIDShow.Location = new System.Drawing.Point(330, 392);
            this.LblinventoryStockIDShow.Name = "LblinventoryStockIDShow";
            this.LblinventoryStockIDShow.Size = new System.Drawing.Size(44, 16);
            this.LblinventoryStockIDShow.TabIndex = 15;
            this.LblinventoryStockIDShow.Text = "label6";
            // 
            // LblInventoryNameShow
            // 
            this.LblInventoryNameShow.AutoSize = true;
            this.LblInventoryNameShow.Location = new System.Drawing.Point(330, 427);
            this.LblInventoryNameShow.Name = "LblInventoryNameShow";
            this.LblInventoryNameShow.Size = new System.Drawing.Size(44, 16);
            this.LblInventoryNameShow.TabIndex = 16;
            this.LblInventoryNameShow.Text = "label7";
            // 
            // LblInventoryQuantityShow
            // 
            this.LblInventoryQuantityShow.AutoSize = true;
            this.LblInventoryQuantityShow.Location = new System.Drawing.Point(330, 460);
            this.LblInventoryQuantityShow.Name = "LblInventoryQuantityShow";
            this.LblInventoryQuantityShow.Size = new System.Drawing.Size(44, 16);
            this.LblInventoryQuantityShow.TabIndex = 17;
            this.LblInventoryQuantityShow.Text = "label8";
            // 
            // LblInventoryPriceShow
            // 
            this.LblInventoryPriceShow.AutoSize = true;
            this.LblInventoryPriceShow.Location = new System.Drawing.Point(330, 495);
            this.LblInventoryPriceShow.Name = "LblInventoryPriceShow";
            this.LblInventoryPriceShow.Size = new System.Drawing.Size(44, 16);
            this.LblInventoryPriceShow.TabIndex = 18;
            this.LblInventoryPriceShow.Text = "label9";
            // 
            // LblInventoryStatusShow
            // 
            this.LblInventoryStatusShow.AutoSize = true;
            this.LblInventoryStatusShow.Location = new System.Drawing.Point(330, 531);
            this.LblInventoryStatusShow.Name = "LblInventoryStatusShow";
            this.LblInventoryStatusShow.Size = new System.Drawing.Size(51, 16);
            this.LblInventoryStatusShow.TabIndex = 19;
            this.LblInventoryStatusShow.Text = "label10";
            // 
            // BtnDone
            // 
            this.BtnDone.Location = new System.Drawing.Point(472, 531);
            this.BtnDone.Name = "BtnDone";
            this.BtnDone.Size = new System.Drawing.Size(84, 28);
            this.BtnDone.TabIndex = 22;
            this.BtnDone.Text = "Done";
            this.BtnDone.UseVisualStyleBackColor = true;
            this.BtnDone.Click += new System.EventHandler(this.BtnDone_Click_1);
            // 
            // checkBoxAdequate
            // 
            this.checkBoxAdequate.AutoSize = true;
            this.checkBoxAdequate.Location = new System.Drawing.Point(333, 531);
            this.checkBoxAdequate.Name = "checkBoxAdequate";
            this.checkBoxAdequate.Size = new System.Drawing.Size(88, 20);
            this.checkBoxAdequate.TabIndex = 23;
            this.checkBoxAdequate.Text = "Adequate";
            this.checkBoxAdequate.UseVisualStyleBackColor = true;
            // 
            // checkBoxLack
            // 
            this.checkBoxLack.AutoSize = true;
            this.checkBoxLack.Location = new System.Drawing.Point(333, 557);
            this.checkBoxLack.Name = "checkBoxLack";
            this.checkBoxLack.Size = new System.Drawing.Size(109, 20);
            this.checkBoxLack.TabIndex = 24;
            this.checkBoxLack.Text = "Lack of Stock";
            this.checkBoxLack.UseVisualStyleBackColor = true;
            // 
            // checkBoxOut
            // 
            this.checkBoxOut.AutoSize = true;
            this.checkBoxOut.Location = new System.Drawing.Point(333, 586);
            this.checkBoxOut.Name = "checkBoxOut";
            this.checkBoxOut.Size = new System.Drawing.Size(100, 20);
            this.checkBoxOut.TabIndex = 25;
            this.checkBoxOut.Text = "Out of Stock";
            this.checkBoxOut.UseVisualStyleBackColor = true;
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Location = new System.Drawing.Point(333, 461);
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(106, 22);
            this.numericUpDownQuantity.TabIndex = 26;
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.Location = new System.Drawing.Point(333, 495);
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(106, 22);
            this.numericUpDownPrice.TabIndex = 27;
            // 
            // BtnInventoryCancel
            // 
            this.BtnInventoryCancel.Location = new System.Drawing.Point(578, 531);
            this.BtnInventoryCancel.Name = "BtnInventoryCancel";
            this.BtnInventoryCancel.Size = new System.Drawing.Size(84, 28);
            this.BtnInventoryCancel.TabIndex = 28;
            this.BtnInventoryCancel.Text = "Cancel";
            this.BtnInventoryCancel.UseVisualStyleBackColor = true;
            this.BtnInventoryCancel.Click += new System.EventHandler(this.BtnInventoryCancel_Click_1);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // LblInventorySearch
            // 
            this.LblInventorySearch.AutoSize = true;
            this.LblInventorySearch.Location = new System.Drawing.Point(500, 416);
            this.LblInventorySearch.Name = "LblInventorySearch";
            this.LblInventorySearch.Size = new System.Drawing.Size(56, 16);
            this.LblInventorySearch.TabIndex = 29;
            this.LblInventorySearch.Text = "Search: ";
            // 
            // TbSearch
            // 
            this.TbSearch.Location = new System.Drawing.Point(562, 410);
            this.TbSearch.Name = "TbSearch";
            this.TbSearch.Size = new System.Drawing.Size(100, 22);
            this.TbSearch.TabIndex = 30;
            // 
            // BtnInventorySearch
            // 
            this.BtnInventorySearch.AutoEllipsis = true;
            this.BtnInventorySearch.Image = global::IOOP_Assignment.Properties.Resources.searchIcon;
            this.BtnInventorySearch.Location = new System.Drawing.Point(543, 448);
            this.BtnInventorySearch.Name = "BtnInventorySearch";
            this.BtnInventorySearch.Size = new System.Drawing.Size(57, 40);
            this.BtnInventorySearch.TabIndex = 31;
            this.BtnInventorySearch.UseVisualStyleBackColor = true;
            // 
            // ChefInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 641);
            this.Controls.Add(this.BtnInventorySearch);
            this.Controls.Add(this.TbSearch);
            this.Controls.Add(this.LblInventorySearch);
            this.Controls.Add(this.BtnInventoryCancel);
            this.Controls.Add(this.checkBoxOut);
            this.Controls.Add(this.checkBoxLack);
            this.Controls.Add(this.BtnDone);
            this.Controls.Add(this.LblInventoryStatusShow);
            this.Controls.Add(this.LblInventoryPriceShow);
            this.Controls.Add(this.LblInventoryQuantityShow);
            this.Controls.Add(this.LblInventoryNameShow);
            this.Controls.Add(this.LblinventoryStockIDShow);
            this.Controls.Add(this.LblInventoryStatus);
            this.Controls.Add(this.LblInventoryName);
            this.Controls.Add(this.LblInventoryPrice);
            this.Controls.Add(this.TBInventoryName);
            this.Controls.Add(this.LblInventoryQuantity);
            this.Controls.Add(this.ButtonAddNewInventory);
            this.Controls.Add(this.LblInventoryStockID);
            this.Controls.Add(this.BtnInventoryDelete);
            this.Controls.Add(this.BtnInventoryUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btnback);
            this.Controls.Add(this.PanelTopicInventory);
            this.Controls.Add(this.numericUpDownQuantity);
            this.Controls.Add(this.numericUpDownPrice);
            this.Controls.Add(this.checkBoxAdequate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChefInventoryForm";
            this.Text = "Chef Inventory Form";
            this.PanelTopicInventory.ResumeLayout(false);
            this.PanelTopicInventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOPDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelTopicInventory;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label LblInventoryTop;
        private System.Windows.Forms.Label LblTime;
        private System.Windows.Forms.Button Btnback;
        private System.Windows.Forms.DataGridView dataGridView1;
        private IOOPDatabaseDataSet iOOPDatabaseDataSet;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private IOOPDatabaseDataSetTableAdapters.InventoryTableAdapter inventoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn individualPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BtnInventoryUpdate;
        private System.Windows.Forms.Button BtnInventoryDelete;
        private System.Windows.Forms.Label LblInventoryStockID;
        private System.Windows.Forms.Button ButtonAddNewInventory;
        private System.Windows.Forms.TextBox TBInventoryName;
        private System.Windows.Forms.Label LblInventoryPrice;
        private System.Windows.Forms.Label LblInventoryQuantity;
        private System.Windows.Forms.Label LblInventoryName;
        private System.Windows.Forms.Label LblInventoryStatus;
        private System.Windows.Forms.Label LblinventoryStockIDShow;
        private System.Windows.Forms.Label LblInventoryNameShow;
        private System.Windows.Forms.Label LblInventoryQuantityShow;
        private System.Windows.Forms.Label LblInventoryPriceShow;
        private System.Windows.Forms.Label LblInventoryStatusShow;
        private System.Windows.Forms.Button BtnDone;
        private System.Windows.Forms.CheckBox checkBoxAdequate;
        private System.Windows.Forms.CheckBox checkBoxLack;
        private System.Windows.Forms.CheckBox checkBoxOut;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.Button BtnInventoryCancel;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Label LblInventorySearch;
        private System.Windows.Forms.TextBox TbSearch;
        private System.Windows.Forms.Button BtnInventorySearch;
    }
}