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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.BtnInventoryUpdate = new System.Windows.Forms.Button();
            this.BtnInventoryDelete = new System.Windows.Forms.Button();
            this.labelquestionInventory = new System.Windows.Forms.Label();
            this.ButtonAddNewInventory = new System.Windows.Forms.Button();
            this.TBInventoryName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LBLStockID = new System.Windows.Forms.Label();
            this.LBLName = new System.Windows.Forms.Label();
            this.LBLQuantity = new System.Windows.Forms.Label();
            this.LBLPrice = new System.Windows.Forms.Label();
            this.LBLStatus = new System.Windows.Forms.Label();
            this.BtnDone = new System.Windows.Forms.Button();
            this.checkBoxAdequate = new System.Windows.Forms.CheckBox();
            this.checkBoxLack = new System.Windows.Forms.CheckBox();
            this.checkBoxOut = new System.Windows.Forms.CheckBox();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
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
            this.Btnback.Location = new System.Drawing.Point(800, 611);
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
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
            // BtnInventoryUpdate
            // 
            this.BtnInventoryUpdate.Location = new System.Drawing.Point(516, 469);
            this.BtnInventoryUpdate.Name = "BtnInventoryUpdate";
            this.BtnInventoryUpdate.Size = new System.Drawing.Size(84, 23);
            this.BtnInventoryUpdate.TabIndex = 3;
            this.BtnInventoryUpdate.Text = "Update quantity";
            this.BtnInventoryUpdate.UseVisualStyleBackColor = true;
            this.BtnInventoryUpdate.Click += new System.EventHandler(this.BtnInventoryAdd_Click);
            // 
            // BtnInventoryDelete
            // 
            this.BtnInventoryDelete.Location = new System.Drawing.Point(516, 435);
            this.BtnInventoryDelete.Name = "BtnInventoryDelete";
            this.BtnInventoryDelete.Size = new System.Drawing.Size(84, 23);
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
            this.labelquestionInventory.Size = new System.Drawing.Size(66, 16);
            this.labelquestionInventory.TabIndex = 6;
            this.labelquestionInventory.Text = "Stock ID : ";
            // 
            // ButtonAddNewInventory
            // 
            this.ButtonAddNewInventory.Location = new System.Drawing.Point(516, 398);
            this.ButtonAddNewInventory.Name = "ButtonAddNewInventory";
            this.ButtonAddNewInventory.Size = new System.Drawing.Size(84, 28);
            this.ButtonAddNewInventory.TabIndex = 8;
            this.ButtonAddNewInventory.Text = "NEW ITEM";
            this.ButtonAddNewInventory.UseVisualStyleBackColor = true;
            this.ButtonAddNewInventory.Click += new System.EventHandler(this.ButtonAddNewInventory_Click);
            // 
            // TBInventoryName
            // 
            this.TBInventoryName.Location = new System.Drawing.Point(170, 430);
            this.TBInventoryName.Name = "TBInventoryName";
            this.TBInventoryName.Size = new System.Drawing.Size(100, 22);
            this.TBInventoryName.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 501);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Individual Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 466);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Quantity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 430);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Name : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 537);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Status : ";
            // 
            // LBLStockID
            // 
            this.LBLStockID.AutoSize = true;
            this.LBLStockID.Location = new System.Drawing.Point(167, 398);
            this.LBLStockID.Name = "LBLStockID";
            this.LBLStockID.Size = new System.Drawing.Size(44, 16);
            this.LBLStockID.TabIndex = 15;
            this.LBLStockID.Text = "label6";
            // 
            // LBLName
            // 
            this.LBLName.AutoSize = true;
            this.LBLName.Location = new System.Drawing.Point(167, 433);
            this.LBLName.Name = "LBLName";
            this.LBLName.Size = new System.Drawing.Size(44, 16);
            this.LBLName.TabIndex = 16;
            this.LBLName.Text = "label7";
            // 
            // LBLQuantity
            // 
            this.LBLQuantity.AutoSize = true;
            this.LBLQuantity.Location = new System.Drawing.Point(167, 466);
            this.LBLQuantity.Name = "LBLQuantity";
            this.LBLQuantity.Size = new System.Drawing.Size(44, 16);
            this.LBLQuantity.TabIndex = 17;
            this.LBLQuantity.Text = "label8";
            // 
            // LBLPrice
            // 
            this.LBLPrice.AutoSize = true;
            this.LBLPrice.Location = new System.Drawing.Point(167, 501);
            this.LBLPrice.Name = "LBLPrice";
            this.LBLPrice.Size = new System.Drawing.Size(44, 16);
            this.LBLPrice.TabIndex = 18;
            this.LBLPrice.Text = "label9";
            // 
            // LBLStatus
            // 
            this.LBLStatus.AutoSize = true;
            this.LBLStatus.Location = new System.Drawing.Point(167, 537);
            this.LBLStatus.Name = "LBLStatus";
            this.LBLStatus.Size = new System.Drawing.Size(51, 16);
            this.LBLStatus.TabIndex = 19;
            this.LBLStatus.Text = "label10";
            // 
            // BtnDone
            // 
            this.BtnDone.Location = new System.Drawing.Point(516, 587);
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
            this.checkBoxAdequate.Location = new System.Drawing.Point(170, 537);
            this.checkBoxAdequate.Name = "checkBoxAdequate";
            this.checkBoxAdequate.Size = new System.Drawing.Size(88, 20);
            this.checkBoxAdequate.TabIndex = 23;
            this.checkBoxAdequate.Text = "Adequate";
            this.checkBoxAdequate.UseVisualStyleBackColor = true;
            // 
            // checkBoxLack
            // 
            this.checkBoxLack.AutoSize = true;
            this.checkBoxLack.Location = new System.Drawing.Point(170, 563);
            this.checkBoxLack.Name = "checkBoxLack";
            this.checkBoxLack.Size = new System.Drawing.Size(109, 20);
            this.checkBoxLack.TabIndex = 24;
            this.checkBoxLack.Text = "Lack of Stock";
            this.checkBoxLack.UseVisualStyleBackColor = true;
            // 
            // checkBoxOut
            // 
            this.checkBoxOut.AutoSize = true;
            this.checkBoxOut.Location = new System.Drawing.Point(170, 592);
            this.checkBoxOut.Name = "checkBoxOut";
            this.checkBoxOut.Size = new System.Drawing.Size(100, 20);
            this.checkBoxOut.TabIndex = 25;
            this.checkBoxOut.Text = "Out of Stock";
            this.checkBoxOut.UseVisualStyleBackColor = true;
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Location = new System.Drawing.Point(170, 467);
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(106, 22);
            this.numericUpDownQuantity.TabIndex = 26;
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.Location = new System.Drawing.Point(170, 501);
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(106, 22);
            this.numericUpDownPrice.TabIndex = 27;
            // 
            // ChefInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 646);
            this.Controls.Add(this.checkBoxOut);
            this.Controls.Add(this.checkBoxLack);
            this.Controls.Add(this.BtnDone);
            this.Controls.Add(this.LBLStatus);
            this.Controls.Add(this.LBLPrice);
            this.Controls.Add(this.LBLQuantity);
            this.Controls.Add(this.LBLName);
            this.Controls.Add(this.LBLStockID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBInventoryName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonAddNewInventory);
            this.Controls.Add(this.labelquestionInventory);
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
        private System.Windows.Forms.Button BtnInventoryUpdate;
        private System.Windows.Forms.Button BtnInventoryDelete;
        private System.Windows.Forms.Label labelquestionInventory;
        private System.Windows.Forms.Button ButtonAddNewInventory;
        private System.Windows.Forms.TextBox TBInventoryName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LBLStockID;
        private System.Windows.Forms.Label LBLName;
        private System.Windows.Forms.Label LBLQuantity;
        private System.Windows.Forms.Label LBLPrice;
        private System.Windows.Forms.Label LBLStatus;
        private System.Windows.Forms.Button BtnDone;
        private System.Windows.Forms.CheckBox checkBoxAdequate;
        private System.Windows.Forms.CheckBox checkBoxLack;
        private System.Windows.Forms.CheckBox checkBoxOut;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
    }
}