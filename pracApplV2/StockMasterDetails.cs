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
    public partial class StockMasterDetails : Form
    {
        int indexRow;
        public StockMasterDetails()
        {
            InitializeComponent();
            dgvStockDetailsStyling();
        }

        public void dgvStockDetailsStyling() 
        {
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

        private void StockMasterDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mngmntSystDBDataSet.StockMasterTbl' table. You can move, or remove it, as needed.
            this.stockMasterTblTableAdapter.Fill(this.mngmntSystDBDataSet.StockMasterTbl);

        }

        //insert/create button of creating a stock item 

        private void button1_Click(object sender, EventArgs e)
        {
            decimal stockCost, stockSPrice, totalPurchEV, totalSalesEV;
            int stckQtyPurch, stckSold, stckOnHand;

            //INPUTS TO CALCULATE 

            stockCost = Convert.ToDecimal(textBox3.Text);  // cost of the stock item to the business 
            stockSPrice = Convert.ToDecimal(textBox4.Text); //selling price of the item

            stckQtyPurch = Convert.ToInt16(textBox7.Text); //quantity that you bought when introducing this stock 

            //calculate 

            totalPurchEV = (stockCost * stckQtyPurch);
            textBox5.Text = totalPurchEV.ToString();  //textbox 5 holds the total purchases ex vat value 

            //instantiate values 
            stckSold = 0; //creating the new stock , no one has bought it at the time of purchase
            textBox8.Text = stckSold.ToString();  //textbox8 holds the stock sold value

            stckOnHand = stckQtyPurch; //stock on hand is = to the amount bought since there have been no purchases at this time 
            textBox9.Text = stckOnHand.ToString();


            totalSalesEV = (stckSold * stockSPrice); //will amount to zero since the stock sold is zero
            textBox6.Text = totalSalesEV.ToString();

            //inserting the record procedure
            DialogResult result = MessageBox.Show("Do you want to add a stock item detail", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes) 
            {
                stockMasterTblTableAdapter.Insert(textBox1.Text, textBox2.Text, stockCost, stockSPrice,
                    Convert.ToDecimal(textBox5.Text), Convert.ToDecimal(textBox6.Text), stckQtyPurch, Convert.ToInt16(textBox8.Text), Convert.ToInt16(textBox9.Text));
                stockMasterTblTableAdapter.Fill(this.mngmntSystDBDataSet.StockMasterTbl);
                MessageBox.Show("Stock added successfully!");

            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Stock item NOT added");
            }
            else
            {
                MessageBox.Show("Stock insertion CANCELLED");
            }

        }
        //update details button
        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow myRow = dataGridView1.Rows[indexRow];

            //variables for the update query
            string oldStockCode, newStockCode, oldStockDescr, newStockDescr;
            decimal oldCost, newCost, oldSellingPrice, newSellingPrice, oldTotalPurchExclVat, newTotalPurchExclVat, oldTotalSalesExclVat, newTotalSalesExclVat;
            int oldQtyPurch, newQtyPurch, oldQtySold, newQtySold, oldStockOnHand, newStockOnHand;

            //assigning the original values 

            oldStockCode = myRow.Cells[0].Value.ToString();
            oldStockDescr = myRow.Cells[1].Value.ToString();
            oldCost = Convert.ToDecimal(myRow.Cells[2].Value.ToString());
            oldSellingPrice = Convert.ToDecimal(myRow.Cells[3].Value.ToString());
            oldTotalPurchExclVat = Convert.ToDecimal(myRow.Cells[4].Value.ToString());
            oldTotalSalesExclVat = Convert.ToDecimal(myRow.Cells[5].Value.ToString());
            oldQtyPurch = Convert.ToInt16(myRow.Cells[6].Value.ToString());
            oldQtySold = Convert.ToInt16(myRow.Cells[7].Value.ToString());
            oldStockOnHand = Convert.ToInt16(myRow.Cells[8].Value.ToString());

            //initialising the new values to the content inside the textboxes

            newStockCode = textBox1.Text; //newStockCode
            newStockDescr = textBox2.Text; //newStockDescr


            newCost = Convert.ToDecimal(textBox3.Text);    //newcost 
            newSellingPrice = Convert.ToDecimal(textBox4.Text); //newSellingPrice

            newQtyPurch = Convert.ToInt16(textBox7.Text);  //newQtyPurch
            newQtySold = Convert.ToInt16(textBox8.Text); //newQtySold 

            newTotalPurchExclVat = (newQtyPurch * newCost);
            textBox5.Text = newTotalPurchExclVat.ToString(); // textbox5 holds the newtotalpurchexclvat

            newTotalSalesExclVat = (newSellingPrice * newQtySold);
            textBox6.Text = newTotalSalesExclVat.ToString();  //textbox6 holds the newtotalsalesexclvat

            newStockOnHand = (newQtyPurch - newQtySold);
            textBox9.Text = newStockOnHand.ToString();   //textbox 9 holds the newstockonhand value


            DialogResult dialogr = MessageBox.Show("Are you sure you want to update this record?", "Update Confirmation", MessageBoxButtons.YesNoCancel);

            if (dialogr == DialogResult.Yes) 
            {
                stockMasterTblTableAdapter.Update(newStockCode, newStockDescr, newCost, newSellingPrice, Convert.ToDecimal(textBox5.Text), Convert.ToDecimal(textBox6.Text), newQtyPurch, newQtySold, Convert.ToInt16(textBox9.Text),
                    oldStockCode, oldStockDescr, oldCost, oldSellingPrice, oldTotalPurchExclVat, oldTotalSalesExclVat, oldQtyPurch, oldQtySold, oldStockOnHand);
                stockMasterTblTableAdapter.Fill(this.mngmntSystDBDataSet.StockMasterTbl);
                MessageBox.Show("Stock successfully updated!");
            }
            else if (dialogr == DialogResult.No)
            {
                MessageBox.Show("Stock was not updated.");
            }
            else
            {
                MessageBox.Show("Stock update cancelled.");
            }


        }

        //this is an event 
        //when a record is clicked on in the datagrid this will populate the values into textboxes so that an update can occur

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex; //initialise index row 
            DataGridViewRow row = dataGridView1.Rows[indexRow]; // the row that was clicked on 
            textBox1.Text = row.Cells[0].Value.ToString(); //assigning the values to populate the textboxes
            textBox2.Text = row.Cells[1].Value.ToString(); //stock descr
            textBox3.Text = row.Cells[2].Value.ToString(); // cost price
            textBox4.Text = row.Cells[3].Value.ToString(); // selling price
            textBox5.Text = row.Cells[4].Value.ToString(); //total purchases excl vat
            textBox6.Text = row.Cells[5].Value.ToString(); // total sales excl vat
            textBox7.Text = row.Cells[6].Value.ToString();  // stock quantity purchased
            textBox8.Text = row.Cells[7].Value.ToString(); // stock quantity sold
            textBox9.Text = row.Cells[8].Value.ToString(); //stock on hand
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
        }

        private void tbSearchStckCode_TextChanged(object sender, EventArgs e)
        {
            stockMasterTblTableAdapter.FillBy(mngmntSystDBDataSet.StockMasterTbl, tbSearchStckCode.Text);
        }
    }
}
