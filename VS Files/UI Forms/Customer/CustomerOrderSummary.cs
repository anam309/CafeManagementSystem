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

namespace Cafe_Management_System_2021_CE_1.UI_Forms
{
    public partial class CustomerOrderSummary : Form
    {
        
        public CustomerOrderSummary()
        {
            InitializeComponent();
        }
        private void CustomerOrderSummary_Load(object sender, EventArgs e)
        {
            SqlConnection connection = SessionState.GetConnection();
            using (connection)
            {
                try
                {
                    int customerId = SessionState.CustomerId;

                    // Initialize DataGridViewButtonColumn
                    DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
                    deleteButtonColumn.HeaderText = "Delete";
                    deleteButtonColumn.Text = "Delete";
                    deleteButtonColumn.UseColumnTextForButtonValue = true;
                    dataGridView1.Columns.Add(deleteButtonColumn);

                    // Prepare and execute the SQL command
                    SqlCommand command = new SqlCommand();
                    command.Parameters.AddWithValue("@customerId", customerId);
                    command.Connection = connection;
                    command.CommandText = "SELECT OD.OrderID, P.Name, OD.Quantity, OD.Subtotal, C.FirstName as Customer, E.FirstName as Employee, O.OrderDate FROM OrderDetails OD INNER JOIN Orders O ON OD.OrderID = O.OrderID INNER JOIN Products P ON OD.ProductID = P.ProductID INNER JOIN Customers C ON O.CustomerID = C.CustomerID INNER JOIN Employees E ON O.EmployeeID = E.EmployeeID WHERE C.CustomerID = @customerId";

                    connection.Open();
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }

            // Hook up events for button clicks
            dataGridView1.CellContentClick += DataGridView1_CellContentClick;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection connection = SessionState.GetConnection();
            // Check if the clicked cell is a button and in a valid row
            if (e.RowIndex >= 0 && (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn))
            {
                int orderId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["OrderID"].Value);

                if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Delete")
                {
                    // Perform delete action for the selected orderId
                    // Example: Prompt confirmation and delete the selected record
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        string deleteQuery = "DELETE FROM OrderDetails WHERE OrderID = @OrderID";

                        using (connection)
                        {
                            SqlCommand command = new SqlCommand(deleteQuery, connection);
                            command.Parameters.AddWithValue("@OrderID", orderId);

                            try
                            {
                                connection.Open();
                                int rowsAffected = command.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Record deleted successfully!");
                                    InitializeComponent();
                                }
                                else
                                {
                                    MessageBox.Show("Record deletion failed.");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error: " + ex.Message);
                            }
                        }
                    }
                }
            }
           
        }
        private void promotionsButton_Click(object sender, EventArgs e)
        {
            CustomerPromotionsForm customerPromotionsForm = new CustomerPromotionsForm();
            this.Hide();
            customerPromotionsForm.Show();
        }

        private void feedbackButton_Click(object sender, EventArgs e)
        {
            CustomerFeedbackForm customerFeedbackForm = new CustomerFeedbackForm();
            this.Hide();
            customerFeedbackForm.Show();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            CustomerHomePage customerHomePage = new CustomerHomePage();
            this.Hide();
            customerHomePage.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            InitialForm initialForm = new InitialForm();
            this.Hide();
            initialForm.Show();
        }
    }
}
