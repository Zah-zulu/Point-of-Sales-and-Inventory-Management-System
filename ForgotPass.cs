using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Major_project_M2
{
    public partial class ForgotPass : Form
    {
        string randomCode;
        public static string to;
        public ForgotPass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
          
        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string phoneNumber = textBox2.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("Please fill out all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsUserValid(username, phoneNumber))
            {
                MessageBox.Show("Invalid username or phone number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ResetPassword resetpass = new ResetPassword(username);
            resetpass.Show();
            this.Hide();
        }
        private bool IsUserValid(string username, string phoneNumber)
        {
            string connectionString = "Data Source= DB Connection;Initial Catalog= User ID;User ID= User Id;Password=User Password";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM dbo.Staff WHERE Staff_Username = @Username AND Staff_Phone_No = @PhoneNumber";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

                try
                {
                    conn.Open();
                    int count = (int)cmd.ExecuteScalar(); // Count matching records
                    return count > 0; // Returns true if user exists
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
    }
}
