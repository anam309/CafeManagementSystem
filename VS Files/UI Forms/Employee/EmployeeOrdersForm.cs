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

namespace Cafe_Management_System_2021_CE_1.UI_Forms.Employee
{
    public partial class EmployeeOrdersForm : Form
    {
        public EmployeeOrdersForm()
        {
            InitializeComponent();
        }

        private void checkInOutButton_Click(object sender, EventArgs e)
        {
            EmployeesHomePage employeesHomePage = new EmployeesHomePage();
            this.Hide();
            employeesHomePage.Show();
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

        private void logoutButton_Click(object sender, EventArgs e)
        {
            InitialForm initialForm = new InitialForm();
            this.Hide();
            initialForm.Show();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
        }

        private void EmployeeOrdersForm_Load(object sender, EventArgs e)
        {
            SqlConnection connection = SessionState.GetConnection();
            SqlCommand command = new SqlCommand();
            connection.Open();
            var empId = SessionState.EmployeeId;
            command.Connection = connection;
            command.Parameters.AddWithValue("@empId", empId);
            command.CommandText = "SELECT [OrderID], [CustomerID], [OrderDate] FROM Orders Where [EmployeeID] = @empId";
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }
    }
}
