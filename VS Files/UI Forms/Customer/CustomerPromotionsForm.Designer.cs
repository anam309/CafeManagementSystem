namespace Cafe_Management_System_2021_CE_1.UI_Forms
{
    partial class CustomerPromotionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerPromotionsForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoutButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.feedbackButton = new System.Windows.Forms.Button();
            this.promotionsButton = new System.Windows.Forms.Button();
            this.orderSummary = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.refreshButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.logoutButton.Location = new System.Drawing.Point(0, 482);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(308, 50);
            this.logoutButton.TabIndex = 13;
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
            this.promotionsButton.BackColor = System.Drawing.Color.DarkSalmon;
            this.promotionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.promotionsButton.ForeColor = System.Drawing.Color.MistyRose;
            this.promotionsButton.Location = new System.Drawing.Point(0, 354);
            this.promotionsButton.Name = "promotionsButton";
            this.promotionsButton.Size = new System.Drawing.Size(308, 50);
            this.promotionsButton.TabIndex = 2;
            this.promotionsButton.Text = "Promotions";
            this.promotionsButton.UseVisualStyleBackColor = false;
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
            this.menuButton.BackColor = System.Drawing.Color.DarkRed;
            this.menuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.menuButton.ForeColor = System.Drawing.Color.MistyRose;
            this.menuButton.Location = new System.Drawing.Point(0, 226);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(308, 50);
            this.menuButton.TabIndex = 0;
            this.menuButton.Text = "Place Order";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(545, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Promotions";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(350, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(652, 342);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.DarkRed;
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.refreshButton.ForeColor = System.Drawing.Color.MistyRose;
            this.refreshButton.Location = new System.Drawing.Point(866, 67);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(136, 54);
            this.refreshButton.TabIndex = 18;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // CustomerPromotionsForm
            // 
            this.AcceptButton = this.promotionsButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1078, 944);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "CustomerPromotionsForm";
            this.Text = "CustomerPromotionsForm";
            this.Load += new System.EventHandler(this.CustomerPromotionsForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button feedbackButton;
        private System.Windows.Forms.Button promotionsButton;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Button orderSummary;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button refreshButton;
    }
}