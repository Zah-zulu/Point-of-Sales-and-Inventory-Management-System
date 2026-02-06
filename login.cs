using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Major_project_M2
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            
        }

        // Event handler for when the Password textbox is clicked
        private void PasswordtextBox_Click(object sender, EventArgs e)
        {
           
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            string username = UsernametextBox.Text;
            string password = PasswordtextBox.Text;

            // Validate the login credentials
            if (ValidateLogin(username, password))
            {
                if (username == "mdlulia02@gmail.com" && password == "Benthomas@04") // Example user check
                {
                    this.Hide();
                    Manager frm1 = new Manager(username);
                    frm1.Show();
                }
                else
                {
                    this.Hide();
                    Cashier mainForm = new Cashier(username);
                    mainForm.Show();
                }
            }
            else
            {
                // Inform the user about the incorrect credentials and offer the "Forgot Password" option
                MessageBox.Show("The username or password you entered is incorrect.\n\n" +
                                "If you have forgotten your password, please select the 'Forgot Password' option to initiate a recovery process.",
                                "Login Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private bool ValidateLogin(string username, string password)
        {
            bool isValid = false;
            string connectionString = "Data Source=School Databse ;Initial Catalog=Username;Persist Security Info=True;User ID=User ID;Password=DB Password";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Staff WHERE Staff_Username = @Username AND Staff_Password = @Password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    isValid = true;
                }
                conn.Close();
            }

            return isValid;
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Operation cancelled. You are being returned to the home page.",
                            "Cancellation Confirmation",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            Form1 frmHomePage = new Form1();
            frmHomePage.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ForgotPass frmForgotPassword = new ForgotPass();
            frmForgotPassword.Show();
        }
    }
}

/*string connectionString = "Data Source=DB;Initial Catalog=User ID;Persist Security Info=True;User ID=User ID;Password=***********";
string query = "SELECT Staff_Role FROM Staff WHERE Staff_Username=@Username AND Staff_Password=@Password";

       using (SqlConnection connection = new SqlConnection(connectionString))
       {
           SqlCommand command = new SqlCommand(query, connection);
           command.Parameters.AddWithValue("@Username", UsernametextBox.Text );
           command.Parameters.AddWithValue("@Password", PasswordtextBox.Text);

           connection.Open();
           SqlDataReader reader = command.ExecuteReader();

           if (reader.HasRows)
           {
               reader.Read();
               string role = reader["Staff_Role"].ToString();
               reader.Close();

               // Load different forms based on role
               if (role == "Cashier")
               {
                    MessageBox.Show("Welcome cashier! You will now be redirected to the POS screen","Valid Login");
                    Cashier frmCashier = new Cashier();
                    frmCashier.Show();
               }
               else if (role == "Manager")
               {
                   MessageBox.Show("Welcome manager! You will now be redirected to the Manager screen","Valid Login");
                   Manager frmManager = new Manager();
                   frmManager.Show();
               }

               this.Hide();
           }
           else
           {
               MessageBox.Show("Invalid username or password");
           }
       }
   }

   /*staffTableAdapter1.FillByLogin(dsStaffLogin1.Staff, UsernametextBox.Text, PasswordtextBox.Text);
   if(dsStaffLogin1.Staff.Rows.Count>0)
   {
       MessageBox.Show("Welcome cashier! You will now be redirected to the POS screen","Valid Login");
       Cashier frmCashier = new Cashier();
       frmCashier.Show();
       this.Close();
   } 
   else if(UsernametextBox.Text == "manager" && PasswordtextBox.Text == "manage")
   {
       MessageBox.Show("Welcome manager! You will now be redirected to the Manager screen","Valid Login");
       Manager frmManager = new Manager();
       frmManager.Show();
       this.Close();
   }
   else 
   {
       MessageBox.Show("Incorrect username or password", "Invalid Login");
   }    
   /*if (UsernametextBox.Text == "cashier" && PasswordtextBox.Text == "newsale")
   {
       MessageBox.Show("Welcome cashier! You will now be redirected to the cashier form.");
       Cashier frmCashier = new Cashier(); // Assuming you have a FormCashier for the cashier role
       frmCashier.Show();
       this.Close();
   }
   else if (UsernametextBox.Text == "manager" && PasswordtextBox.Text == "manage")
   {
       MessageBox.Show("Welcome manager! You will now be redirected to the manager form.");
       Manager frmManager = new Manager(); // Assuming you have a FormManager for the manager role
       frmManager.Show();
       this.Close();
   }
   else
   {
       MessageBox.Show("Invalid username or password", "Invalid Login");
   }*/


/*private void Cancelbutton_Click(object sender, EventArgs e)
{
    MessageBox.Show("Cancelled. Returning to the home page.");
    // Here you can navigate back to the home page or wherever you want to redirect the user
    // For example, if "FormHomePage" is your home page form:
    Form1 frmHomePage = new Form1();
    frmHomePage.Show();
    this.Close();
}*/



