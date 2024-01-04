namespace Cafe_Management_System_2021_CE_1.UI_Forms.Employee
{
    partial class AddProductsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.addEditButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.addEditLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoutButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.supplierButton = new System.Windows.Forms.Button();
            this.employeeButton = new System.Windows.Forms.Button();
            this.customersButton = new System.Windows.Forms.Button();
            this.feedbackButton = new System.Windows.Forms.Button();
            this.promotionsButton = new System.Windows.Forms.Button();
            this.orderSummary = new System.Windows.Forms.Button();
            this.productsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.categoriesComboBox = new System.Windows.Forms.ComboBox();
            this.suppliersComboBox = new System.Windows.Forms.ComboBox();
            this.quantityUpDown = new System.Windows.Forms.NumericUpDown();
            this.cafe_Management_systemDataSet = new Cafe_Management_System_2021_CE_1.cafe_Management_systemDataSet();
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suppliersTableAdapter = new Cafe_Management_System_2021_CE_1.cafe_Management_systemDataSetTableAdapters.SuppliersTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafe_Management_systemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addEditButton
            // 
            this.addEditButton.BackColor = System.Drawing.Color.DarkRed;
            this.addEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addEditButton.ForeColor = System.Drawing.Color.MistyRose;
            this.addEditButton.Location = new System.Drawing.Point(596, 365);
            this.addEditButton.Name = "addEditButton";
            this.addEditButton.Size = new System.Drawing.Size(136, 54);
            this.addEditButton.TabIndex = 62;
            this.addEditButton.Text = "Add";
            this.addEditButton.UseVisualStyleBackColor = false;
            this.addEditButton.Click += new System.EventHandler(this.addEditButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.DarkRed;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.backButton.ForeColor = System.Drawing.Color.MistyRose;
            this.backButton.Location = new System.Drawing.Point(792, 365);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(136, 54);
            this.backButton.TabIndex = 61;
            this.backButton.Text = "Go Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(515, 176);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(413, 26);
            this.descriptionTextBox.TabIndex = 60;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.ForeColor = System.Drawing.Color.DarkRed;
            this.label10.Location = new System.Drawing.Point(397, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 25);
            this.label10.TabIndex = 59;
            this.label10.Text = "Description";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(397, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 25);
            this.label8.TabIndex = 57;
            this.label8.Text = "Quantity";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(515, 218);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(413, 26);
            this.priceTextBox.TabIndex = 56;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(397, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 25);
            this.label9.TabIndex = 55;
            this.label9.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(397, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 53;
            this.label3.Text = "Category";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(515, 85);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(413, 26);
            this.nameTextBox.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(397, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 51;
            this.label2.Text = "Name";
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.DarkRed;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.clearButton.ForeColor = System.Drawing.Color.MistyRose;
            this.clearButton.Location = new System.Drawing.Point(402, 365);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(136, 54);
            this.clearButton.TabIndex = 50;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // addEditLabel
            // 
            this.addEditLabel.AutoSize = true;
            this.addEditLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEditLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.addEditLabel.Location = new System.Drawing.Point(533, 17);
            this.addEditLabel.Name = "addEditLabel";
            this.addEditLabel.Size = new System.Drawing.Size(252, 46);
            this.addEditLabel.TabIndex = 49;
            this.addEditLabel.Text = "Add Product";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.logoutButton);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.supplierButton);
            this.panel1.Controls.Add(this.employeeButton);
            this.panel1.Controls.Add(this.customersButton);
            this.panel1.Controls.Add(this.feedbackButton);
            this.panel1.Controls.Add(this.promotionsButton);
            this.panel1.Controls.Add(this.orderSummary);
            this.panel1.Controls.Add(this.productsButton);
            this.panel1.Location = new System.Drawing.Point(5, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 943);
            this.panel1.TabIndex = 48;
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.DarkRed;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.logoutButton.ForeColor = System.Drawing.Color.MistyRose;
            this.logoutButton.Location = new System.Drawing.Point(0, 636);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(308, 50);
            this.logoutButton.TabIndex = 9;
            this.logoutButton.Text = "Log Out";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cafe_Management_System_2021_CE_1.Properties.Resources.cafeLogo;
            this.pictureBox1.Location = new System.Drawing.Point(42, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 216);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // supplierButton
            // 
            this.supplierButton.BackColor = System.Drawing.Color.DarkRed;
            this.supplierButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.supplierButton.ForeColor = System.Drawing.Color.MistyRose;
            this.supplierButton.Location = new System.Drawing.Point(0, 576);
            this.supplierButton.Name = "supplierButton";
            this.supplierButton.Size = new System.Drawing.Size(308, 50);
            this.supplierButton.TabIndex = 7;
            this.supplierButton.Text = "Suppliers";
            this.supplierButton.UseVisualStyleBackColor = false;
            this.supplierButton.Click += new System.EventHandler(this.supplierButton_Click);
            // 
            // employeeButton
            // 
            this.employeeButton.BackColor = System.Drawing.Color.DarkRed;
            this.employeeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.employeeButton.ForeColor = System.Drawing.Color.MistyRose;
            this.employeeButton.Location = new System.Drawing.Point(0, 517);
            this.employeeButton.Name = "employeeButton";
            this.employeeButton.Size = new System.Drawing.Size(308, 50);
            this.employeeButton.TabIndex = 6;
            this.employeeButton.Text = "Employees";
            this.employeeButton.UseVisualStyleBackColor = false;
            this.employeeButton.Click += new System.EventHandler(this.employeeButton_Click);
            // 
            // customersButton
            // 
            this.customersButton.BackColor = System.Drawing.Color.DarkRed;
            this.customersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.customersButton.ForeColor = System.Drawing.Color.MistyRose;
            this.customersButton.Location = new System.Drawing.Point(0, 458);
            this.customersButton.Name = "customersButton";
            this.customersButton.Size = new System.Drawing.Size(308, 50);
            this.customersButton.TabIndex = 5;
            this.customersButton.Text = "Customers";
            this.customersButton.UseVisualStyleBackColor = false;
            this.customersButton.Click += new System.EventHandler(this.customersButton_Click);
            // 
            // feedbackButton
            // 
            this.feedbackButton.BackColor = System.Drawing.Color.DarkRed;
            this.feedbackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.feedbackButton.ForeColor = System.Drawing.Color.MistyRose;
            this.feedbackButton.Location = new System.Drawing.Point(0, 399);
            this.feedbackButton.Name = "feedbackButton";
            this.feedbackButton.Size = new System.Drawing.Size(308, 50);
            this.feedbackButton.TabIndex = 3;
            this.feedbackButton.Text = "Feedbacks";
            this.feedbackButton.UseVisualStyleBackColor = false;
            this.feedbackButton.Click += new System.EventHandler(this.feedbackButton_Click);
            // 
            // promotionsButton
            // 
            this.promotionsButton.BackColor = System.Drawing.Color.DarkRed;
            this.promotionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.promotionsButton.ForeColor = System.Drawing.Color.MistyRose;
            this.promotionsButton.Location = new System.Drawing.Point(-12, 341);
            this.promotionsButton.Name = "promotionsButton";
            this.promotionsButton.Size = new System.Drawing.Size(320, 50);
            this.promotionsButton.TabIndex = 2;
            this.promotionsButton.Text = "Promotions";
            this.promotionsButton.UseVisualStyleBackColor = false;
            this.promotionsButton.Click += new System.EventHandler(this.promotionsButton_Click);
            // 
            // orderSummary
            // 
            this.orderSummary.BackColor = System.Drawing.Color.DarkRed;
            this.orderSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.orderSummary.ForeColor = System.Drawing.Color.MistyRose;
            this.orderSummary.Location = new System.Drawing.Point(0, 284);
            this.orderSummary.Name = "orderSummary";
            this.orderSummary.Size = new System.Drawing.Size(308, 50);
            this.orderSummary.TabIndex = 1;
            this.orderSummary.Text = "Pending Orders";
            this.orderSummary.UseVisualStyleBackColor = false;
            this.orderSummary.Click += new System.EventHandler(this.orderSummary_Click);
            // 
            // productsButton
            // 
            this.productsButton.BackColor = System.Drawing.Color.DarkSalmon;
            this.productsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.productsButton.ForeColor = System.Drawing.Color.MistyRose;
            this.productsButton.Location = new System.Drawing.Point(0, 226);
            this.productsButton.Name = "productsButton";
            this.productsButton.Size = new System.Drawing.Size(308, 50);
            this.productsButton.TabIndex = 0;
            this.productsButton.Text = "Products";
            this.productsButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(397, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 63;
            this.label1.Text = "Supplier";
            // 
            // categoriesComboBox
            // 
            this.categoriesComboBox.FormattingEnabled = true;
            this.categoriesComboBox.Location = new System.Drawing.Point(515, 130);
            this.categoriesComboBox.Name = "categoriesComboBox";
            this.categoriesComboBox.Size = new System.Drawing.Size(413, 28);
            this.categoriesComboBox.TabIndex = 64;
            this.categoriesComboBox.SelectedIndexChanged += new System.EventHandler(this.categoriesComboBox_SelectedIndexChanged);
            // 
            // suppliersComboBox
            // 
            this.suppliersComboBox.DataSource = this.suppliersBindingSource;
            this.suppliersComboBox.FormattingEnabled = true;
            this.suppliersComboBox.Location = new System.Drawing.Point(515, 307);
            this.suppliersComboBox.Name = "suppliersComboBox";
            this.suppliersComboBox.Size = new System.Drawing.Size(413, 28);
            this.suppliersComboBox.TabIndex = 65;
            this.suppliersComboBox.SelectedIndexChanged += new System.EventHandler(this.suppliersComboBox_SelectedIndexChanged);
            // 
            // quantityUpDown
            // 
            this.quantityUpDown.Location = new System.Drawing.Point(515, 264);
            this.quantityUpDown.Name = "quantityUpDown";
            this.quantityUpDown.Size = new System.Drawing.Size(413, 26);
            this.quantityUpDown.TabIndex = 66;
            // 
            // cafe_Management_systemDataSet
            // 
            this.cafe_Management_systemDataSet.DataSetName = "cafe_Management_systemDataSet";
            this.cafe_Management_systemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // suppliersBindingSource
            // 
            this.suppliersBindingSource.DataMember = "Suppliers";
            this.suppliersBindingSource.DataSource = this.cafe_Management_systemDataSet;
            // 
            // suppliersTableAdapter
            // 
            this.suppliersTableAdapter.ClearBeforeFill = true;
            // 
            // AddProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1078, 944);
            this.Controls.Add(this.quantityUpDown);
            this.Controls.Add(this.suppliersComboBox);
            this.Controls.Add(this.categoriesComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addEditButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.addEditLabel);
            this.Controls.Add(this.panel1);
            this.Name = "AddProductsForm";
            this.Text = "AddProductsForm";
            this.Load += new System.EventHandler(this.AddProductsForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafe_Management_systemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addEditButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label addEditLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button supplierButton;
        private System.Windows.Forms.Button employeeButton;
        private System.Windows.Forms.Button customersButton;
        private System.Windows.Forms.Button feedbackButton;
        private System.Windows.Forms.Button promotionsButton;
        private System.Windows.Forms.Button orderSummary;
        private System.Windows.Forms.Button productsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox categoriesComboBox;
        private System.Windows.Forms.ComboBox suppliersComboBox;
        private System.Windows.Forms.NumericUpDown quantityUpDown;
        private cafe_Management_systemDataSet cafe_Management_systemDataSet;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private cafe_Management_systemDataSetTableAdapters.SuppliersTableAdapter suppliersTableAdapter;
    }
}