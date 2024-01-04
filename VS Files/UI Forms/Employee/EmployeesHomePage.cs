using Cafe_Management_System_2021_CE_1.UI_Forms.Employee;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Cafe_Management_System_2021_CE_1.UI_Forms
{
    public partial class EmployeesHomePage : Form
    {
        public string Username;
        public EmployeesHomePage()
        {
            InitializeComponent();
        }
        public EmployeesHomePage(string username)
        {
            Username = username;
            InitializeComponent();
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

        private void accountInfoButton_Click(object sender, EventArgs e)
        {
            AccountDetailsForm accountDetailsForm = new AccountDetailsForm();
            this.Hide();
            accountDetailsForm.Show();
        }

        private void checkInButton_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            SqlConnection connection = SessionState.GetConnection();
            connection.Open();
            var empId = SessionState.EmployeeId;
            var checkIn = DateTime.Now.TimeOfDay;
            var dateCheckIn = DateTime.Now.Date;
            command.Connection = connection;
            command.Parameters.AddWithValue("@empId", empId);
            command.Parameters.AddWithValue("@dateCheckIn", dateCheckIn);
            command.Parameters.AddWithValue("@checkIn", checkIn);
            command.CommandText = "INSERT INTO EmployeeCheckInOuts ([EmployeeID], [CheckInTime], [DateCheckInOut]) VALUES (@empId, @checkIn, @dateCheckIn)";
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Checked In Successfully");
        }

        private void checkOutButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = SessionState.GetConnection();
            SqlCommand command = new SqlCommand();

            var empId = SessionState.EmployeeId;
            var checkOut = DateTime.Now.TimeOfDay;
            var dateCheckOut = DateTime.Now.Date;

            command.Connection = connection;
            command.Parameters.AddWithValue("@empId", empId);
            command.Parameters.AddWithValue("@dateCheckOut", dateCheckOut);
            command.Parameters.AddWithValue("@checkOut", checkOut);

            // Check if the employee has checked in before
            string checkExistingCheckInQuery = "SELECT TOP(1) [CheckInOutId], [CheckOutTime] FROM EmployeeCheckInOuts WHERE [EmployeeID] = @empId AND [DateCheckInOut] = @dateCheckOut ORDER BY [CheckInTime] DESC";

            connection.Open();
            command.CommandText = checkExistingCheckInQuery;
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                var existingCheckInId = reader["CheckInOutId"];
                var existingCheckOutTime = reader["CheckOutTime"];

                connection.Close();

                if (existingCheckOutTime != DBNull.Value && existingCheckOutTime != null)
                {
                    MessageBox.Show("You have already checked out.");
                }
                else
                {
                    // Update the existing check-in record with the check-out time
                    string updateCheckOutQuery = "UPDATE EmployeeCheckInOuts SET [CheckOutTime] = @checkOut WHERE [CheckInOutId] = @existingCheckInId";
                    command.CommandText = updateCheckOutQuery;
                    command.Parameters.AddWithValue("@existingCheckInId", existingCheckInId);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Checked Out Successfully");
                }
            }
            else
            {
                connection.Close();
                MessageBox.Show("Error: Please check in first before checking out.");
            }
        }

        private void EmployeesHomePage_Load(object sender, EventArgs e)
        {
            employeeName.Text = SessionState.Username + " Logged in";
            currentDateLabel.Text = DateTime.Now.Date.ToShortDateString();
        }
    }
}
