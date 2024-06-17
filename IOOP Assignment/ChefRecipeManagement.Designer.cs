namespace IOOP_Assignment
{
    partial class ChefRecipeManagement
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
            this.RecipePanel = new System.Windows.Forms.Panel();
            this.TimelblRecipe = new System.Windows.Forms.Label();
            this.LBLTopicRecipe = new System.Windows.Forms.Label();
            this.RecipeDataView = new System.Windows.Forms.DataGridView();
            this.recipeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockQuantityUsedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recipeStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iOOPDatabaseDataSet1 = new IOOP_Assignment.IOOPDatabaseDataSet1();
            this.recipeStockTableAdapter = new IOOP_Assignment.IOOPDatabaseDataSet1TableAdapters.RecipeStockTableAdapter();
            this.BtnRecipeBack = new System.Windows.Forms.Button();
            this.BtnRecipeAdd = new System.Windows.Forms.Button();
            this.BtnRecipeDone = new System.Windows.Forms.Button();
            this.BtnRecipeCancel = new System.Windows.Forms.Button();
            this.LBLRecipeID = new System.Windows.Forms.Label();
            this.LBLProductID = new System.Windows.Forms.Label();
            this.LBLQuantityUsedRecipe = new System.Windows.Forms.Label();
            this.LBLRecipeIDShow = new System.Windows.Forms.Label();
            this.LblProductIDShow = new System.Windows.Forms.Label();
            this.LBLInventoryID = new System.Windows.Forms.Label();
            this.LBLQuantityRecipeShow = new System.Windows.Forms.Label();
            this.iOOPDatabaseDataSet2 = new IOOP_Assignment.IOOPDatabaseDataSet2();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryTableAdapter = new IOOP_Assignment.IOOPDatabaseDataSet2TableAdapters.InventoryTableAdapter();
            this.ListRecipeInventory = new System.Windows.Forms.ListBox();
            this.NumericQuantityUsed = new System.Windows.Forms.NumericUpDown();
            this.InventoryRecipeBox = new System.Windows.Forms.ListBox();
            this.RecipePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecipeDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeStockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOPDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOPDatabaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericQuantityUsed)).BeginInit();
            this.SuspendLayout();
            // 
            // RecipePanel
            // 
            this.RecipePanel.BackColor = System.Drawing.Color.IndianRed;
            this.RecipePanel.Controls.Add(this.TimelblRecipe);
            this.RecipePanel.Controls.Add(this.LBLTopicRecipe);
            this.RecipePanel.Location = new System.Drawing.Point(-7, -8);
            this.RecipePanel.Name = "RecipePanel";
            this.RecipePanel.Size = new System.Drawing.Size(982, 78);
            this.RecipePanel.TabIndex = 0;
            // 
            // TimelblRecipe
            // 
            this.TimelblRecipe.AutoSize = true;
            this.TimelblRecipe.Location = new System.Drawing.Point(584, 17);
            this.TimelblRecipe.Name = "TimelblRecipe";
            this.TimelblRecipe.Size = new System.Drawing.Size(38, 16);
            this.TimelblRecipe.TabIndex = 2;
            this.TimelblRecipe.Text = "Time";
            // 
            // LBLTopicRecipe
            // 
            this.LBLTopicRecipe.AutoSize = true;
            this.LBLTopicRecipe.Font = new System.Drawing.Font("Russo One", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTopicRecipe.Location = new System.Drawing.Point(12, 34);
            this.LBLTopicRecipe.Name = "LBLTopicRecipe";
            this.LBLTopicRecipe.Size = new System.Drawing.Size(341, 36);
            this.LBLTopicRecipe.TabIndex = 1;
            this.LBLTopicRecipe.Text = "Recipe Management";
            // 
            // RecipeDataView
            // 
            this.RecipeDataView.AutoGenerateColumns = false;
            this.RecipeDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecipeDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recipeIDDataGridViewTextBoxColumn,
            this.productIDDataGridViewTextBoxColumn,
            this.stockQuantityUsedDataGridViewTextBoxColumn});
            this.RecipeDataView.DataSource = this.recipeStockBindingSource;
            this.RecipeDataView.Location = new System.Drawing.Point(69, 84);
            this.RecipeDataView.Name = "RecipeDataView";
            this.RecipeDataView.RowHeadersWidth = 51;
            this.RecipeDataView.RowTemplate.Height = 24;
            this.RecipeDataView.Size = new System.Drawing.Size(698, 221);
            this.RecipeDataView.TabIndex = 1;
            // 
            // recipeIDDataGridViewTextBoxColumn
            // 
            this.recipeIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.recipeIDDataGridViewTextBoxColumn.DataPropertyName = "RecipeID";
            this.recipeIDDataGridViewTextBoxColumn.FillWeight = 500F;
            this.recipeIDDataGridViewTextBoxColumn.HeaderText = "RecipeID";
            this.recipeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.recipeIDDataGridViewTextBoxColumn.Name = "recipeIDDataGridViewTextBoxColumn";
            this.recipeIDDataGridViewTextBoxColumn.Width = 93;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // stockQuantityUsedDataGridViewTextBoxColumn
            // 
            this.stockQuantityUsedDataGridViewTextBoxColumn.DataPropertyName = "StockQuantityUsed";
            this.stockQuantityUsedDataGridViewTextBoxColumn.FillWeight = 400F;
            this.stockQuantityUsedDataGridViewTextBoxColumn.HeaderText = "StockQuantityUsed";
            this.stockQuantityUsedDataGridViewTextBoxColumn.MaxInputLength = 100000;
            this.stockQuantityUsedDataGridViewTextBoxColumn.MinimumWidth = 1000;
            this.stockQuantityUsedDataGridViewTextBoxColumn.Name = "stockQuantityUsedDataGridViewTextBoxColumn";
            this.stockQuantityUsedDataGridViewTextBoxColumn.Width = 1000;
            // 
            // recipeStockBindingSource
            // 
            this.recipeStockBindingSource.DataMember = "RecipeStock";
            this.recipeStockBindingSource.DataSource = this.iOOPDatabaseDataSet1;
            // 
            // iOOPDatabaseDataSet1
            // 
            this.iOOPDatabaseDataSet1.DataSetName = "IOOPDatabaseDataSet1";
            this.iOOPDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recipeStockTableAdapter
            // 
            this.recipeStockTableAdapter.ClearBeforeFill = true;
            // 
            // BtnRecipeBack
            // 
            this.BtnRecipeBack.Location = new System.Drawing.Point(663, 537);
            this.BtnRecipeBack.Name = "BtnRecipeBack";
            this.BtnRecipeBack.Size = new System.Drawing.Size(104, 25);
            this.BtnRecipeBack.TabIndex = 2;
            this.BtnRecipeBack.Text = "Back";
            this.BtnRecipeBack.UseVisualStyleBackColor = true;
            this.BtnRecipeBack.Click += new System.EventHandler(this.BtnRecipeBack_Click);
            // 
            // BtnRecipeAdd
            // 
            this.BtnRecipeAdd.Location = new System.Drawing.Point(79, 534);
            this.BtnRecipeAdd.Name = "BtnRecipeAdd";
            this.BtnRecipeAdd.Size = new System.Drawing.Size(101, 31);
            this.BtnRecipeAdd.TabIndex = 3;
            this.BtnRecipeAdd.Text = "Add Inventory";
            this.BtnRecipeAdd.UseVisualStyleBackColor = true;
            this.BtnRecipeAdd.Click += new System.EventHandler(this.BtnRecipeAdd_Click_1);
            // 
            // BtnRecipeDone
            // 
            this.BtnRecipeDone.Location = new System.Drawing.Point(186, 534);
            this.BtnRecipeDone.Name = "BtnRecipeDone";
            this.BtnRecipeDone.Size = new System.Drawing.Size(82, 31);
            this.BtnRecipeDone.TabIndex = 4;
            this.BtnRecipeDone.Text = "Done";
            this.BtnRecipeDone.UseVisualStyleBackColor = true;
            // 
            // BtnRecipeCancel
            // 
            this.BtnRecipeCancel.Location = new System.Drawing.Point(274, 534);
            this.BtnRecipeCancel.Name = "BtnRecipeCancel";
            this.BtnRecipeCancel.Size = new System.Drawing.Size(84, 31);
            this.BtnRecipeCancel.TabIndex = 5;
            this.BtnRecipeCancel.Text = "Cancel";
            this.BtnRecipeCancel.UseVisualStyleBackColor = true;
            // 
            // LBLRecipeID
            // 
            this.LBLRecipeID.AutoSize = true;
            this.LBLRecipeID.Location = new System.Drawing.Point(97, 330);
            this.LBLRecipeID.Name = "LBLRecipeID";
            this.LBLRecipeID.Size = new System.Drawing.Size(76, 16);
            this.LBLRecipeID.TabIndex = 6;
            this.LBLRecipeID.Text = "Recipe ID : ";
            // 
            // LBLProductID
            // 
            this.LBLProductID.AutoSize = true;
            this.LBLProductID.Location = new System.Drawing.Point(97, 366);
            this.LBLProductID.Name = "LBLProductID";
            this.LBLProductID.Size = new System.Drawing.Size(78, 16);
            this.LBLProductID.TabIndex = 7;
            this.LBLProductID.Text = "Product ID : ";
            // 
            // LBLQuantityUsedRecipe
            // 
            this.LBLQuantityUsedRecipe.AutoSize = true;
            this.LBLQuantityUsedRecipe.Location = new System.Drawing.Point(78, 483);
            this.LBLQuantityUsedRecipe.Name = "LBLQuantityUsedRecipe";
            this.LBLQuantityUsedRecipe.Size = new System.Drawing.Size(100, 16);
            this.LBLQuantityUsedRecipe.TabIndex = 8;
            this.LBLQuantityUsedRecipe.Text = "Quantity Used : ";
            // 
            // LBLRecipeIDShow
            // 
            this.LBLRecipeIDShow.AutoSize = true;
            this.LBLRecipeIDShow.Location = new System.Drawing.Point(204, 330);
            this.LBLRecipeIDShow.Name = "LBLRecipeIDShow";
            this.LBLRecipeIDShow.Size = new System.Drawing.Size(44, 16);
            this.LBLRecipeIDShow.TabIndex = 9;
            this.LBLRecipeIDShow.Text = "label4";
            // 
            // LblProductIDShow
            // 
            this.LblProductIDShow.AutoSize = true;
            this.LblProductIDShow.Location = new System.Drawing.Point(204, 366);
            this.LblProductIDShow.Name = "LblProductIDShow";
            this.LblProductIDShow.Size = new System.Drawing.Size(44, 16);
            this.LblProductIDShow.TabIndex = 10;
            this.LblProductIDShow.Text = "label5";
            // 
            // LBLInventoryID
            // 
            this.LBLInventoryID.AutoSize = true;
            this.LBLInventoryID.Location = new System.Drawing.Point(95, 404);
            this.LBLInventoryID.Name = "LBLInventoryID";
            this.LBLInventoryID.Size = new System.Drawing.Size(86, 16);
            this.LBLInventoryID.TabIndex = 12;
            this.LBLInventoryID.Text = "Inventory ID : ";
            // 
            // LBLQuantityRecipeShow
            // 
            this.LBLQuantityRecipeShow.AutoSize = true;
            this.LBLQuantityRecipeShow.Location = new System.Drawing.Point(209, 483);
            this.LBLQuantityRecipeShow.Name = "LBLQuantityRecipeShow";
            this.LBLQuantityRecipeShow.Size = new System.Drawing.Size(44, 16);
            this.LBLQuantityRecipeShow.TabIndex = 13;
            this.LBLQuantityRecipeShow.Text = "label1";
            // 
            // iOOPDatabaseDataSet2
            // 
            this.iOOPDatabaseDataSet2.DataSetName = "IOOPDatabaseDataSet2";
            this.iOOPDatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "Inventory";
            this.inventoryBindingSource.DataSource = this.iOOPDatabaseDataSet2;
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // ListRecipeInventory
            // 
            this.ListRecipeInventory.BackColor = System.Drawing.SystemColors.Window;
            this.ListRecipeInventory.FormattingEnabled = true;
            this.ListRecipeInventory.ItemHeight = 16;
            this.ListRecipeInventory.Location = new System.Drawing.Point(207, 400);
            this.ListRecipeInventory.Name = "ListRecipeInventory";
            this.ListRecipeInventory.Size = new System.Drawing.Size(139, 52);
            this.ListRecipeInventory.TabIndex = 16;
            this.ListRecipeInventory.SelectedIndexChanged += new System.EventHandler(this.ListRecipeInventory_SelectedIndexChanged);
            // 
            // NumericQuantityUsed
            // 
            this.NumericQuantityUsed.Location = new System.Drawing.Point(207, 481);
            this.NumericQuantityUsed.Name = "NumericQuantityUsed";
            this.NumericQuantityUsed.Size = new System.Drawing.Size(120, 22);
            this.NumericQuantityUsed.TabIndex = 17;
            // 
            // InventoryRecipeBox
            // 
            this.InventoryRecipeBox.BackColor = System.Drawing.SystemColors.Window;
            this.InventoryRecipeBox.FormattingEnabled = true;
            this.InventoryRecipeBox.ItemHeight = 16;
            this.InventoryRecipeBox.Location = new System.Drawing.Point(400, 330);
            this.InventoryRecipeBox.Name = "InventoryRecipeBox";
            this.InventoryRecipeBox.Size = new System.Drawing.Size(367, 196);
            this.InventoryRecipeBox.TabIndex = 18;
            // 
            // ChefRecipeManagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(836, 591);
            this.Controls.Add(this.InventoryRecipeBox);
            this.Controls.Add(this.NumericQuantityUsed);
            this.Controls.Add(this.ListRecipeInventory);
            this.Controls.Add(this.LBLQuantityRecipeShow);
            this.Controls.Add(this.LBLInventoryID);
            this.Controls.Add(this.LblProductIDShow);
            this.Controls.Add(this.LBLRecipeIDShow);
            this.Controls.Add(this.LBLQuantityUsedRecipe);
            this.Controls.Add(this.LBLProductID);
            this.Controls.Add(this.LBLRecipeID);
            this.Controls.Add(this.BtnRecipeCancel);
            this.Controls.Add(this.BtnRecipeDone);
            this.Controls.Add(this.BtnRecipeAdd);
            this.Controls.Add(this.BtnRecipeBack);
            this.Controls.Add(this.RecipeDataView);
            this.Controls.Add(this.RecipePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChefRecipeManagement";
            this.Text = "Chef Recipe Form ";
            this.RecipePanel.ResumeLayout(false);
            this.RecipePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecipeDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeStockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOPDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOPDatabaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericQuantityUsed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel RecipePanel;
        private System.Windows.Forms.Label LBLTopicRecipe;
        private System.Windows.Forms.DataGridView RecipeDataView;
        private IOOPDatabaseDataSet1 iOOPDatabaseDataSet1;
        private System.Windows.Forms.BindingSource recipeStockBindingSource;
        private IOOPDatabaseDataSet1TableAdapters.RecipeStockTableAdapter recipeStockTableAdapter;
        private System.Windows.Forms.Button BtnRecipeBack;
        private System.Windows.Forms.Button BtnRecipeAdd;
        private System.Windows.Forms.Button BtnRecipeDone;
        private System.Windows.Forms.Button BtnRecipeCancel;
        private System.Windows.Forms.Label LBLRecipeID;
        private System.Windows.Forms.Label LBLProductID;
        private System.Windows.Forms.Label LBLQuantityUsedRecipe;
        private System.Windows.Forms.Label LBLRecipeIDShow;
        private System.Windows.Forms.Label LblProductIDShow;
        private System.Windows.Forms.Label LBLInventoryID;
        private System.Windows.Forms.Label LBLQuantityRecipeShow;
        private IOOPDatabaseDataSet2 iOOPDatabaseDataSet2;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private IOOPDatabaseDataSet2TableAdapters.InventoryTableAdapter inventoryTableAdapter;
        private System.Windows.Forms.ListBox ListRecipeInventory;
        private System.Windows.Forms.Label TimelblRecipe;
        private System.Windows.Forms.NumericUpDown NumericQuantityUsed;
        private System.Windows.Forms.ListBox InventoryRecipeBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn recipeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockQuantityUsedDataGridViewTextBoxColumn;
    }
}