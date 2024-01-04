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
    public partial class AddEditSupplierForm : Form
    {
        public AddEditSupplierForm()
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
            ManagerSuppliersForm managerSuppliersForm = new ManagerSuppliersForm();
            this.Hide();
            managerSuppliersForm.Show();
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

                using (SqlCommand command = new SqlCommand("AddNewSupplier", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Set parameters from textboxes
                    command.Parameters.AddWithValue("@Name", nameTextBox.Text);
                    command.Parameters.AddWithValue("@ContactPerson", contactPersonTextBox.Text);
                    command.Parameters.AddWithValue("@Phone", contactTextBox.Text);
                    command.Parameters.AddWithValue("@Email", emailTextBox.Text);
                    command.Parameters.AddWithValue("@Address", addressTextBox.Text);

                    connection.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("Supplier added successfully.");
                    clearButton_Click(sender, e);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding supplier: " + ex.Message);
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

    }
}
