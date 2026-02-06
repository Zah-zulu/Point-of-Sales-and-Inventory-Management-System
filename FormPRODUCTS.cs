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
    public partial class FormPRODUCTS : Form
    {
        public class Product
        {
            public int Product_Barcode { get; set; }
            public string Product_Description { get; set; }
            public decimal Product_Price { get; set; }
            public int Product_Available_Quantity { get; set; }
        }
        public FormPRODUCTS()
        {
            InitializeComponent();
        }
        public FormPRODUCTS(string value)
        {
            InitializeComponent();
            labelSupplierId.Text = value;

        }
        public void SetButtonVisible(bool addVisible, bool updateVisible,bool clearVisible)
        {
            addnewproduct.Visible = addVisible; // Show or hide the Add button
            button1.Visible = clearVisible;
            button2.Visible = updateVisible; // Show or hide the Update button
        }
        public void buttonset()
        {
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
        }

        private void FormPRODUCTS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSManager.Product' table. You can move, or remove it, as needed.
            //productTableAdapter.FillByDescript(g10wst2024DataSet.Product, labelSupplierId.Text);
            this.productTableAdapter1.Fill(this.dSManager.Product);


        }

        private void SearchProducttextBox_TextChanged(object sender, EventArgs e)
        {
            productTableAdapter.FillByDescript(g10wst2024DataSet.Product, SearchProducttextBox.Text);
        }

        private void addnewproduct_Click(object sender, EventArgs e)
        {
            decimal price;
            int qtyAvail;
            int reorderThresh;
            //textBox3.ReadOnly = true;
            try
            {
                if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) ||
        string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox5.Text))
                {
                    MessageBox.Show("All textboxes must have values except VAT, which will be calculated automatically.",
                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit the method if validation fails
                }

                // Attempt to parse numeric inputs
                string productDescript = textBox1.Text;
                if (!decimal.TryParse(textBox2.Text, out price) ||
                    !int.TryParse(textBox4.Text, out qtyAvail) ||
                    !int.TryParse(textBox5.Text, out reorderThresh))
                {
                    MessageBox.Show("Please enter valid numeric values for Price, Quantity Available, and Reorder Threshold.",
                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit the method if validation fails
                }

                // Automatically calculate VAT (15% of price)
                decimal VAT = price * 0.15M;

                // Display calculated VAT in the VAT textbox (optional)
                textBox3.Text = VAT.ToString("0.00");

                // Confirmation dialog
                DialogResult result = MessageBox.Show("Do you want to confirm?", "Confirmation", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    productTableAdapter.InsertProducts(Convert.ToInt32(labelSupplierId.Text), textBox1.Text, Convert.ToDecimal(textBox2.Text), Convert.ToDecimal(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text));
                        MessageBox.Show("product added successfully");
                }
                else if (result == DialogResult.No)
                {
                    MessageBox.Show("New Product NOT Added");
                }
                //else
                //{
                //MessageBox.Show("Cancelled");
                // }
                //string supplierid = labelSupplierId.Text;
                // Parse and validate Supplier ID
                //if (!int.TryParse(supplierid, out int parsedsupplierid))
                //{
                //MessageBox.Show("Invalid Supplier ID. Please enter a valid integer.");
                //return;
                //}
                /*if (!int.TryParse(labelSupplierId.Text, out Convert.ToInt32(supplierid)))
                {
                    MessageBox.Show("Invalid Supplier ID. Please enter a valid integer.");
                    return;
                }*/

                // Validate Product Name
                //string productName = textBox1.Text;
                //if (string.IsNullOrWhiteSpace(productName))
                // {
                // MessageBox.Show("Product Name cannot be empty.");
                // return;
                //}

                // Parse and validate Unit Price
                //if (!decimal.TryParse(textBox2.Text, out decimal unitPrice))
                // {
                //     MessageBox.Show("Invalid Unit Price. Please enter a valid decimal number.");
                // return;
                //}

                // Parse and validate Discount
                //if (!decimal.TryParse(textBox3.Text, out decimal discount))
                // {
                // MessageBox.Show("Invalid Discount. Please enter a valid decimal number.");
                // return;
                //}

                // Parse and validate Stock Quantity
                //if (!int.TryParse(textBox4.Text, out int stockQuantity))
                //{
                //MessageBox.Show("Invalid Stock Quantity. Please enter a valid integer.");
                //return;
                // }

                // Parse and validate Reorder Level
                // if (!int.TryParse(textBox5.Text, out int reorderLevel))
                //{
                // MessageBox.Show("Invalid Reorder Level. Please enter a valid integer.");
                // return;
                // }

                // Insert product into the database
                //productTableAdapter.InsertProducts(Supplier_ID, productName, unitPrice, discount, stockQuantity, reorderLevel);
                //productTableAdapter.InsertProduct(parsedsupplierid, productName, unitPrice, discount, stockQuantity, reorderLevel);
                // Inform the user of success
                //MessageBox.Show("Product inserted successfully.");
            }
            catch (Exception ex)
            {
                // Handle any unexpected exceptions
                MessageBox.Show($"An error occurred: {ex.Message}");
                this.Focus();
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            //clear text from all textbox fields on the product form
            textBox5.Text = "";
            textBox4.Text = "";
            textBox3.Text = "";
            textBox2.Text = "";
            textBox1.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int barcode = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                decimal price = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[3].Value);
                string description = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                int QOH = Convert.ToInt32(dataGridView1.CurrentRow.Cells[5].Value);
                UpdateDetailsForm updateForm = new UpdateDetailsForm(barcode, description, price, QOH);
                //updateForm.ShowDialog();
                if (updateForm.ShowDialog() == DialogResult.OK)
                {
                    // Update the DataGridView with modified data
                    dataGridView1.CurrentRow.Cells[0].Value = updateForm.Barcode;
                    dataGridView1.CurrentRow.Cells[2].Value = updateForm.Description;
                    dataGridView1.CurrentRow.Cells[3].Value = updateForm.Price;
                    dataGridView1.CurrentRow.Cells[5].Value = updateForm.QOH;

                    MessageBox.Show("Details updated successfully!");
                }
            }
            catch
            {
                MessageBox.Show("please select product to update");
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
              
      
    

