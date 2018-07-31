using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystem.Models;
using StockManagementSystem.BLL;
using StockManagementSystem.DAL;

namespace StockManagementSystem.UI.ItemSetup
{
    public partial class ItemSetupForm : Form
    {
        public ItemSetupForm()
        {
            InitializeComponent();
        }

        Item item = new Item();
        ItemManagement itemManagement = new ItemManagement();
        ItemRepository itemRepository = new ItemRepository();

        private void ItemSetupForm_Load(object sender, EventArgs e)
        {
            DataTable companydt = new DataTable();
            companydt = itemRepository.LoadCompany();
            companyComboBox.DataSource = companydt;

            companyComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            companyComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;

            DataTable categoryDt = new DataTable();
            categoryDt = itemRepository.LoadCategory();
            categoryComboBox.DataSource = categoryDt;

            categoryComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            categoryComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            item.Name = nameTextBox.Text;
            bool isExist = itemManagement.IsExisted(item);
            if (isExist)
            {
                itemErrorLabel.Text = "* This Item Already Existed!!";
                return;
            }
            itemErrorLabel.Text = "";
        }

        private void reorderTextBox_TextChanged(object sender, EventArgs e)
        {
            string temp = reorderTextBox.Text;
            foreach (char c in temp)
            {
                if (char.IsDigit(c) == false)
                {
                    reorderErrorLabel.Text = "* Invalid Reorder Number!!";
                    return;
                }

                reorderErrorLabel.Text = "";
            }

            if (string.IsNullOrWhiteSpace(temp))
            {
                reorderErrorLabel.Text = "* Invalid Reorder Number!!";
                return;
            }

            reorderErrorLabel.Text = "";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            item.Company = companyComboBox.GetItemText(companyComboBox.SelectedItem);
            item.Category = categoryComboBox.GetItemText(categoryComboBox.SelectedItem);
            item.Name = nameTextBox.Text;
            item.ErrorText = itemErrorLabel.Text;
            item.ReorderError = reorderErrorLabel.Text;

            bool verify = itemManagement.IsVerified(item);
            if (verify)
            {
                MessageBox.Show("Field Must Not Be Empty!!");
                return;
            }


            bool error = itemManagement.IsError(item);
            if (error)
            {
                MessageBox.Show("Please Resolve Your Error!!");
                return;
            }

            if (reorderTextBox.Text == "")
            {
                return;
            }
            item.Reorder = Convert.ToInt32(reorderTextBox.Text);

            bool isAdd = itemManagement.IsAdded(item);
            if (isAdd)
            {
                MessageBox.Show("New Item Successfully Add!!");
                nameTextBox.Clear();
                reorderTextBox.Clear();
                //companyComboBox.Items.Clear();
                //categoryComboBox.Items.Clear();
            }

        }

        //Override Form Close Button
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            MainForm.MainForm mainForm = new MainForm.MainForm();
            this.Hide();
            mainForm.Show();
        }

        
    }
}
