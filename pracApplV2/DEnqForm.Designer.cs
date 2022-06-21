
namespace pracApplV2
{
    partial class DEnqForm
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
            this.tabControlDebtorsEnqForm = new System.Windows.Forms.TabControl();
            this.tabPageViewDebtorsDetails = new System.Windows.Forms.TabPage();
            this.dgvViewDebtorsDetails = new System.Windows.Forms.DataGridView();
            this.accountCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debtorsMasterDetailsTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mngmntSystDBDataSet = new pracApplV2.MngmntSystDBDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSearchForDebtor = new System.Windows.Forms.TextBox();
            this.tabPageDebtorsEnquiryScreen = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.invoiceNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountCodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtySoldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitSellDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalSellAmountExclVatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debtorsEnquiryTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnLowestQty = new System.Windows.Forms.Button();
            this.btnHighestQty = new System.Windows.Forms.Button();
            this.btnRecentDebtor = new System.Windows.Forms.Button();
            this.tbLowestValue = new System.Windows.Forms.TextBox();
            this.tbHighestValue = new System.Windows.Forms.TextBox();
            this.tbMostRecentItemSold = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dEnquiryDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.debtorsMasterDetailsTblTableAdapter = new pracApplV2.MngmntSystDBDataSetTableAdapters.DebtorsMasterDetailsTblTableAdapter();
            this.dEnquiryDetailsTableAdapter = new pracApplV2.MngmntSystDBDataSetTableAdapters.DEnquiryDetailsTableAdapter();
            this.dEnquiryDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.debtorsEnquiryTableTableAdapter = new pracApplV2.MngmntSystDBDataSetTableAdapters.DebtorsEnquiryTableTableAdapter();
            this.debtorsMasterDetailsTbl1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.debtorsMasterDetailsTbl1TableAdapter = new pracApplV2.MngmntSystDBDataSetTableAdapters.DebtorsMasterDetailsTbl1TableAdapter();
            this.tabControlDebtorsEnqForm.SuspendLayout();
            this.tabPageViewDebtorsDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewDebtorsDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.debtorsMasterDetailsTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mngmntSystDBDataSet)).BeginInit();
            this.tabPageDebtorsEnquiryScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.debtorsEnquiryTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEnquiryDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEnquiryDetailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.debtorsMasterDetailsTbl1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlDebtorsEnqForm
            // 
            this.tabControlDebtorsEnqForm.Controls.Add(this.tabPageViewDebtorsDetails);
            this.tabControlDebtorsEnqForm.Controls.Add(this.tabPageDebtorsEnquiryScreen);
            this.tabControlDebtorsEnqForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControlDebtorsEnqForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlDebtorsEnqForm.ItemSize = new System.Drawing.Size(245, 40);
            this.tabControlDebtorsEnqForm.Location = new System.Drawing.Point(0, 0);
            this.tabControlDebtorsEnqForm.Name = "tabControlDebtorsEnqForm";
            this.tabControlDebtorsEnqForm.SelectedIndex = 0;
            this.tabControlDebtorsEnqForm.Size = new System.Drawing.Size(1225, 984);
            this.tabControlDebtorsEnqForm.TabIndex = 0;
            // 
            // tabPageViewDebtorsDetails
            // 
            this.tabPageViewDebtorsDetails.AutoScroll = true;
            this.tabPageViewDebtorsDetails.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tabPageViewDebtorsDetails.Controls.Add(this.dgvViewDebtorsDetails);
            this.tabPageViewDebtorsDetails.Controls.Add(this.label1);
            this.tabPageViewDebtorsDetails.Controls.Add(this.tbSearchForDebtor);
            this.tabPageViewDebtorsDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageViewDebtorsDetails.Location = new System.Drawing.Point(4, 44);
            this.tabPageViewDebtorsDetails.Name = "tabPageViewDebtorsDetails";
            this.tabPageViewDebtorsDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageViewDebtorsDetails.Size = new System.Drawing.Size(1217, 936);
            this.tabPageViewDebtorsDetails.TabIndex = 0;
            this.tabPageViewDebtorsDetails.Text = "View Debtors Details";
            // 
            // dgvViewDebtorsDetails
            // 
            this.dgvViewDebtorsDetails.AutoGenerateColumns = false;
            this.dgvViewDebtorsDetails.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvViewDebtorsDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewDebtorsDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountCodeDataGridViewTextBoxColumn,
            this.address1DataGridViewTextBoxColumn,
            this.address2DataGridViewTextBoxColumn,
            this.address3DataGridViewTextBoxColumn,
            this.balanceDataGridViewTextBoxColumn});
            this.dgvViewDebtorsDetails.DataSource = this.debtorsMasterDetailsTbl1BindingSource;
            this.dgvViewDebtorsDetails.Location = new System.Drawing.Point(41, 109);
            this.dgvViewDebtorsDetails.Name = "dgvViewDebtorsDetails";
            this.dgvViewDebtorsDetails.RowHeadersWidth = 62;
            this.dgvViewDebtorsDetails.RowTemplate.Height = 28;
            this.dgvViewDebtorsDetails.Size = new System.Drawing.Size(964, 315);
            this.dgvViewDebtorsDetails.TabIndex = 2;
            // 
            // accountCodeDataGridViewTextBoxColumn
            // 
            this.accountCodeDataGridViewTextBoxColumn.DataPropertyName = "AccountCode";
            this.accountCodeDataGridViewTextBoxColumn.HeaderText = "AccountCode";
            this.accountCodeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.accountCodeDataGridViewTextBoxColumn.Name = "accountCodeDataGridViewTextBoxColumn";
            this.accountCodeDataGridViewTextBoxColumn.Width = 150;
            // 
            // address1DataGridViewTextBoxColumn
            // 
            this.address1DataGridViewTextBoxColumn.DataPropertyName = "Address1";
            this.address1DataGridViewTextBoxColumn.HeaderText = "Address1";
            this.address1DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.address1DataGridViewTextBoxColumn.Name = "address1DataGridViewTextBoxColumn";
            this.address1DataGridViewTextBoxColumn.Width = 150;
            // 
            // address2DataGridViewTextBoxColumn
            // 
            this.address2DataGridViewTextBoxColumn.DataPropertyName = "Address2";
            this.address2DataGridViewTextBoxColumn.HeaderText = "Address2";
            this.address2DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.address2DataGridViewTextBoxColumn.Name = "address2DataGridViewTextBoxColumn";
            this.address2DataGridViewTextBoxColumn.Width = 150;
            // 
            // address3DataGridViewTextBoxColumn
            // 
            this.address3DataGridViewTextBoxColumn.DataPropertyName = "Address3";
            this.address3DataGridViewTextBoxColumn.HeaderText = "Address3";
            this.address3DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.address3DataGridViewTextBoxColumn.Name = "address3DataGridViewTextBoxColumn";
            this.address3DataGridViewTextBoxColumn.Width = 150;
            // 
            // balanceDataGridViewTextBoxColumn
            // 
            this.balanceDataGridViewTextBoxColumn.DataPropertyName = "Balance";
            this.balanceDataGridViewTextBoxColumn.HeaderText = "Balance";
            this.balanceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            this.balanceDataGridViewTextBoxColumn.Width = 150;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search for debtor";
            // 
            // tbSearchForDebtor
            // 
            this.tbSearchForDebtor.Location = new System.Drawing.Point(204, 49);
            this.tbSearchForDebtor.Name = "tbSearchForDebtor";
            this.tbSearchForDebtor.Size = new System.Drawing.Size(231, 30);
            this.tbSearchForDebtor.TabIndex = 0;
            this.tbSearchForDebtor.TextChanged += new System.EventHandler(this.tbSearchForDebtor_TextChanged);
            // 
            // tabPageDebtorsEnquiryScreen
            // 
            this.tabPageDebtorsEnquiryScreen.AutoScroll = true;
            this.tabPageDebtorsEnquiryScreen.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tabPageDebtorsEnquiryScreen.Controls.Add(this.dataGridView1);
            this.tabPageDebtorsEnquiryScreen.Controls.Add(this.btnLowestQty);
            this.tabPageDebtorsEnquiryScreen.Controls.Add(this.btnHighestQty);
            this.tabPageDebtorsEnquiryScreen.Controls.Add(this.btnRecentDebtor);
            this.tabPageDebtorsEnquiryScreen.Controls.Add(this.tbLowestValue);
            this.tabPageDebtorsEnquiryScreen.Controls.Add(this.tbHighestValue);
            this.tabPageDebtorsEnquiryScreen.Controls.Add(this.tbMostRecentItemSold);
            this.tabPageDebtorsEnquiryScreen.Controls.Add(this.label5);
            this.tabPageDebtorsEnquiryScreen.Controls.Add(this.label4);
            this.tabPageDebtorsEnquiryScreen.Controls.Add(this.label3);
            this.tabPageDebtorsEnquiryScreen.Controls.Add(this.label2);
            this.tabPageDebtorsEnquiryScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageDebtorsEnquiryScreen.Location = new System.Drawing.Point(4, 44);
            this.tabPageDebtorsEnquiryScreen.Name = "tabPageDebtorsEnquiryScreen";
            this.tabPageDebtorsEnquiryScreen.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDebtorsEnquiryScreen.Size = new System.Drawing.Size(1217, 936);
            this.tabPageDebtorsEnquiryScreen.TabIndex = 1;
            this.tabPageDebtorsEnquiryScreen.Text = "Debtors Enquiry Screen";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoiceNoDataGridViewTextBoxColumn,
            this.accountCodeDataGridViewTextBoxColumn1,
            this.dateDataGridViewTextBoxColumn,
            this.stockCodeDataGridViewTextBoxColumn,
            this.qtySoldDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.unitSellDataGridViewTextBoxColumn,
            this.discDataGridViewTextBoxColumn,
            this.unitCostDataGridViewTextBoxColumn,
            this.totalSellAmountExclVatDataGridViewTextBoxColumn,
            this.vatDataGridViewTextBoxColumn,
            this.totalCostDataGridViewTextBoxColumn,
            this.expr1DataGridViewTextBoxColumn,
            this.itemNoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.debtorsEnquiryTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 309);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1081, 317);
            this.dataGridView1.TabIndex = 21;
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
            // accountCodeDataGridViewTextBoxColumn1
            // 
            this.accountCodeDataGridViewTextBoxColumn1.DataPropertyName = "AccountCode";
            this.accountCodeDataGridViewTextBoxColumn1.HeaderText = "AccountCode";
            this.accountCodeDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.accountCodeDataGridViewTextBoxColumn1.Name = "accountCodeDataGridViewTextBoxColumn1";
            this.accountCodeDataGridViewTextBoxColumn1.Width = 150;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 150;
            // 
            // stockCodeDataGridViewTextBoxColumn
            // 
            this.stockCodeDataGridViewTextBoxColumn.DataPropertyName = "StockCode";
            this.stockCodeDataGridViewTextBoxColumn.HeaderText = "StockCode";
            this.stockCodeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.stockCodeDataGridViewTextBoxColumn.Name = "stockCodeDataGridViewTextBoxColumn";
            this.stockCodeDataGridViewTextBoxColumn.Width = 150;
            // 
            // qtySoldDataGridViewTextBoxColumn
            // 
            this.qtySoldDataGridViewTextBoxColumn.DataPropertyName = "QtySold";
            this.qtySoldDataGridViewTextBoxColumn.HeaderText = "QtySold";
            this.qtySoldDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.qtySoldDataGridViewTextBoxColumn.Name = "qtySoldDataGridViewTextBoxColumn";
            this.qtySoldDataGridViewTextBoxColumn.Width = 150;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.Width = 150;
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
            // unitCostDataGridViewTextBoxColumn
            // 
            this.unitCostDataGridViewTextBoxColumn.DataPropertyName = "UnitCost";
            this.unitCostDataGridViewTextBoxColumn.HeaderText = "UnitCost";
            this.unitCostDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.unitCostDataGridViewTextBoxColumn.Name = "unitCostDataGridViewTextBoxColumn";
            this.unitCostDataGridViewTextBoxColumn.Width = 150;
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
            // expr1DataGridViewTextBoxColumn
            // 
            this.expr1DataGridViewTextBoxColumn.DataPropertyName = "Expr1";
            this.expr1DataGridViewTextBoxColumn.HeaderText = "Expr1";
            this.expr1DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.expr1DataGridViewTextBoxColumn.Name = "expr1DataGridViewTextBoxColumn";
            this.expr1DataGridViewTextBoxColumn.Width = 150;
            // 
            // itemNoDataGridViewTextBoxColumn
            // 
            this.itemNoDataGridViewTextBoxColumn.DataPropertyName = "ItemNo";
            this.itemNoDataGridViewTextBoxColumn.HeaderText = "ItemNo";
            this.itemNoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.itemNoDataGridViewTextBoxColumn.Name = "itemNoDataGridViewTextBoxColumn";
            this.itemNoDataGridViewTextBoxColumn.Width = 150;
            // 
            // debtorsEnquiryTableBindingSource
            // 
            this.debtorsEnquiryTableBindingSource.DataMember = "DebtorsEnquiryTable";
            this.debtorsEnquiryTableBindingSource.DataSource = this.mngmntSystDBDataSet;
            // 
            // btnLowestQty
            // 
            this.btnLowestQty.BackColor = System.Drawing.Color.Navy;
            this.btnLowestQty.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLowestQty.Location = new System.Drawing.Point(782, 230);
            this.btnLowestQty.Name = "btnLowestQty";
            this.btnLowestQty.Size = new System.Drawing.Size(323, 40);
            this.btnLowestQty.TabIndex = 20;
            this.btnLowestQty.Text = "Lowest Value on Invoice";
            this.btnLowestQty.UseVisualStyleBackColor = false;
            this.btnLowestQty.Click += new System.EventHandler(this.btnLowestQty_Click);
            // 
            // btnHighestQty
            // 
            this.btnHighestQty.BackColor = System.Drawing.Color.Navy;
            this.btnHighestQty.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHighestQty.Location = new System.Drawing.Point(782, 170);
            this.btnHighestQty.Name = "btnHighestQty";
            this.btnHighestQty.Size = new System.Drawing.Size(323, 41);
            this.btnHighestQty.TabIndex = 19;
            this.btnHighestQty.Text = "Highest Value on Invoice";
            this.btnHighestQty.UseVisualStyleBackColor = false;
            this.btnHighestQty.Click += new System.EventHandler(this.btnHighestQty_Click);
            // 
            // btnRecentDebtor
            // 
            this.btnRecentDebtor.BackColor = System.Drawing.Color.Navy;
            this.btnRecentDebtor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRecentDebtor.Location = new System.Drawing.Point(782, 113);
            this.btnRecentDebtor.Name = "btnRecentDebtor";
            this.btnRecentDebtor.Size = new System.Drawing.Size(323, 41);
            this.btnRecentDebtor.TabIndex = 18;
            this.btnRecentDebtor.Text = "Most Recent Item Sold to Debtor";
            this.btnRecentDebtor.UseVisualStyleBackColor = false;
            this.btnRecentDebtor.Click += new System.EventHandler(this.btnRecentDebtor_Click);
            // 
            // tbLowestValue
            // 
            this.tbLowestValue.Location = new System.Drawing.Point(900, 763);
            this.tbLowestValue.Name = "tbLowestValue";
            this.tbLowestValue.Size = new System.Drawing.Size(190, 30);
            this.tbLowestValue.TabIndex = 6;
            this.tbLowestValue.Visible = false;
            this.tbLowestValue.TextChanged += new System.EventHandler(this.tbLowestValue_TextChanged);
            // 
            // tbHighestValue
            // 
            this.tbHighestValue.Location = new System.Drawing.Point(900, 710);
            this.tbHighestValue.Name = "tbHighestValue";
            this.tbHighestValue.Size = new System.Drawing.Size(190, 30);
            this.tbHighestValue.TabIndex = 5;
            this.tbHighestValue.Visible = false;
            this.tbHighestValue.TextChanged += new System.EventHandler(this.tbHighestValue_TextChanged);
            // 
            // tbMostRecentItemSold
            // 
            this.tbMostRecentItemSold.Location = new System.Drawing.Point(277, 121);
            this.tbMostRecentItemSold.Name = "tbMostRecentItemSold";
            this.tbMostRecentItemSold.Size = new System.Drawing.Size(190, 30);
            this.tbMostRecentItemSold.TabIndex = 4;
            this.tbMostRecentItemSold.TextChanged += new System.EventHandler(this.tbMostRecentItemSold_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(653, 766);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Lowest value on invoice:";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(653, 710);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Highest value on invoice:";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Search by Account Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Filter Search";
            // 
            // dEnquiryDetailsBindingSource
            // 
            this.dEnquiryDetailsBindingSource.DataMember = "DEnquiryDetails";
            this.dEnquiryDetailsBindingSource.DataSource = this.mngmntSystDBDataSet;
            // 
            // debtorsMasterDetailsTblTableAdapter
            // 
            this.debtorsMasterDetailsTblTableAdapter.ClearBeforeFill = true;
            // 
            // dEnquiryDetailsTableAdapter
            // 
            this.dEnquiryDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // dEnquiryDetailsBindingSource1
            // 
            this.dEnquiryDetailsBindingSource1.DataMember = "DEnquiryDetails";
            this.dEnquiryDetailsBindingSource1.DataSource = this.mngmntSystDBDataSet;
            // 
            // debtorsEnquiryTableTableAdapter
            // 
            this.debtorsEnquiryTableTableAdapter.ClearBeforeFill = true;
            // 
            // debtorsMasterDetailsTbl1BindingSource
            // 
            this.debtorsMasterDetailsTbl1BindingSource.DataMember = "DebtorsMasterDetailsTbl1";
            this.debtorsMasterDetailsTbl1BindingSource.DataSource = this.mngmntSystDBDataSet;
            // 
            // debtorsMasterDetailsTbl1TableAdapter
            // 
            this.debtorsMasterDetailsTbl1TableAdapter.ClearBeforeFill = true;
            // 
            // DEnqForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1225, 1050);
            this.Controls.Add(this.tabControlDebtorsEnqForm);
            this.Name = "DEnqForm";
            this.Text = "Debtors Enquiry Form";
            this.Load += new System.EventHandler(this.DEnqForm_Load);
            this.tabControlDebtorsEnqForm.ResumeLayout(false);
            this.tabPageViewDebtorsDetails.ResumeLayout(false);
            this.tabPageViewDebtorsDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewDebtorsDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.debtorsMasterDetailsTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mngmntSystDBDataSet)).EndInit();
            this.tabPageDebtorsEnquiryScreen.ResumeLayout(false);
            this.tabPageDebtorsEnquiryScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.debtorsEnquiryTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEnquiryDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEnquiryDetailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.debtorsMasterDetailsTbl1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlDebtorsEnqForm;
        private System.Windows.Forms.TabPage tabPageViewDebtorsDetails;
        private System.Windows.Forms.TabPage tabPageDebtorsEnquiryScreen;
        private System.Windows.Forms.DataGridView dgvViewDebtorsDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearchForDebtor;
        private MngmntSystDBDataSet mngmntSystDBDataSet;
        private System.Windows.Forms.BindingSource debtorsMasterDetailsTblBindingSource;
        private MngmntSystDBDataSetTableAdapters.DebtorsMasterDetailsTblTableAdapter debtorsMasterDetailsTblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn address1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn address2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn address3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLowestValue;
        private System.Windows.Forms.TextBox tbHighestValue;
        private System.Windows.Forms.TextBox tbMostRecentItemSold;
        private System.Windows.Forms.BindingSource dEnquiryDetailsBindingSource;
        private MngmntSystDBDataSetTableAdapters.DEnquiryDetailsTableAdapter dEnquiryDetailsTableAdapter;
        private System.Windows.Forms.Button btnLowestQty;
        private System.Windows.Forms.Button btnHighestQty;
        private System.Windows.Forms.Button btnRecentDebtor;
        private System.Windows.Forms.BindingSource dEnquiryDetailsBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource debtorsEnquiryTableBindingSource;
        private MngmntSystDBDataSetTableAdapters.DebtorsEnquiryTableTableAdapter debtorsEnquiryTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountCodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtySoldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitSellDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalSellAmountExclVatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource debtorsMasterDetailsTbl1BindingSource;
        private MngmntSystDBDataSetTableAdapters.DebtorsMasterDetailsTbl1TableAdapter debtorsMasterDetailsTbl1TableAdapter;
    }
}