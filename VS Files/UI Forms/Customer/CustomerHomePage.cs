using Cafe_Management_System_2021_CE_1.UI_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Cafe_Management_System_2021_CE_1
{
    public partial class CustomerHomePage : Form
    {
        private int productId;
        public string Username;
        private decimal productPrice = 0;
        public CustomerHomePage()
        {
            InitializeComponent();
            quantityBox.ValueChanged += quantityBox_ValueChanged;
            LoadCategories();
            dataGridView1.Columns.Add("ProductID", "Product Id");
            dataGridView1.Columns.Add("Name", "Product Name");
            dataGridView1.Columns.Add("Description", "Description");
            dataGridView1.Columns.Add("Price", "Price");
            dataGridView1.Columns.Add("Quantity", "Quantity");

        }
        public CustomerHomePage(string username)
        {
            Username = username;
            InitializeComponent();
            quantityBox.ValueChanged += quantityBox_ValueChanged;
            LoadCategories();
            dataGridView1.Columns.Add("ProductID", "Product Id");
            dataGridView1.Columns.Add("Name", "Product Name");
            dataGridView1.Columns.Add("Description", "Description");
            dataGridView1.Columns.Add("Price", "Price");
            dataGridView1.Columns.Add("Quantity", "Quantity");
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

        private void orderSummary_Click(object sender, EventArgs e)
        {
            CustomerOrderSummary customerOrderSummary = new CustomerOrderSummary();
            this.Hide();
            customerOrderSummary.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            InitialForm initialForm = new InitialForm();
            this.Hide();
            initialForm.Show();
        }
        private void quantityBox_ValueChanged(object sender, EventArgs e)
        {
            CalculateSubtotal();
        }

        private Dictionary<string, decimal> cartItems = new Dictionary<string, decimal>();

        private void addToCartButton_Click(object sender, EventArgs e)
        {
            UpdateDataGridView();
            if (itemComboBox.SelectedIndex != -1 && !string.IsNullOrEmpty(priceTextBox.Text))
            {
                // Get selected item and price
                string selectedItem = itemComboBox.Text;
                decimal selectedPrice = decimal.Parse(priceTextBox.Text);

                // Check if the item already exists in the cart
                if (cartItems.ContainsKey(selectedItem))
                {
                    // Remove the previous entry for this item
                    cartItems.Remove(selectedItem);
                }

                // Add or update item and price in the cart dictionary
                cartItems[selectedItem] = selectedPrice;

                // Update the display in richTextBox1
                DisplayCartItems();
            }
        }

        private void DisplayCartItems()
        {
            // Clear the richTextBox
            richTextBox1.Clear();

            // Display items in the richTextBox
            foreach (var item in cartItems)
            {
                richTextBox1.AppendText($"{item.Key} - Price: {item.Value}\n");
            }

            // Calculate and display total price
            decimal totalPrice = CalculateTotalPrice();
            totalPriceTextBox.Text = totalPrice.ToString();
        }
        private int GetRandomEmployeeID()
        {
            int employeeID = 0;

            SqlConnection connection = SessionState.GetConnection();

            connection.Open();

            string query = @"SELECT TOP 1 EmployeeID FROM Employees WHERE IsManager = 0 ORDER BY NEWID()";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                object result = command.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    employeeID = Convert.ToInt32(result);
                }
            }


            return employeeID;
        }
        private void SaveOrderDetails(int orderId)
        {
            using (SqlConnection connection = SessionState.GetConnection())
            {
                try
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO [cafe_Management_system].[dbo].[OrderDetails] (OrderID, ProductID, Quantity, Subtotal) VALUES (@orderId, @productId, @quantity, @subtotal)";
                    SqlCommand insertCommand = new SqlCommand(insertQuery, connection);

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (!row.IsNewRow) // Skip the new row placeholder
                        {
                            int productId = (int)row.Cells["ProductID"].Value;
                            int quantity = (int)row.Cells["Quantity"].Value;
                            decimal productPrice  = GetProductPrice(productId);
                            decimal subtotal = quantity * productPrice;

                            insertCommand.Parameters.Clear();
                            insertCommand.Parameters.Add("@orderId", SqlDbType.Int).Value = orderId;
                            insertCommand.Parameters.Add("@ProductID", SqlDbType.Int).Value = productId;
                            insertCommand.Parameters.Add("@Quantity", SqlDbType.Int).Value = quantity; ;
                            insertCommand.Parameters.Add("@Subtotal", SqlDbType.Decimal).Value = subtotal;

                            insertCommand.ExecuteNonQuery();
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error saving order details: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            int customerID = SessionState.CustomerId; // Replace this with the actual customer ID
            int employeeID = GetRandomEmployeeID();
            DateTime orderDate = DateTime.Now;
            SqlConnection connection = SessionState.GetConnection();
            connection.Open();

            try
            {
                int orderId;
                string insertOrderQuery = "INSERT INTO [cafe_Management_system].[dbo].[Orders] (CustomerID, EmployeeID, OrderDate) VALUES (@customerID, @employeeID, @orderDate); SELECT SCOPE_IDENTITY();";
                using (SqlCommand insertOrderCommand = new SqlCommand(insertOrderQuery, connection))
                {
                    insertOrderCommand.Parameters.AddWithValue("@customerID", customerID);
                    insertOrderCommand.Parameters.AddWithValue("@employeeID", employeeID);
                    insertOrderCommand.Parameters.AddWithValue("@orderDate", orderDate);
                    insertOrderCommand.ExecuteNonQuery();
                }
                string orderIdquery = "SELECT TOP 1 [OrderID] FROM [cafe_Management_system].[dbo].[Orders] ORDER BY OrderID DESC";
                using (SqlCommand orderIdqueryCommand = new SqlCommand(orderIdquery, connection))
                {
                    orderId = (int)orderIdqueryCommand.ExecuteScalar();
                }
                SaveOrderDetails(orderId);
                // Show confirmation message and clear the cart
                MessageBox.Show("Order placed successfully!", "Cafe Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.Rows.Clear();
                totalPriceTextBox.Text = "0.00";
                priceTextBox.Text = string.Empty;
                quantityBox.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Cafe Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

        }
        private decimal GetProductPrice(int productId)
        {
            decimal price = 0;
            SqlConnection connection = SessionState.GetConnection();
            connection.Open();
            string query = "SELECT Price FROM Products WHERE ProductID = @productId";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ProductID", productId);

                try
                {
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        price = Convert.ToDecimal(result);
                        var discount = CheckDiscount(productId);
                        if (discount > 0)
                        {
                            price -= (discount / 100) * price;
                        }
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

            return price;
        }
        private decimal CalculateTotalPrice()
        {
            decimal totalPrice = 0;
            string[] lines = richTextBox1.Lines;
            foreach (string line in lines)
            {
                // Assuming each line has the format "ItemName - Price: 10.00" (change it to match your actual format)
                string[] parts = line.Split(new string[] { " - Price: " }, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length == 2)
                {
                    decimal itemPrice = decimal.Parse(parts[1]);
                    totalPrice += itemPrice;
                }
            }

            return totalPrice;
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
                        LoadItemsForCategory(categoryId);
                    }
                    else
                    {
                        // Handle the case where the conversion fails
                        MessageBox.Show("Invalid category ID");
                    }
                }
            }
        }
        private void LoadItemsForCategory(int categoryId)
        {
            SqlConnection connection = SessionState.GetConnection();

            try
            {
                string query = "SELECT ProductID, Name FROM Products WHERE CategoryId = @categoryId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CategoryId", categoryId);
                    connection.Open();
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Bind DataTable to itemComboBox
                    itemComboBox.DataSource = dt;
                    itemComboBox.DisplayMember = "Name"; // Display member
                    itemComboBox.ValueMember = "ProductID"; // Value member
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
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        categoriesComboBox.DataSource = dt;
                        categoriesComboBox.DisplayMember = "CategoryName"; // Display member
                        categoriesComboBox.ValueMember = "CategoryId"; // Value member
                    }
                    LoadItemsForCategory(1);
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

        private void itemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemComboBox.SelectedItem != null)
            {
                DataRowView drv = itemComboBox.SelectedItem as DataRowView;
                if (drv != null)
                {
                    int productId;
                    if (int.TryParse(drv["ProductID"].ToString(), out productId))
                    {
                        // Load quantity and other details based on the selected item
                        LoadQuantityForProduct(productId);

                        // Get the price of the selected product
                        productPrice = GetProductPrice(productId);
                        if (quantityBox.Value == 0)
                        {
                            priceTextBox.Text = "0";
                        }
                        else
                        {
                            priceTextBox.Text = productPrice.ToString();
                        }

                        // Calculate and display subtotal
                        // CalculateSubtotal();
                    }
                    else
                    {
                        // Handle the case where the conversion fails
                        MessageBox.Show("Invalid product ID");
                    }
                }
            }
        }



        private void LoadQuantityForProduct(int productId)
        {
            SqlConnection connection = SessionState.GetConnection();
            connection.Open();
            try
            {
                // SQL query to retrieve the maximum quantity available for the selected ProductId
                string query = "SELECT Quantity FROM Products WHERE ProductID = @productId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductID", productId);
                    object result = command.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        int maxQuantity = Convert.ToInt32(result);
                        // Set the NumericUpDown control's maximum value
                        quantityBox.Minimum = 0;
                        quantityBox.Maximum = maxQuantity;
                        quantityBox.Value = 0;
                    }
                    else
                    {
                        quantityBox.Enabled = false;
                    }
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
        private decimal CheckDiscount(int productId)
        {
            decimal discount = 0;
            // Assuming you have a connection string
            SqlConnection connection = SessionState.GetConnection();

            connection.Open();
            string query = @"SELECT p.CategoryId, pr.StartDate, pr.EndDate, pr.Discount
                         FROM Products p
                         INNER JOIN Promotions pr ON p.CategoryId = pr.ProductCategory
                         WHERE p.CategoryId = @productId AND pr.StartDate <= GETDATE() AND pr.EndDate >= GETDATE()";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ProductID", productId);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        discount = reader.GetDecimal(reader.GetOrdinal("Discount"));
                    }
                }
            }


            return discount;
        }

        private void CalculateSubtotal()
        {
            // Get the selected quantity from the NumericUpDown control
            int selectedQuantity = (int)quantityBox.Value;

            // Calculate subtotal using the current productPrice
            decimal subtotal = selectedQuantity * productPrice;

            // Update the priceTextBox with the new subtotal value
            priceTextBox.Text = subtotal.ToString();
        }

        private void UpdateDataGridView()
        {
            if (itemComboBox.SelectedItem != null)
            {
                DataRowView drv = itemComboBox.SelectedItem as DataRowView;
                if (drv != null)
                {
                    int productId;
                    if (int.TryParse(drv["ProductID"].ToString(), out productId))
                    {

                        // Fetch product information (name, description, price) based on productId
                        string productName = GetProductName(productId);
                        string productDescription = GetProductDescription(productId);
                        decimal productPrice = GetProductPrice(productId);

                        // Get the selected quantity from the NumericUpDown control
                        int selectedQuantity = (int)quantityBox.Value;

                        // Add or update the DataGridView with the product information and selected quantity
                        UpdateOrAddDataGridViewRow(productId, productName, productDescription, productPrice, selectedQuantity);
                    }
                    else
                    {
                        MessageBox.Show("Invalid product ID");
                    }
                }
            }
        }
        private string GetProductName(int productId)
        {
            string productName = string.Empty; // Initialize with an empty string

            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-5UN9QJT\SQLEXPRESS;Initial Catalog=cafe_Management_system;Integrated Security=True"))
            {
                connection.Open();
                string query = "SELECT Name FROM Products WHERE ProductID = @productId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@productId", productId);

                    try
                    {
                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            productName = result.ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

            return productName;
        }
        private string GetProductDescription(int productId)
        {
            string productDescription = string.Empty; // Initialize with an empty string

            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-5UN9QJT\SQLEXPRESS;Initial Catalog=cafe_Management_system;Integrated Security=True"))
            {
                connection.Open();
                string query = "SELECT Description FROM Products WHERE ProductID = @productId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@productId", productId);

                    try
                    {
                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            productDescription = result.ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

            return productDescription;
        }
        private void UpdateOrAddDataGridViewRow(int productId, string productName, string productDescription, decimal productPrice, int selectedQuantity)
        {
            DataGridViewRow existingRow = null;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Name"].Value != null &&
                    (row.Cells["Name"].Value).ToString() == productName)
                {
                    existingRow = row;
                    break;
                }
            }

            if (existingRow != null)
            {
                // If the product already exists, update the quantity
                existingRow.Cells["Quantity"].Value = selectedQuantity;
            }
            else
            {
                // If the product doesn't exist, add a new row with product information and quantity
                dataGridView1.Rows.Add(productId,productName, productDescription, productPrice, selectedQuantity);
            }
        }


    }

}
