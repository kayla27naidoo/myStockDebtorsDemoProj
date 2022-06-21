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
    public partial class InvoiceForm : Form
    {
        int indexRow;

        public static int invoiceNo;
        public static string debtor;
        public static DateTime date;
        public static decimal totalSellAmtExVat;
        public static decimal vatAmount;
        public static decimal totalCost;

        public static string stockCode;
        public static decimal stockItemPrice;
        public static int qtySold;
        public static decimal discountValue;
        public static decimal total;
        public static string paymentType;


        public InvoiceForm()
        {
            InitializeComponent();
            dgvInvoiceHeaderStyling();
            dgvStockStyling();
            dgvInvoiceDetStyling();
        }

        public void dgvInvoiceHeaderStyling() 
        {
            //styling for the invoiceheader dgv table 

            dgvInvoiceHeader.BorderStyle = BorderStyle.None;
            dgvInvoiceHeader.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249); //alternating row colour

            dgvInvoiceHeader.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvInvoiceHeader.DefaultCellStyle.SelectionBackColor = Color.PaleTurquoise; //selection colour of the cell
            dgvInvoiceHeader.DefaultCellStyle.SelectionForeColor = Color.Black; //font colour
            dgvInvoiceHeader.BackgroundColor = Color.FromArgb(173, 196, 240); //background colour 
            dgvInvoiceHeader.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvInvoiceHeader.EnableHeadersVisualStyles = false;
            dgvInvoiceHeader.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvInvoiceHeader.ColumnHeadersDefaultCellStyle.Font = new Font("MS Rederence Sans Serif", 10, FontStyle.Bold);
            dgvInvoiceHeader.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(3, 90, 148);
            dgvInvoiceHeader.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }


        public void dgvStockStyling() 
        {
            //styling for the stock dgv 
            dgvStock.BorderStyle = BorderStyle.None;
            dgvStock.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249); //alternating row colour

            dgvStock.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvStock.DefaultCellStyle.SelectionBackColor = Color.PaleTurquoise; //selection colour of the cell
            dgvStock.DefaultCellStyle.SelectionForeColor = Color.Black; //font colour
            dgvStock.BackgroundColor = Color.FromArgb(173, 196, 240); //backgorund colour 
            dgvStock.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvStock.EnableHeadersVisualStyles = false;
            dgvStock.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvStock.ColumnHeadersDefaultCellStyle.Font = new Font("MS Rederence Sans Serif", 10, FontStyle.Bold);
            dgvStock.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(3, 90, 148);
            dgvStock.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        public void dgvInvoiceDetStyling() 
        {
            // styling for invoice details datagridview 

            dgvInvoiceDet.BorderStyle = BorderStyle.None;
            dgvInvoiceDet.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249); //alternating row colour

            dgvInvoiceDet.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvInvoiceDet.DefaultCellStyle.SelectionBackColor = Color.PaleTurquoise; //selection colour of the cell
            dgvInvoiceDet.DefaultCellStyle.SelectionForeColor = Color.Black; //font colour
            dgvInvoiceDet.BackgroundColor = Color.FromArgb(173, 196, 240); //background colour 
            dgvInvoiceDet.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvInvoiceDet.EnableHeadersVisualStyles = false;
            dgvInvoiceDet.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvInvoiceDet.ColumnHeadersDefaultCellStyle.Font = new Font("MS Rederence Sans Serif", 10, FontStyle.Bold);
            dgvInvoiceDet.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(3, 90, 148);
            dgvInvoiceDet.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }


        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mngmntSystDBDataSet.InvoiceDetTbl' table. You can move, or remove it, as needed.
            this.invoiceDetTblTableAdapter.Fill(this.mngmntSystDBDataSet.InvoiceDetTbl);
            // TODO: This line of code loads data into the 'mngmntSystDBDataSet.StockMasterTbl' table. You can move, or remove it, as needed.
            this.stockMasterTblTableAdapter.Fill(this.mngmntSystDBDataSet.StockMasterTbl);
            // TODO: This line of code loads data into the 'mngmntSystDBDataSet.InvoiceHeaderTbl' table. You can move, or remove it, as needed.
            this.invoiceHeaderTblTableAdapter.Fill(this.mngmntSystDBDataSet.InvoiceHeaderTbl);
            // TODO: This line of code loads data into the 'mngmntSystDBDataSet.DebtorsMasterDetailsTbl' table. You can move, or remove it, as needed.
            this.debtorsMasterDetailsTblTableAdapter.Fill(this.mngmntSystDBDataSet.DebtorsMasterDetailsTbl);

            //Load under the Invoice Display text box 
            rtbInvoiceDisplay.AppendText("-------------------------------------- Invoice Details -------------------------------------- " + "\n");
            rtbInvoiceDisplay.AppendText("\n");
            rtbInvoiceDisplay.AppendText("Stock Code " + "\t" + "Price " + "\t" + "\t" + "Qty " + "\t" + "\t" + "Disc " + "\t" + "\t" + " Total " + "\n");



        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear the textbox values 
            tbStockCode.Clear();
            tbQtySold.Clear();
            tbUnitCost.Clear();
            tbUnitSell.Clear();
            tbDisc.Clear();
            tbTotal.Clear();
            tbDiscountPerc.Clear();
            tbStockItemPrice.Clear();
            tbCostPrice.Clear();
            tbItemNo.Clear();
        }

        private void dgvStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dgvStock.Rows[indexRow];
            
            //populate these textboxes with values from the stock master details table
            tbStockCode.Text = row.Cells[0].Value.ToString();
            tbCostPrice.Text = row.Cells[2].Value.ToString();
            tbStockItemPrice.Text = row.Cells[3].Value.ToString();

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // calculate values 

            //int qtySold;
            decimal unitCost, costPrice, unitSell;

            decimal discPerc; //percentage of discount

            qtySold = Convert.ToInt16(tbQtySold.Text); //quantity sold 

            costPrice = Convert.ToDecimal(tbCostPrice.Text); //cost of the stock item

            unitCost = (qtySold * costPrice);         // unitcost for this transaction = qty * cost price
            tbUnitCost.Text = unitCost.ToString(); // display this value in the unit cost texbox


            stockItemPrice = Convert.ToDecimal(tbStockItemPrice.Text); //selling price of stock item 

            unitSell = (qtySold * stockItemPrice);  //unitsell for this trans = qty* stock item selling price
            tbUnitSell.Text = unitSell.ToString();  //display the value in the unit sell textbox

            discPerc = Convert.ToDecimal(tbDiscountPerc.Text); //get the percentage of discount 

            discountValue = ((discPerc / 100) * unitSell); // discount = perc * unit sell for this transaction 
            tbDisc.Text = discountValue.ToString();  //display the discout value 

            total = (unitSell - discountValue);  //total for this transaction = unitsell - discount 
            tbTotal.Text = total.ToString();  //display 

        }

        private void btnAddtoHeaderSect_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OLD BUTTON");

        }

        private void btnInsertInvoiceDet_Click(object sender, EventArgs e)
        {
            invoiceNo = Convert.ToInt16(tbInvoiceNo.Text);
            
            //insert this into invoicedet tbl 
            DialogResult dialogr = MessageBox.Show("Do you want to insert this invoice detail?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (dialogr == DialogResult.Yes) 
            {
                //getting the old stockOnHand value
                DataGridViewRow myRow = dgvStock.Rows[indexRow];
                int oldStockOnHand;
                oldStockOnHand = Convert.ToInt16(myRow.Cells[8].Value.ToString()); //OLD

                if (oldStockOnHand < qtySold)
                {
                    MessageBox.Show("Quantity of stock is not available." + "\n" + "\n" + "Current Stock On Hand :" + oldStockOnHand);
                }
                else 
                {
                    invoiceDetTblTableAdapter.Insert(invoiceNo, Convert.ToInt16(tbItemNo.Text), tbStockCode.Text, Convert.ToInt16(tbQtySold.Text), Convert.ToDecimal(tbUnitCost.Text), Convert.ToDecimal(tbUnitSell.Text), Convert.ToDecimal(tbDisc.Text), Convert.ToDecimal(tbTotal.Text));
                    invoiceDetTblTableAdapter.Fill(this.mngmntSystDBDataSet.InvoiceDetTbl);
                    MessageBox.Show("Record inserted successfully!");

                    //update stock
                    string  stockDescr;
                    decimal stockC, stockSP, stockTotPurch, oldTotalSales, newTotalSales;
                    int stockQtyPurch, oldstockQtySold, newStockQuantitySold, newStockOnHand;

                    //values - old//constant

                    stockCode = myRow.Cells[0].Value.ToString(); //constant
                    stockDescr = myRow.Cells[1].Value.ToString(); // constant 
                    stockC = Convert.ToDecimal(myRow.Cells[2].Value.ToString()); // constant 
                    stockSP = Convert.ToDecimal(myRow.Cells[3].Value.ToString()); // constant
                    stockTotPurch = Convert.ToDecimal(myRow.Cells[4].Value.ToString()); // constant

                    oldTotalSales = Convert.ToDecimal(myRow.Cells[5].Value.ToString()); // OLD

                    stockQtyPurch = Convert.ToInt16(myRow.Cells[6].Value.ToString()); // constant

                    oldstockQtySold = Convert.ToInt16(myRow.Cells[7].Value.ToString()); //OLD
                

                    // new values 

                    newTotalSales = (Convert.ToDecimal(myRow.Cells[5].Value.ToString()) + Convert.ToDecimal(tbUnitSell.Text));

                    newStockQuantitySold = (Convert.ToInt16(myRow.Cells[7].Value.ToString()) + Convert.ToInt16(tbQtySold.Text));

                    newStockOnHand = (Convert.ToInt16(myRow.Cells[8].Value.ToString()) - Convert.ToInt16(tbQtySold.Text));

                    //update 

                    stockMasterTblTableAdapter.Update(stockCode, stockDescr, stockC, stockSP, stockTotPurch, newTotalSales, stockQtyPurch, newStockQuantitySold, newStockOnHand,
                    stockCode, stockDescr, stockC, stockSP, stockTotPurch, oldTotalSales, stockQtyPurch, oldstockQtySold, oldStockOnHand);
                    stockMasterTblTableAdapter.Fill(this.mngmntSystDBDataSet.StockMasterTbl);
                    MessageBox.Show("Stock updated successfully!");

                    //ADD TO HEADER TOTALS 

                    decimal vatNumber;  // the vat percentage = 15%
                    //decimal totalSellAmtExVat, vatAmount, totalCost; //invoice header values 

                    totalSellAmtExVat = Convert.ToDecimal(tbTotalSellAmtEV.Text); //initialise value to value already in textbox 

                    totalSellAmtExVat = Convert.ToDecimal(tbTotal.Text) + totalSellAmtExVat; //if another transaction is added to the details section -->
                    tbTotalSellAmtEV.Text = totalSellAmtExVat.ToString();     //displays the value in a textbox ,that should total to the totalsellamtexvat textbox 


                    vatNumber = 15;
                    vatAmount = vatNumber / 100 * totalSellAmtExVat;  //calculating the vat amount of the total amout excl vat 
                    tbVatAmt.Text = vatAmount.ToString();  //displaying 

                    totalCost = (vatAmount + totalSellAmtExVat); //the final total value of invoice = vat amount + amtexclvat 
                    tbTotalCost.Text = totalCost.ToString();  //displaying total cost value in textbox 

                    //display
                    rtbInvoiceDisplay.AppendText(stockCode + "\t" + "\t" + stockItemPrice + "\t" + "\t" + qtySold + "\t" + "\t" + discountValue + "\t" + "\t" + total + "\n");

                }      
            }
            else if (dialogr == DialogResult.No)
            {
                MessageBox.Show("Record not inserted");
            }
            else
            {
                MessageBox.Show("Insertion cancelled.");
            }


        }

        private void btnUpdateStock_Click(object sender, EventArgs e)
        {

            MessageBox.Show("OLD BUTTTON ");


        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Insert transaction into Invoice Header TBL 

            paymentType = cmbPaymntType.GetItemText(this.cmbPaymntType.SelectedItem);
            debtor = cmbChooseDebtor.GetItemText(this.cmbChooseDebtor.SelectedItem);  // initialise the debtor 
            date = dateTimePicker1.Value;
            
            DialogResult result = MessageBox.Show("Do you want to insert this invoice header?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                invoiceHeaderTblTableAdapter.Insert(debtor, date, Convert.ToDecimal(tbTotalSellAmtEV.Text), Convert.ToDecimal(tbVatAmt.Text), Convert.ToDecimal(tbTotalCost.Text));
                invoiceHeaderTblTableAdapter.Fill(this.mngmntSystDBDataSet.InvoiceHeaderTbl);
                MessageBox.Show("Record inserted successfully!");

                //For the invoice display 
                rtbInvoiceDisplay.AppendText("\n ---------------------------------------------------------------------------------------------" + "\n");
                rtbInvoiceDisplay.AppendText("\n");
                rtbInvoiceDisplay.AppendText("Invoice No :" + invoiceNo + "\n");
                rtbInvoiceDisplay.AppendText("Account Code : " + debtor + "\n");
                rtbInvoiceDisplay.AppendText("Date :" + date + "\n");
                rtbInvoiceDisplay.AppendText("Payment Type :" + paymentType + "\n");
                rtbInvoiceDisplay.AppendText("\n ---------------------------------------------------------------------------------------------" + "\n");
                rtbInvoiceDisplay.AppendText("\n");
                rtbInvoiceDisplay.AppendText("Total Sell Amount Excl Vat:" + "\t  " + "R" + totalSellAmtExVat + "\n");
                rtbInvoiceDisplay.AppendText("Vat Amount: " + "\t  " + "\t  " + "\t  " + "R" + vatAmount + "\n");
                rtbInvoiceDisplay.AppendText("Total Cost: " + "\t  " + "\t  " + "\t  " + "R" + totalCost + "\n");


            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Record not inserted");
            }
            else
            {
                MessageBox.Show("Insertion cancelled.");
            }

        }
    }
}
