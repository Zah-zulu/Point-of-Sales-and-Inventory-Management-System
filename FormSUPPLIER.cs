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
    public partial class FormSUPPLIER : Form
    {
        public FormSUPPLIER()
        {
            InitializeComponent();
        }

        private void SearchSuppliertextBox_TextChanged(object sender, EventArgs e)
        {
            supplierTableAdapter.FillBySName(dSManager.Supplier, SearchSuppliertextBox.Text);
        }

        private void FormSUPPLIER_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSManager.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.dSManager.Supplier);

        }

        private void AddSupplierbutton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Confirm?", "Confirmation", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                string suppliername = SupplierNametextBox.Text;
                string supplieraddress = SupplierAddresstextBox.Text;
                string supplierphoneNumber = SupplierPhoneNumbertextBox.Text;
                string supplieremail = SupplierEmailtextBox.Text;
                //decimal supplieraccountbalance = Convert.ToDecimal(SupplierAccountBalancetextBox.Text);
                decimal supplieraccountbalance;

                if (string.IsNullOrWhiteSpace(suppliername) || string.IsNullOrWhiteSpace(supplieraddress) ||
                  string.IsNullOrWhiteSpace(supplierphoneNumber) || string.IsNullOrWhiteSpace(supplieremail))
                {
                    MessageBox.Show("All fields except account balance must be filled.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit if validation fails
                }
                            // Check if the text box is null or empty
               if (string.IsNullOrWhiteSpace(SupplierAccountBalancetextBox.Text))
                {
                    // Assign a default value if it is null or empty
                    supplieraccountbalance = 0m;
                }
                else
                {
                    // Attempt to parse the text to a decimal
                    if (!decimal.TryParse(SupplierAccountBalancetextBox.Text, out supplieraccountbalance))
                    {
                        // Handle invalid input by assigning a default value or showing an error message
                        supplieraccountbalance = 0m;
                        MessageBox.Show("Invalid input. Setting supplier account balance to 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


                supplierTableAdapter.InsertNewSupp(suppliername, supplieraddress, supplierphoneNumber, supplieremail, supplieraccountbalance);
                MessageBox.Show("New Supplier Added");

                // Clear the textboxes after adding a new supplier
                SupplierNametextBox.Text = "";
                SupplierAddresstextBox.Text = "";
                SupplierPhoneNumbertextBox.Text = "";
                SupplierEmailtextBox.Text = "";
                SupplierAccountBalancetextBox.Text = "";


                supplierTableAdapter.Fill(dSManager.Supplier);// To Fill method to get the latest data into the gridset
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("New Supplier NOT Added");
            }
            else
            {
                MessageBox.Show("Cancelled");
            }
        }

        private void dataGridViewsupplier_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewsupplier.Rows[e.RowIndex];

                // Assign DataGridView cell values to respective TextBoxes
                SupplierNametextBox.Text = row.Cells[1].Value?.ToString();
                SupplierAddresstextBox.Text = row.Cells[2].Value?.ToString();
                SupplierPhoneNumbertextBox.Text = row.Cells[3].Value?.ToString();
                SupplierAccountBalancetextBox.Text = row.Cells[5].Value?.ToString();
                SupplierEmailtextBox.Text = row.Cells[4].Value?.ToString();
            }
            label7.Text = dataGridViewsupplier.CurrentRow.Cells[0].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valueToPass = label7.Text; // Get the value from label1
            if (dataGridViewsupplier.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a supplier row first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                FormPRODUCTS form2 = new FormPRODUCTS(valueToPass); // Pass the value to Form2
                form2.Show(); // Show Form2
            }
           

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
