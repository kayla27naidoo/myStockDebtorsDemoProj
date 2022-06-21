
namespace pracApplV2
{
    partial class StockEnquiryForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stockCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellingPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPurchasesExclVatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalSalesExclVatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyPurchasedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtySoldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockOnHandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockMasterTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mngmntSystDBDataSet = new pracApplV2.MngmntSystDBDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.stockTransactionNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockCodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitSellDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockTransTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stocktransSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.stockMasterTblTableAdapter = new pracApplV2.MngmntSystDBDataSetTableAdapters.StockMasterTblTableAdapter();
            this.stockTransTblTableAdapter = new pracApplV2.MngmntSystDBDataSetTableAdapters.StockTransTblTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockMasterTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mngmntSystDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockTransTblBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1188, 62);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(445, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "View Stock Item Details";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(0, 466);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1188, 62);
            this.panel2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(445, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "View Stock Transactions";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Search for Stock Item:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(264, 84);
            this.textBox1.MinimumSize = new System.Drawing.Size(323, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(323, 26);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockCodeDataGridViewTextBoxColumn,
            this.stockDescriptionDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.sellingPriceDataGridViewTextBoxColumn,
            this.totalPurchasesExclVatDataGridViewTextBoxColumn,
            this.totalSalesExclVatDataGridViewTextBoxColumn,
            this.qtyPurchasedDataGridViewTextBoxColumn,
            this.qtySoldDataGridViewTextBoxColumn,
            this.stockOnHandDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stockMasterTblBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1115, 315);
            this.dataGridView1.TabIndex = 9;
            // 
            // stockCodeDataGridViewTextBoxColumn
            // 
            this.stockCodeDataGridViewTextBoxColumn.DataPropertyName = "StockCode";
            this.stockCodeDataGridViewTextBoxColumn.HeaderText = "StockCode";
            this.stockCodeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.stockCodeDataGridViewTextBoxColumn.Name = "stockCodeDataGridViewTextBoxColumn";
            this.stockCodeDataGridViewTextBoxColumn.Width = 150;
            // 
            // stockDescriptionDataGridViewTextBoxColumn
            // 
            this.stockDescriptionDataGridViewTextBoxColumn.DataPropertyName = "StockDescription";
            this.stockDescriptionDataGridViewTextBoxColumn.HeaderText = "StockDescription";
            this.stockDescriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.stockDescriptionDataGridViewTextBoxColumn.Name = "stockDescriptionDataGridViewTextBoxColumn";
            this.stockDescriptionDataGridViewTextBoxColumn.Width = 150;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.Width = 150;
            // 
            // sellingPriceDataGridViewTextBoxColumn
            // 
            this.sellingPriceDataGridViewTextBoxColumn.DataPropertyName = "SellingPrice";
            this.sellingPriceDataGridViewTextBoxColumn.HeaderText = "SellingPrice";
            this.sellingPriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sellingPriceDataGridViewTextBoxColumn.Name = "sellingPriceDataGridViewTextBoxColumn";
            this.sellingPriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // totalPurchasesExclVatDataGridViewTextBoxColumn
            // 
            this.totalPurchasesExclVatDataGridViewTextBoxColumn.DataPropertyName = "TotalPurchasesExclVat";
            this.totalPurchasesExclVatDataGridViewTextBoxColumn.HeaderText = "TotalPurchasesExclVat";
            this.totalPurchasesExclVatDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.totalPurchasesExclVatDataGridViewTextBoxColumn.Name = "totalPurchasesExclVatDataGridViewTextBoxColumn";
            this.totalPurchasesExclVatDataGridViewTextBoxColumn.Width = 150;
            // 
            // totalSalesExclVatDataGridViewTextBoxColumn
            // 
            this.totalSalesExclVatDataGridViewTextBoxColumn.DataPropertyName = "TotalSalesExclVat";
            this.totalSalesExclVatDataGridViewTextBoxColumn.HeaderText = "TotalSalesExclVat";
            this.totalSalesExclVatDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.totalSalesExclVatDataGridViewTextBoxColumn.Name = "totalSalesExclVatDataGridViewTextBoxColumn";
            this.totalSalesExclVatDataGridViewTextBoxColumn.Width = 150;
            // 
            // qtyPurchasedDataGridViewTextBoxColumn
            // 
            this.qtyPurchasedDataGridViewTextBoxColumn.DataPropertyName = "QtyPurchased";
            this.qtyPurchasedDataGridViewTextBoxColumn.HeaderText = "QtyPurchased";
            this.qtyPurchasedDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.qtyPurchasedDataGridViewTextBoxColumn.Name = "qtyPurchasedDataGridViewTextBoxColumn";
            this.qtyPurchasedDataGridViewTextBoxColumn.Width = 150;
            // 
            // qtySoldDataGridViewTextBoxColumn
            // 
            this.qtySoldDataGridViewTextBoxColumn.DataPropertyName = "QtySold";
            this.qtySoldDataGridViewTextBoxColumn.HeaderText = "QtySold";
            this.qtySoldDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.qtySoldDataGridViewTextBoxColumn.Name = "qtySoldDataGridViewTextBoxColumn";
            this.qtySoldDataGridViewTextBoxColumn.Width = 150;
            // 
            // stockOnHandDataGridViewTextBoxColumn
            // 
            this.stockOnHandDataGridViewTextBoxColumn.DataPropertyName = "StockOnHand";
            this.stockOnHandDataGridViewTextBoxColumn.HeaderText = "StockOnHand";
            this.stockOnHandDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.stockOnHandDataGridViewTextBoxColumn.Name = "stockOnHandDataGridViewTextBoxColumn";
            this.stockOnHandDataGridViewTextBoxColumn.Width = 150;
            // 
            // stockMasterTblBindingSource
            // 
            this.stockMasterTblBindingSource.DataMember = "StockMasterTbl";
            this.stockMasterTblBindingSource.DataSource = this.mngmntSystDBDataSet;
            // 
            // mngmntSystDBDataSet
            // 
            this.mngmntSystDBDataSet.DataSetName = "MngmntSystDBDataSet";
            this.mngmntSystDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockTransactionNoDataGridViewTextBoxColumn,
            this.stockCodeDataGridViewTextBoxColumn1,
            this.dateDataGridViewTextBoxColumn,
            this.transactionTypeDataGridViewTextBoxColumn,
            this.documentNoDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.unitCostDataGridViewTextBoxColumn,
            this.unitSellDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.stockTransTblBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(16, 614);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(1115, 315);
            this.dataGridView2.TabIndex = 10;
            // 
            // stockTransactionNoDataGridViewTextBoxColumn
            // 
            this.stockTransactionNoDataGridViewTextBoxColumn.DataPropertyName = "StockTransactionNo";
            this.stockTransactionNoDataGridViewTextBoxColumn.HeaderText = "StockTransactionNo";
            this.stockTransactionNoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.stockTransactionNoDataGridViewTextBoxColumn.Name = "stockTransactionNoDataGridViewTextBoxColumn";
            this.stockTransactionNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.stockTransactionNoDataGridViewTextBoxColumn.Width = 150;
            // 
            // stockCodeDataGridViewTextBoxColumn1
            // 
            this.stockCodeDataGridViewTextBoxColumn1.DataPropertyName = "StockCode";
            this.stockCodeDataGridViewTextBoxColumn1.HeaderText = "StockCode";
            this.stockCodeDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.stockCodeDataGridViewTextBoxColumn1.Name = "stockCodeDataGridViewTextBoxColumn1";
            this.stockCodeDataGridViewTextBoxColumn1.Width = 150;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 150;
            // 
            // transactionTypeDataGridViewTextBoxColumn
            // 
            this.transactionTypeDataGridViewTextBoxColumn.DataPropertyName = "TransactionType";
            this.transactionTypeDataGridViewTextBoxColumn.HeaderText = "TransactionType";
            this.transactionTypeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.transactionTypeDataGridViewTextBoxColumn.Name = "transactionTypeDataGridViewTextBoxColumn";
            this.transactionTypeDataGridViewTextBoxColumn.Width = 150;
            // 
            // documentNoDataGridViewTextBoxColumn
            // 
            this.documentNoDataGridViewTextBoxColumn.DataPropertyName = "DocumentNo";
            this.documentNoDataGridViewTextBoxColumn.HeaderText = "DocumentNo";
            this.documentNoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.documentNoDataGridViewTextBoxColumn.Name = "documentNoDataGridViewTextBoxColumn";
            this.documentNoDataGridViewTextBoxColumn.Width = 150;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 150;
            // 
            // unitCostDataGridViewTextBoxColumn
            // 
            this.unitCostDataGridViewTextBoxColumn.DataPropertyName = "UnitCost";
            this.unitCostDataGridViewTextBoxColumn.HeaderText = "UnitCost";
            this.unitCostDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.unitCostDataGridViewTextBoxColumn.Name = "unitCostDataGridViewTextBoxColumn";
            this.unitCostDataGridViewTextBoxColumn.Width = 150;
            // 
            // unitSellDataGridViewTextBoxColumn
            // 
            this.unitSellDataGridViewTextBoxColumn.DataPropertyName = "UnitSell";
            this.unitSellDataGridViewTextBoxColumn.HeaderText = "UnitSell";
            this.unitSellDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.unitSellDataGridViewTextBoxColumn.Name = "unitSellDataGridViewTextBoxColumn";
            this.unitSellDataGridViewTextBoxColumn.Width = 150;
            // 
            // stockTransTblBindingSource
            // 
            this.stockTransTblBindingSource.DataMember = "StockTransTbl";
            this.stockTransTblBindingSource.DataSource = this.mngmntSystDBDataSet;
            // 
            // stocktransSearch
            // 
            this.stocktransSearch.Location = new System.Drawing.Point(316, 558);
            this.stocktransSearch.MinimumSize = new System.Drawing.Size(323, 26);
            this.stocktransSearch.Name = "stocktransSearch";
            this.stocktransSearch.Size = new System.Drawing.Size(323, 26);
            this.stocktransSearch.TabIndex = 12;
            this.stocktransSearch.TextChanged += new System.EventHandler(this.stocktransSearch_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 561);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(281, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Search for Stock Transactions:";
            // 
            // stockMasterTblTableAdapter
            // 
            this.stockMasterTblTableAdapter.ClearBeforeFill = true;
            // 
            // stockTransTblTableAdapter
            // 
            this.stockTransTblTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(954, 553);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 40);
            this.button1.TabIndex = 17;
            this.button1.Text = "Highest Quantity";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StockEnquiryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1188, 974);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.stocktransSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "StockEnquiryForm";
            this.Text = "StockEnquiryForm";
            this.Load += new System.EventHandler(this.StockEnquiryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockMasterTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mngmntSystDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockTransTblBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox stocktransSearch;
        private System.Windows.Forms.Label label4;
        private MngmntSystDBDataSet mngmntSystDBDataSet;
        private System.Windows.Forms.BindingSource stockMasterTblBindingSource;
        private MngmntSystDBDataSetTableAdapters.StockMasterTblTableAdapter stockMasterTblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellingPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPurchasesExclVatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalSalesExclVatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyPurchasedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtySoldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockOnHandDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource stockTransTblBindingSource;
        private MngmntSystDBDataSetTableAdapters.StockTransTblTableAdapter stockTransTblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockTransactionNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockCodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitSellDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}