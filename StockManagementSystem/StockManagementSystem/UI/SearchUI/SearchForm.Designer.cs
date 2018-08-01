namespace StockManagementSystem.UI.SearchUI
{
    partial class SearchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.companyComboBox = new System.Windows.Forms.ComboBox();
            this.compannyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.summeryIttemDataGridView = new System.Windows.Forms.DataGridView();
            this.GridSumItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridSumCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridSumCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridSumAvQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridSumReorderLvl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.compannyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.summeryIttemDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // companyComboBox
            // 
            this.companyComboBox.DataSource = this.compannyBindingSource;
            this.companyComboBox.DisplayMember = "Name";
            this.companyComboBox.FormattingEnabled = true;
            this.companyComboBox.Location = new System.Drawing.Point(298, 38);
            this.companyComboBox.Name = "companyComboBox";
            this.companyComboBox.Size = new System.Drawing.Size(274, 21);
            this.companyComboBox.TabIndex = 8;
            this.companyComboBox.ValueMember = "Id";
            // 
            // compannyBindingSource
            // 
            this.compannyBindingSource.DataSource = typeof(StockManagementSystem.Models.Companny);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DataSource = this.categoryBindingSource;
            this.categoryComboBox.DisplayMember = "Name";
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(298, 69);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(274, 21);
            this.categoryComboBox.TabIndex = 9;
            this.categoryComboBox.ValueMember = "Id";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(StockManagementSystem.Models.Category);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Company";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Category";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(497, 99);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 13;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // summeryIttemDataGridView
            // 
            this.summeryIttemDataGridView.AllowUserToAddRows = false;
            this.summeryIttemDataGridView.AllowUserToDeleteRows = false;
            this.summeryIttemDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.summeryIttemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.summeryIttemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GridSumItem,
            this.GridSumCompany,
            this.GridSumCategory,
            this.GridSumAvQuantity,
            this.GridSumReorderLvl});
            this.summeryIttemDataGridView.Location = new System.Drawing.Point(48, 144);
            this.summeryIttemDataGridView.Name = "summeryIttemDataGridView";
            this.summeryIttemDataGridView.ReadOnly = true;
            this.summeryIttemDataGridView.Size = new System.Drawing.Size(713, 164);
            this.summeryIttemDataGridView.TabIndex = 14;
            // 
            // GridSumItem
            // 
            this.GridSumItem.DataPropertyName = "ItemName";
            this.GridSumItem.HeaderText = "Item";
            this.GridSumItem.Name = "GridSumItem";
            this.GridSumItem.ReadOnly = true;
            // 
            // GridSumCompany
            // 
            this.GridSumCompany.DataPropertyName = "CompanyName";
            this.GridSumCompany.HeaderText = "Company";
            this.GridSumCompany.Name = "GridSumCompany";
            this.GridSumCompany.ReadOnly = true;
            // 
            // GridSumCategory
            // 
            this.GridSumCategory.DataPropertyName = "CategoryName";
            this.GridSumCategory.HeaderText = "Category";
            this.GridSumCategory.Name = "GridSumCategory";
            this.GridSumCategory.ReadOnly = true;
            // 
            // GridSumAvQuantity
            // 
            this.GridSumAvQuantity.DataPropertyName = "Quantity";
            this.GridSumAvQuantity.HeaderText = "Available Quantity";
            this.GridSumAvQuantity.Name = "GridSumAvQuantity";
            this.GridSumAvQuantity.ReadOnly = true;
            // 
            // GridSumReorderLvl
            // 
            this.GridSumReorderLvl.DataPropertyName = "Reorder";
            this.GridSumReorderLvl.HeaderText = "Reorder Level";
            this.GridSumReorderLvl.Name = "GridSumReorderLvl";
            this.GridSumReorderLvl.ReadOnly = true;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 351);
            this.Controls.Add(this.summeryIttemDataGridView);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.companyComboBox);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search and View Item\'s Summery";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.compannyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.summeryIttemDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox companyComboBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView summeryIttemDataGridView;
        private System.Windows.Forms.BindingSource compannyBindingSource;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridSumItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridSumCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridSumCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridSumAvQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridSumReorderLvl;
    }
}