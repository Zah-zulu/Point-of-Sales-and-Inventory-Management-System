using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Major_project_M2
{
    public partial class UpdateDetailsForm : Form
    {
        public int Barcode { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public int QOH { get; private set; }

        private string connectionString = "Data Source=DB CONNECTION;Initial Catalog= ID;User ID= User ID;Password=user Password";
        public UpdateDetailsForm(int bcode, string descr, decimal pric, int QO)
        {
            InitializeComponent();
            textBox1.Text=descr;
            textBox2.Text = bcode.ToString();
            textBox3.Text = pric.ToString();
            textBox4.Text = QO.ToString();
        }

        private void UpdateDetailsForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Update properties with values from textboxes
                Barcode = Convert.ToInt32(textBox2.Text);
                Description = textBox1.Text;
                Price = Convert.ToDecimal(textBox3.Text);
                QOH = Convert.ToInt32(textBox4.Text);

                // Set DialogResult to OK and close the form
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL UPDATE command
                    string query = "UPDATE dbo.Product SET Prod_Description = @Description, Prod_Price = @Price, Prod_Quantity_Available = @QOH WHERE Prod_Barcode = @Barcode";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Set parameters
                        //command.Parameters.AddWithValue("@Barcode", Barcode);
                        command.Parameters.AddWithValue("@Description", Description);
                        command.Parameters.AddWithValue("@Price", Price);
                        command.Parameters.AddWithValue("@QOH", QOH);


                        command.Parameters.AddWithValue("@Barcode", Barcode);
                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Database updated successfully!");
                            this.DialogResult = DialogResult.OK; // Indicate success
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No rows affected. Please check the Barcode.");
                        }
                    }
                }
                //this.DialogResult = DialogResult.OK;
               // this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving details: " + ex.Message);
            }
        }
    }
    }

