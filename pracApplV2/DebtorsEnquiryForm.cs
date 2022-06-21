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
    public partial class DebtorsEnquiryForm : Form
    {
        public DebtorsEnquiryForm()
        {
            InitializeComponent();
        }

        private void DebtorsEnquiryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mngmntSystDBDataSet1.DebtorsTransTbl' table. You can move, or remove it, as needed.
            this.debtorsTransTblTableAdapter.Fill(this.mngmntSystDBDataSet1.DebtorsTransTbl);
            // TODO: This line of code loads data into the 'mngmntSystDBDataSet.DebtorsMasterDetailsTbl' table. You can move, or remove it, as needed.
            this.debtorsMasterDetailsTblTableAdapter.Fill(this.mngmntSystDBDataSet.DebtorsMasterDetailsTbl);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            debtorsMasterDetailsTblTableAdapter.FillBy(mngmntSystDBDataSet.DebtorsMasterDetailsTbl, textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            debtorsTransTblTableAdapter.FillBy(mngmntSystDBDataSet1.DebtorsTransTbl, textBox2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            debtorsTransTblTableAdapter.FillBy1(mngmntSystDBDataSet1.DebtorsTransTbl);
        }
    }
}
