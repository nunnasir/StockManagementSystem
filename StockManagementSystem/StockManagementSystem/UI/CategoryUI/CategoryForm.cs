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
using StockManagementSystem.BLL;
using StockManagementSystem.Models;
using StockManagementSystem.DAL;


namespace StockManagementSystem.UI.CategoryUI
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        Category category = new Category();
        CategoryManagement categoryManagement = new CategoryManagement();
        CategoryRepository categoryRepository = new CategoryRepository();


        //Save Category
        private void SaveButton_Click(object sender, EventArgs e)
        {
            category.Name = nameTextBox.Text;
            category.ErrorText = categoryErrorLabel.Text;

            bool isExist = categoryManagement.IsExisted(category);
            if (isExist)
            {
                categoryErrorLabel.Text = "*This Categerory Already Existed!!";
                return;
            }
            categoryErrorLabel.Text = "";

            bool verify = categoryManagement.IsVerified(category);
            if (verify)
            {
                categoryErrorLabel.Text = "*Field Must Not Be Empty!!";
                return;
            }
            

            bool isAdd = categoryManagement.IsAdded(category);
            if (isAdd)
            {
                nameTextBox.Clear();
                categoryErrorLabel.Text = "";

                DataTable dt = new DataTable();
                dt = categoryRepository.AddCategory();
                categoryDataGridView.DataSource = dt;
            }

        }


        //Show Item TextBox on DoubleClick
        private void categoryDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            nameTextBox.Text = categoryDataGridView.CurrentRow.Cells[0].Value.ToString();
            category.OldName = nameTextBox.Text;
            UpdateButton.Show();
            UpdateButton.Location = new Point(369, 86);
            SaveButton.Hide();
        }

        //Update Category
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            category.Name = nameTextBox.Text;

            bool verify = categoryManagement.IsVerified(category);
            if (verify)
            {
                categoryErrorLabel.Text = "*Field Must Not Be Empty!!";
                return;
            }

            bool isExist = categoryManagement.IsExisted(category);
            if (isExist)
            {
                categoryErrorLabel.Text = "*This Categerory Already Existed!!";
                return;
            }

            bool isUpdate = categoryManagement.IsUpdated(category);
            if (isUpdate)
            {
                MessageBox.Show("Update Successfully!!");
                nameTextBox.Clear();
                categoryErrorLabel.Text = "";
                UpdateButton.Hide();
                SaveButton.Show();
                DataTable dt = new DataTable();
                dt = categoryRepository.AddCategory();
                categoryDataGridView.DataSource = dt;
            }
        }

        //Form Load
        private void CategoryForm_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = categoryRepository.AddCategory();
            categoryDataGridView.DataSource = dt;
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
