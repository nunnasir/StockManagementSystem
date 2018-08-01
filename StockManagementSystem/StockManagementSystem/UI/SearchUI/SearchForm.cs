using System;
using System.Data;
using System.Windows.Forms;
using StockManagementSystem.Models;
using StockManagementSystem.DAL;
using StockManagementSystem.BLL;

namespace StockManagementSystem.UI.SearchUI
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        Search search = new Search();
        SearchRepository searchRepository = new SearchRepository();
        SearchManager searchManager = new SearchManager();

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            MainForm.MainForm mainForm = new MainForm.MainForm();
            this.Hide();
            mainForm.Show();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            //Load Company
            DataTable companydt = new DataTable();
            companydt = searchRepository.LoadCompany();
            compannyBindingSource.DataSource = companydt;
            companyComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            companyComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;

            //Load Category
            DataTable categoryDt = new DataTable();
            categoryDt = searchRepository.LoadCategory();
            categoryBindingSource.DataSource = categoryDt;
            categoryComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            categoryComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            //search.Company = companyComboBox.GetItemText(companyComboBox.SelectedItem);
            //search.Category = categoryComboBox.GetItemText(categoryComboBox.SelectedItem);
            search.CompanyId = Convert.ToInt32(companyComboBox.SelectedValue);
            search.CategoryId = Convert.ToInt32(categoryComboBox.SelectedValue);

            DataTable dt = new DataTable();
            dt = searchRepository.LoadSearchItem(search);
            summeryIttemDataGridView.DataSource = dt;
        }
    }
}
