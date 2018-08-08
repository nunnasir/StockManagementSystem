using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using StockManagementSystem.Models;
using StockManagementSystem.DAL;
using StockManagementSystem.BLL;

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
        StockoutManager stockoutManager = new StockoutManager();
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

                if (Convert.ToInt32(availableTextBox.Text) < Convert.ToInt32(reorderTextBox.Text))
                {
                    ReorderErrorLavel.Text = "*Items are Below Reorder Level";
                }
                else
                {
                    ReorderErrorLavel.Text = "";
                }
            }
            else
            {
                reorderTextBox.Clear();
                availableTextBox.Clear();
            }
            
            conn.Close();
        }

        private void stockQuantityTextBox_TextChanged(object sender, EventArgs e)
        {
            string temp = stockQuantityTextBox.Text;

            foreach (char c in temp)
            {
                if (char.IsDigit(c) == false)
                {
                    errorQuantityLabel.Text = "Invalid Quantity!!";
                    return;
                }
                errorQuantityLabel.Text = "";
            }
        }

        List<StockOut> stockoutsiList = new List<StockOut>();
        List<StockOutVM> stockOutDisplayList = new List<StockOutVM>();

        private void AddButton_Click(object sender, EventArgs e)
        {
            StockOutVM stockOutVm = new StockOutVM();

            string avQuantity = availableTextBox.Text;
            stockOut.Company = companyComboBox.GetItemText(companyComboBox.SelectedItem);
            stockOut.Category = categoryComboBox.GetItemText(companyComboBox.SelectedItem);
            stockOut.Item = itemComboBox.GetItemText(itemComboBox.SelectedItem);
            stockOut.SOQuantity = stockQuantityTextBox.Text;
            stockOut.Reorder = reorderTextBox.Text;

            stockOutVm.ItemId = Convert.ToInt32(itemComboBox.SelectedValue);
            stockOutVm.CompanyName = companyComboBox.GetItemText(companyComboBox.SelectedItem);
            stockOutVm.ItemName = itemComboBox.GetItemText(itemComboBox.SelectedItem);
            stockOutVm.StockOutQuantity = stockQuantityTextBox.Text;

            if (string.IsNullOrEmpty(stockOut.Item) || string.IsNullOrEmpty(avQuantity) || string.IsNullOrEmpty(stockOut.Reorder))
            {
                selectItemErrorLabel.Text = "*Please Select Item";
                return;
            }
            selectItemErrorLabel.Text = "";

            if (!string.IsNullOrEmpty(errorQuantityLabel.Text))
            {
                MessageBox.Show("Please Resolve Your Error First!!");
                return;
            }

            if (string.IsNullOrEmpty(stockQuantityTextBox.Text))
            {
                //MessageBox.Show("stock out must not be empty");
                errorQuantityLabel.Text = "*stock out must not be empty!!";
                return;
            }

            if (Convert.ToInt32(avQuantity) < Convert.ToInt32(stockOut.SOQuantity))
            {
                errorQuantityLabel.Text = "*sorry unavailable Items!!";
                return;
            }



            //Add List
            stockoutsiList.Add(stockOut);
            stockOutDisplayList.Add(stockOutVm);

            //Add Gridview
            stockOutDataGridView.DataSource = null;
            stockOutDataGridView.DataSource = stockOutDisplayList;
            stockOutDataGridView.Columns["ItemId"].Visible = false;

            stockQuantityTextBox.Clear();
            reorderTextBox.Clear();
            availableTextBox.Clear();
            itemComboBox.ResetText();
            errorQuantityLabel.Text = "";

        }

        //Stockout by Sell
        private void SellButton_Click(object sender, EventArgs e)
        {
            if (stockOutDisplayList.Count > 0)
            {
                int uc = 0;
                int ic = 0;
                foreach (var outVm in stockOutDisplayList)
                {
                    SqlConnection conn = new SqlConnection(connection.connectionDb);
                    string query = @"UPDATE Inventory SET Quantity = (SELECT Quantity FROM Inventory WHERE ItemId = " + outVm.ItemId + ") - " + outVm.StockOutQuantity + " WHERE ItemId = " + outVm.ItemId + " ";
                    string insertQuery = @"INSERT INTO StockOut VALUES(" + outVm.ItemId + ", " + outVm.StockOutQuantity + ", 1, GETDATE())";

                    SqlCommand upCommand = new SqlCommand(query, conn);
                    SqlCommand insCommand = new SqlCommand(insertQuery, conn);
                    conn.Open();
                    uc += upCommand.ExecuteNonQuery();
                    ic += insCommand.ExecuteNonQuery();
                    conn.Close();
                }

                if (uc == ic)
                {
                    MessageBox.Show("SuccessFully Stockout by Sell");
                    stockOutDisplayList.Clear();
                    stockOutDataGridView.DataSource = null;
                }
                else
                {
                    MessageBox.Show("There is an error!!");
                }
            }
            else
            {
                MessageBox.Show("There is no any selected Item!!");
            }

        }

        //Stockout by Damage
        private void DamageButton_Click(object sender, EventArgs e)
        {
            if (stockOutDisplayList.Count > 0)
            {
                int uc = 0;
                int ic = 0;
                foreach (var outVm in stockOutDisplayList)
                {
                    SqlConnection conn = new SqlConnection(connection.connectionDb);
                    string query = @"UPDATE Inventory SET Quantity = (SELECT Quantity FROM Inventory WHERE ItemId = " + outVm.ItemId + ") - " + outVm.StockOutQuantity + " WHERE ItemId = " + outVm.ItemId + " ";
                    string insertQuery = @"INSERT INTO StockOut VALUES(" + outVm.ItemId + ", " + outVm.StockOutQuantity + ", 2, GETDATE())";

                    SqlCommand upCommand = new SqlCommand(query, conn);
                    SqlCommand insCommand = new SqlCommand(insertQuery, conn);
                    conn.Open();
                    uc += upCommand.ExecuteNonQuery();
                    ic += insCommand.ExecuteNonQuery();
                    conn.Close();
                }

                if (uc == ic)
                {
                    MessageBox.Show("SuccessFully Stockout by Damage");
                    stockOutDisplayList.Clear();
                    stockOutDataGridView.DataSource = null;
                }
                else
                {
                    MessageBox.Show("There is an error!!");
                }
            }
            else
            {
                MessageBox.Show("There is no any selected Item!!");
            }
        }

        //Stockout by lost
        private void LostButton_Click(object sender, EventArgs e)
        {
            if (stockOutDisplayList.Count > 0)
            {
                int uc = 0;
                int ic = 0;
                foreach (var outVm in stockOutDisplayList)
                {
                    SqlConnection conn = new SqlConnection(connection.connectionDb);
                    string query = @"UPDATE Inventory SET Quantity = (SELECT Quantity FROM Inventory WHERE ItemId = " + outVm.ItemId + ") - " + outVm.StockOutQuantity + " WHERE ItemId = " + outVm.ItemId + " ";
                    string insertQuery = @"INSERT INTO StockOut VALUES(" + outVm.ItemId + ", " + outVm.StockOutQuantity + ", 3, GETDATE())";

                    SqlCommand upCommand = new SqlCommand(query, conn);
                    SqlCommand insCommand = new SqlCommand(insertQuery, conn);
                    conn.Open();
                    uc += upCommand.ExecuteNonQuery();
                    ic += insCommand.ExecuteNonQuery();
                    conn.Close();
                }

                if (uc == ic)
                {
                    MessageBox.Show("SuccessFully Stockout by Lost");
                    stockOutDisplayList.Clear();
                    stockOutDataGridView.DataSource = null;
                }
                else
                {
                    MessageBox.Show("There is an error!!");
                }
            }
            else
            {
                MessageBox.Show("There is no any selected Item!!");
            }
        }


    }
}
