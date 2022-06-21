using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pracApplV2
{
    public partial class StockEnquiryForm : Form
    {
        public StockEnquiryForm()
        {
            InitializeComponent();
        }

        private void StockEnquiryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mngmntSystDBDataSet.StockTransTbl' table. You can move, or remove it, as needed.
            this.stockTransTblTableAdapter.Fill(this.mngmntSystDBDataSet.StockTransTbl);
            // TODO: This line of code loads data into the 'mngmntSystDBDataSet.StockMasterTbl' table. You can move, or remove it, as needed.
            this.stockMasterTblTableAdapter.Fill(this.mngmntSystDBDataSet.StockMasterTbl);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            stockMasterTblTableAdapter.FillBy(mngmntSystDBDataSet.StockMasterTbl, textBox1.Text);
        }

        private void stocktransSearch_TextChanged(object sender, EventArgs e)
        {
            stockTransTblTableAdapter.FillBy(mngmntSystDBDataSet.StockTransTbl, stocktransSearch.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stockTransTblTableAdapter.FillBy1(mngmntSystDBDataSet.StockTransTbl);
        }
    }
}
