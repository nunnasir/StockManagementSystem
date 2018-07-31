using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystem.BLL;
using StockManagementSystem.Models;
using StockManagementSystem.UI.MainForm;

namespace StockManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void LoginButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();

            LoginManager loginManager = new LoginManager();
            login.Name = nameTextBox.Text;
            login.Password = passTextBox.Text;

            bool verified = loginManager.IsVerified(login);
            if (verified)
            {
                MessageBox.Show("All Fields are Mendatory!!!");
                return;
            }

            bool isSuccessLogin = loginManager.IsSuccess(login);
            if (!isSuccessLogin)
            {
                MessageBox.Show("Incorrect User Name or Password!!");
                return;
            }
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void CancelledButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
