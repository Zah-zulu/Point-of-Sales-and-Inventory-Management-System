using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Major_project_M2
{
    public partial class Cashier : Form
    {
        // Connection string (update it with your database details)
        //private string connectionString = "your_connection_string_here";
        private string username;
        private Label subtotalLabel;
        private Label totalLabel;
        public DataTable InvoiceTable { get; private set; }
        //  to track whether the sale was recorded successfully
        private bool saleRecorded = false;
        public Cashier(string username)
        {
            this.username = username;
            InitializeComponent();
            LoadStaffDetails();
            LoadProducts();
            InitializeInvoiceTable();
            InitializeDataGridView();
            AddSubtotalAndTotalLabels();

            // Set text boxes to read-only
            subtotalTextBox.ReadOnly = true;
            totalVATTextBox.ReadOnly = true;
            totalAmountTextBox.ReadOnly = true;
            textBox3.ReadOnly = true;

            // Set DataGridView to be read-only
            dataGridView2.ReadOnly = true;

            // Subscribe to the SelectionChanged event
            dataGridView2.SelectionChanged += DataGridView2_SelectionChanged;

            // Set dataGridViewProd to be read-only
            dataGridViewProd.ReadOnly = true;

            // Subscribe to the Leave event on textBox4 to validate input
            textBox4.Leave += TextBox4_Leave;

            buttonCheckT_Click_1(null, null);
            button1.Visible = false;
            //buttonCheckT.Visible = false;


        }
        private void TextBox4_Leave(object sender, EventArgs e)
        {
            int parsedValue;
            // Validate if the input in textBox4 is an integer
            if (!int.TryParse(textBox4.Text, out parsedValue))
            {
                // Show an error message if input is not valid
                MessageBox.Show("Error: Please enter a valid Amount value for the amount tendered.",
                                "Input Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                // Clear the textbox
                textBox4.Clear();

                // Optionally, set focus back to textBox4
                textBox4.Focus();
            }
        }
        private void LoadStaffDetails()
        {
            string connectionString = "Data Source=146.230.177.46;Initial Catalog=G10wst2024;Persist Security Info=True;User ID=G10Wst2024;Password=znxdw";
            string query = "SELECT Staff_ID,Staff_Role,Staff_FName,Staff_LName,Staff_Phone_No FROM Staff WHERE Staff_Username = @Username";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@Username", username);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewexample.DataSource = dt;
                AdjustDataGridViewColumns();
                dataGridViewexample.Visible = false; // Hide the dataGridViewExample
            }
        }

        private void AdjustDataGridViewColumns()
        {
            // Example adjustments
            if (dataGridViewexample.Columns["Staff_FName"] != null)
            {
                dataGridViewexample.Columns["Staff_FName"].Width = 200;
            }
            if (dataGridViewexample.Columns["Staff_LName"] != null)
            {
                dataGridViewexample.Columns["Staff_LName"].Width = 200;
            }
            if (dataGridViewexample.Columns["Staff_ID"] != null)
            {
                dataGridViewexample.Columns["Staff_ID"].Width = 200;
            }
            if (dataGridViewexample.Columns["Staff_Role"] != null)
            {
                dataGridViewexample.Columns["Staff_Role"].Width = 200;
            }
            if (dataGridViewexample.Columns["Staff_Phone_No"] != null)
            {
                dataGridViewexample.Columns["Staff_Phone_No"].Width = 200;
            }

            // Additional column settings
            // e.g., setting columns to read-only
            foreach (DataGridViewColumn column in dataGridViewexample.Columns)
            {
                column.ReadOnly = true;
            }
        }


        private void InitializeInvoiceTable()
        {
            InvoiceTable = new DataTable();
            InvoiceTable.Columns.Add("Prod_Barcode", typeof(int));
            InvoiceTable.Columns.Add("ProductName", typeof(string));
            InvoiceTable.Columns.Add("Quantity", typeof(int));
            InvoiceTable.Columns.Add("Price", typeof(decimal));
           // InvoiceTable.Columns.Add("VAT", typeof(decimal));
            InvoiceTable.Columns.Add("Subtotal", typeof(decimal));

            InvoiceTable.RowChanged += InvoiceTable_RowChanged;
        }
        private void InvoiceTable_RowChanged(object sender, DataRowChangeEventArgs e)
        {
            if (e.Action == DataRowAction.Add || e.Action == DataRowAction.Change)
            {
                // Recalculate subtotal and total whenever a row is added or changed
                CalculateSubtotalAndTotal();
            }
        }
        private void AddSubtotalAndTotalLabels()
        {
            // Create a label for Subtotal
            subtotalLabel = new Label();
            subtotalLabel.Text = "Subtotal: $0.00";
            subtotalLabel.Location = new Point(10, 10); // Set the location of the Subtotal label
            subtotalLabel.AutoSize = true;

            // Create a label for Total
            totalLabel = new Label();
            totalLabel.Text = "Total: $0.00";
            totalLabel.Location = new Point(10, 30); // Set the location of the Total label
            totalLabel.AutoSize = true;

            // Add the labels to your form's controls collection
            // Controls.Add(subtotalLabel);
            // Controls.Add(totalLabel);
        }
        private void CalculateSubtotalAndTotal()
        {
            decimal subtotal = 0;
            decimal total = 0;
            StringBuilder errorMessage = new StringBuilder();
            bool hasError = false;

            foreach (DataRow row in InvoiceTable.Rows)
            {
                // Check for empty Price
                if (row["Price"] == DBNull.Value || row["Price"] == null)
                {
                    errorMessage.AppendLine("Price cannot be empty.");
                    hasError = true;
                    continue; // Skip to the next row
                }

                // Check for empty Quantity
                if (row["Quantity"] == DBNull.Value || row["Quantity"] == null)
                {
                    errorMessage.AppendLine("Quantity cannot be empty.");
                    hasError = true;
                    continue; // Skip to the next row
                }

                // If both values are valid, calculate subtotal
                decimal price = Convert.ToDecimal(row["Price"]);
                int quantity = Convert.ToInt32(row["Quantity"]);

                subtotal += price * quantity; // Update the subtotal calculation
            }

            if (hasError)
            {
                // Show error messages if any occurred
                MessageBox.Show(errorMessage.ToString(), "Calculation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                total = subtotal; // Placeholder for correct calculation based on VAT

                // Update the labels with the calculated subtotal and total
                subtotalLabel.Text = $"Subtotal: ${subtotal:C}";
                totalLabel.Text = $"Total: ${total:C}";
            }
        }

        private void InitializeDataGridView()
        {
            dataGridinvoice.DataSource = InvoiceTable; // Bind the InvoiceTable to the DataGridView named dataGridInvoice 

            // Set the columns to read-only except for 'Quantity'
            foreach (DataGridViewColumn column in dataGridinvoice.Columns)
            {
                column.ReadOnly = (column.Name != "Quantity");
            }
        }

        private void SearchCustomertextBox_TextChanged(object sender, EventArgs e)
        {
            taCuust1.FillByCustSurname(dsCust1.Customer_, SearchCustomertextBox.Text);
            //taCust2.FillByCust_LName(dsCust1.Customer_, SearchCustomertextBox.Text); 
            int rowsAffected = taCuust1.FillByCustSurname(dsCust1.Customer_, SearchCustomertextBox.Text);
            //dataGridView2.DataSource = dsCust1.Customer_;
            //LoadCustomerData();

            if (rowsAffected == 0)
            {
                MessageBox.Show("No customer records were found matching the provided last name. Please verify the information and try again.", "Customer Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // else
            // {
            //dataGridView2.CurrentCell = dataGridView2.Rows[0].Cells[0];
            //}


        }

        private void Cashier_Load(object sender, EventArgs e)
        {
            button1.Visible = true;
            // TODO: This line of code loads data into the 'g10wst2024DataSet1.Product' table. You can move, or remove it, as needed.
            this.taProd.Fill(this.g10wst2024DataSet1.Product);
            // TODO: This line of code loads data into the 'g10wst2024DataSet.Customer_' table. You can move, or remove it, as needed.
            //this.taCuust1.Fill(this.g10wst2024DataSet.Customer_);
            // TODO: This line of code loads data into the 'dsCust1.Payment' table. You can move, or remove it, as needed.
            this.taPayment.Fill(this.dsCust1.Payment);
            //dataGridView2.DataSource = dsCust1.Customer_;
            //LoadCustomerData();
            dataGridViewProd.DataSource = dsCust1.Product;
            LoadProducts();
            loadPos(false, false, false, false, false);
            //this.taStaff.Fill(this.dsCust1.Staff); 
            DateTime currentTime = DateTime.Now;
            string greeting = "";

            if (currentTime.Hour < 12)
            {
                greeting = "Morning";
            }
            else if (currentTime.Hour < 17)
            {
                greeting = "Afternoon";
            }
            else
            {
                greeting = "Evening";
            }

            string staffName = dataGridViewexample.Rows[0].Cells["Staff_FName"].Value.ToString() + " " + dataGridViewexample.Rows[0].Cells["Staff_LName"].Value.ToString();
            string message = $"{greeting}, {staffName}";

            /*string motivation = "Remember, a positive attitude and excellent customer service  " + Environment.NewLine +
                       "can make all the difference in a customer's day. " + Environment.NewLine +
                       "Let's make it a great day!";*/



            labelGreeting.Text = message;
            //Labelmotivation.Text = motivation; 


            //Remember, a positive attitude and excellent customer service can make all the difference in a customer's day. Let's make it a great day!


        }
        private void loadPos(bool button1vis,bool button5enable,bool nexbut,bool button2ena,bool butt4)
        {
            button1.Enabled = button1vis;
            button5.Enabled = button5enable;
            nextButton.Enabled = nexbut;
            button2.Enabled = button2ena;
            button4.Enabled = butt4;

        }
        private void LoadProducts()
        {

            taProd.Fill(dsCust1.Product); // Fill the Products DataTable

            // Set the DataTable as the DataSource for the DataGridView
            dataGridViewProd.DataSource = dsCust1.Product;

        }
        private void LoadCustomerData()
        {
            try
            {
                taCuust1.Fill(dsCust1.Customer_); // Assuming taCust1 is your TableAdapter
            }
            catch (Exception ex)
            {
                // Log the exception details (optional)
                Console.WriteLine("Error loading customer data: " + ex.Message);
            }
        }

        private void DataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            // Check if there is a selected row
            if (dataGridView2.CurrentRow != null && dataGridView2.SelectedRows.Count > 0)
            {
                // Ensure that the entire row is selected
                if (dataGridView2.SelectedRows[0].Index == dataGridView2.CurrentRow.Index)
                {
                    // Populate TextBoxes with the values from the selected row
                    FNametextBox.Text = dataGridView2.CurrentRow.Cells[1].Value?.ToString();
                    LNametextBox.Text = dataGridView2.CurrentRow.Cells[2].Value?.ToString();
                    AddresstextBox.Text = dataGridView2.CurrentRow.Cells[3].Value?.ToString();
                    maskedTextBox1.Text = dataGridView2.CurrentRow.Cells[4].Value?.ToString();
                    EmailAddresstextBox.Text = dataGridView2.CurrentRow.Cells[5].Value?.ToString();
                }
                else
                {
                    // Clear the TextBoxes if the row is not fully selected
                    ClearTextBoxes();
                }
            }
            else
            {
                // Clear the TextBoxes if no row is selected
                ClearTextBoxes();
            }
        }

        private void ClearTextBoxes()
        {
            FNametextBox.Text = "";
            LNametextBox.Text = "";
            AddresstextBox.Text = "";
            maskedTextBox1.Text = "";
            EmailAddresstextBox.Text = "";
        }
        private void UpdateCustomerbutton_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if a customer record is selected
                if (dataGridView2.CurrentRow == null)
                {
                    MessageBox.Show("Please select a customer to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Check if all text boxes are empty and show an error message
                if (string.IsNullOrEmpty(FNametextBox.Text) &&
                    string.IsNullOrEmpty(LNametextBox.Text) &&
                    string.IsNullOrEmpty(AddresstextBox.Text) &&
                    string.IsNullOrEmpty(maskedTextBox1.Text) &&
                    string.IsNullOrEmpty(EmailAddresstextBox.Text))
                {
                    MessageBox.Show("Please ensure that at least one field has been updated before proceeding.",
                        "Validation Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return; // Exit the method without proceeding
                }

                // Prompt for confirmation before updating customer details
                DialogResult confirmResult = MessageBox.Show("Do you want to update the customer details?",
                                                              "Confirm Update",
                                                              MessageBoxButtons.YesNo);

                if (confirmResult != DialogResult.Yes)
                {
                    MessageBox.Show("The update has been cancelled.", "Update Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return; // Exit the method without performing the update
                }

                // Retrieve existing values to retain unchanged fields
                string firstName = (string)dataGridView2.CurrentRow.Cells[1].Value;
                string lastName = (string)dataGridView2.CurrentRow.Cells[2].Value;
                string address = (string)dataGridView2.CurrentRow.Cells[3].Value;
                string phoneNumber = (string)dataGridView2.CurrentRow.Cells[4].Value;
                string emailAddress = (string)dataGridView2.CurrentRow.Cells[5].Value;

                // Update fields based on what has been entered
                string newFirstName = string.IsNullOrEmpty(FNametextBox.Text) ? firstName : FNametextBox.Text;
                string newLastName = string.IsNullOrEmpty(LNametextBox.Text) ? lastName : LNametextBox.Text;
                string newAddress = string.IsNullOrEmpty(AddresstextBox.Text) ? address : AddresstextBox.Text;
                string newPhoneNumber = string.IsNullOrEmpty(maskedTextBox1.Text) ? phoneNumber : maskedTextBox1.Text;
                string newEmailAddress = string.IsNullOrEmpty(EmailAddresstextBox.Text) ? emailAddress : EmailAddresstextBox.Text;

                // Update the fields in the database with the new values
                taCuust1.UpdateCustInfo(newFirstName, newLastName, newAddress, newPhoneNumber, newEmailAddress, (int)dataGridView2.CurrentRow.Cells[0].Value);

                // Refresh the DataGridView after updating customer information
                taCuust1.Fill(dsCust1.Customer_);

                MessageBox.Show("Customer information has been successfully updated.",
                    "Update Confirmation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Clear the textboxes after updating customer information
                ClearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating customer information: " + ex.Message,
                    "Update Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void AddCustomerbutton_Click(object sender, EventArgs e)
        {
            // Check if first name or last name are empty or consist only of whitespace
            if (string.IsNullOrWhiteSpace(FNametextBox.Text) ||
                string.IsNullOrWhiteSpace(LNametextBox.Text))
            {
                MessageBox.Show("First name and last name are required fields and cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method without adding the customer
            }

            // Prompt for confirmation before adding a new customer
            DialogResult result = MessageBox.Show("Do you want to confirm?", "Confirmation", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                // Capture input values from text boxes, trimming whitespace
                string firstName = FNametextBox.Text.Trim();
                string lastName = LNametextBox.Text.Trim();
                string address = AddresstextBox.Text.Trim(); // This can be empty
                string phoneNumber = maskedTextBox1.Text.Trim(); // This can be empty
                string email = EmailAddresstextBox.Text.Trim(); // This can be empty

                // Insert the customer info into the database
                try
                {
                    taCuust1.InsertCustInfo(firstName, lastName, address, phoneNumber, email);
                    MessageBox.Show("The new customer has been successfully added.", "Customer Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear the textboxes after adding a new customer
                    ClearTextBoxes();

                    // Refresh the customer dataset
                    taCuust1.Fill(dsCust1.Customer_);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while adding the customer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("The new customer has not been added.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("The operation has been cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void buttonPro_Click(object sender, EventArgs e)
        {

            // Assuming tabControl1 is the name of your TabControl
            tabControl1.SelectedIndex = 2; // Index of the tab where the customer can select items 
            label4.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            label5.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();


        }
        private void addInvoice_Click(object sender, EventArgs e)
        {
            if (dataGridViewProd.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewProd.SelectedRows[0];

                int Prod_Barcode = Convert.ToInt32(selectedRow.Cells[0].Value);
                int supplierID = Convert.ToInt32(selectedRow.Cells[1].Value);
                string productDescription = selectedRow.Cells[2].Value.ToString();
                decimal price = Convert.ToDecimal(selectedRow.Cells[3].Value);
                int quantityAvailable = Convert.ToInt32(selectedRow.Cells[4].Value);
                decimal vat = Convert.ToDecimal(selectedRow.Cells[5].Value);

                // Check if the product is already in the InvoiceTable
                DataRow existingProductRow = InvoiceTable.AsEnumerable()
                    .FirstOrDefault(row => Convert.ToInt32(row["Prod_Barcode"]) == Prod_Barcode);

                if (existingProductRow != null)
                {
                    int currentQuantity = Convert.ToInt32(existingProductRow["Quantity"]);
                    // Check if there is sufficient stock available
                    if (currentQuantity < quantityAvailable)
                    {
                        existingProductRow["Quantity"] = currentQuantity + 1; // Increase the quantity by 1
                        existingProductRow["Subtotal"] = Convert.ToDecimal(existingProductRow["Price"]) * Convert.ToInt32(existingProductRow["Quantity"]); // Update the subtotal
                        selectedRow.Cells[4].Value = quantityAvailable - 1; // Update available stock
                    }
                    else
                    {
                        // Show message with available stock info
                        MessageBox.Show($"No stock available for this product. Only {quantityAvailable-1} are available.", "Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    // Check if any stock is available to add a new record
                    if (quantityAvailable > 0)
                    {
                        int quantity = 1; // Default quantity is 1
                        DataRow product = InvoiceTable.NewRow();
                        product["Prod_Barcode"] = Prod_Barcode;
                        product["ProductName"] = productDescription;
                        product["Quantity"] = quantity;
                        product["Price"] = price;
                        product["Subtotal"] = price * quantity;

                        InvoiceTable.Rows.Add(product);

                        // Subtract from the quantity available in the datagridProd
                        selectedRow.Cells[4].Value = quantityAvailable - 1;
                    }
                    else
                    {
                        // Show message with available stock info
                        MessageBox.Show($"No stock available for this product. Only {quantityAvailable-1} are available.", "Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                // Update subtotal and total labels
                UpdateTextBoxes(); // Update the text boxes after adding
                loadPos(true, true, false, false, false);
            }
        }

        // New method to handle updating the TextBoxes
        private void UpdateTextBoxes()
        {
            decimal totalAmount = 0;
            decimal subtotal = 0;
            decimal vatRate = 0.15m; // 15% VAT rate

            try
            {
                // Ensure InvoiceTable has rows to iterate through
                foreach (DataRow row in InvoiceTable.Rows)
                {
                    decimal itemSubtotal = Convert.ToDecimal(row["Subtotal"]);
                    subtotal += itemSubtotal; // Sum up subtotal for total
                }

                // Calculate total VAT based on subtotal
                decimal totalVAT = subtotal * vatRate; // Total VAT calculated from subtotal
                totalAmount = subtotal + totalVAT; // Combine subtotal and total VAT

                // Display the total amount, total VAT, and subtotal in the respective TextBoxes
                totalAmountTextBox.Text = totalAmount.ToString("C");
                totalVATTextBox.Text = totalVAT.ToString("C");
                subtotalTextBox.Text = subtotal.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Please ensure your textboxes have valid numeric values. Error: {ex.Message}");
            }
        }

        private void buttonCheckT_Click_1(object sender, EventArgs e)
        {
            int quantity;
            StringBuilder errorMessage = new StringBuilder();
            bool hasError = false;

            foreach (DataGridViewRow row in dataGridinvoice.Rows)
            {
                // Check if the row is not a new row
                if (!row.IsNewRow)
                {
                    // Check if the Quantity cell is empty or invalid
                    if (row.Cells["Quantity"].Value == null || string.IsNullOrWhiteSpace(row.Cells["Quantity"].Value.ToString()))
                    {
                        int prodBarcode = Convert.ToInt32(row.Cells["Prod_Barcode"].Value);
                        errorMessage.AppendLine($"Product {prodBarcode}: Quantity cannot be empty.");
                        hasError = true;
                        continue; // Skip to the next row
                    }

                    // Try to parse the quantity
                    if (!int.TryParse(row.Cells["Quantity"].Value.ToString(), out quantity) || quantity < 0) 
                    {
                        int prodBarcode = Convert.ToInt32(row.Cells["Prod_Barcode"].Value);
                        errorMessage.AppendLine($"Product {prodBarcode}: Invalid quantity. Please enter a positive integer.");
                        hasError = true;
                        continue; // Skip to the next row
                    }

                    // Find the corresponding DataRow in the InvoiceTable
                    int prodBarcodeForInvoice = Convert.ToInt32(row.Cells["Prod_Barcode"].Value);
                    DataRow invoiceRow = InvoiceTable.AsEnumerable()
                        .FirstOrDefault(r => Convert.ToInt32(r["Prod_Barcode"]) == prodBarcodeForInvoice);

                    if (invoiceRow != null)
                    {
                        // Update the quantity and subtotal in InvoiceTable
                        invoiceRow["Quantity"] = quantity; // Update the quantity
                        invoiceRow["Subtotal"] = Convert.ToDecimal(invoiceRow["Price"]) * quantity; // Update the subtotal based on the updated quantity
                    }
                }
            }

            if (hasError)
            {
                // Show error messages if any occurred
                MessageBox.Show(errorMessage.ToString(), "Quantity Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Recalculate the totals after updating quantities if no error
            if (!hasError)
            {
                UpdateTextBoxes();
            }
            
        }
        private void buttonChecjout_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nextButton_Click_1(object sender, EventArgs e)
        {
            
            // Confirm the order
            DialogResult dialogResult = MessageBox.Show("Confirm Order to " + label4.Text + " of an amount of " + totalAmountTextBox.Text, "Order Confirmation", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                decimal total;
                decimal amountTendered;
                decimal change;

                // Clean and parse input values
                string totalAmountText = CleanCurrencyInput(totalAmountTextBox.Text);
                string amountTenderedText = CleanCurrencyInput(textBox4.Text);
                string changeText = CleanCurrencyInput(textBox3.Text);

                // Parse the string values directly into decimals
                bool isTotalParsed = decimal.TryParse(totalAmountText, NumberStyles.AllowDecimalPoint, CultureInfo.CurrentCulture, out total);
                bool isAmountTenderedParsed = decimal.TryParse(amountTenderedText, NumberStyles.AllowDecimalPoint, CultureInfo.CurrentCulture, out amountTendered);
                bool isChangeParsed = decimal.TryParse(changeText, NumberStyles.AllowDecimalPoint, CultureInfo.CurrentCulture, out change);

                if (isTotalParsed && isAmountTenderedParsed && isChangeParsed)
                {
                    try
                    {
                        // Ensure proper decimal formatting
                        if (total != Math.Round(total, 2) || amountTendered != Math.Round(amountTendered, 2) || change != Math.Round(change, 2))
                        {
                            MessageBox.Show("Ensure all amounts are formatted correctly as two decimal places.", "Formatting Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Insert the sale record
                        taSales.InsertNewsale(Convert.ToInt32(label5.Text), DateTime.Now.ToString("d"), total, comboBox1.SelectedItem.ToString(), amountTendered, change, Convert.ToInt32(employeeid.Text));
                        MessageBox.Show("Sale recorded successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Set the saleRecorded flag to true
                        saleRecorded = true;

                        // Refresh the sales data
                        taSales.Fill(dsCust1.Sales);

                        // Update the DataGridView (this will now show empty)
                        InitializeDataGridView();

                        // Display the latest sale info if applicable
                        if (dataGridViewSale.Rows.Count > 0)
                        {
                            // Get the index of the last row
                            int secondLastRowIndex = dataGridViewSale.Rows.Count - 2;

                            // Get the value from the first cell of the last row
                            object cellValue = dataGridViewSale.Rows[secondLastRowIndex].Cells[0].Value;

                            // Check if the cell value is not null
                            if (cellValue != null)
                            {
                                label23.Text = cellValue.ToString();
                            }
                            else
                            {
                                label23.Text = "No data";
                            }
                        }
                        else
                        {
                            label23.Text = "No data available";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error recording sale: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Display an error message if parsing fails
                    string errorMsg = "Please ensure all textboxes contain valid numeric values.\n";
                    if (!isTotalParsed) errorMsg += "Error parsing total amount.\n";
                    if (!isAmountTenderedParsed) errorMsg += "Error parsing amount tendered.\n";
                    if (!isChangeParsed) errorMsg += "Error parsing change.";
                    MessageBox.Show(errorMsg, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                loadPos(false, false, true, true, false);
            }
            else if (dialogResult == DialogResult.No)
            {
                // If cancelled, clear only relevant input fields
                totalAmountTextBox.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                loadPos(true, true, true, false, false);
            }
        }
        private string CleanCurrencyInput(string input)
        {
            // Remove any non-numeric characters except the decimal point
            return Regex.Replace(input, @"[^\d.,]", ""); // Allowing both comma and decimal points
        }

        private void tabPagePro_Click(object sender, EventArgs e)
        {

        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (dataGridinvoice.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridinvoice.SelectedRows[0];
                int Prod_Barcode = Convert.ToInt32(selectedRow.Cells["Prod_Barcode"].Value);
                int quantityToRemove = 1;

                DataRow rowToRemove = InvoiceTable.AsEnumerable()
                    .FirstOrDefault(row => Convert.ToInt32(row["Prod_Barcode"]) == Prod_Barcode);

                if (rowToRemove != null)
                {
                    int currentQuantityProd = Convert.ToInt32(rowToRemove["Quantity"]);

                    if (currentQuantityProd > 1)
                    {
                        rowToRemove["Quantity"] = currentQuantityProd - 1;

                        // Update the subtotal for the product
                        rowToRemove["Subtotal"] = Convert.ToDecimal(rowToRemove["Price"]) * Convert.ToInt32(rowToRemove["Quantity"]);
                    }
                    else
                    {
                        InvoiceTable.Rows.Remove(rowToRemove);
                    }

                    DataGridViewRow productRow = dataGridViewProd.Rows
                        .Cast<DataGridViewRow>()
                        .FirstOrDefault(r => Convert.ToInt32(r.Cells[0].Value) == Prod_Barcode);

                    if (productRow != null)
                    {
                        int currentQuantity = Convert.ToInt32(productRow.Cells[4].Value);
                        productRow.Cells[4].Value = currentQuantity + quantityToRemove;
                    }

                    // Call the method to update the text boxes with the new totals
                    UpdateTextBoxes(); // Update the amounts displayed in the textboxes
                }
            }
            else
            {
                MessageBox.Show("Please select a record to remove.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            taProd.FillByDescript(dsCust1.Product, textBox1.Text);

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                taSales.FillByDate(dsCust1.Sales, dateTimePicker1.Value.Date.ToShortDateString());
            }
            catch (Exception)
            {

                MessageBox.Show("No sales records were found matching the Specified Sale.", "Sale Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //taSales.FillByDate(dsCust1.Sales, dateTimePicker1.Value.Date.ToShortDateString());
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void tabControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //
        }

        private void dataGridViewEmployee_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //employeeid.Text = dataGridViewEmployee.CurrentRow.Cells[0].Value.ToString();
            //staffrole.Text = dataGridViewEmployee.CurrentRow.Cells[2].Value.ToString();
            //tabControl1.SelectedIndex = 1;

        }

        private void dataGridViewProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            // taPayment.FillByPayment(dsCust1.Payment, textBox5.Text);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            GenerateReceipt();
            loadPos(false, false, false, true, true);
        }
        private string GenerateRandomInvoiceNumber()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString();
        }
        private void GenerateReceipt()
        {
            // Check if a sale was recorded before generating the receipt
            if (!saleRecorded)
            {
                MessageBox.Show("Please record the sale before generating the receipt.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method if the sale has not been recorded
            }

            // Check if all required fields are filled
            if (!ValidateInputs())
            {
                // If validation fails, show a message and stop the process
                MessageBox.Show("Please fill in all required fields before generating the receipt.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Start creating the receipt
            string receipt = "";
            receipt += "R and M Business Supplies (PTY) LTD\n";
            receipt += " ";
            receipt += "59 Rose Heights Road, Arena Park\n";
            receipt += "Phone: 082 847 6632 | Email: rahim.haffejee@gmail.com\n\n";
            receipt += "Invoice Number: #" + GenerateRandomInvoiceNumber() + "\n";
            receipt += "-------------------------------------------------------------------------------------\n";
            receipt += $"Date:\t{DateTime.Now}\n";
            receipt += "-------------------------------------------------------------------------------------\n";
            receipt += "Product Name\t\tQty\t\tPrice\n";
            receipt += "-------------------------------------------------------------------------------------\n";

            decimal subtotal = 0;
            foreach (DataRow row in InvoiceTable.Rows)
            {
                decimal itemSubtotal = Convert.ToDecimal(row["Subtotal"]);
                decimal selectedQuantity = Convert.ToDecimal(row["Quantity"]);
                string productName = row["ProductName"].ToString();

                receipt += $"{productName}\t{selectedQuantity}\t  R {itemSubtotal:C}\n"; // Format as currency
                subtotal += itemSubtotal; // Accumulate subtotal for grand total calculation
            }

            receipt += "-------------------------------------------------------------------------------------\n";

            // Calculate VAT and grand total
            decimal vatRate = 0.15m; // VAT Rate of 15%
            decimal totalVAT = subtotal * vatRate; // Total VAT calculated from subtotal
            decimal grandTotal = subtotal + totalVAT; // Grand Total

            receipt += $"Subtotal: {subtotal:C}\n"; // Show subtotal
            receipt += $"Total VAT (15%): {totalVAT:C}\n"; // Show VAT
            receipt += $"Grand Total: {grandTotal:C}\n"; // Show grand total
            receipt += $"Payment Method:\t{comboBox1.SelectedItem}\n";
            receipt += $"Amount Tendered:R{textBox4.Text:C}\n";
            receipt += $"Change: {textBox3.Text:C}\n";
            receipt += "-------------------------------------------------------------------------------------\n";
            receipt += $"Cashier Name:\t{staffrole.Text + " " + StaffSurname.Text}\n";
            receipt += "-------------------------------------------------------------------------------------\n";
            receipt += "\n";
            receipt += "\t*Thank you for shopping with us! See you soon!*\n";
            receipt += "\n";
            receipt += "\t\t\t RETURN POLICY\n";
            receipt += "Returns accepted within 7 days with receipt. No returns on opened or used items.\n";

            // Display the receipt in a message box
            DialogResult dialogResult = MessageBox.Show(receipt, "R and M Business Supplies (PTY) LTD", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("The receipt has been successfully printed.", "Receipt Printed", MessageBoxButtons.OK, MessageBoxIcon.Information);



                // Optionally switch to another tab if needed
                //tabControl1.SelectedIndex = 3;
                // Clear all specified text boxes and combo box after printing
                subtotalTextBox.Clear();
                totalVATTextBox.Clear();
                totalAmountTextBox.Clear();
                comboBox1.SelectedIndex = -1; // Clear the combo box selection
                textBox4.Clear();
                textBox3.Clear();
                InvoiceTable.Clear();
                textBox4.ReadOnly = false; 
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("The receipt has been successfully discarded.", "Receipt Discarded", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        private bool ValidateInputs()
        {
            // Check if all textboxes and controls have values
            if (string.IsNullOrWhiteSpace(totalAmountTextBox.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                comboBox1.SelectedItem == null ||
                string.IsNullOrWhiteSpace(staffrole.Text) ||
                string.IsNullOrWhiteSpace(StaffSurname.Text))
            {
                // If any of the above are empty, return false
                return false;
            }

            // Additional validation checks can be added here if necessary

            // If all checks pass, return true
            return true;
        }


        //logout button 
        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void ClearDataGridView(DataGridView dgv)
        {
            dgv.DataSource = null;
            dgv.Rows.Clear();
            dgv.Refresh();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //clear 
            ClearDataGridView(dataGridinvoice);
            ClearDataGridView(dataGridViewProd);
            subtotalTextBox.Text = "";
            totalVATTextBox.Text = "";
            totalAmountTextBox.Text = "";
            //textBox2.Text = "";
            textBox4.Text = "";
            textBox3.Text = "";
            loadPos(false, false, false, false, true);

        }

        private void dataGridViewexample_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            employeeid.Text = dataGridViewexample.CurrentRow.Cells[0].Value.ToString();
            staffrole.Text = dataGridViewexample.CurrentRow.Cells[2].Value.ToString();
            StaffSurname.Text = dataGridViewexample.CurrentRow.Cells[3].Value.ToString();
            tabControl1.SelectedIndex = 1;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        /*private void textBox6_TextChanged(object sender, EventArgs e)
        {
            taProd.FillByDescript(dsCust1.Product, textBox6.Text);
        }*/

        private void button3_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to confirm your logout?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
               

                MessageBox.Show("You have been successfully logged out.", "Logout Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close(); // Close the current form
                // Create an instance of Form1 (or the desired form)
                Form1 frmHomePage = new Form1();
                frmHomePage.Show(); // Show the login or home page

            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("You have not been logged out.", "Logout Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The logout operation has been cancelled.", "Operation Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PhoneNotextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("When paying in cash, the amount tendered must be equal to or greater than the total amount of the sale.", "Payment Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            string paymentType = comboBox1.SelectedItem?.ToString().Trim(); // Trim whitespace

            // Ensure a payment type is selected
            if (string.IsNullOrEmpty(paymentType))
            {
                MessageBox.Show("Please choose a payment type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the payment method is cash
            if (paymentType.Equals("Cash", StringComparison.OrdinalIgnoreCase))
            {
                decimal totalAmount;
                decimal amountTendered;
                decimal change;

                // Parsing the total amount from totalAmountTextBox
                if (!decimal.TryParse(totalAmountTextBox.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out totalAmount))
                {
                    MessageBox.Show("Invalid total amount value. Please check and try again.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate amount tendered from textBox4
                if (!decimal.TryParse(textBox4.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out amountTendered))
                {
                    MessageBox.Show("Please enter a valid numeric amount for the amount tendered.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if amount tendered is sufficient
                if (amountTendered < totalAmount)
                {
                    MessageBox.Show("The amount tendered must be equal to or greater than the total amount.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Calculate the change
                change = amountTendered - totalAmount;

                // Display the change in textBox3
                textBox3.Text = change.ToString("C"); // Format the change as currency

                // Make textBox4 read-only
                textBox4.ReadOnly = true; // Set textBox4 to read-only
                MessageBox.Show("Payment made successfully","Payment Confirmation",MessageBoxButtons.OK,MessageBoxIcon.Information);

                
            }
            else if (paymentType.Equals("Credit Card", StringComparison.OrdinalIgnoreCase))
            {
                
                // For credit card payments
                textBox3.Text = "R0,00";  // Set change to zero
                textBox4.Text = "R0,00";  // Set amount tendered to zero
                
                // Hide textBox3 and textBox4
                textBox3.Visible = false;  // Make textBox3 invisible
                textBox4.Visible = false;  // Make textBox4 invisible
                
                // Display a success message 
                MessageBox.Show("Payment successfully!", "Payment Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Make textBox3 visible again
                textBox3.Visible = true;   // Make textBox3 visible again
                textBox4.Visible = true;   // Make textBox4 visible again 
                textBox4.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("This payment method does not require change calculations.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            loadPos(true, true, true, false, false);
        }
        private void dataGridViewexample_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {


            employeeid.Text = dataGridViewexample.Rows[0].Cells["Staff_ID"].Value.ToString();
            staffrole.Text = dataGridViewexample.Rows[0].Cells["Staff_FName"].Value.ToString();
            StaffSurname.Text = dataGridViewexample.Rows[0].Cells["Staff_LName"].Value.ToString();
            tabControl1.SelectedTab = tabPageCus;
            tabPageCus.Focus();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }



        private void nextButton_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            int quantity;
            StringBuilder errorMessage = new StringBuilder();
            bool hasError = false;

            foreach (DataGridViewRow row in dataGridinvoice.Rows)
            {
                // Check if the row is not a new row
                if (!row.IsNewRow)
                {
                    // Check if the Quantity cell is empty or invalid
                    if (row.Cells["Quantity"].Value == null || string.IsNullOrWhiteSpace(row.Cells["Quantity"].Value.ToString()))
                    {
                        int prodBarcode = Convert.ToInt32(row.Cells["Prod_Barcode"].Value);
                        errorMessage.AppendLine($"Product {prodBarcode}: Quantity cannot be empty.");
                        hasError = true;
                        continue; // Skip to the next row
                    }

                    // Try to parse the quantity
                    if (!int.TryParse(row.Cells["Quantity"].Value.ToString(), out quantity) || quantity < 0)
                    {
                        int prodBarcode = Convert.ToInt32(row.Cells["Prod_Barcode"].Value);
                        errorMessage.AppendLine($"Product {prodBarcode}: Invalid quantity. Please enter a positive integer.");
                        hasError = true;
                        continue; // Skip to the next row
                    }

                    // Find the corresponding DataRow in the InvoiceTable
                    int prodBarcodeForInvoice = Convert.ToInt32(row.Cells["Prod_Barcode"].Value);
                    DataRow invoiceRow = InvoiceTable.AsEnumerable()
                        .FirstOrDefault(r => Convert.ToInt32(r["Prod_Barcode"]) == prodBarcodeForInvoice);

                    if (invoiceRow != null)
                    {
                        // Update the quantity and subtotal in InvoiceTable
                        invoiceRow["Quantity"] = quantity; // Update the quantity
                        invoiceRow["Subtotal"] = Convert.ToDecimal(invoiceRow["Price"]) * quantity; // Update the subtotal based on the updated quantity
                    }
                }
            }

            if (hasError)
            {
                // Show error messages if any occurred
                MessageBox.Show(errorMessage.ToString(), "Quantity Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Recalculate the totals after updating quantities if no error
            if (!hasError)
            {
                UpdateTextBoxes();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}