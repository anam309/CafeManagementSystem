using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management_System_2021_CE_1.UI_Forms
{
    public partial class InitialForm : Form
    {
        public InitialForm()
        {
            InitializeComponent();
        }
    
        private void employeeLoginButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm("employee");
            this.Hide();
            loginForm.Show();

        }

        private void customerLoginButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm("customer");
            this.Hide();
            loginForm.Show();
        }
    }
}
