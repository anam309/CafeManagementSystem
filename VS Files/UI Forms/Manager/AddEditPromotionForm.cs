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
    public partial class AddEditPromotionForm : Form
    {
        public int CategoryId;
        public AddEditPromotionForm()
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

        private void backButton_Click(object sender, EventArgs e)
        {
            ManagerPromotionsForm managerPromotionsForm = new ManagerPromotionsForm();
            this.Hide();
            managerPromotionsForm.Show();
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

        private void addEditButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = SessionState.GetConnection();

                using (SqlCommand command = new SqlCommand("AddNewPromotion", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Set parameters from textboxes
                    command.Parameters.AddWithValue("@Name", nameTextBox.Text);
                    command.Parameters.AddWithValue("@ProductCategory", CategoryId);
                    command.Parameters.AddWithValue("@Description", descriptionTextBox.Text);
                    command.Parameters.AddWithValue("@Discount", decimal.Parse(discountTextBox.Text));
                    command.Parameters.AddWithValue("@StartDate", DateTime.Parse(dateTimePicker1.Text).Date);
                    command.Parameters.AddWithValue("@EndDate", DateTime.Parse(dateTimePicker2.Text).Date);

                    connection.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("Promotion added successfully.");
                    clearButton_Click(sender,e);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding employee: " + ex.Message);
            }
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

        private void AddEditPromotionForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }
    }
}
