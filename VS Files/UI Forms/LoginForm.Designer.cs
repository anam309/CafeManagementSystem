namespace Cafe_Management_System_2021_CE_1
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.cafeName = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lognButton = new System.Windows.Forms.Button();
            this.registerLabel = new System.Windows.Forms.LinkLabel();
            this.backButton = new System.Windows.Forms.Button();
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
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(469, 152);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(213, 26);
            this.usernameTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(469, 194);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(213, 26);
            this.passwordTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(322, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(322, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // lognButton
            // 
            this.lognButton.BackColor = System.Drawing.Color.LightCoral;
            this.lognButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lognButton.ForeColor = System.Drawing.Color.White;
            this.lognButton.Location = new System.Drawing.Point(432, 247);
            this.lognButton.Name = "lognButton";
            this.lognButton.Size = new System.Drawing.Size(131, 46);
            this.lognButton.TabIndex = 5;
            this.lognButton.Text = "Login";
            this.lognButton.UseVisualStyleBackColor = false;
            this.lognButton.Click += new System.EventHandler(this.lognButton_Click);
            // 
            // registerLabel
            // 
            this.registerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.registerLabel.AutoSize = true;
            this.registerLabel.LinkColor = System.Drawing.Color.Maroon;
            this.registerLabel.Location = new System.Drawing.Point(357, 306);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(280, 20);
            this.registerLabel.TabIndex = 6;
            this.registerLabel.TabStop = true;
            this.registerLabel.Text = "Don\'t have an account? Register Now!";
            this.registerLabel.Visible = false;
            this.registerLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registerLabel_LinkClicked);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.LightCoral;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(777, 34);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(131, 46);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "Go Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1078, 944);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.registerLabel);
            this.Controls.Add(this.lognButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.cafeName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "Cafe Management System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cafeName;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button lognButton;
        private System.Windows.Forms.LinkLabel registerLabel;
        private System.Windows.Forms.Button backButton;
    }
}

