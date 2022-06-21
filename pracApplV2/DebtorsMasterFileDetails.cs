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
    public partial class DebtorsMasterFileDetails : Form
    {
        int indexRow;
        public DebtorsMasterFileDetails()
        {
            InitializeComponent();
            dgvStyling();
        }

        public void dgvStyling() 
        {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249); //alternating row colour

            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.PaleTurquoise; //selection colour of the cell
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black; //font colour
            dataGridView1.BackgroundColor = Color.FromArgb(173, 196, 240); //background dgv colour 
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("MS Rederence Sans Serif", 10, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(3, 90, 148); //column header style
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }

        private void DebtorsMasterFileDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mngmntSystDBDataSet.DebtorsMasterDetailsTbl' table. You can move, or remove it, as needed.
            this.debtorsMasterDetailsTblTableAdapter.Fill(this.mngmntSystDBDataSet.DebtorsMasterDetailsTbl);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to insert a Debtor?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes) 
            {
                debtorsMasterDetailsTblTableAdapter.Insert(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text,
                    Convert.ToDecimal(textBox5.Text), Convert.ToDecimal(textBox6.Text), Convert.ToDecimal(textBox7.Text));
                debtorsMasterDetailsTblTableAdapter.Fill(this.mngmntSystDBDataSet.DebtorsMasterDetailsTbl);
                MessageBox.Show("Debtor was successfully added!");
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Debtor NOT added");
            }
            else
            {
                MessageBox.Show("Insertion CANCELLED");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow myRow = dataGridView1.Rows[indexRow];
            string oldAccountCode, newAccountCode, oldAdd1, newAdd1, oldAdd2, newAdd2, oldAdd3, newAdd3;
            decimal oldBalance, newBalance, oldSaleYearToDate, newSaleYearToDate, oldCostYearToDate, newCostYearToDate;

            oldAccountCode = myRow.Cells[0].Value.ToString();
            oldAdd1 = myRow.Cells[1].Value.ToString();
            oldAdd2 = myRow.Cells[2].Value.ToString();
            oldAdd3 = myRow.Cells[3].Value.ToString();
            oldBalance = Convert.ToDecimal(myRow.Cells[4].Value.ToString());
            oldSaleYearToDate = Convert.ToDecimal(myRow.Cells[5].Value.ToString());
            oldCostYearToDate = Convert.ToDecimal(myRow.Cells[6].Value.ToString());


            newAccountCode = textBox1.Text;
            newAdd1 = textBox2.Text;
            newAdd2 = textBox3.Text;
            newAdd3 = textBox4.Text;
            newBalance = Convert.ToDecimal(textBox5.Text);
            newSaleYearToDate = Convert.ToDecimal(textBox6.Text);
            newCostYearToDate = Convert.ToDecimal(textBox7.Text);

            DialogResult dialogr = MessageBox.Show("Are you sure you want to update this record?", "Update Confirmation", MessageBoxButtons.YesNoCancel);

            if (dialogr == DialogResult.Yes) 
            {
                debtorsMasterDetailsTblTableAdapter.Update(newAccountCode, newAdd1, newAdd2, newAdd3, newBalance, newSaleYearToDate, newCostYearToDate,
                 oldAccountCode, oldAdd1, oldAdd2, oldAdd3, oldBalance, oldSaleYearToDate, oldCostYearToDate);
                debtorsMasterDetailsTblTableAdapter.Fill(this.mngmntSystDBDataSet.DebtorsMasterDetailsTbl);
                MessageBox.Show("Details updated!");

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexRow];
            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            textBox3.Text = row.Cells[2].Value.ToString();
            textBox4.Text = row.Cells[3].Value.ToString();
            textBox5.Text = row.Cells[4].Value.ToString();
            textBox6.Text = row.Cells[5].Value.ToString();
            textBox7.Text = row.Cells[6].Value.ToString();
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
        }

        private void tbSearchDebtor_TextChanged(object sender, EventArgs e)
        {
            debtorsMasterDetailsTblTableAdapter.FillBy(mngmntSystDBDataSet.DebtorsMasterDetailsTbl, tbSearchDebtor.Text);
        }
    }
}
