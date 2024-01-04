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

namespace Cafe_Management_System_2021_CE_1.UI_Forms.Manager
{
    public partial class ManagerEmployeesForm : Form
    {
        public ManagerEmployeesForm()
        {
            InitializeComponent();
        }
        private void productsButton_Click(object sender, EventArgs e)
        {
            ManagerHomePage managerHomePage = new ManagerHomePage();
            this.Hide();
            managerHomePage.Show();
        }

        private void orderSummary_Click(object sender, EventArgs e)
        {
            ManagerPendingOrdersForm managerPendingOrdersForm = new ManagerPendingOrdersForm();
            this.Hide();
            managerPendingOrdersForm.Show();
        }

        private void promotionsButton_Click(object sender, EventArgs e)
        {
            ManagerPromotionsForm managerPromotionsForm = new ManagerPromotionsForm();
            this.Hide();
            managerPromotionsForm.Show();
        }

        private void feedbackButton_Click(object sender, EventArgs e)
        {
            ManagerFeedbacksForm managerFeedbacksForm = new ManagerFeedbacksForm();
            this.Hide();
            managerFeedbacksForm.Show();

        }

        private void customersButton_Click(object sender, EventArgs e)
        {
            ManagerCustomerForm managerCustomerForm = new ManagerCustomerForm();
            this.Hide();
            managerCustomerForm.Show();
        }

        private void supplierButton_Click(object sender, EventArgs e)
        {
            ManagerSuppliersForm managerSuppliersForm = new ManagerSuppliersForm();
            this.Hide();
            managerSuppliersForm.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            InitialForm initialForm = new InitialForm();
            this.Hide();
            initialForm.Show();
        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            AddEditEmployeeForm addEmployeeForm = new AddEditEmployeeForm();
            this.Hide();
            addEmployeeForm.Show();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
        }

        private void ManagerEmployeesForm_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
            dataGridView1.CellEndEdit += DataGridView1_CellEndEdit;
        }

        private void LoadDataIntoDataGridView()
        {
            SqlConnection connection = SessionState.GetConnection();
            SqlCommand command = new SqlCommand();
            connection.Open();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM [cafe_Management_system].[dbo].[EmployeeInformation]";
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Get the updated data from the DataGridView
            DataGridViewRow updatedRow = dataGridView1.Rows[e.RowIndex];

            int employeeID = Convert.ToInt32(updatedRow.Cells["EmployeeID"].Value);
            string firstName = updatedRow.Cells["FirstName"].Value.ToString();
            string lastName = updatedRow.Cells["LastName"].Value.ToString();
            string email = updatedRow.Cells["Email"].Value.ToString();
            string phoneNumber = updatedRow.Cells["PhoneNumber"].Value.ToString();
            string address = updatedRow.Cells["Address"].Value.ToString();
            DateTime joinDate = Convert.ToDateTime(updatedRow.Cells["JoinDate"].Value);
            decimal salary = Convert.ToDecimal(updatedRow.Cells["Salary"].Value);
            bool isManager = Convert.ToBoolean(updatedRow.Cells["IsManager"].Value);

            // Update the database with the changes
            using (SqlConnection connection = SessionState.GetConnection()) { 
                connection.Open();
                string updateQuery = "UPDATE [cafe_Management_system].[dbo].[EmployeeInformation] SET FirstName = @FirstName, LastName = @LastName, Email = @Email, PhoneNumber = @PhoneNumber, Address = @Address, JoinDate = @JoinDate, Salary = @Salary, IsManager = @IsManager WHERE EmployeeID = @EmployeeID";
                SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                updateCommand.Parameters.AddWithValue("@FirstName", firstName);
                updateCommand.Parameters.AddWithValue("@LastName", lastName);
                updateCommand.Parameters.AddWithValue("@Email", email);
                updateCommand.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                updateCommand.Parameters.AddWithValue("@Address", address);
                updateCommand.Parameters.AddWithValue("@JoinDate", joinDate);
                updateCommand.Parameters.AddWithValue("@Salary", salary);
                updateCommand.Parameters.AddWithValue("@IsManager", isManager);
                updateCommand.Parameters.AddWithValue("@EmployeeID", employeeID);
                updateCommand.ExecuteNonQuery();
                connection.Close();

            }
            dataGridView1.RefreshEdit();
        }

    }
}
