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
    public partial class StockAdjustmentsForm : Form
    {
        int indexRow;
        public StockAdjustmentsForm()
        {
            InitializeComponent();
            dgvStockDetailsStyling();
        }

        public void dgvStockDetailsStyling() 
        {
            dgvStockDetails.BorderStyle = BorderStyle.None;
            dgvStockDetails.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249); //alternating row colour

            dgvStockDetails.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvStockDetails.DefaultCellStyle.SelectionBackColor = Color.PaleTurquoise; //selection colour of the cell
            dgvStockDetails.DefaultCellStyle.SelectionForeColor = Color.Black; //font colour
            dgvStockDetails.BackgroundColor = Color.FromArgb(173, 196, 240); // background colour 
            dgvStockDetails.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvStockDetails.EnableHeadersVisualStyles = false;
            dgvStockDetails.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvStockDetails.ColumnHeadersDefaultCellStyle.Font = new Font("MS Rederence Sans Serif", 10, FontStyle.Bold);
            dgvStockDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(3, 90, 148);
            dgvStockDetails.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void StockAdjustmentsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mngmntSystDBDataSet.StockMasterTbl' table. You can move, or remove it, as needed.
            this.stockMasterTblTableAdapter.Fill(this.mngmntSystDBDataSet.StockMasterTbl);

        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            stockMasterTblTableAdapter.FillBy(mngmntSystDBDataSet.StockMasterTbl, tbSearch.Text);
        }

        private void dgvStockDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dgvStockDetails.Rows[indexRow];
            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            tbCost.Text = row.Cells[2].Value.ToString();
            textBox4.Text = row.Cells[3].Value.ToString();
            tbTotPurchEV.Text = row.Cells[4].Value.ToString(); //total purchases values 
            textBox6.Text = row.Cells[5].Value.ToString();
            tbQuantityPurch.Text = row.Cells[6].Value.ToString(); //quantity purchased
            textBox8.Text = row.Cells[7].Value.ToString();
            tbStockOnHand.Text = row.Cells[8].Value.ToString(); //stock on hand



        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //calculation 

            int newIncomingQuantity;
            newIncomingQuantity = Convert.ToInt16(incomingStockQty.Text); //stock received 

            decimal newTotalPurchasesValue; // updated value 
            newTotalPurchasesValue = Convert.ToDecimal(tbTotPurchEV.Text) + (newIncomingQuantity * Convert.ToDecimal(tbCost.Text)); // old purchases value + new recent purchases amount

            int newQuantityPurch; // updated value 
            newQuantityPurch = newIncomingQuantity + Convert.ToInt16(tbQuantityPurch.Text); // new stock + old stock quantities  

            int newStockOnHand; //updated value
            newStockOnHand = (Convert.ToInt16(tbStockOnHand.Text) + newIncomingQuantity); //stock on hand + new quantity

            //updating the textbox values to reflect the new stock added 
            tbTotPurchEV.Text = newTotalPurchasesValue.ToString();
            tbQuantityPurch.Text = newQuantityPurch.ToString();
            tbStockOnHand.Text = newStockOnHand.ToString();

            //update the database 

            DataGridViewRow myRow = dgvStockDetails.Rows[indexRow]; // to update the record 

            //values for the update
            //values without the n or old in front indicated they are not being updated.

            int nQtyPurch, oldQtyPurch, qtySold, nStockOnHand, oldStockOnHand;

            string stockCode, stockDescr;

            decimal sCost, sellingPrice, nTotalPurchases, oldTPurchases, totalSales;

            //these 4 values will stay the same after the update

            stockCode = myRow.Cells[0].Value.ToString();
            stockDescr = myRow.Cells[1].Value.ToString();
            sCost = Convert.ToDecimal(myRow.Cells[2].Value.ToString());
            sellingPrice = Convert.ToDecimal(myRow.Cells[3].Value.ToString());

            oldTPurchases = Convert.ToDecimal(myRow.Cells[4].Value.ToString()); //old value

            totalSales = Convert.ToDecimal(myRow.Cells[5].Value.ToString()); //value will stay the same

            oldQtyPurch = Convert.ToInt16(myRow.Cells[6].Value.ToString()); //old value 

            qtySold = Convert.ToInt16(myRow.Cells[7].Value.ToString());  // value will stay the same 

            oldStockOnHand = Convert.ToInt16(myRow.Cells[8].Value.ToString());//old value 

            //new updated values 

            nTotalPurchases = Convert.ToDecimal(tbTotPurchEV.Text); // takes in the newly updated values in the textbox
            nQtyPurch = Convert.ToInt16(tbQuantityPurch.Text);
            nStockOnHand = Convert.ToInt16(tbStockOnHand.Text);


            DialogResult result = MessageBox.Show("Do you want to update stock quantities", "Confirmation", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                stockMasterTblTableAdapter.Update(stockCode, stockDescr, sCost, sellingPrice, nTotalPurchases, totalSales, nQtyPurch, qtySold, nStockOnHand,
                    stockCode, stockDescr, sCost, sellingPrice, oldTPurchases, totalSales, oldQtyPurch, qtySold, oldStockOnHand);
                stockMasterTblTableAdapter.Fill(mngmntSystDBDataSet.StockMasterTbl);
                MessageBox.Show("Quantities were updated!");
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Adjustments not updated");
            }
            else
            {
                MessageBox.Show("Updated cancelled");
            }




        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            tbCost.Clear();
            textBox4.Clear();
            tbTotPurchEV.Clear();
            textBox6.Clear();
            tbQuantityPurch.Clear();
            textBox8.Clear();
            tbStockOnHand.Clear();
            incomingStockQty.Clear();
        }
    }
}
