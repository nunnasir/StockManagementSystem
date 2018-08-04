namespace StockManagementSystem.UI.ItemSetup
{
    partial class ItemSetupForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.companyComboBox = new System.Windows.Forms.ComboBox();
            this.compannyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.reorderTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemErrorLabel = new System.Windows.Forms.Label();
            this.reorderErrorLabel = new System.Windows.Forms.Label();
            this.itemDataGridView = new System.Windows.Forms.DataGridView();
            this.ItemGridItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemGridCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemGridCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemGridReorder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compannyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DataSource = this.categoryBindingSource;
            this.categoryComboBox.DisplayMember = "Name";
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(302, 52);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(274, 21);
            this.categoryComboBox.TabIndex = 1;
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
            this.label2.Location = new System.Drawing.Point(211, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Company";
            // 
            // companyComboBox
            // 
            this.companyComboBox.DataSource = this.compannyBindingSource;
            this.companyComboBox.DisplayMember = "Name";
            this.companyComboBox.FormattingEnabled = true;
            this.companyComboBox.Location = new System.Drawing.Point(302, 23);
            this.companyComboBox.Name = "companyComboBox";
            this.companyComboBox.Size = new System.Drawing.Size(274, 21);
            this.companyComboBox.TabIndex = 1;
            this.companyComboBox.ValueMember = "Id";
            // 
            // compannyBindingSource
            // 
            this.compannyBindingSource.DataSource = typeof(StockManagementSystem.Models.Companny);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(203, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Item Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(302, 81);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(274, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(180, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Reorder Level";
            // 
            // reorderTextBox
            // 
            this.reorderTextBox.Location = new System.Drawing.Point(302, 109);
            this.reorderTextBox.Name = "reorderTextBox";
            this.reorderTextBox.Size = new System.Drawing.Size(274, 20);
            this.reorderTextBox.TabIndex = 2;
            this.reorderTextBox.TextChanged += new System.EventHandler(this.reorderTextBox_TextChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(501, 137);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(StockManagementSystem.Models.Item);
            // 
            // itemErrorLabel
            // 
            this.itemErrorLabel.AutoSize = true;
            this.itemErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.itemErrorLabel.Location = new System.Drawing.Point(583, 85);
            this.itemErrorLabel.Name = "itemErrorLabel";
            this.itemErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.itemErrorLabel.TabIndex = 4;
            // 
            // reorderErrorLabel
            // 
            this.reorderErrorLabel.AutoSize = true;
            this.reorderErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.reorderErrorLabel.Location = new System.Drawing.Point(582, 111);
            this.reorderErrorLabel.Name = "reorderErrorLabel";
            this.reorderErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.reorderErrorLabel.TabIndex = 4;
            // 
            // itemDataGridView
            // 
            this.itemDataGridView.AllowUserToAddRows = false;
            this.itemDataGridView.AllowUserToDeleteRows = false;
            this.itemDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.itemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemGridItem,
            this.ItemGridCompany,
            this.ItemGridCategory,
            this.ItemGridReorder});
            this.itemDataGridView.Location = new System.Drawing.Point(90, 176);
            this.itemDataGridView.Name = "itemDataGridView";
            this.itemDataGridView.ReadOnly = true;
            this.itemDataGridView.Size = new System.Drawing.Size(635, 145);
            this.itemDataGridView.TabIndex = 5;
            // 
            // ItemGridItem
            // 
            this.ItemGridItem.DataPropertyName = "Name";
            this.ItemGridItem.HeaderText = "Item";
            this.ItemGridItem.Name = "ItemGridItem";
            this.ItemGridItem.ReadOnly = true;
            // 
            // ItemGridCompany
            // 
            this.ItemGridCompany.DataPropertyName = "Company";
            this.ItemGridCompany.HeaderText = "Company";
            this.ItemGridCompany.Name = "ItemGridCompany";
            this.ItemGridCompany.ReadOnly = true;
            // 
            // ItemGridCategory
            // 
            this.ItemGridCategory.DataPropertyName = "Category";
            this.ItemGridCategory.HeaderText = "Category";
            this.ItemGridCategory.Name = "ItemGridCategory";
            this.ItemGridCategory.ReadOnly = true;
            // 
            // ItemGridReorder
            // 
            this.ItemGridReorder.DataPropertyName = "Reorder";
            this.ItemGridReorder.HeaderText = "Reorder";
            this.ItemGridReorder.Name = "ItemGridReorder";
            this.ItemGridReorder.ReadOnly = true;
            // 
            // ItemSetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 351);
            this.Controls.Add(this.itemDataGridView);
            this.Controls.Add(this.reorderErrorLabel);
            this.Controls.Add(this.itemErrorLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.reorderTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.companyComboBox);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "ItemSetupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Setup";
            this.Load += new System.EventHandler(this.ItemSetupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compannyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox companyComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox reorderTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.BindingSource compannyBindingSource;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.Label itemErrorLabel;
        private System.Windows.Forms.Label reorderErrorLabel;
        private System.Windows.Forms.DataGridView itemDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemGridItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemGridCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemGridCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemGridReorder;
    }
}