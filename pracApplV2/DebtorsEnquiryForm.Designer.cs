
namespace pracApplV2
{
    partial class DebtorsEnquiryForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.accountCodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grossTransactionalValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vatValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debtorsTransTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mngmntSystDBDataSet1 = new pracApplV2.MngmntSystDBDataSet();
            this.accountCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesYearToDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costYearToDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debtorsMasterDetailsTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mngmntSystDBDataSet = new pracApplV2.MngmntSystDBDataSet();
            this.debtorsMasterDetailsTblTableAdapter = new pracApplV2.MngmntSystDBDataSetTableAdapters.DebtorsMasterDetailsTblTableAdapter();
            this.debtorsTransTblTableAdapter = new pracApplV2.MngmntSystDBDataSetTableAdapters.DebtorsTransTblTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.debtorsTransTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mngmntSystDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.debtorsMasterDetailsTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mngmntSystDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(453, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "View Debtors Details";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1162, 62);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search for Debtor:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(188, 87);
            this.textBox1.MinimumSize = new System.Drawing.Size(323, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(323, 26);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountCodeDataGridViewTextBoxColumn,
            this.address1DataGridViewTextBoxColumn,
            this.address2DataGridViewTextBoxColumn,
            this.address3DataGridViewTextBoxColumn,
            this.balanceDataGridViewTextBoxColumn,
            this.salesYearToDateDataGridViewTextBoxColumn,
            this.costYearToDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.debtorsMasterDetailsTblBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1115, 315);
            this.dataGridView1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(0, 466);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1162, 62);
            this.panel2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(431, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "View Debtors Transactions";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 548);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(431, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Search for transactons by Debtor AccountCode:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(449, 548);
            this.textBox2.MinimumSize = new System.Drawing.Size(323, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(323, 26);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountCodeDataGridViewTextBoxColumn1,
            this.dateDataGridViewTextBoxColumn,
            this.transactionTypeDataGridViewTextBoxColumn,
            this.documentNoDataGridViewTextBoxColumn,
            this.grossTransactionalValueDataGridViewTextBoxColumn,
            this.vatValueDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.debtorsTransTblBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 600);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(1115, 369);
            this.dataGridView2.TabIndex = 8;
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
            // grossTransactionalValueDataGridViewTextBoxColumn
            // 
            this.grossTransactionalValueDataGridViewTextBoxColumn.DataPropertyName = "GrossTransactionalValue";
            this.grossTransactionalValueDataGridViewTextBoxColumn.HeaderText = "GrossTransactionalValue";
            this.grossTransactionalValueDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.grossTransactionalValueDataGridViewTextBoxColumn.Name = "grossTransactionalValueDataGridViewTextBoxColumn";
            this.grossTransactionalValueDataGridViewTextBoxColumn.Width = 150;
            // 
            // vatValueDataGridViewTextBoxColumn
            // 
            this.vatValueDataGridViewTextBoxColumn.DataPropertyName = "VatValue";
            this.vatValueDataGridViewTextBoxColumn.HeaderText = "VatValue";
            this.vatValueDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.vatValueDataGridViewTextBoxColumn.Name = "vatValueDataGridViewTextBoxColumn";
            this.vatValueDataGridViewTextBoxColumn.Width = 150;
            // 
            // debtorsTransTblBindingSource
            // 
            this.debtorsTransTblBindingSource.DataMember = "DebtorsTransTbl";
            this.debtorsTransTblBindingSource.DataSource = this.mngmntSystDBDataSet1;
            // 
            // mngmntSystDBDataSet1
            // 
            this.mngmntSystDBDataSet1.DataSetName = "MngmntSystDBDataSet";
            this.mngmntSystDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // salesYearToDateDataGridViewTextBoxColumn
            // 
            this.salesYearToDateDataGridViewTextBoxColumn.DataPropertyName = "SalesYearToDate";
            this.salesYearToDateDataGridViewTextBoxColumn.HeaderText = "SalesYearToDate";
            this.salesYearToDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.salesYearToDateDataGridViewTextBoxColumn.Name = "salesYearToDateDataGridViewTextBoxColumn";
            this.salesYearToDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // costYearToDateDataGridViewTextBoxColumn
            // 
            this.costYearToDateDataGridViewTextBoxColumn.DataPropertyName = "CostYearToDate";
            this.costYearToDateDataGridViewTextBoxColumn.HeaderText = "CostYearToDate";
            this.costYearToDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.costYearToDateDataGridViewTextBoxColumn.Name = "costYearToDateDataGridViewTextBoxColumn";
            this.costYearToDateDataGridViewTextBoxColumn.Width = 150;
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
            // debtorsMasterDetailsTblTableAdapter
            // 
            this.debtorsMasterDetailsTblTableAdapter.ClearBeforeFill = true;
            // 
            // debtorsTransTblTableAdapter
            // 
            this.debtorsTransTblTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(950, 540);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 40);
            this.button1.TabIndex = 16;
            this.button1.Text = "Highest Value";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DebtorsEnquiryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1162, 981);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "DebtorsEnquiryForm";
            this.Text = "DebtorsEnquiryForm";
            this.Load += new System.EventHandler(this.DebtorsEnquiryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.debtorsTransTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mngmntSystDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.debtorsMasterDetailsTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mngmntSystDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MngmntSystDBDataSet mngmntSystDBDataSet;
        private System.Windows.Forms.BindingSource debtorsMasterDetailsTblBindingSource;
        private MngmntSystDBDataSetTableAdapters.DebtorsMasterDetailsTblTableAdapter debtorsMasterDetailsTblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn address1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn address2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn address3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesYearToDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costYearToDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private MngmntSystDBDataSet mngmntSystDBDataSet1;
        private System.Windows.Forms.BindingSource debtorsTransTblBindingSource;
        private MngmntSystDBDataSetTableAdapters.DebtorsTransTblTableAdapter debtorsTransTblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountCodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grossTransactionalValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vatValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}