
namespace pracApplV2
{
    partial class StockMasterDetails
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.stockMasterTblTableAdapter = new pracApplV2.MngmntSystDBDataSetTableAdapters.StockMasterTblTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbSearchStckCode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockMasterTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mngmntSystDBDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(37, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1090, 319);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(489, 746);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 46);
            this.button2.TabIndex = 32;
            this.button2.Text = "Update Details";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(160, 746);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 46);
            this.button1.TabIndex = 31;
            this.button1.Text = "Create ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(562, 590);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 23);
            this.label7.TabIndex = 30;
            this.label7.Text = "Qty Purchased";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(562, 537);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 23);
            this.label6.TabIndex = 29;
            this.label6.Text = "Total Sales Excl VAT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(562, 485);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 23);
            this.label5.TabIndex = 28;
            this.label5.Text = "Total Purchases Excl VAT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(156, 643);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 23);
            this.label4.TabIndex = 27;
            this.label4.Text = "SellingPrice";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(156, 590);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 23);
            this.label3.TabIndex = 26;
            this.label3.Text = "Cost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(156, 537);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "Stock Descr";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 485);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 23);
            this.label1.TabIndex = 24;
            this.label1.Text = "Stock Code";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(824, 584);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(176, 26);
            this.textBox7.TabIndex = 23;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(824, 534);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(176, 26);
            this.textBox6.TabIndex = 22;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(824, 485);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(176, 26);
            this.textBox5.TabIndex = 21;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(291, 640);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(176, 26);
            this.textBox4.TabIndex = 20;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(291, 587);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(176, 26);
            this.textBox3.TabIndex = 19;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(291, 534);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(176, 26);
            this.textBox2.TabIndex = 18;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(291, 482);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 26);
            this.textBox1.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(562, 640);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 23);
            this.label8.TabIndex = 33;
            this.label8.Text = "Qty Sold";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(562, 690);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 23);
            this.label9.TabIndex = 34;
            this.label9.Text = "Stock On Hand";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(824, 637);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(176, 26);
            this.textBox8.TabIndex = 35;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(824, 687);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(176, 26);
            this.textBox9.TabIndex = 36;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkBlue;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(823, 746);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 46);
            this.button3.TabIndex = 37;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // stockMasterTblTableAdapter
            // 
            this.stockMasterTblTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1239, 62);
            this.panel1.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(429, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(416, 26);
            this.label10.TabIndex = 0;
            this.label10.Text = "Create and Update Stock Master Details";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(156, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 23);
            this.label11.TabIndex = 39;
            this.label11.Text = "Search";
            // 
            // tbSearchStckCode
            // 
            this.tbSearchStckCode.Location = new System.Drawing.Point(250, 87);
            this.tbSearchStckCode.Name = "tbSearchStckCode";
            this.tbSearchStckCode.Size = new System.Drawing.Size(750, 26);
            this.tbSearchStckCode.TabIndex = 40;
            this.tbSearchStckCode.TextChanged += new System.EventHandler(this.tbSearchStckCode_TextChanged);
            // 
            // StockMasterDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1239, 842);
            this.Controls.Add(this.tbSearchStckCode);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StockMasterDetails";
            this.Text = "StockMasterDetails";
            this.Load += new System.EventHandler(this.StockMasterDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockMasterTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mngmntSystDBDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button button3;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbSearchStckCode;
    }
}