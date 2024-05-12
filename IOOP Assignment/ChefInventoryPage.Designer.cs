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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelTopicInventory = new System.Windows.Forms.Panel();
            this.LblTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.BtnInventoryAdd = new System.Windows.Forms.Button();
            this.BtnInventoryEdit = new System.Windows.Forms.Button();
            this.BtnInventoryDelete = new System.Windows.Forms.Button();
            this.labelquestionInventory = new System.Windows.Forms.Label();
            this.TBInventoryID = new System.Windows.Forms.TextBox();
            this.ButtonAddNewInventory = new System.Windows.Forms.Button();
            this.TBInventoryQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TbInventoryPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelTopicInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOPDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTopicInventory
            // 
            this.PanelTopicInventory.BackColor = System.Drawing.Color.Silver;
            this.PanelTopicInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PanelTopicInventory.Controls.Add(this.LblTime);
            this.PanelTopicInventory.Controls.Add(this.label1);
            this.PanelTopicInventory.Controls.Add(this.flowLayoutPanel1);
            this.PanelTopicInventory.Location = new System.Drawing.Point(-8, -8);
            this.PanelTopicInventory.Name = "PanelTopicInventory";
            this.PanelTopicInventory.Size = new System.Drawing.Size(910, 77);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inventory Stocks";
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
            this.Btnback.Location = new System.Drawing.Point(800, 547);
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
            this.dataGridView1.Location = new System.Drawing.Point(17, 92);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(858, 291);
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
            // BtnInventoryAdd
            // 
            this.BtnInventoryAdd.Location = new System.Drawing.Point(324, 398);
            this.BtnInventoryAdd.Name = "BtnInventoryAdd";
            this.BtnInventoryAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnInventoryAdd.TabIndex = 3;
            this.BtnInventoryAdd.Text = "Update quantity";
            this.BtnInventoryAdd.UseVisualStyleBackColor = true;
            this.BtnInventoryAdd.Click += new System.EventHandler(this.BtnInventoryAdd_Click_1);
            // 
            // BtnInventoryEdit
            // 
            this.BtnInventoryEdit.Location = new System.Drawing.Point(324, 430);
            this.BtnInventoryEdit.Name = "BtnInventoryEdit";
            this.BtnInventoryEdit.Size = new System.Drawing.Size(75, 23);
            this.BtnInventoryEdit.TabIndex = 4;
            this.BtnInventoryEdit.Text = "EDIT ";
            this.BtnInventoryEdit.UseVisualStyleBackColor = true;
            this.BtnInventoryEdit.Click += new System.EventHandler(this.BtnInventoryEdit_Click_1);
            // 
            // BtnInventoryDelete
            // 
            this.BtnInventoryDelete.Location = new System.Drawing.Point(324, 466);
            this.BtnInventoryDelete.Name = "BtnInventoryDelete";
            this.BtnInventoryDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnInventoryDelete.TabIndex = 5;
            this.BtnInventoryDelete.Text = "DELETE";
            this.BtnInventoryDelete.UseVisualStyleBackColor = true;
            this.BtnInventoryDelete.Click += new System.EventHandler(this.BtnInventoryDelete_Click_1);
            // 
            // labelquestionInventory
            // 
            this.labelquestionInventory.AutoSize = true;
            this.labelquestionInventory.Location = new System.Drawing.Point(50, 398);
            this.labelquestionInventory.Name = "labelquestionInventory";
            this.labelquestionInventory.Size = new System.Drawing.Size(114, 16);
            this.labelquestionInventory.TabIndex = 6;
            this.labelquestionInventory.Text = "Enter Inventory ID:";
            // 
            // TBInventoryID
            // 
            this.TBInventoryID.Location = new System.Drawing.Point(170, 398);
            this.TBInventoryID.Name = "TBInventoryID";
            this.TBInventoryID.Size = new System.Drawing.Size(100, 22);
            this.TBInventoryID.TabIndex = 7;
            // 
            // ButtonAddNewInventory
            // 
            this.ButtonAddNewInventory.Location = new System.Drawing.Point(324, 507);
            this.ButtonAddNewInventory.Name = "ButtonAddNewInventory";
            this.ButtonAddNewInventory.Size = new System.Drawing.Size(84, 23);
            this.ButtonAddNewInventory.TabIndex = 8;
            this.ButtonAddNewInventory.Text = "NEW ITEM";
            this.ButtonAddNewInventory.UseVisualStyleBackColor = true;
            this.ButtonAddNewInventory.Click += new System.EventHandler(this.ButtonAddNewInventory_Click);
            // 
            // TBInventoryQuantity
            // 
            this.TBInventoryQuantity.Location = new System.Drawing.Point(170, 430);
            this.TBInventoryQuantity.Name = "TBInventoryQuantity";
            this.TBInventoryQuantity.Size = new System.Drawing.Size(100, 22);
            this.TBInventoryQuantity.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 466);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Individual Price:";
            // 
            // TbInventoryPrice
            // 
            this.TbInventoryPrice.Location = new System.Drawing.Point(170, 466);
            this.TbInventoryPrice.Name = "TbInventoryPrice";
            this.TbInventoryPrice.Size = new System.Drawing.Size(100, 22);
            this.TbInventoryPrice.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Quantity:";
            // 
            // ChefInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 582);
            this.Controls.Add(this.TbInventoryPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBInventoryQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonAddNewInventory);
            this.Controls.Add(this.TBInventoryID);
            this.Controls.Add(this.labelquestionInventory);
            this.Controls.Add(this.BtnInventoryDelete);
            this.Controls.Add(this.BtnInventoryEdit);
            this.Controls.Add(this.BtnInventoryAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btnback);
            this.Controls.Add(this.PanelTopicInventory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChefInventoryForm";
            this.Text = "Chef Inventory Form";
            this.Load += new System.EventHandler(this.ChefInventoryForm_Load);
            this.PanelTopicInventory.ResumeLayout(false);
            this.PanelTopicInventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOPDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelTopicInventory;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Button BtnInventoryAdd;
        private System.Windows.Forms.Button BtnInventoryEdit;
        private System.Windows.Forms.Button BtnInventoryDelete;
        private System.Windows.Forms.Label labelquestionInventory;
        private System.Windows.Forms.TextBox TBInventoryID;
        private System.Windows.Forms.Button ButtonAddNewInventory;
        private System.Windows.Forms.TextBox TBInventoryQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbInventoryPrice;
        private System.Windows.Forms.Label label2;
    }
}