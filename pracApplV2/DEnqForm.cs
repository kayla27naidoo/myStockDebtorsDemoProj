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
    public partial class DEnqForm : Form
    {
        public DEnqForm()
        {
            InitializeComponent();
            dgvStyling1();
            dgvDebtorsDetailsStyling();
        }

        public void dgvStyling1() 
        {
            //on the debtors enquiry screen 
            //for datagridview 1
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249); //alternating row colour

            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.PaleTurquoise; //selection colour of the cell
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black; //font colour
            dataGridView1.BackgroundColor = Color.FromArgb(173, 196, 240); //black colour: maybe for the header
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("MS Rederence Sans Serif", 10, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(3, 90, 148);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        public void dgvDebtorsDetailsStyling() 
        {
            //for the viewing of debtors details 
            //for dgv viewdebtorsdetails 

            dgvViewDebtorsDetails.BorderStyle = BorderStyle.None;
            dgvViewDebtorsDetails.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249); //alternating row colour

            dgvViewDebtorsDetails.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvViewDebtorsDetails.DefaultCellStyle.SelectionBackColor = Color.PaleTurquoise; //selection colour of the cell
            dgvViewDebtorsDetails.DefaultCellStyle.SelectionForeColor = Color.Black; //font colour
            dgvViewDebtorsDetails.BackgroundColor = Color.FromArgb(173, 196, 240); //black colour: maybe for the header
            dgvViewDebtorsDetails.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvViewDebtorsDetails.EnableHeadersVisualStyles = false;
            dgvViewDebtorsDetails.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvViewDebtorsDetails.ColumnHeadersDefaultCellStyle.Font = new Font("MS Rederence Sans Serif", 10, FontStyle.Bold);
            dgvViewDebtorsDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(3, 90, 148);
            dgvViewDebtorsDetails.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }

        private void DEnqForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mngmntSystDBDataSet.DebtorsMasterDetailsTbl1' table. You can move, or remove it, as needed.
            this.debtorsMasterDetailsTbl1TableAdapter.Fill(this.mngmntSystDBDataSet.DebtorsMasterDetailsTbl1);
            // TODO: This line of code loads data into the 'mngmntSystDBDataSet.DebtorsEnquiryTable' table. You can move, or remove it, as needed.
            this.debtorsEnquiryTableTableAdapter.Fill(this.mngmntSystDBDataSet.DebtorsEnquiryTable);
            // TODO: This line of code loads data into the 'mngmntSystDBDataSet.DebtorsMasterDetailsTbl' table. You can move, or remove it, as needed.
            //this.debtorsMasterDetailsTblTableAdapter.Fill(this.mngmntSystDBDataSet.DebtorsMasterDetailsTbl);
            //this.dEnquiryDetailsTableAdapter.FillBy(this.mngmntSystDBDataSet.DEnquiryDetails);
        }

        private void tbSearchForDebtor_TextChanged(object sender, EventArgs e)
        {
            debtorsMasterDetailsTbl1TableAdapter.FillBySearchtb(mngmntSystDBDataSet.DebtorsMasterDetailsTbl1, tbSearchForDebtor.Text);
           //debtorsMasterDetailsTblTableAdapter.FillBy(mngmntSystDBDataSet.DebtorsMasterDetailsTbl, tbSearchForDebtor.Text);

        }

        private void tbMostRecentItemSold_TextChanged(object sender, EventArgs e)
        {
            //dEnquiryDetailsTableAdapter.FillBySearchDebtor(mngmntSystDBDataSet.DEnquiryDetails, tbMostRecentItemSold.Text);
            debtorsEnquiryTableTableAdapter.FillBySearch(mngmntSystDBDataSet.DebtorsEnquiryTable, tbMostRecentItemSold.Text);
        }

        private void tbHighestValue_TextChanged(object sender, EventArgs e)
        {
            //dEnquiryDetailsTableAdapter.FillByHighestVal(mngmntSystDBDataSet.DEnquiryDetails, tbHighestValue.Text);
        }

        private void tbLowestValue_TextChanged(object sender, EventArgs e)
        {
           // dEnquiryDetailsTableAdapter.FillByLowestValue(mngmntSystDBDataSet.DEnquiryDetails, tbLowestValue.Text);
        }

        private void btnRecentDebtor_Click(object sender, EventArgs e)
        {
            //dEnquiryDetailsTableAdapter.FillByMostRecentItemSold(mngmntSystDBDataSet.DEnquiryDetails, tbMostRecentItemSold.Text);
            debtorsEnquiryTableTableAdapter.FillByMstRcntItmSold(mngmntSystDBDataSet.DebtorsEnquiryTable, tbMostRecentItemSold.Text);
        }

        private void btnHighestQty_Click(object sender, EventArgs e)
        {
            //dEnquiryDetailsTableAdapter.FillByHighestVal(mngmntSystDBDataSet.DEnquiryDetails, tbMostRecentItemSold.Text);
            debtorsEnquiryTableTableAdapter.FillByHighestTotalVal(mngmntSystDBDataSet.DebtorsEnquiryTable, tbMostRecentItemSold.Text);
        }

        private void btnLowestQty_Click(object sender, EventArgs e)
        {
            //dEnquiryDetailsTableAdapter.FillByLowestValue(mngmntSystDBDataSet.DEnquiryDetails, tbMostRecentItemSold.Text);
            debtorsEnquiryTableTableAdapter.FillByLowestTotalValue(mngmntSystDBDataSet.DebtorsEnquiryTable , tbMostRecentItemSold.Text);
        }
    }
}
