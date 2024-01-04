using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Cafe_Management_System_2021_CE_1.UI_Forms.Employee
{
    public partial class AccountDetailsForm : Form
    {
        public AccountDetailsForm()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            EmployeesHomePage employeesHomePage = new EmployeesHomePage();
            this.Hide();
            employeesHomePage.Show();
        }
        private void logoutButton_Click(object sender, EventArgs e)
        {
            InitialForm initialForm = new InitialForm();
            this.Hide();
            initialForm.Show();
        }

        private void ordersButton_Click(object sender, EventArgs e)
        {
            EmployeeOrdersForm employeeOrdersForm = new EmployeeOrdersForm();
            this.Hide();
            employeeOrdersForm.Show();
        }

        private void promotionsButton_Click(object sender, EventArgs e)
        {
            EmployeePromotionsForm employeePromotionsForm = new EmployeePromotionsForm();
            this.Hide();
            employeePromotionsForm.Show();
        }

        private void customerButton_Click(object sender, EventArgs e)
        {
            EmployeeCustomersForm employeeCustomersForm = new EmployeeCustomersForm();
            this.Hide();
            employeeCustomersForm.Show();
        }

        private void feedbackButton_Click(object sender, EventArgs e)
        {
            EmployeeFeedbacksForm employeeFeedbacksForm = new EmployeeFeedbacksForm();
            this.Hide();
            employeeFeedbacksForm.Show();
        }

        private void AccountDetailsForm_Load(object sender, EventArgs e)
        {
            LoadEmployeeData();
        }
        private void LoadEmployeeData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-5UN9QJT\\SQLEXPRESS;Initial Catalog=cafe_Management_system;Integrated Security=True"))
                {
                    var empId = SessionState.EmployeeId;
                    string query = "SELECT [EmployeeID],[Username],[Password],[IsManager],[FirstName],[LastName],[Email],[PhoneNumber],[Address],[JoinDate],[Salary],[HourlyRate],[ShiftStartTime],[ShiftEndTime] FROM [cafe_Management_system].[dbo].[Employees] where EmployeeID = @empId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@empId", empId);
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {

                            usernameTextBox.Text = reader["Username"].ToString();
                            passwordTextBox.Text = reader["Password"].ToString();
                            firstNameTextBox.Text = reader["FirstName"].ToString();
                            lastNameTextBox.Text = reader["LastName"].ToString();
                            emailTextBox.Text = reader["Email"].ToString();
                            contactTextBox.Text = reader["PhoneNumber"].ToString();
                            addressTextBox.Text = reader["Address"].ToString();
                            joinDateTextbox.Text = reader["JoinDate"].ToString();
                            salaryTextBox.Text = reader["Salary"].ToString();
                            hourlyTextBox.Text = reader["HourlyRate"].ToString();
                            shiftStartTextBox.Text = reader["ShiftStartTime"].ToString();
                            shiftEndTextBox.Text = reader["ShiftEndTime"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("No data found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}
