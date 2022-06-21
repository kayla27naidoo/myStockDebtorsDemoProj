
namespace pracApplV2
{
    partial class StockAdjustmentsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tbTotPurchEV = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.tbQuantityPurch = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.tbStockOnHand = new System.Windows.Forms.TextBox();
            this.incomingStockQty = new System.Windows.Forms.TextBox();
            this.dgvStockDetails = new System.Windows.Forms.DataGridView();
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
            this.label11 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.stockMasterTblTableAdapter = new pracApplV2.MngmntSystDBDataSetTableAdapters.StockMasterTblTableAdapter();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockMasterTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mngmntSystDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stock Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stock Descr";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Selling Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Total Purchases Excl Vat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Total Sales Excl Vat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 435);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Qty Purchased";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 490);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Qty Sold";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(32, 544);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 25);
            this.label9.TabIndex = 9;
            this.label9.Text = "Stock On Hand";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(32, 597);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(245, 25);
            this.label10.TabIndex = 8;
            this.label10.Text = "Incoming Quantity of Stock";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(297, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 26);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(297, 158);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 26);
            this.textBox2.TabIndex = 11;
            // 
            // tbCost
            // 
            this.tbCost.Location = new System.Drawing.Point(297, 211);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(156, 26);
            this.tbCost.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(297, 266);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(156, 26);
            this.textBox4.TabIndex = 13;
            // 
            // tbTotPurchEV
            // 
            this.tbTotPurchEV.Location = new System.Drawing.Point(297, 319);
            this.tbTotPurchEV.Name = "tbTotPurchEV";
            this.tbTotPurchEV.Size = new System.Drawing.Size(156, 26);
            this.tbTotPurchEV.TabIndex = 14;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(297, 377);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(156, 26);
            this.textBox6.TabIndex = 15;
            // 
            // tbQuantityPurch
            // 
            this.tbQuantityPurch.Location = new System.Drawing.Point(297, 434);
            this.tbQuantityPurch.Name = "tbQuantityPurch";
            this.tbQuantityPurch.Size = new System.Drawing.Size(156, 26);
            this.tbQuantityPurch.TabIndex = 16;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(297, 489);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(156, 26);
            this.textBox8.TabIndex = 17;
            // 
            // tbStockOnHand
            // 
            this.tbStockOnHand.Location = new System.Drawing.Point(297, 543);
            this.tbStockOnHand.Name = "tbStockOnHand";
            this.tbStockOnHand.Size = new System.Drawing.Size(156, 26);
            this.tbStockOnHand.TabIndex = 18;
            // 
            // incomingStockQty
            // 
            this.incomingStockQty.Location = new System.Drawing.Point(297, 596);
            this.incomingStockQty.Name = "incomingStockQty";
            this.incomingStockQty.Size = new System.Drawing.Size(156, 26);
            this.incomingStockQty.TabIndex = 19;
            // 
            // dgvStockDetails
            // 
            this.dgvStockDetails.AutoGenerateColumns = false;
            this.dgvStockDetails.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvStockDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockCodeDataGridViewTextBoxColumn,
            this.stockDescriptionDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.sellingPriceDataGridViewTextBoxColumn,
            this.totalPurchasesExclVatDataGridViewTextBoxColumn,
            this.totalSalesExclVatDataGridViewTextBoxColumn,
            this.qtyPurchasedDataGridViewTextBoxColumn,
            this.qtySoldDataGridViewTextBoxColumn,
            this.stockOnHandDataGridViewTextBoxColumn});
            this.dgvStockDetails.DataSource = this.stockMasterTblBindingSource;
            this.dgvStockDetails.Location = new System.Drawing.Point(491, 159);
            this.dgvStockDetails.Name = "dgvStockDetails";
            this.dgvStockDetails.RowHeadersWidth = 62;
            this.dgvStockDetails.RowTemplate.Height = 28;
            this.dgvStockDetails.Size = new System.Drawing.Size(655, 395);
            this.dgvStockDetails.TabIndex = 20;
            this.dgvStockDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStockDetails_CellClick);
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(486, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(210, 25);
            this.label11.TabIndex = 21;
            this.label11.Text = "Search for Stock Code";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(702, 100);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(219, 26);
            this.tbSearch.TabIndex = 22;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // stockMasterTblTableAdapter
            // 
            this.stockMasterTblTableAdapter.ClearBeforeFill = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(503, 587);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(177, 46);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(33, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(197, 30);
            this.label12.TabIndex = 24;
            this.label12.Text = "Receiving Stock";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DarkBlue;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(718, 587);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(177, 46);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // StockAdjustmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1206, 735);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgvStockDetails);
            this.Controls.Add(this.incomingStockQty);
            this.Controls.Add(this.tbStockOnHand);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.tbQuantityPurch);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.tbTotPurchEV);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.tbCost);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StockAdjustmentsForm";
            this.Text = "StockAdjustmentsForm";
            this.Load += new System.EventHandler(this.StockAdjustmentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockMasterTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mngmntSystDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox tbTotPurchEV;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox tbQuantityPurch;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox tbStockOnHand;
        private System.Windows.Forms.TextBox incomingStockQty;
        private System.Windows.Forms.DataGridView dgvStockDetails;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbSearch;
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
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnClear;
    }
}