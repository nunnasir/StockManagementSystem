using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystem.UI.CategoryUI;
using StockManagementSystem.UI.Company;
using StockManagementSystem.UI.DateSearchUI;
using StockManagementSystem.UI.ItemSetup;
using StockManagementSystem.UI.SearchUI;
using StockManagementSystem.UI.StockInUI;
using StockManagementSystem.UI.StockOutUI;

namespace StockManagementSystem.UI.MainForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();
        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.Show();
            this.Hide();
        }

        private void CompanyButton_Click(object sender, EventArgs e)
        {
            CompanyForm companyForm = new CompanyForm();
            companyForm.Show();
            this.Hide();
        }

        private void ItemButton_Click(object sender, EventArgs e)
        {
            ItemSetupForm itemSetupForm = new ItemSetupForm();
            itemSetupForm.Show();
            this.Hide();
        }

        private void DateSearchButton_Click(object sender, EventArgs e)
        {
            DateSearchForm dateSearchForm = new DateSearchForm();
            dateSearchForm.Show();
            this.Hide();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.Show();
            this.Hide();
        }

        private void StockInButton_Click(object sender, EventArgs e)
        {
            StockInForm stockInForm = new StockInForm();
            stockInForm.Show();
            this.Hide();
        }

        private void StockOutButton_Click(object sender, EventArgs e)
        {
            StockOutForm stockOutForm = new StockOutForm();
            stockOutForm.Show();
            this.Hide();
        }
    }
}
