using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Major_project_M2
{
    public partial class Manager : Form
    {
        
        public Manager(string username)
        {
            InitializeComponent();
            vIEWSEARCHToolStripMenuItem.Click += new EventHandler(vIEWSEARCHToolStripMenuItem_Click);
            
        }

        private void ADDUPDATEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSTAFF frmStaff = new FormSTAFF();
            frmStaff.Show();
        }

        private void uPDATESTAFFToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormSTAFF frmStaff = new FormSTAFF();
            frmStaff.Show();
            frmStaff.SetButtonVisibility(false, true); // Hide Add button, show Update button
            
        }
        private void aDDUPDATEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSTAFF frmStaff = new FormSTAFF();
            frmStaff.SetButtonVisibility(true, false); // Show Add button, hide Update button
            frmStaff.Show();
        }

        private void vIEWSEARCHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPRODUCTS frmProd = new FormPRODUCTS();
            frmProd.Show();
            frmProd.SetButtonVisible(false, true,false); // Show Add button, hide Update button            
            frmProd.buttonset();
            //MessageBox.Show("you will not be able to add new products without selecting a supplier");
            //FormPRODUCTS frmProducts = new FormPRODUCTS();
            //frmProducts.Show();
            
        }

        private void OpenFormPRODUCTSWithoutValue()
        {
            FormPRODUCTS form2 = new FormPRODUCTS(); // Open Form2 without passing a value
            form2.Show(); // Show Form2
            
        }
        /*private void FormPRODUCTS_Load(object sender, EventArgs e)
        {
            if (dialogResult == DialogResult.No)
            {
                groupBox1.Visible = false;
            }
        }*/

        private void Manager_Load(object sender, EventArgs e)
        {
           
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Confirm your LogOut?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                this.Close();
                MessageBox.Show("logged out successfully");
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("you have not been logged out");
            }
            else
            {
                MessageBox.Show("Cancelled");
                this.Close();
            }
        }
        private void aDDUPDATEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormSUPPLIER frmSupplier = new FormSUPPLIER();
            frmSupplier.Show();
        }
        private void aDDPRODUCTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please select supplier first and then add new product");
            FormSUPPLIER frmSupplier = new FormSUPPLIER();
            frmSupplier.Show();
            
        }

        private void uPDATESTAFFToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pRODUCTSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void uPDATEPRODUCTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FormPRODUCTS frmproduct = new FormPRODUCTS();
            //frmproduct.Show();
        }

        private void sEARCHPRODUCTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormPRODUCTSWithoutValue();
        }

        private void uPDATESUPPLIERToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
