using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystem.Models;
using StockManagementSystem.BLL;
using StockManagementSystem.DAL;

namespace StockManagementSystem.UI.Company
{
    public partial class CompanyForm : Form
    {
        public CompanyForm()
        {
            InitializeComponent();
        }

        Companny companny = new Companny();
        CompanyManagement companyManagement = new CompanyManagement();
        CompanyRepository companyRepository = new CompanyRepository();

        //Save Company
        private void SaveButton_Click(object sender, EventArgs e)
        {
            companny.Name = nameTextBox.Text;
            companny.ErrorText = categoryErrorLabel.Text;

            bool isExist = companyManagement.IsExisted(companny);
            if (isExist)
            {
                categoryErrorLabel.Text = "*This Company Already Existed!!";
                return;
            }

            bool verify = companyManagement.IsVerified(companny);
            if (verify)
            {
                categoryErrorLabel.Text = "*Field Must Not Be Empty!!!!";
                return;
            }

            bool isAdd = companyManagement.IsAdded(companny);
            if (isAdd)
            {
                nameTextBox.Clear();
                categoryErrorLabel.Text = "";

                DataTable dt = new DataTable();
                dt = companyRepository.AddCompany();
                companyDataGridView.DataSource = dt;
            }
        }

        //Show Item TextBox on DoubleClick
        private void companyDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            nameTextBox.Text = companyDataGridView.CurrentRow.Cells[0].Value.ToString();
            companny.OldName = nameTextBox.Text;
            UpdateButton.Show();
            UpdateButton.Location = new Point(369, 86);
            SaveButton.Hide();
        }

        //Update Company
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            companny.Name = nameTextBox.Text;

            bool verify = companyManagement.IsVerified(companny);
            if (verify)
            {
                categoryErrorLabel.Text = "*Field Must Not Be Empty!!!!";
                return;
            }

            bool isExist = companyManagement.IsExisted(companny);
            if (isExist)
            {
                categoryErrorLabel.Text = "*This Company Already Existed!!";
                return;
            }

            bool isUpdate = companyManagement.IsUpdated(companny);
            if (isUpdate)
            {
                MessageBox.Show("Update Successfully!!");
                categoryErrorLabel.Text = "";
                nameTextBox.Clear();
                UpdateButton.Hide();
                SaveButton.Show();
                DataTable dt = new DataTable();
                dt = companyRepository.AddCompany();
                companyDataGridView.DataSource = dt;
            }
        }

        //Form Load
        private void CompanyForm_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = companyRepository.AddCompany();
            companyDataGridView.DataSource = dt;
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
