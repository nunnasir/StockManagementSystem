using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using StockManagementSystem.Models;
using StockManagementSystem.DAL;

namespace StockManagementSystem.UI.StockOutUI
{
    public partial class StockOutForm : Form
    {
        public StockOutForm()
        {
            InitializeComponent();
        }

        StockOut stockOut = new StockOut();
        StockOutRepository stockOutRepository = new StockOutRepository();
        Connection connection = new Connection();

        private void StockOutForm_Load(object sender, EventArgs e)
        {
            //Load Company
            DataTable companydt = new DataTable();
            companydt = stockOutRepository.LoadCompany();
            compannyBindingSource.DataSource = companydt;
            companyComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            companyComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;

            //Load Category
            DataTable categoryDt = new DataTable();
            categoryDt = stockOutRepository.LoadCategory();
            categoryBindingSource.DataSource = categoryDt;
            categoryComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            categoryComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            MainForm.MainForm mainForm = new MainForm.MainForm();
            this.Hide();
            mainForm.Show();
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Item Load
            stockOut.Id = Convert.ToInt32(itemComboBox.SelectedValue);
            stockOut.CategoryId = Convert.ToInt32(categoryComboBox.SelectedValue);
            stockOut.CompanyId = Convert.ToInt32(companyComboBox.SelectedValue);

            DataTable itemDt = new DataTable();
            itemDt = stockOutRepository.LoadItem(stockOut);
            itemComboBox.DataSource = itemDt;

            itemComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            itemComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void itemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            stockOut.Id = Convert.ToInt32(itemComboBox.SelectedValue);
            stockOut.CategoryId = Convert.ToInt32(categoryComboBox.SelectedValue);
            stockOut.CompanyId = Convert.ToInt32(companyComboBox.SelectedValue);

            SqlConnection conn = new SqlConnection(connection.connectionDb);
            string query = @"select iv.Quantity, iv.Reorder from Items it inner join Inventory iv on it.Id = iv.itemId where it.CategoryId = " + stockOut.CategoryId + " and it.CompanyId = " + stockOut.CompanyId + " and it.Id = " + stockOut.Id + "   ";
            SqlCommand command = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                availableTextBox.Text = dr.GetValue(0).ToString();
                reorderTextBox.Text = dr.GetValue(1).ToString();
            }
            else
            {
                reorderTextBox.Clear();
                availableTextBox.Clear();
            }
            
            conn.Close();
        }

        //List<StockOut> stockoutsiList = new List<StockOut>();
        private void AddButton_Click(object sender, EventArgs e)
        {

            stockOut.Company = companyComboBox.GetItemText(companyComboBox.SelectedItem);
            stockOut.Item = itemComboBox.GetItemText(itemComboBox.SelectedItem);
            stockOut.SOQuantity = stockQuantityTextBox.Text;

            int n = stockOutDataGridView.Rows.Add();
            stockOutDataGridView.Rows[n].Cells[0].Value = stockOut.Item;
            stockOutDataGridView.Rows[n].Cells[1].Value = stockOut.Company;
            stockOutDataGridView.Rows[n].Cells[2].Value = stockOut.SOQuantity;

            stockQuantityTextBox.Clear();

        }

        private void SellButton_Click(object sender, EventArgs e)
        {
            List<string> updateStockList = new List<string>();

            for (int i = 0; i < stockOutDataGridView.Rows.Count; i++)
            {
                updateStockList.Add(stockOutDataGridView.Rows[i].Cells[0].ToString());
            }

            if (updateStockList.Count > 0)
            {
                SqlConnection conn = new SqlConnection(connection.connectionDb);
                string query = @"UPDATE Inventory SET Quantity = (SELECT Quantity FROM Inventory WHERE ItemId = " + stockOut.Id + ") - " + stockOut.SOQuantity + " WHERE ItemId = " + stockOut.Id + " ";
                string insertQuery = @"INSERT INTO StockOut VALUES(" + stockOut.Id + ", " + stockOut.SOQuantity + ", 1, GETDATE())";
                SqlCommand upCommand = new SqlCommand(query, conn);
                SqlCommand insCommand = new SqlCommand(insertQuery, conn);
                conn.Open();
                bool isRowAffected = upCommand.ExecuteNonQuery() > 0 && insCommand.ExecuteNonQuery() > 0;
                if (isRowAffected)
                {
                    MessageBox.Show("Stock Out Successfully!!");
                    stockOutDataGridView.Rows.Clear();
                }
                conn.Close();
            }
        }

        private void DamageButton_Click(object sender, EventArgs e)
        {
            List<string> updateStockList = new List<string>();

            for (int i = 0; i < stockOutDataGridView.Rows.Count; i++)
            {
                updateStockList.Add(stockOutDataGridView.Rows[i].Cells[0].ToString());
            }

            if (updateStockList.Count > 0)
            {
                SqlConnection conn = new SqlConnection(connection.connectionDb);
                string query = @"UPDATE Inventory SET Quantity = (SELECT Quantity FROM Inventory WHERE ItemId = " + stockOut.Id + ") - " + stockOut.SOQuantity + " WHERE ItemId = " + stockOut.Id + " ";
                string insertQuery = @"INSERT INTO StockOut VALUES(" + stockOut.Id + ", " + stockOut.SOQuantity + ", 2, GETDATE())";
                SqlCommand upCommand = new SqlCommand(query, conn);
                SqlCommand insCommand = new SqlCommand(insertQuery, conn);
                conn.Open();
                bool isRowAffected = upCommand.ExecuteNonQuery() > 0 && insCommand.ExecuteNonQuery() > 0;
                if (isRowAffected)
                {
                    MessageBox.Show("Stock Out Successfully!!");
                    stockOutDataGridView.Rows.Clear();
                }
                conn.Close();
            }
        }

        private void LostButton_Click(object sender, EventArgs e)
        {
            List<string> updateStockList = new List<string>();

            for (int i = 0; i < stockOutDataGridView.Rows.Count; i++)
            {
                updateStockList.Add(stockOutDataGridView.Rows[i].Cells[0].ToString());
            }

            if (updateStockList.Count > 0)
            {
                SqlConnection conn = new SqlConnection(connection.connectionDb);
                string query = @"UPDATE Inventory SET Quantity = (SELECT Quantity FROM Inventory WHERE ItemId = " + stockOut.Id + ") - " + stockOut.SOQuantity + " WHERE ItemId = " + stockOut.Id + " ";
                string insertQuery = @"INSERT INTO StockOut VALUES(" + stockOut.Id + ", " + stockOut.SOQuantity + ", 3, GETDATE())";
                SqlCommand upCommand = new SqlCommand(query, conn);
                SqlCommand insCommand = new SqlCommand(insertQuery, conn);
                conn.Open();
                bool isRowAffected = upCommand.ExecuteNonQuery() > 0 && insCommand.ExecuteNonQuery() > 0;
                if (isRowAffected)
                {
                    MessageBox.Show("Stock Out Successfully!!");
                    stockOutDataGridView.Rows.Clear();
                }
                conn.Close();
            }
        }

        
    }
}
