using Cafe_Management_System_2021_CE_1.UI_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management_System_2021_CE_1
{
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = SessionState.GetConnection();
            SqlCommand command = new SqlCommand();

            // Get data from textboxes
            string firstName = firstnameTextBox.Text.Trim();
            string lastName = lastNameTextBox.Text.Trim();
            string username = usernameTextBox.Text.Trim().ToLower(); // Convert to lowercase
            string password = passwordTextBox.Text.Trim();
            string email = emailTextBox.Text.Trim();
            string phoneNumber = phoneTextBox.Text.Trim();
            string address = addressTextBox.Text.Trim();

            try
            {
                // Check for empty fields
                if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) ||
                    string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) ||
                    string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phoneNumber) ||
                    string.IsNullOrEmpty(address))
                {
                    MessageBox.Show("Please fill in all the fields.");
                    return;
                }
                connection.Open();
                command.Connection = connection;
                // Check if the username already exists in Customers or Employees table

                string checkUsernameQueryCustomers = "SELECT COUNT(*) FROM Customers WHERE username = @Username";
                string checkUsernameQueryEmployees = "SELECT COUNT(*) FROM Employees WHERE username = @Username";

                using (SqlCommand commandCustomers = new SqlCommand(checkUsernameQueryCustomers, connection))
                using (SqlCommand commandEmployees = new SqlCommand(checkUsernameQueryEmployees, connection))
                {
                    commandCustomers.Parameters.AddWithValue("@Username", username);
                    commandEmployees.Parameters.AddWithValue("@Username", username);

                    int countCustomers = (int)commandCustomers.ExecuteScalar();
                    int countEmployees = (int)commandEmployees.ExecuteScalar();

                    if (countCustomers > 0 || countEmployees > 0)
                    {
                        MessageBox.Show("Username already exists. Please choose another username.");
                        return;
                    }
                }
                var joinDate = DateTime.Now;
                // If the username is unique, insert the record into Customers table
                string insertQuery = "INSERT INTO Customers (FirstName, LastName, Username, Password, Email, PhoneNumber, Address, JoinDate) " +
                    "VALUES (@FirstName, @LastName, @Username, @Password, @Email, @PhoneNumber, @Address, @joinDate)";

                using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@FirstName", firstName);
                    insertCommand.Parameters.AddWithValue("@LastName", lastName);
                    insertCommand.Parameters.AddWithValue("@Username", username);
                    insertCommand.Parameters.AddWithValue("@Password", password);
                    insertCommand.Parameters.AddWithValue("@Email", email);
                    insertCommand.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    insertCommand.Parameters.AddWithValue("@Address", address);
                    insertCommand.Parameters.AddWithValue("@JoinDate", joinDate);

                    try
                    {
                        SqlDataAdapter da = new SqlDataAdapter(insertCommand);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        int rowsAffected = insertCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Signup successful! You can now log in.");
                            InitialForm initialForm = new InitialForm();
                            this.Hide();
                            initialForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Signup failed. Please try again.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();

            }
        }
    }
}
