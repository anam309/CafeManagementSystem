namespace Cafe_Management_System_2021_CE_1
{
    partial class CustomerHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerHomePage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoutButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.feedbackButton = new System.Windows.Forms.Button();
            this.promotionsButton = new System.Windows.Forms.Button();
            this.orderSummary = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.itemComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.totalPriceTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.orderButton = new System.Windows.Forms.Button();
            this.addToCartButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.quantityBox = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.categoriesComboBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.logoutButton);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.feedbackButton);
            this.panel1.Controls.Add(this.promotionsButton);
            this.panel1.Controls.Add(this.orderSummary);
            this.panel1.Controls.Add(this.menuButton);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 631);
            this.panel1.TabIndex = 0;
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.DarkRed;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.logoutButton.ForeColor = System.Drawing.Color.MistyRose;
            this.logoutButton.Location = new System.Drawing.Point(0, 483);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(308, 50);
            this.logoutButton.TabIndex = 10;
            this.logoutButton.Text = "Log Out";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 216);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // feedbackButton
            // 
            this.feedbackButton.BackColor = System.Drawing.Color.DarkRed;
            this.feedbackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.feedbackButton.ForeColor = System.Drawing.Color.MistyRose;
            this.feedbackButton.Location = new System.Drawing.Point(0, 418);
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
            this.promotionsButton.Location = new System.Drawing.Point(0, 354);
            this.promotionsButton.Name = "promotionsButton";
            this.promotionsButton.Size = new System.Drawing.Size(308, 50);
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
            this.orderSummary.Location = new System.Drawing.Point(0, 290);
            this.orderSummary.Name = "orderSummary";
            this.orderSummary.Size = new System.Drawing.Size(308, 50);
            this.orderSummary.TabIndex = 1;
            this.orderSummary.Text = "Order Summary";
            this.orderSummary.UseVisualStyleBackColor = false;
            this.orderSummary.Click += new System.EventHandler(this.orderSummary_Click);
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.DarkSalmon;
            this.menuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.menuButton.ForeColor = System.Drawing.Color.MistyRose;
            this.menuButton.Location = new System.Drawing.Point(0, 226);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(308, 50);
            this.menuButton.TabIndex = 0;
            this.menuButton.Text = "Place Order";
            this.menuButton.UseVisualStyleBackColor = false;
            // 
            // itemComboBox
            // 
            this.itemComboBox.FormattingEnabled = true;
            this.itemComboBox.Location = new System.Drawing.Point(794, 46);
            this.itemComboBox.Name = "itemComboBox";
            this.itemComboBox.Size = new System.Drawing.Size(218, 28);
            this.itemComboBox.TabIndex = 2;
            this.itemComboBox.SelectedIndexChanged += new System.EventHandler(this.itemComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(336, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(713, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Item";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(343, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(706, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Price";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Enabled = false;
            this.priceTextBox.Location = new System.Drawing.Point(794, 109);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(218, 26);
            this.priceTextBox.TabIndex = 8;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(794, 227);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(218, 242);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // totalPriceTextBox
            // 
            this.totalPriceTextBox.Enabled = false;
            this.totalPriceTextBox.Location = new System.Drawing.Point(794, 489);
            this.totalPriceTextBox.Name = "totalPriceTextBox";
            this.totalPriceTextBox.Size = new System.Drawing.Size(218, 26);
            this.totalPriceTextBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(706, 491);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Total";
            // 
            // orderButton
            // 
            this.orderButton.BackColor = System.Drawing.Color.DarkRed;
            this.orderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.orderButton.ForeColor = System.Drawing.Color.MistyRose;
            this.orderButton.Location = new System.Drawing.Point(794, 539);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(218, 50);
            this.orderButton.TabIndex = 10;
            this.orderButton.Text = "Place Order";
            this.orderButton.UseVisualStyleBackColor = false;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // addToCartButton
            // 
            this.addToCartButton.BackColor = System.Drawing.Color.DarkRed;
            this.addToCartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addToCartButton.ForeColor = System.Drawing.Color.MistyRose;
            this.addToCartButton.Location = new System.Drawing.Point(454, 160);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(218, 50);
            this.addToCartButton.TabIndex = 13;
            this.addToCartButton.Text = "Add To Cart";
            this.addToCartButton.UseVisualStyleBackColor = false;
            this.addToCartButton.Click += new System.EventHandler(this.addToCartButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(858, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "Receipt";
            // 
            // quantityBox
            // 
            this.quantityBox.Location = new System.Drawing.Point(454, 109);
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.Size = new System.Drawing.Size(218, 26);
            this.quantityBox.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(348, 227);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(324, 242);
            this.dataGridView1.TabIndex = 16;
            // 
            // categoriesComboBox
            // 
            this.categoriesComboBox.FormattingEnabled = true;
            this.categoriesComboBox.Location = new System.Drawing.Point(454, 42);
            this.categoriesComboBox.Name = "categoriesComboBox";
            this.categoriesComboBox.Size = new System.Drawing.Size(218, 28);
            this.categoriesComboBox.TabIndex = 17;
            this.categoriesComboBox.SelectedIndexChanged += new System.EventHandler(this.categoriesComboBox_SelectedIndexChanged);
            // 
            // CustomerHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1078, 944);
            this.Controls.Add(this.categoriesComboBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.quantityBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addToCartButton);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.totalPriceTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itemComboBox);
            this.Controls.Add(this.panel1);
            this.Name = "CustomerHomePage";
            this.Text = "HomePage";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button feedbackButton;
        private System.Windows.Forms.Button promotionsButton;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox itemComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox totalPriceTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Button addToCartButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button orderSummary;
        private System.Windows.Forms.NumericUpDown quantityBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox categoriesComboBox;
    }
}