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
    public partial class StEnqForm : Form
    {
        public StEnqForm()
        {
            InitializeComponent();
            dgvViewStockStyling();
            dgvStockEnquiryStyling();
        }

        public void dgvViewStockStyling() 
        {
            //styling for the view stock item details 

            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249); //alternating row colour

            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.PaleTurquoise; //selection colour of the cell
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black; //font colour
            dataGridView1.BackgroundColor = Color.FromArgb(173, 196, 240); //background colour
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("MS Rederence Sans Serif", 10, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(3, 90, 148);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }


        public void dgvStockEnquiryStyling() 
        {
            dgvStockEnquiryScreen.BorderStyle = BorderStyle.None;
            dgvStockEnquiryScreen.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249); //alternating row colour

            dgvStockEnquiryScreen.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvStockEnquiryScreen.DefaultCellStyle.SelectionBackColor = Color.PaleTurquoise; //selection colour of the cell
            dgvStockEnquiryScreen.DefaultCellStyle.SelectionForeColor = Color.Black; //font colour
            dgvStockEnquiryScreen.BackgroundColor = Color.FromArgb(173, 196, 240); //black colour: maybe for the header
            dgvStockEnquiryScreen.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvStockEnquiryScreen.EnableHeadersVisualStyles = false;
            dgvStockEnquiryScreen.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvStockEnquiryScreen.ColumnHeadersDefaultCellStyle.Font = new Font("MS Rederence Sans Serif", 10, FontStyle.Bold);
            dgvStockEnquiryScreen.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(3, 90, 148);
            dgvStockEnquiryScreen.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }



        private void StEnqForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mngmntSystDBDataSet.DTStockEnqDetails' table. You can move, or remove it, as needed.
            this.dTStockEnqDetailsTableAdapter.Fill(this.mngmntSystDBDataSet.DTStockEnqDetails);
            // TODO: This line of code loads data into the 'mngmntSystDBDataSet.StockMasterTbl' table. You can move, or remove it, as needed.
            this.stockMasterTblTableAdapter.Fill(this.mngmntSystDBDataSet.StockMasterTbl);

        }

        private void tbSearchForDebtor_TextChanged(object sender, EventArgs e)
        {
            //stockMasterTblTableAdapter.FillBy(mngmntSystDBDataSet.StockMasterTbl, tbSearchForStockCode.Text);
        }

        private void tbSearchForStockCode_TextChanged(object sender, EventArgs e)
        {
            stockMasterTblTableAdapter.FillBy(mngmntSystDBDataSet.StockMasterTbl, tbSearchForStockCode.Text);
        }

        private void tbMostRecentDebtor_TextChanged(object sender, EventArgs e)
        {
            dTStockEnqDetailsTableAdapter.FillBySearchStockCode(mngmntSystDBDataSet.DTStockEnqDetails , tbMostRecentDebtor.Text);
        }

        private void tbHighestQuantity_TextChanged(object sender, EventArgs e)
        {
            //dTStockEnqDetailsTableAdapter.FillByHighestQuantity(mngmntSystDBDataSet.DTStockEnqDetails, tbHighestQuantity.Text);
        }

        private void tbLowestQuantity_TextChanged(object sender, EventArgs e)
        {
           // dTStockEnqDetailsTableAdapter.FillByLowestQuantity(mngmntSystDBDataSet.DTStockEnqDetails, tbLowestQuantity.Text);
        }

        private void btnRecentDebtor_Click(object sender, EventArgs e)
        {
            dTStockEnqDetailsTableAdapter.FillBy(mngmntSystDBDataSet.DTStockEnqDetails, tbMostRecentDebtor.Text);
        }

        private void btnHighestQty_Click(object sender, EventArgs e)
        {
            dTStockEnqDetailsTableAdapter.FillByHighestQuantity(mngmntSystDBDataSet.DTStockEnqDetails, tbMostRecentDebtor.Text);
        }

        private void btnLowestQty_Click(object sender, EventArgs e)
        {
            dTStockEnqDetailsTableAdapter.FillByLowestQuantity(mngmntSystDBDataSet.DTStockEnqDetails, tbMostRecentDebtor.Text);
        }
    }
}
