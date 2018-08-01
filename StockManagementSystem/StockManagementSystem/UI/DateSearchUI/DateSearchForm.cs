using System;
using System.Data;
using System.Windows.Forms;
using StockManagementSystem.Models;
using StockManagementSystem.DAL;

namespace StockManagementSystem.UI.DateSearchUI
{
    public partial class DateSearchForm : Form
    {
        public DateSearchForm()
        {
            InitializeComponent();
        }

        DateSearch dateSearch = new DateSearch();
        DateSearchRepository dateSearchRepository = new DateSearchRepository();

        private void SearchButton_Click(object sender, EventArgs e)
        {
            dateSearch.FromDate = Convert.ToDateTime(fromDateTimePicker.Text);
            dateSearch.ToDate = Convert.ToDateTime(toDateTimePicker.Text);

            DataTable dt = new DataTable();
            dt = dateSearchRepository.LoadDateSearchItem(dateSearch);
            summeryIttemDataGridView.DataSource = dt;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            MainForm.MainForm mainForm = new MainForm.MainForm();
            this.Hide();
            mainForm.Show();
        }

    }
}
