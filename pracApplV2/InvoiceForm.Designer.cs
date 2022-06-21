
namespace pracApplV2
{
    partial class InvoiceForm
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
            this.cmbChooseDebtor = new System.Windows.Forms.ComboBox();
            this.debtorsMasterDetailsTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mngmntSystDBDataSet = new pracApplV2.MngmntSystDBDataSet();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tbTotalSellAmtEV = new System.Windows.Forms.TextBox();
            this.tbVatAmt = new System.Windows.Forms.TextBox();
            this.tbTotalCost = new System.Windows.Forms.TextBox();
            this.dgvInvoiceHeader = new System.Windows.Forms.DataGridView();
            this.invoiceNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalSellAmountExclVatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceHeaderTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.debtorsMasterDetailsTblTableAdapter = new pracApplV2.MngmntSystDBDataSetTableAdapters.DebtorsMasterDetailsTblTableAdapter();
            this.invoiceHeaderTblTableAdapter = new pracApplV2.MngmntSystDBDataSetTableAdapters.InvoiceHeaderTblTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvStock = new System.Windows.Forms.DataGridView();
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
            this.stockMasterTblTableAdapter = new pracApplV2.MngmntSystDBDataSetTableAdapters.StockMasterTblTableAdapter();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbUnitCost = new System.Windows.Forms.TextBox();
            this.tbQtySold = new System.Windows.Forms.TextBox();
            this.tbStockCode = new System.Windows.Forms.TextBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.tbDisc = new System.Windows.Forms.TextBox();
            this.tbUnitSell = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbStockItemPrice = new System.Windows.Forms.TextBox();
            this.tbCostPrice = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbItemNo = new System.Windows.Forms.TextBox();
            this.tbInvoiceNo = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tbDiscountPerc = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnInsertInvoiceDet = new System.Windows.Forms.Button();
            this.btnUpdateStock = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddtoHeaderSect = new System.Windows.Forms.Button();
            this.dgvInvoiceDet = new System.Windows.Forms.DataGridView();
            this.invoiceNoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockCodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtySoldDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitSellDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceDetTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceDetTblTableAdapter = new pracApplV2.MngmntSystDBDataSetTableAdapters.InvoiceDetTblTableAdapter();
            this.button6 = new System.Windows.Forms.Button();
            this.rtbInvoiceDisplay = new System.Windows.Forms.RichTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cmbPaymntType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.debtorsMasterDetailsTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mngmntSystDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceHeaderTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockMasterTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceDet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetTblBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoice Header";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Account Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Sell Amount Excl Vat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "VAT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total Cost";
            // 
            // cmbChooseDebtor
            // 
            this.cmbChooseDebtor.DataSource = this.debtorsMasterDetailsTblBindingSource;
            this.cmbChooseDebtor.DisplayMember = "AccountCode";
            this.cmbChooseDebtor.FormattingEnabled = true;
            this.cmbChooseDebtor.Location = new System.Drawing.Point(305, 101);
            this.cmbChooseDebtor.Name = "cmbChooseDebtor";
            this.cmbChooseDebtor.Size = new System.Drawing.Size(200, 28);
            this.cmbChooseDebtor.TabIndex = 6;
            this.cmbChooseDebtor.ValueMember = "AccountCode";
            // 
            // debtorsMasterDetailsTblBindingSource
            // 
            this.debtorsMasterDetailsTblBindingSource.DataMember = "DebtorsMasterDetailsTbl";
            this.debtorsMasterDetailsTblBindingSource.DataSource = this.mngmntSystDBDataSet;
            // 
            // mngmntSystDBDataSet
            // 
            this.mngmntSystDBDataSet.DataSetName = "MngmntSystDBDataSet";
            this.mngmntSystDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(305, 152);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // tbTotalSellAmtEV
            // 
            this.tbTotalSellAmtEV.Location = new System.Drawing.Point(305, 202);
            this.tbTotalSellAmtEV.Name = "tbTotalSellAmtEV";
            this.tbTotalSellAmtEV.Size = new System.Drawing.Size(200, 26);
            this.tbTotalSellAmtEV.TabIndex = 8;
            this.tbTotalSellAmtEV.Text = "0";
            // 
            // tbVatAmt
            // 
            this.tbVatAmt.Location = new System.Drawing.Point(305, 252);
            this.tbVatAmt.Name = "tbVatAmt";
            this.tbVatAmt.Size = new System.Drawing.Size(200, 26);
            this.tbVatAmt.TabIndex = 9;
            // 
            // tbTotalCost
            // 
            this.tbTotalCost.Location = new System.Drawing.Point(305, 299);
            this.tbTotalCost.Name = "tbTotalCost";
            this.tbTotalCost.Size = new System.Drawing.Size(200, 26);
            this.tbTotalCost.TabIndex = 10;
            // 
            // dgvInvoiceHeader
            // 
            this.dgvInvoiceHeader.AutoGenerateColumns = false;
            this.dgvInvoiceHeader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoiceHeader.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoiceNoDataGridViewTextBoxColumn,
            this.accountCodeDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.totalSellAmountExclVatDataGridViewTextBoxColumn,
            this.vatDataGridViewTextBoxColumn,
            this.totalCostDataGridViewTextBoxColumn});
            this.dgvInvoiceHeader.DataSource = this.invoiceHeaderTblBindingSource;
            this.dgvInvoiceHeader.Location = new System.Drawing.Point(349, 929);
            this.dgvInvoiceHeader.Name = "dgvInvoiceHeader";
            this.dgvInvoiceHeader.RowHeadersWidth = 62;
            this.dgvInvoiceHeader.RowTemplate.Height = 28;
            this.dgvInvoiceHeader.Size = new System.Drawing.Size(303, 109);
            this.dgvInvoiceHeader.TabIndex = 11;
            this.dgvInvoiceHeader.Visible = false;
            // 
            // invoiceNoDataGridViewTextBoxColumn
            // 
            this.invoiceNoDataGridViewTextBoxColumn.DataPropertyName = "InvoiceNo";
            this.invoiceNoDataGridViewTextBoxColumn.HeaderText = "InvoiceNo";
            this.invoiceNoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.invoiceNoDataGridViewTextBoxColumn.Name = "invoiceNoDataGridViewTextBoxColumn";
            this.invoiceNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.invoiceNoDataGridViewTextBoxColumn.Width = 150;
            // 
            // accountCodeDataGridViewTextBoxColumn
            // 
            this.accountCodeDataGridViewTextBoxColumn.DataPropertyName = "AccountCode";
            this.accountCodeDataGridViewTextBoxColumn.HeaderText = "AccountCode";
            this.accountCodeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.accountCodeDataGridViewTextBoxColumn.Name = "accountCodeDataGridViewTextBoxColumn";
            this.accountCodeDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 150;
            // 
            // totalSellAmountExclVatDataGridViewTextBoxColumn
            // 
            this.totalSellAmountExclVatDataGridViewTextBoxColumn.DataPropertyName = "TotalSellAmountExclVat";
            this.totalSellAmountExclVatDataGridViewTextBoxColumn.HeaderText = "TotalSellAmountExclVat";
            this.totalSellAmountExclVatDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.totalSellAmountExclVatDataGridViewTextBoxColumn.Name = "totalSellAmountExclVatDataGridViewTextBoxColumn";
            this.totalSellAmountExclVatDataGridViewTextBoxColumn.Width = 150;
            // 
            // vatDataGridViewTextBoxColumn
            // 
            this.vatDataGridViewTextBoxColumn.DataPropertyName = "Vat";
            this.vatDataGridViewTextBoxColumn.HeaderText = "Vat";
            this.vatDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.vatDataGridViewTextBoxColumn.Name = "vatDataGridViewTextBoxColumn";
            this.vatDataGridViewTextBoxColumn.Width = 150;
            // 
            // totalCostDataGridViewTextBoxColumn
            // 
            this.totalCostDataGridViewTextBoxColumn.DataPropertyName = "TotalCost";
            this.totalCostDataGridViewTextBoxColumn.HeaderText = "TotalCost";
            this.totalCostDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.totalCostDataGridViewTextBoxColumn.Name = "totalCostDataGridViewTextBoxColumn";
            this.totalCostDataGridViewTextBoxColumn.Width = 150;
            // 
            // invoiceHeaderTblBindingSource
            // 
            this.invoiceHeaderTblBindingSource.DataMember = "InvoiceHeaderTbl";
            this.invoiceHeaderTblBindingSource.DataSource = this.mngmntSystDBDataSet;
            // 
            // debtorsMasterDetailsTblTableAdapter
            // 
            this.debtorsMasterDetailsTblTableAdapter.ClearBeforeFill = true;
            // 
            // invoiceHeaderTblTableAdapter
            // 
            this.invoiceHeaderTblTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(727, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 30);
            this.label7.TabIndex = 12;
            this.label7.Text = "Invoice Details";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(728, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(321, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "Select stock items to add to invoice:";
            // 
            // dgvStock
            // 
            this.dgvStock.AutoGenerateColumns = false;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockCodeDataGridViewTextBoxColumn,
            this.stockDescriptionDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.sellingPriceDataGridViewTextBoxColumn,
            this.totalPurchasesExclVatDataGridViewTextBoxColumn,
            this.totalSalesExclVatDataGridViewTextBoxColumn,
            this.qtyPurchasedDataGridViewTextBoxColumn,
            this.qtySoldDataGridViewTextBoxColumn,
            this.stockOnHandDataGridViewTextBoxColumn});
            this.dgvStock.DataSource = this.stockMasterTblBindingSource;
            this.dgvStock.Location = new System.Drawing.Point(732, 128);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.RowHeadersWidth = 62;
            this.dgvStock.RowTemplate.Height = 28;
            this.dgvStock.Size = new System.Drawing.Size(549, 184);
            this.dgvStock.TabIndex = 14;
            this.dgvStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStock_CellClick);
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
            // stockMasterTblTableAdapter
            // 
            this.stockMasterTblTableAdapter.ClearBeforeFill = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(727, 549);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 25);
            this.label9.TabIndex = 19;
            this.label9.Text = "Disc";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(727, 502);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 25);
            this.label10.TabIndex = 18;
            this.label10.Text = "Unit Sell";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(727, 452);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 25);
            this.label11.TabIndex = 17;
            this.label11.Text = "Unit Cost";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(727, 404);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 25);
            this.label12.TabIndex = 16;
            this.label12.Text = "Qty";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(727, 355);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 25);
            this.label13.TabIndex = 15;
            this.label13.Text = "Stock Code";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(727, 594);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 25);
            this.label14.TabIndex = 20;
            this.label14.Text = "Total";
            // 
            // tbUnitCost
            // 
            this.tbUnitCost.Location = new System.Drawing.Point(868, 451);
            this.tbUnitCost.Name = "tbUnitCost";
            this.tbUnitCost.Size = new System.Drawing.Size(200, 26);
            this.tbUnitCost.TabIndex = 23;
            // 
            // tbQtySold
            // 
            this.tbQtySold.Location = new System.Drawing.Point(868, 403);
            this.tbQtySold.Name = "tbQtySold";
            this.tbQtySold.Size = new System.Drawing.Size(200, 26);
            this.tbQtySold.TabIndex = 22;
            // 
            // tbStockCode
            // 
            this.tbStockCode.Location = new System.Drawing.Point(868, 356);
            this.tbStockCode.Name = "tbStockCode";
            this.tbStockCode.Size = new System.Drawing.Size(200, 26);
            this.tbStockCode.TabIndex = 21;
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(868, 598);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(200, 26);
            this.tbTotal.TabIndex = 26;
            // 
            // tbDisc
            // 
            this.tbDisc.Location = new System.Drawing.Point(868, 550);
            this.tbDisc.Name = "tbDisc";
            this.tbDisc.Size = new System.Drawing.Size(200, 26);
            this.tbDisc.TabIndex = 25;
            // 
            // tbUnitSell
            // 
            this.tbUnitSell.Location = new System.Drawing.Point(868, 503);
            this.tbUnitSell.Name = "tbUnitSell";
            this.tbUnitSell.Size = new System.Drawing.Size(200, 26);
            this.tbUnitSell.TabIndex = 24;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1113, 357);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 25);
            this.label15.TabIndex = 28;
            this.label15.Text = "Price";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(1113, 404);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 25);
            this.label16.TabIndex = 27;
            this.label16.Text = "Disc %";
            // 
            // tbStockItemPrice
            // 
            this.tbStockItemPrice.Location = new System.Drawing.Point(1181, 358);
            this.tbStockItemPrice.Name = "tbStockItemPrice";
            this.tbStockItemPrice.Size = new System.Drawing.Size(100, 26);
            this.tbStockItemPrice.TabIndex = 29;
            // 
            // tbCostPrice
            // 
            this.tbCostPrice.Location = new System.Drawing.Point(1483, 200);
            this.tbCostPrice.Name = "tbCostPrice";
            this.tbCostPrice.Size = new System.Drawing.Size(100, 26);
            this.tbCostPrice.TabIndex = 31;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(1404, 201);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 25);
            this.label17.TabIndex = 30;
            this.label17.Text = "Cost";
            // 
            // tbItemNo
            // 
            this.tbItemNo.Location = new System.Drawing.Point(868, 696);
            this.tbItemNo.Name = "tbItemNo";
            this.tbItemNo.Size = new System.Drawing.Size(200, 26);
            this.tbItemNo.TabIndex = 35;
            // 
            // tbInvoiceNo
            // 
            this.tbInvoiceNo.Location = new System.Drawing.Point(868, 648);
            this.tbInvoiceNo.Name = "tbInvoiceNo";
            this.tbInvoiceNo.Size = new System.Drawing.Size(200, 26);
            this.tbInvoiceNo.TabIndex = 34;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(727, 692);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 25);
            this.label18.TabIndex = 33;
            this.label18.Text = "Item No";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(727, 647);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(104, 25);
            this.label19.TabIndex = 32;
            this.label19.Text = "Invoice No";
            // 
            // tbDiscountPerc
            // 
            this.tbDiscountPerc.Location = new System.Drawing.Point(1197, 404);
            this.tbDiscountPerc.Name = "tbDiscountPerc";
            this.tbDiscountPerc.Size = new System.Drawing.Size(84, 26);
            this.tbDiscountPerc.TabIndex = 36;
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.DarkBlue;
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalc.Location = new System.Drawing.Point(1123, 542);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(220, 41);
            this.btnCalc.TabIndex = 37;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnInsertInvoiceDet
            // 
            this.btnInsertInvoiceDet.BackColor = System.Drawing.Color.DarkBlue;
            this.btnInsertInvoiceDet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertInvoiceDet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInsertInvoiceDet.Location = new System.Drawing.Point(1123, 609);
            this.btnInsertInvoiceDet.Name = "btnInsertInvoiceDet";
            this.btnInsertInvoiceDet.Size = new System.Drawing.Size(220, 46);
            this.btnInsertInvoiceDet.TabIndex = 38;
            this.btnInsertInvoiceDet.Text = "Add to Invoice Detail";
            this.btnInsertInvoiceDet.UseVisualStyleBackColor = false;
            this.btnInsertInvoiceDet.Click += new System.EventHandler(this.btnInsertInvoiceDet_Click);
            // 
            // btnUpdateStock
            // 
            this.btnUpdateStock.BackColor = System.Drawing.Color.DarkBlue;
            this.btnUpdateStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateStock.Location = new System.Drawing.Point(1518, 849);
            this.btnUpdateStock.Name = "btnUpdateStock";
            this.btnUpdateStock.Size = new System.Drawing.Size(38, 39);
            this.btnUpdateStock.TabIndex = 39;
            this.btnUpdateStock.Text = "Update Stock ";
            this.btnUpdateStock.UseVisualStyleBackColor = false;
            this.btnUpdateStock.Visible = false;
            this.btnUpdateStock.Click += new System.EventHandler(this.btnUpdateStock_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DarkBlue;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(1123, 680);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(220, 41);
            this.btnClear.TabIndex = 41;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddtoHeaderSect
            // 
            this.btnAddtoHeaderSect.BackColor = System.Drawing.Color.DarkBlue;
            this.btnAddtoHeaderSect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddtoHeaderSect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddtoHeaderSect.Location = new System.Drawing.Point(1463, 850);
            this.btnAddtoHeaderSect.Name = "btnAddtoHeaderSect";
            this.btnAddtoHeaderSect.Size = new System.Drawing.Size(38, 36);
            this.btnAddtoHeaderSect.TabIndex = 40;
            this.btnAddtoHeaderSect.Text = "Add to Header Section";
            this.btnAddtoHeaderSect.UseVisualStyleBackColor = false;
            this.btnAddtoHeaderSect.Visible = false;
            this.btnAddtoHeaderSect.Click += new System.EventHandler(this.btnAddtoHeaderSect_Click);
            // 
            // dgvInvoiceDet
            // 
            this.dgvInvoiceDet.AutoGenerateColumns = false;
            this.dgvInvoiceDet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoiceDet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoiceNoDataGridViewTextBoxColumn1,
            this.itemNoDataGridViewTextBoxColumn,
            this.stockCodeDataGridViewTextBoxColumn1,
            this.qtySoldDataGridViewTextBoxColumn1,
            this.unitCostDataGridViewTextBoxColumn,
            this.unitSellDataGridViewTextBoxColumn,
            this.discDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dgvInvoiceDet.DataSource = this.invoiceDetTblBindingSource;
            this.dgvInvoiceDet.Location = new System.Drawing.Point(733, 768);
            this.dgvInvoiceDet.Name = "dgvInvoiceDet";
            this.dgvInvoiceDet.RowHeadersWidth = 62;
            this.dgvInvoiceDet.RowTemplate.Height = 28;
            this.dgvInvoiceDet.Size = new System.Drawing.Size(436, 215);
            this.dgvInvoiceDet.TabIndex = 42;
            // 
            // invoiceNoDataGridViewTextBoxColumn1
            // 
            this.invoiceNoDataGridViewTextBoxColumn1.DataPropertyName = "InvoiceNo";
            this.invoiceNoDataGridViewTextBoxColumn1.HeaderText = "InvoiceNo";
            this.invoiceNoDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.invoiceNoDataGridViewTextBoxColumn1.Name = "invoiceNoDataGridViewTextBoxColumn1";
            this.invoiceNoDataGridViewTextBoxColumn1.Width = 150;
            // 
            // itemNoDataGridViewTextBoxColumn
            // 
            this.itemNoDataGridViewTextBoxColumn.DataPropertyName = "ItemNo";
            this.itemNoDataGridViewTextBoxColumn.HeaderText = "ItemNo";
            this.itemNoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.itemNoDataGridViewTextBoxColumn.Name = "itemNoDataGridViewTextBoxColumn";
            this.itemNoDataGridViewTextBoxColumn.Width = 150;
            // 
            // stockCodeDataGridViewTextBoxColumn1
            // 
            this.stockCodeDataGridViewTextBoxColumn1.DataPropertyName = "StockCode";
            this.stockCodeDataGridViewTextBoxColumn1.HeaderText = "StockCode";
            this.stockCodeDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.stockCodeDataGridViewTextBoxColumn1.Name = "stockCodeDataGridViewTextBoxColumn1";
            this.stockCodeDataGridViewTextBoxColumn1.Width = 150;
            // 
            // qtySoldDataGridViewTextBoxColumn1
            // 
            this.qtySoldDataGridViewTextBoxColumn1.DataPropertyName = "QtySold";
            this.qtySoldDataGridViewTextBoxColumn1.HeaderText = "QtySold";
            this.qtySoldDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.qtySoldDataGridViewTextBoxColumn1.Name = "qtySoldDataGridViewTextBoxColumn1";
            this.qtySoldDataGridViewTextBoxColumn1.Width = 150;
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
            // discDataGridViewTextBoxColumn
            // 
            this.discDataGridViewTextBoxColumn.DataPropertyName = "Disc";
            this.discDataGridViewTextBoxColumn.HeaderText = "Disc";
            this.discDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.discDataGridViewTextBoxColumn.Name = "discDataGridViewTextBoxColumn";
            this.discDataGridViewTextBoxColumn.Width = 150;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.Width = 150;
            // 
            // invoiceDetTblBindingSource
            // 
            this.invoiceDetTblBindingSource.DataMember = "InvoiceDetTbl";
            this.invoiceDetTblBindingSource.DataSource = this.mngmntSystDBDataSet;
            // 
            // invoiceDetTblTableAdapter
            // 
            this.invoiceDetTblTableAdapter.ClearBeforeFill = true;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DarkBlue;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(39, 403);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(221, 44);
            this.button6.TabIndex = 43;
            this.button6.Text = "Add to Invoice Header\r\n\r\n";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // rtbInvoiceDisplay
            // 
            this.rtbInvoiceDisplay.Location = new System.Drawing.Point(39, 466);
            this.rtbInvoiceDisplay.Name = "rtbInvoiceDisplay";
            this.rtbInvoiceDisplay.Size = new System.Drawing.Size(598, 434);
            this.rtbInvoiceDisplay.TabIndex = 44;
            this.rtbInvoiceDisplay.Text = "";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(36, 346);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(139, 25);
            this.label20.TabIndex = 45;
            this.label20.Text = "Payment Type";
            // 
            // cmbPaymntType
            // 
            this.cmbPaymntType.FormattingEnabled = true;
            this.cmbPaymntType.Items.AddRange(new object[] {
            "Cash ",
            "Credit "});
            this.cmbPaymntType.Location = new System.Drawing.Point(305, 346);
            this.cmbPaymntType.Name = "cmbPaymntType";
            this.cmbPaymntType.Size = new System.Drawing.Size(200, 28);
            this.cmbPaymntType.TabIndex = 46;
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1605, 1050);
            this.Controls.Add(this.cmbPaymntType);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.rtbInvoiceDisplay);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dgvInvoiceDet);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddtoHeaderSect);
            this.Controls.Add(this.btnUpdateStock);
            this.Controls.Add(this.btnInsertInvoiceDet);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.tbDiscountPerc);
            this.Controls.Add(this.tbItemNo);
            this.Controls.Add(this.tbInvoiceNo);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.tbCostPrice);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.tbStockItemPrice);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.tbDisc);
            this.Controls.Add(this.tbUnitSell);
            this.Controls.Add(this.tbUnitCost);
            this.Controls.Add(this.tbQtySold);
            this.Controls.Add(this.tbStockCode);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgvStock);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvInvoiceHeader);
            this.Controls.Add(this.tbTotalCost);
            this.Controls.Add(this.tbVatAmt);
            this.Controls.Add(this.tbTotalSellAmtEV);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmbChooseDebtor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InvoiceForm";
            this.Text = "InvoiceForm";
            this.Load += new System.EventHandler(this.InvoiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.debtorsMasterDetailsTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mngmntSystDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceHeaderTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockMasterTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceDet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetTblBindingSource)).EndInit();
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
        private System.Windows.Forms.ComboBox cmbChooseDebtor;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox tbTotalSellAmtEV;
        private System.Windows.Forms.TextBox tbVatAmt;
        private System.Windows.Forms.TextBox tbTotalCost;
        private System.Windows.Forms.DataGridView dgvInvoiceHeader;
        private MngmntSystDBDataSet mngmntSystDBDataSet;
        private System.Windows.Forms.BindingSource debtorsMasterDetailsTblBindingSource;
        private MngmntSystDBDataSetTableAdapters.DebtorsMasterDetailsTblTableAdapter debtorsMasterDetailsTblTableAdapter;
        private System.Windows.Forms.BindingSource invoiceHeaderTblBindingSource;
        private MngmntSystDBDataSetTableAdapters.InvoiceHeaderTblTableAdapter invoiceHeaderTblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalSellAmountExclVatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvStock;
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbUnitCost;
        private System.Windows.Forms.TextBox tbQtySold;
        private System.Windows.Forms.TextBox tbStockCode;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.TextBox tbDisc;
        private System.Windows.Forms.TextBox tbUnitSell;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbStockItemPrice;
        private System.Windows.Forms.TextBox tbCostPrice;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbItemNo;
        private System.Windows.Forms.TextBox tbInvoiceNo;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbDiscountPerc;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnInsertInvoiceDet;
        private System.Windows.Forms.Button btnUpdateStock;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAddtoHeaderSect;
        private System.Windows.Forms.DataGridView dgvInvoiceDet;
        private System.Windows.Forms.BindingSource invoiceDetTblBindingSource;
        private MngmntSystDBDataSetTableAdapters.InvoiceDetTblTableAdapter invoiceDetTblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceNoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockCodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtySoldDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitSellDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.RichTextBox rtbInvoiceDisplay;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cmbPaymntType;
    }
}