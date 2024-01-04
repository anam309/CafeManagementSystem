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
    public partial class CustomerPromotionsForm : Form
    {
        public CustomerPromotionsForm()
        {
            InitializeComponent();
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

        private void orderSummary_Click(object sender, EventArgs e)
        {
            CustomerOrderSummary customerOrderSummary = new CustomerOrderSummary();
            this.Hide();
            customerOrderSummary.Show();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CustomerPromotionsForm_Load(object sender, EventArgs e)
        {
            SqlConnection connection = SessionState.GetConnection();

            using (connection)
            {
                SqlCommand command = new SqlCommand();
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT [PromotionID], [Name], [Description], [StartDate], [EndDate], [Discount], [ProductCategory] FROM Promotions";
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.Close();
            }
              
        }
    }
}
