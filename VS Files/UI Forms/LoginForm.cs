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
    public partial class LoginForm : Form
    {
        public string Parameter;
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-5UN9QJT\SQLEXPRESS;Initial Catalog=cafe_Management_system;Integrated Security=True");

        public LoginForm()
        {
            InitializeComponent();
        }

        public LoginForm(string parameter)
        {
            Parameter = parameter;
            InitializeComponent();

            if (Parameter == "customer")
            {
                this.registerLabel.Visible = true;
            }
        }

        private void lognButton_Click(object sender, EventArgs e)
        {

            string username = usernameTextBox.Text.ToLower().Trim();
            string password = passwordTextBox.Text.Trim();
            SessionState.Username = username;
            try
            {
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please enter both username and password.");
                    return;
                }
                using (connection)
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        if (connection.State != ConnectionState.Open)
                        {
                            connection.Open();
                        }

                        string query = "";
                        if (Parameter == "employee")
                        {
                            query = "SELECT COUNT(*) FROM Employees WHERE LOWER(username) = @Username AND password = @Password";
                        }
                        else if (Parameter == "customer")
                        {
                            query = "SELECT COUNT(*) FROM Customers WHERE username = @Username AND password = @Password";
                        }

                        command.CommandText = query;
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        int count = (int)command.ExecuteScalar();

                        if (count > 0)
                        {
                            // Perform additional actions if login is successful
                            if (Parameter == "customer")
                            {
                                string customerIdQuery = "SELECT CustomerId FROM Customers WHERE Username = @Username";
                                using (SqlCommand customerIdCommand = new SqlCommand(customerIdQuery, connection))
                                {
                                    customerIdCommand.Parameters.AddWithValue("@Username", username);

                                    object result = customerIdCommand.ExecuteScalar();
                                    if (result != null && result != DBNull.Value)
                                    {
                                        int customerId = Convert.ToInt32(result);
                                        SessionState.CustomerId = customerId;

                                        CustomerHomePage customerHomePage = new CustomerHomePage(username);
                                        this.Hide();
                                        customerHomePage.Show();
                                    }
                                }
                            }
                            else if (Parameter == "employee")
                            {
                                string employeeIdQuery = "SELECT EmployeeId, IsManager FROM Employees WHERE Username = @Username";
                                using (SqlCommand employeedIdCommand = new SqlCommand(employeeIdQuery, connection))
                                {
                                    employeedIdCommand.Parameters.AddWithValue("@Username", username);

                                    object result = employeedIdCommand.ExecuteScalar();
                                    if (result != null && result != DBNull.Value)
                                    {
                                        SqlDataReader reader = employeedIdCommand.ExecuteReader();
                                        if (reader.Read())
                                        {
                                            int employeeId = Convert.ToInt32(reader["EmployeeId"]);
                                            bool isManager = Convert.ToBoolean(reader["IsManager"]);

                                            SessionState.EmployeeId = employeeId;

                                            if (isManager)
                                            {
                                                // Open manager page
                                                ManagerHomePage managerHomePage = new ManagerHomePage(username);
                                                this.Hide();
                                                managerHomePage.Show();
                                            }
                                            else
                                            {
                                                // Open employee page
                                                EmployeesHomePage employeesHomePage = new EmployeesHomePage(username);
                                                this.Hide();
                                                employeesHomePage.Show();
                                            }
                                        }
                                    }
                                }
                            }

                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.");
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Login failed. Error: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }



        private void registerLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignupForm signupForm = new SignupForm();
            signupForm.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            InitialForm initialForm = new InitialForm();
            this.Hide();
            initialForm.Show();
        }
    }
}
