namespace Cafe_Management_System_2021_CE_1.UI_Forms
{
    partial class InitialForm
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
            this.cafeName = new System.Windows.Forms.Label();
            this.employeeLoginButton = new System.Windows.Forms.Button();
            this.customerLoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cafeName
            // 
            this.cafeName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cafeName.AutoSize = true;
            this.cafeName.Font = new System.Drawing.Font("MV Boli", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cafeName.ForeColor = System.Drawing.Color.Firebrick;
            this.cafeName.Location = new System.Drawing.Point(250, 4);
            this.cafeName.Name = "cafeName";
            this.cafeName.Size = new System.Drawing.Size(506, 105);
            this.cafeName.TabIndex = 0;
            this.cafeName.Text = "Anam\'s Cafe";
            // 
            // employeeLoginButton
            // 
            this.employeeLoginButton.BackColor = System.Drawing.Color.DarkRed;
            this.employeeLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.employeeLoginButton.ForeColor = System.Drawing.Color.White;
            this.employeeLoginButton.Location = new System.Drawing.Point(278, 152);
            this.employeeLoginButton.Name = "employeeLoginButton";
            this.employeeLoginButton.Size = new System.Drawing.Size(220, 118);
            this.employeeLoginButton.TabIndex = 5;
            this.employeeLoginButton.Text = "Login as Employee";
            this.employeeLoginButton.UseVisualStyleBackColor = false;
            this.employeeLoginButton.Click += new System.EventHandler(this.employeeLoginButton_Click);
            // 
            // customerLoginButton
            // 
            this.customerLoginButton.BackColor = System.Drawing.Color.DarkRed;
            this.customerLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.customerLoginButton.ForeColor = System.Drawing.Color.White;
            this.customerLoginButton.Location = new System.Drawing.Point(504, 152);
            this.customerLoginButton.Name = "customerLoginButton";
            this.customerLoginButton.Size = new System.Drawing.Size(220, 118);
            this.customerLoginButton.TabIndex = 6;
            this.customerLoginButton.Text = "Login as Customer";
            this.customerLoginButton.UseVisualStyleBackColor = false;
            this.customerLoginButton.Click += new System.EventHandler(this.customerLoginButton_Click);
            // 
            // InitialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1078, 944);
            this.Controls.Add(this.customerLoginButton);
            this.Controls.Add(this.employeeLoginButton);
            this.Controls.Add(this.cafeName);
            this.Name = "InitialForm";
            this.Text = "Cafe Management System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cafeName;
        private System.Windows.Forms.Button employeeLoginButton;
        private System.Windows.Forms.Button customerLoginButton;
    }
}