using Cafe_Management_System_2021_CE_1.UI_Forms.Manager;
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
    public partial class AddProductsForm : Form
    {
        public int CategoryId;
        public int SupplierId;
        public AddProductsForm()
        {
            InitializeComponent();
        }
        private void logoutButton_Click(object sender, EventArgs e)
        {
            InitialForm initialForm = new InitialForm();
            this.Hide();
            initialForm.Show();
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

        private void employeeButton_Click(object sender, EventArgs e)
        {
            ManagerEmployeesForm managerEmployeesForm = new ManagerEmployeesForm();
            this.Hide();
            managerEmployeesForm.Show();
        }

        private void supplierButton_Click(object sender, EventArgs e)
        {
            ManagerSuppliersForm managerSuppliersForm = new ManagerSuppliersForm();
            this.Hide();
            managerSuppliersForm.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ManagerHomePage managerHomePage = new ManagerHomePage();
            this.Hide();
            managerHomePage.Show();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Clear();
                }
            }
        }
        private void LoadCategories()
        {
            SqlConnection connection = SessionState.GetConnection();
            connection.Open();
            try
            {
                string query = "SELECT CategoryId, CategoryName FROM ProductCategories";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Bind DataTable to ComboBox
                    categoriesComboBox.DataSource = dt;
                    categoriesComboBox.DisplayMember = "CategoryName"; // Display member
                    categoriesComboBox.ValueMember = "CategoryId"; // Value member
                }

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
        private void LoadSuppliers()
        {
            SqlConnection connection = SessionState.GetConnection();
            connection.Open();
            try
            {
                string query = "SELECT SupplierId, Name FROM Suppliers";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Bind DataTable to ComboBox
                    suppliersComboBox.DataSource = dt;
                    suppliersComboBox.DisplayMember = "Name"; // Display member
                    suppliersComboBox.ValueMember = "SupplierId"; // Value member
                }

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
        private void addEditButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = SessionState.GetConnection();

                using (SqlCommand command = new SqlCommand("AddNewProducts", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Set parameters from textboxes
                    command.Parameters.AddWithValue("@Name", nameTextBox.Text);
                    command.Parameters.AddWithValue("@Description", descriptionTextBox.Text);
                    command.Parameters.AddWithValue("@Quantity", quantityUpDown.Value);
                    command.Parameters.AddWithValue("@Price", priceTextBox.Text);
                    command.Parameters.AddWithValue("@CategoryId", CategoryId);
                    command.Parameters.AddWithValue("@SupplierId", SupplierId);

                    connection.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("Product added successfully.");
                    clearButton_Click(sender, e);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding Product: " + ex.Message);
            }
        }

        private void AddProductsForm_Load(object sender, EventArgs e)
        {

            LoadCategories();
            LoadSuppliers();
        }

        private void categoriesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoriesComboBox.SelectedItem != null)
            {
                DataRowView drv = categoriesComboBox.SelectedItem as DataRowView;
                if (drv != null)
                {
                    int categoryId;
                    if (int.TryParse(drv["CategoryId"].ToString(), out categoryId))
                    {
                        CategoryId = categoryId;
                    }
                    else
                    {
                        // Handle the case where the conversion fails
                        MessageBox.Show("Invalid category ID");
                    }
                }
            }
        }

        private void suppliersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (suppliersComboBox.SelectedItem != null)
            {
                DataRowView drv = suppliersComboBox.SelectedItem as DataRowView;
                if (drv != null)
                {
                    int supplierId;
                    if (int.TryParse(drv["SupplierId"].ToString(), out supplierId))
                    {
                        SupplierId = supplierId;
                    }
                    else
                    {
                        // Handle the case where the conversion fails
                        MessageBox.Show("Invalid supplier ID");
                    }
                }
            }
        }
    }
}
