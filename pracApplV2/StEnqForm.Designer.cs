
namespace pracApplV2
{
    partial class StEnqForm
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
            this.tabControlStockEnquiryForm = new System.Windows.Forms.TabControl();
            this.tabPageViewStockItemDet = new System.Windows.Forms.TabPage();
            this.tbSearchForStockCode = new System.Windows.Forms.TextBox();
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageStockEnqScreen = new System.Windows.Forms.TabPage();
            this.btnLowestQty = new System.Windows.Forms.Button();
            this.btnHighestQty = new System.Windows.Forms.Button();
            this.btnRecentDebtor = new System.Windows.Forms.Button();
            this.dgvStockEnquiryScreen = new System.Windows.Forms.DataGridView();
            this.invoiceNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockCodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtySoldDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitSellDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTStockEnqDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbLowestQuantity = new System.Windows.Forms.TextBox();
            this.tbHighestQuantity = new System.Windows.Forms.TextBox();
            this.tbMostRecentDebtor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stockMasterTblTableAdapter = new pracApplV2.MngmntSystDBDataSetTableAdapters.StockMasterTblTableAdapter();
            this.dTStockEnqDetailsTableAdapter = new pracApplV2.MngmntSystDBDataSetTableAdapters.DTStockEnqDetailsTableAdapter();
            this.tabControlStockEnquiryForm.SuspendLayout();
            this.tabPageViewStockItemDet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockMasterTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mngmntSystDBDataSet)).BeginInit();
            this.tabPageStockEnqScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockEnquiryScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTStockEnqDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlStockEnquiryForm
            // 
            this.tabControlStockEnquiryForm.Controls.Add(this.tabPageViewStockItemDet);
            this.tabControlStockEnquiryForm.Controls.Add(this.tabPageStockEnqScreen);
            this.tabControlStockEnquiryForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControlStockEnquiryForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlStockEnquiryForm.ItemSize = new System.Drawing.Size(245, 40);
            this.tabControlStockEnquiryForm.Location = new System.Drawing.Point(0, 0);
            this.tabControlStockEnquiryForm.Name = "tabControlStockEnquiryForm";
            this.tabControlStockEnquiryForm.SelectedIndex = 0;
            this.tabControlStockEnquiryForm.Size = new System.Drawing.Size(1253, 861);
            this.tabControlStockEnquiryForm.TabIndex = 0;
            // 
            // tabPageViewStockItemDet
            // 
            this.tabPageViewStockItemDet.AutoScroll = true;
            this.tabPageViewStockItemDet.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tabPageViewStockItemDet.Controls.Add(this.tbSearchForStockCode);
            this.tabPageViewStockItemDet.Controls.Add(this.dataGridView1);
            this.tabPageViewStockItemDet.Controls.Add(this.label1);
            this.tabPageViewStockItemDet.Location = new System.Drawing.Point(4, 44);
            this.tabPageViewStockItemDet.Name = "tabPageViewStockItemDet";
            this.tabPageViewStockItemDet.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageViewStockItemDet.Size = new System.Drawing.Size(1245, 813);
            this.tabPageViewStockItemDet.TabIndex = 0;
            this.tabPageViewStockItemDet.Text = "View Stock Item Details";
            // 
            // tbSearchForStockCode
            // 
            this.tbSearchForStockCode.Location = new System.Drawing.Point(231, 43);
            this.tbSearchForStockCode.Name = "tbSearchForStockCode";
            this.tbSearchForStockCode.Size = new System.Drawing.Size(220, 30);
            this.tbSearchForStockCode.TabIndex = 5;
            this.tbSearchForStockCode.TextChanged += new System.EventHandler(this.tbSearchForStockCode_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
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
            this.dataGridView1.Location = new System.Drawing.Point(35, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1083, 321);
            this.dataGridView1.TabIndex = 4;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search for Stock Item";
            // 
            // tabPageStockEnqScreen
            // 
            this.tabPageStockEnqScreen.AutoScroll = true;
            this.tabPageStockEnqScreen.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tabPageStockEnqScreen.Controls.Add(this.btnLowestQty);
            this.tabPageStockEnqScreen.Controls.Add(this.btnHighestQty);
            this.tabPageStockEnqScreen.Controls.Add(this.btnRecentDebtor);
            this.tabPageStockEnqScreen.Controls.Add(this.dgvStockEnquiryScreen);
            this.tabPageStockEnqScreen.Controls.Add(this.tbLowestQuantity);
            this.tabPageStockEnqScreen.Controls.Add(this.tbHighestQuantity);
            this.tabPageStockEnqScreen.Controls.Add(this.tbMostRecentDebtor);
            this.tabPageStockEnqScreen.Controls.Add(this.label5);
            this.tabPageStockEnqScreen.Controls.Add(this.label4);
            this.tabPageStockEnqScreen.Controls.Add(this.label3);
            this.tabPageStockEnqScreen.Controls.Add(this.label2);
            this.tabPageStockEnqScreen.Location = new System.Drawing.Point(4, 44);
            this.tabPageStockEnqScreen.Name = "tabPageStockEnqScreen";
            this.tabPageStockEnqScreen.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStockEnqScreen.Size = new System.Drawing.Size(1245, 813);
            this.tabPageStockEnqScreen.TabIndex = 1;
            this.tabPageStockEnqScreen.Text = "Stock Enquiry Screen";
            // 
            // btnLowestQty
            // 
            this.btnLowestQty.BackColor = System.Drawing.Color.Navy;
            this.btnLowestQty.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLowestQty.Location = new System.Drawing.Point(792, 217);
            this.btnLowestQty.Name = "btnLowestQty";
            this.btnLowestQty.Size = new System.Drawing.Size(323, 40);
            this.btnLowestQty.TabIndex = 17;
            this.btnLowestQty.Text = "Lowest Qty on Invoice";
            this.btnLowestQty.UseVisualStyleBackColor = false;
            this.btnLowestQty.Click += new System.EventHandler(this.btnLowestQty_Click);
            // 
            // btnHighestQty
            // 
            this.btnHighestQty.BackColor = System.Drawing.Color.Navy;
            this.btnHighestQty.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHighestQty.Location = new System.Drawing.Point(792, 160);
            this.btnHighestQty.Name = "btnHighestQty";
            this.btnHighestQty.Size = new System.Drawing.Size(323, 41);
            this.btnHighestQty.TabIndex = 16;
            this.btnHighestQty.Text = "Highest Qty on Invoice";
            this.btnHighestQty.UseVisualStyleBackColor = false;
            this.btnHighestQty.Click += new System.EventHandler(this.btnHighestQty_Click);
            // 
            // btnRecentDebtor
            // 
            this.btnRecentDebtor.BackColor = System.Drawing.Color.Navy;
            this.btnRecentDebtor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRecentDebtor.Location = new System.Drawing.Point(792, 107);
            this.btnRecentDebtor.Name = "btnRecentDebtor";
            this.btnRecentDebtor.Size = new System.Drawing.Size(323, 41);
            this.btnRecentDebtor.TabIndex = 15;
            this.btnRecentDebtor.Text = "Most Recent Debtor \r\n";
            this.btnRecentDebtor.UseVisualStyleBackColor = false;
            this.btnRecentDebtor.Click += new System.EventHandler(this.btnRecentDebtor_Click);
            // 
            // dgvStockEnquiryScreen
            // 
            this.dgvStockEnquiryScreen.AutoGenerateColumns = false;
            this.dgvStockEnquiryScreen.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvStockEnquiryScreen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockEnquiryScreen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoiceNoDataGridViewTextBoxColumn,
            this.accountCodeDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.stockCodeDataGridViewTextBoxColumn1,
            this.qtySoldDataGridViewTextBoxColumn1,
            this.unitCostDataGridViewTextBoxColumn,
            this.unitSellDataGridViewTextBoxColumn,
            this.discDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.itemNoDataGridViewTextBoxColumn});
            this.dgvStockEnquiryScreen.DataSource = this.dTStockEnqDetailsBindingSource;
            this.dgvStockEnquiryScreen.Location = new System.Drawing.Point(29, 300);
            this.dgvStockEnquiryScreen.Name = "dgvStockEnquiryScreen";
            this.dgvStockEnquiryScreen.RowHeadersWidth = 62;
            this.dgvStockEnquiryScreen.RowTemplate.Height = 28;
            this.dgvStockEnquiryScreen.Size = new System.Drawing.Size(1086, 335);
            this.dgvStockEnquiryScreen.TabIndex = 14;
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
            // itemNoDataGridViewTextBoxColumn
            // 
            this.itemNoDataGridViewTextBoxColumn.DataPropertyName = "ItemNo";
            this.itemNoDataGridViewTextBoxColumn.HeaderText = "ItemNo";
            this.itemNoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.itemNoDataGridViewTextBoxColumn.Name = "itemNoDataGridViewTextBoxColumn";
            this.itemNoDataGridViewTextBoxColumn.Width = 150;
            // 
            // dTStockEnqDetailsBindingSource
            // 
            this.dTStockEnqDetailsBindingSource.DataMember = "DTStockEnqDetails";
            this.dTStockEnqDetailsBindingSource.DataSource = this.mngmntSystDBDataSet;
            // 
            // tbLowestQuantity
            // 
            this.tbLowestQuantity.Location = new System.Drawing.Point(1006, 762);
            this.tbLowestQuantity.Name = "tbLowestQuantity";
            this.tbLowestQuantity.Size = new System.Drawing.Size(190, 30);
            this.tbLowestQuantity.TabIndex = 13;
            this.tbLowestQuantity.Visible = false;
            this.tbLowestQuantity.TextChanged += new System.EventHandler(this.tbLowestQuantity_TextChanged);
            // 
            // tbHighestQuantity
            // 
            this.tbHighestQuantity.Location = new System.Drawing.Point(1006, 708);
            this.tbHighestQuantity.Name = "tbHighestQuantity";
            this.tbHighestQuantity.Size = new System.Drawing.Size(190, 30);
            this.tbHighestQuantity.TabIndex = 12;
            this.tbHighestQuantity.Visible = false;
            this.tbHighestQuantity.TextChanged += new System.EventHandler(this.tbHighestQuantity_TextChanged);
            // 
            // tbMostRecentDebtor
            // 
            this.tbMostRecentDebtor.Location = new System.Drawing.Point(269, 118);
            this.tbMostRecentDebtor.Name = "tbMostRecentDebtor";
            this.tbMostRecentDebtor.Size = new System.Drawing.Size(190, 30);
            this.tbMostRecentDebtor.TabIndex = 11;
            this.tbMostRecentDebtor.TextChanged += new System.EventHandler(this.tbMostRecentDebtor_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(650, 767);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(293, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Transaction with lowest quantity:";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(650, 711);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(301, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Transaction with highest quantity:";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Search by Stock Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "Filter Search";
            // 
            // stockMasterTblTableAdapter
            // 
            this.stockMasterTblTableAdapter.ClearBeforeFill = true;
            // 
            // dTStockEnqDetailsTableAdapter
            // 
            this.dTStockEnqDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // StEnqForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1253, 873);
            this.Controls.Add(this.tabControlStockEnquiryForm);
            this.Name = "StEnqForm";
            this.Text = "Stock Enquiry Form";
            this.Load += new System.EventHandler(this.StEnqForm_Load);
            this.tabControlStockEnquiryForm.ResumeLayout(false);
            this.tabPageViewStockItemDet.ResumeLayout(false);
            this.tabPageViewStockItemDet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockMasterTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mngmntSystDBDataSet)).EndInit();
            this.tabPageStockEnqScreen.ResumeLayout(false);
            this.tabPageStockEnqScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockEnquiryScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTStockEnqDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlStockEnquiryForm;
        private System.Windows.Forms.TabPage tabPageViewStockItemDet;
        private System.Windows.Forms.TabPage tabPageStockEnqScreen;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.TextBox tbSearchForStockCode;
        private System.Windows.Forms.TextBox tbLowestQuantity;
        private System.Windows.Forms.TextBox tbHighestQuantity;
        private System.Windows.Forms.TextBox tbMostRecentDebtor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvStockEnquiryScreen;
        private System.Windows.Forms.BindingSource dTStockEnqDetailsBindingSource;
        private MngmntSystDBDataSetTableAdapters.DTStockEnqDetailsTableAdapter dTStockEnqDetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockCodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtySoldDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitSellDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnLowestQty;
        private System.Windows.Forms.Button btnHighestQty;
        private System.Windows.Forms.Button btnRecentDebtor;
    }
}