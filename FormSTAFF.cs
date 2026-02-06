using System;
using System.Windows.Forms;

namespace Major_project_M2
{
    public partial class FormSTAFF : Form
    {
        public FormSTAFF()
        {
            InitializeComponent();
        }

        public void SetButtonVisibility(bool addVisible, bool updateVisible)
        {
            AddEmployeebutton.Visible = addVisible; // Show or hide the Add button
            UpdateEmployeebutton.Visible = updateVisible; // Show or hide the Update button
        }

        private void FormSTAFF_Load(object sender, EventArgs e)
        {
            // Load data into the 'dSStaff.Staff' table
            this.staffTableAdapter.Fill(this.dSStaff.Staff);
        }
        private void SearchStafftextBox_TextChanged(object sender, EventArgs e)
        {
            staffTableAdapter.FillByLname(dSStaff.Staff, SearchStafftextBox.Text);
        }

        private void EmployeedataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // Check if there is a selected row
            if (EmployeedataGridView.CurrentRow != null && EmployeedataGridView.SelectedRows.Count > 0)
            {
                // Ensure that the entire row is selected
                if (EmployeedataGridView.SelectedRows[0].Index == EmployeedataGridView.CurrentRow.Index)
                {
                    // Populate TextBoxes with the values from the selected row
                    StaffRoletextBox.Text = EmployeedataGridView.CurrentRow.Cells[1].Value?.ToString();
                    StaffFirstNametextBox.Text = EmployeedataGridView.CurrentRow.Cells[2].Value?.ToString();
                    StaffLastNametextBox.Text = EmployeedataGridView.CurrentRow.Cells[3].Value?.ToString();
                    StaffUsernametextBox.Text = EmployeedataGridView.CurrentRow.Cells[4].Value?.ToString();
                    StaffPasswordtextBox.Text = EmployeedataGridView.CurrentRow.Cells[5].Value?.ToString();
                    StaffAgetextBox.Text = EmployeedataGridView.CurrentRow.Cells[6].Value?.ToString();
                    maskedTextBox1.Text = EmployeedataGridView.CurrentRow.Cells[7].Value?.ToString();
                    StaffAddresstextBox.Text = EmployeedataGridView.CurrentRow.Cells[8].Value?.ToString();
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
            StaffRoletextBox.Text = "";
            StaffFirstNametextBox.Text = "";
            StaffLastNametextBox.Text = "";
            StaffUsernametextBox.Text = "";
            StaffPasswordtextBox.Text = "";
            StaffAgetextBox.Text = "";
            maskedTextBox1.Text = "";
            StaffAddresstextBox.Text = "";
        }

        private void UpdateEmployeebutton_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (EmployeedataGridView.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a staff member to update.");
                    return;
                }

                // Prompt for confirmation before updating staff details
                DialogResult confirmResult = MessageBox.Show("Do you want to update the staff member details?", "Confirm Update", MessageBoxButtons.YesNo);
                if (confirmResult != DialogResult.Yes)
                {
                    MessageBox.Show("Update cancelled.");
                    return; // Exit the method without performing the update
                }

                // Retrieve the existing values from the DataGridView for fields that were not updated
                string currentRole = (string)EmployeedataGridView.CurrentRow.Cells[1].Value;
                string currentFirstName = (string)EmployeedataGridView.CurrentRow.Cells[2].Value;
                string currentLastName = (string)EmployeedataGridView.CurrentRow.Cells[3].Value;
                string currentUsername = (string)EmployeedataGridView.CurrentRow.Cells[4].Value;
                string currentPassword = (string)EmployeedataGridView.CurrentRow.Cells[5].Value;
                string currentAge = (string)EmployeedataGridView.CurrentRow.Cells[6].Value;
                string currentPhoneNumber = (string)EmployeedataGridView.CurrentRow.Cells[7].Value;
                string currentAddress = (string)EmployeedataGridView.CurrentRow.Cells[8].Value;

                // Update only the fields that were modified
                string newRole = string.IsNullOrEmpty(StaffRoletextBox.Text) ? currentRole : StaffRoletextBox.Text;
                string newFirstName = string.IsNullOrEmpty(StaffFirstNametextBox.Text) ? currentFirstName : StaffFirstNametextBox.Text;
                string newLastName = string.IsNullOrEmpty(StaffLastNametextBox.Text) ? currentLastName : StaffLastNametextBox.Text;
                string newUsername = string.IsNullOrEmpty(StaffUsernametextBox.Text) ? currentUsername : StaffUsernametextBox.Text;
                string newPassword = string.IsNullOrEmpty(StaffPasswordtextBox.Text) ? currentPassword : StaffPasswordtextBox.Text;
                string newAge = string.IsNullOrEmpty(StaffAgetextBox.Text) ? currentAge : StaffAgetextBox.Text;
                string newPhoneNumber = string.IsNullOrEmpty(maskedTextBox1.Text) ? currentPhoneNumber : maskedTextBox1.Text;
                string newAddress = string.IsNullOrEmpty(StaffAddresstextBox.Text) ? currentAddress : StaffAddresstextBox.Text;

                // Check if any of the textboxes are empty and show a message
                if (string.IsNullOrEmpty(newFirstName) && string.IsNullOrEmpty(newLastName) &&
                    string.IsNullOrEmpty(newUsername) && string.IsNullOrEmpty(newPassword) &&
                    string.IsNullOrEmpty(newAge) && string.IsNullOrEmpty(newPhoneNumber) &&
                    string.IsNullOrEmpty(newAddress))
                {
                    MessageBox.Show("No changes made. Please update at least one field.");
                    return;
                }

                // Get the staff member's ID from the DataGridView
                int staffMemberID = (int)EmployeedataGridView.CurrentRow.Cells[0].Value;

                // Update the staff member's information in the database
                staffTableAdapter.UpdateStaff(newRole, newFirstName, newLastName, newUsername,
                                              newPassword, newAge, newPhoneNumber,
                                              newAddress, staffMemberID);

                // Refresh the DataGridView after updating staff information
                staffTableAdapter.Fill(dSStaff.Staff);

                MessageBox.Show("Staff member information has been updated successfully.");

                // Clear the textboxes after updating staff information
                ClearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating staff information: " + ex.Message);
            }
        }

        private void AddEmployeebutton_Click(object sender, EventArgs e)
        {
            // Logic for adding new employee (similar to previous code)
            DialogResult result = MessageBox.Show("Do you want to confirm?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                int age;
                string staffRole = StaffRoletextBox.Text;
                string staffFirstName = StaffFirstNametextBox.Text;
                string staffLastName = StaffLastNametextBox.Text;
                string staffUsername = StaffUsernametextBox.Text;
                string staffPassword = StaffPasswordtextBox.Text;
                string staffAge = StaffAgetextBox.Text;
                string staffPhoneNumber = maskedTextBox1.Text;
                string staffAddress = StaffAddresstextBox.Text;
                if (string.IsNullOrWhiteSpace(staffRole) || string.IsNullOrWhiteSpace(staffFirstName) ||
        string.IsNullOrWhiteSpace(staffLastName) || string.IsNullOrWhiteSpace(staffUsername) ||
        string.IsNullOrWhiteSpace(staffPassword) || string.IsNullOrWhiteSpace(staffAge) ||
        string.IsNullOrWhiteSpace(staffPhoneNumber) || string.IsNullOrWhiteSpace(staffAddress))
                {
                    MessageBox.Show("All fields must be filled out.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit if validation fails
                }

                // Validate age
                if (!int.TryParse(staffAge, out age) || age <= 0)
                {
                    MessageBox.Show("Please enter a valid age.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit if age is invalid
                }

                try
                {
                    staffTableAdapter.InsertStaff(staffRole, staffFirstName, staffLastName, staffUsername,
                                               staffPassword, staffAge, staffPhoneNumber, staffAddress);
                    MessageBox.Show("New Employee Added");

                    // Clear textboxes after adding a new employee
                    ClearTextBoxes();

                    staffTableAdapter.Fill(dSStaff.Staff); // Refresh the data in the DataGridView
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"An error occurred while adding the employee: {ex.Message}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                    
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("New Employee NOT Added");
            }
            else
            {
                MessageBox.Show("Cancelled");
            }
        }

        private void UpdateEmployeebutton_Click(object sender, EventArgs e)
        {

        }
    }
}
