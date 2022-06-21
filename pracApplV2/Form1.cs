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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //invoking the method on runtime
            formDesign();

        }

        private void formDesign() 
        {
            //to hide the submenu panels 
            //setting the visible property to false
            createupdateSubMenuPanel.Visible = false;
            enquirySubMenuPanel.Visible = false;

           
        }
        //method to hide the submenu 
        private void hideSubMenu() 
        {
            if (createupdateSubMenuPanel.Visible == true) 
            {
                createupdateSubMenuPanel.Visible = false;  //if this panel is visible initialise it to false 
            } 

            if (enquirySubMenuPanel.Visible == true)
            {
                enquirySubMenuPanel.Visible = false;    //if this panel is visible initialise it to false
            }

        }

        //display the submenu

        //all submenus are panels 
        private void showSubMenu(Panel subMenu) 
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu(); //to hide if there are any submenus 
                subMenu.Visible = true;//show the submenu 

            } //otherwise -- submenu is visible
            else
                subMenu.Visible = false; //change the visibilty



        }

        private void btnCreateUpdate_Click(object sender, EventArgs e)
        {
            showSubMenu(createupdateSubMenuPanel);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Debtors Master File form 
            openChildForm(new DebtorsMasterFileDetails());
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // stock master details form 
            openChildForm(new StockMasterDetails());
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // stock adjustments form 
            openChildForm(new StockAdjustmentsForm());
            hideSubMenu();
        }

        private void btnEnquiry_Click(object sender, EventArgs e)
        {
            //show the Enquiry Submenu panel 
            showSubMenu(enquirySubMenuPanel);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //show the Debtors enquiry form 
            openChildForm(new DEnqForm());
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //show the stock enquiry form 
            openChildForm(new StEnqForm());
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Invoices button has no submenu 
            //show the enquiry form 
            openChildForm(new InvoiceForm());
            hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //exit button 
            Application.Exit();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm) 
        {
            if (activeForm != null) 
            {
                activeForm.Close(); //if there is an active form --close form 
            }
            activeForm = childForm; //now we save the form that opened in the active form variable 
            childForm.TopLevel = false; //so now it will behave like a control
            childForm.FormBorderStyle = FormBorderStyle.None; //remove border of the form 
            childForm.Dock = DockStyle.Fill; //to fill the entire container panel 
            logoPanel.Controls.Add(childForm); // add the form to list of controls in the container panel where on the home page, the logo resides --logoPanel
            logoPanel.Tag = childForm; //associate the form with the container panel 
            childForm.BringToFront(); //bring the form to the front 
            childForm.Show(); // show the child form 
        }
    }
}
