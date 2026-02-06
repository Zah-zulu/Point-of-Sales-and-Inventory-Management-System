using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Major_project_M2
{
    public partial class ResetPassword : Form
    {
        //string username=ForgotPass.to;
        private string username;

        public ResetPassword(string username)
        {
            InitializeComponent();
            // Store the provided email for the user
            this.username = username;

            // Attach click event handler to the password text box
            //textBoxNewPassword.Click += TextBoxNewPassword_Click;
        }

        private void TextBoxNewPassword_Click(object sender, EventArgs e)
        {
            // Show information about password requirements
           // MessageBox.Show("Password must be between 5 and 8 characters long.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonReset_Click_1(object sender, EventArgs e)
        {
            string newPassword = textBoxNewPassword.Text;
            string confirmPassword = textBoxConfrimPassword.Text;

            // Password validation logic
            if (string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill out both password fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Update password in the database
            UpdatePassword(username, newPassword);
        }

        private void UpdatePassword(string username, string newPassword)
        {
            string connectionString = "Data Source=DB Connection;Initial Catalog=User ID;User ID= User ID;Password=User Password";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE dbo.Staff SET Staff_Password = @Password WHERE Staff_Username = @Username";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Password", newPassword); // Hash the password
                cmd.Parameters.AddWithValue("@Username", username);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Password reset successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        //if (textBoxNewPassword.Text == textBoxConfrimPassword.Text)
        // {
        // SqlConnection con = new SqlConnection("Data Source=DB Connection;Initial Catalog=User ID;User ID= User ID;Password=User Password");
        // SqlCommand cmd = new SqlCommand("UPDATE[dbo].[Staff] SET[Staff_Password] = '" + textBoxNewPassword.Text + "' WHERE Staff_Ursename='" + username + "'", con);
        //con.Open();
        //cmd.ExecuteNonQuery();
        //con.Close();
        // MessageBox.Show("reset successfully");
        //}
        // else
        // {
        //MessageBox.Show("new password does not match");
        //}
    }
        private void textBoxNewPassword_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
          
        }
    }
}