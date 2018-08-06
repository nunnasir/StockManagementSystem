namespace StockManagementSystem.UI.StockInUI
{
    partial class StockInForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.itemComboBox = new System.Windows.Forms.ComboBox();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reorderErrorLabel = new System.Windows.Forms.Label();
            this.itemErrorLabel = new System.Windows.Forms.Label();
            this.availableTextBox = new System.Windows.Forms.TextBox();
            this.reorderTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.stockQuantityTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.stockinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockQuantityLabel = new System.Windows.Forms.Label();
            this.ReorderErrorLavel = new System.Windows.Forms.Label();
            this.stockInDataGridView = new System.Windows.Forms.DataGridView();
            this.StockInGridItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockInGridCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockInGridQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.compannyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockInDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // companyComboBox
            // 
            this.companyComboBox.DataSource = this.compannyBindingSource;
            this.companyComboBox.DisplayMember = "Name";
            this.companyComboBox.FormattingEnabled = true;
            this.companyComboBox.Location = new System.Drawing.Point(303, 11);
            this.companyComboBox.Name = "companyComboBox";
            this.companyComboBox.Size = new System.Drawing.Size(274, 21);
            this.companyComboBox.TabIndex = 4;
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
            this.categoryComboBox.Location = new System.Drawing.Point(303, 37);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(274, 21);
            this.categoryComboBox.TabIndex = 5;
            this.categoryComboBox.ValueMember = "Id";
            this.categoryComboBox.TextChanged += new System.EventHandler(this.categoryComboBox_TextChanged);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(StockManagementSystem.Models.Category);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(215, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Company";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(248, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Item";
            // 
            // itemComboBox
            // 
            this.itemComboBox.DataSource = this.itemBindingSource;
            this.itemComboBox.DisplayMember = "Name";
            this.itemComboBox.FormattingEnabled = true;
            this.itemComboBox.Location = new System.Drawing.Point(303, 63);
            this.itemComboBox.Name = "itemComboBox";
            this.itemComboBox.Size = new System.Drawing.Size(274, 21);
            this.itemComboBox.TabIndex = 5;
            this.itemComboBox.ValueMember = "Id";
            this.itemComboBox.SelectedIndexChanged += new System.EventHandler(this.itemComboBox_SelectedIndexChanged);
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(StockManagementSystem.Models.Item);
            // 
            // reorderErrorLabel
            // 
            this.reorderErrorLabel.AutoSize = true;
            this.reorderErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.reorderErrorLabel.Location = new System.Drawing.Point(583, 117);
            this.reorderErrorLabel.Name = "reorderErrorLabel";
            this.reorderErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.reorderErrorLabel.TabIndex = 10;
            // 
            // itemErrorLabel
            // 
            this.itemErrorLabel.AutoSize = true;
            this.itemErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.itemErrorLabel.Location = new System.Drawing.Point(584, 93);
            this.itemErrorLabel.Name = "itemErrorLabel";
            this.itemErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.itemErrorLabel.TabIndex = 11;
            // 
            // availableTextBox
            // 
            this.availableTextBox.Location = new System.Drawing.Point(303, 114);
            this.availableTextBox.Name = "availableTextBox";
            this.availableTextBox.ReadOnly = true;
            this.availableTextBox.Size = new System.Drawing.Size(274, 20);
            this.availableTextBox.TabIndex = 8;
            // 
            // reorderTextBox
            // 
            this.reorderTextBox.Location = new System.Drawing.Point(303, 89);
            this.reorderTextBox.Name = "reorderTextBox";
            this.reorderTextBox.ReadOnly = true;
            this.reorderTextBox.Size = new System.Drawing.Size(274, 20);
            this.reorderTextBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(160, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Available Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(184, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Reorder Level";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(167, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Stock In Quantity";
            // 
            // stockQuantityTextBox
            // 
            this.stockQuantityTextBox.Location = new System.Drawing.Point(303, 141);
            this.stockQuantityTextBox.Name = "stockQuantityTextBox";
            this.stockQuantityTextBox.Size = new System.Drawing.Size(274, 20);
            this.stockQuantityTextBox.TabIndex = 8;
            this.stockQuantityTextBox.TextChanged += new System.EventHandler(this.stockQuantityTextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(583, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 10;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(502, 170);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 12;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // stockinBindingSource
            // 
            this.stockinBindingSource.DataSource = typeof(StockManagementSystem.Models.Stockin);
            // 
            // stockQuantityLabel
            // 
            this.stockQuantityLabel.AutoSize = true;
            this.stockQuantityLabel.ForeColor = System.Drawing.Color.Red;
            this.stockQuantityLabel.Location = new System.Drawing.Point(584, 145);
            this.stockQuantityLabel.Name = "stockQuantityLabel";
            this.stockQuantityLabel.Size = new System.Drawing.Size(0, 13);
            this.stockQuantityLabel.TabIndex = 13;
            // 
            // ReorderErrorLavel
            // 
            this.ReorderErrorLavel.AutoSize = true;
            this.ReorderErrorLavel.ForeColor = System.Drawing.Color.Red;
            this.ReorderErrorLavel.Location = new System.Drawing.Point(583, 117);
            this.ReorderErrorLavel.Name = "ReorderErrorLavel";
            this.ReorderErrorLavel.Size = new System.Drawing.Size(0, 13);
            this.ReorderErrorLavel.TabIndex = 14;
            // 
            // stockInDataGridView
            // 
            this.stockInDataGridView.AllowUserToAddRows = false;
            this.stockInDataGridView.AllowUserToDeleteRows = false;
            this.stockInDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stockInDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockInDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StockInGridItem,
            this.StockInGridCompany,
            this.StockInGridQuantity});
            this.stockInDataGridView.Location = new System.Drawing.Point(73, 224);
            this.stockInDataGridView.Name = "stockInDataGridView";
            this.stockInDataGridView.ReadOnly = true;
            this.stockInDataGridView.Size = new System.Drawing.Size(662, 131);
            this.stockInDataGridView.TabIndex = 15;
            // 
            // StockInGridItem
            // 
            this.StockInGridItem.DataPropertyName = "Item";
            this.StockInGridItem.HeaderText = "Item";
            this.StockInGridItem.Name = "StockInGridItem";
            this.StockInGridItem.ReadOnly = true;
            // 
            // StockInGridCompany
            // 
            this.StockInGridCompany.DataPropertyName = "Company";
            this.StockInGridCompany.HeaderText = "Company";
            this.StockInGridCompany.Name = "StockInGridCompany";
            this.StockInGridCompany.ReadOnly = true;
            // 
            // StockInGridQuantity
            // 
            this.StockInGridQuantity.DataPropertyName = "Quantity";
            this.StockInGridQuantity.HeaderText = "Quantity";
            this.StockInGridQuantity.Name = "StockInGridQuantity";
            this.StockInGridQuantity.ReadOnly = true;
            // 
            // StockInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 376);
            this.Controls.Add(this.stockInDataGridView);
            this.Controls.Add(this.ReorderErrorLavel);
            this.Controls.Add(this.stockQuantityLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.reorderErrorLabel);
            this.Controls.Add(this.itemErrorLabel);
            this.Controls.Add(this.stockQuantityTextBox);
            this.Controls.Add(this.availableTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.reorderTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.companyComboBox);
            this.Controls.Add(this.itemComboBox);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StockInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock In";
            this.Load += new System.EventHandler(this.StockInForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.compannyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockInDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox companyComboBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox itemComboBox;
        private System.Windows.Forms.Label reorderErrorLabel;
        private System.Windows.Forms.Label itemErrorLabel;
        private System.Windows.Forms.TextBox availableTextBox;
        private System.Windows.Forms.TextBox reorderTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox stockQuantityTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.BindingSource stockinBindingSource;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.BindingSource compannyBindingSource;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.Label stockQuantityLabel;
        private System.Windows.Forms.Label ReorderErrorLavel;
        private System.Windows.Forms.DataGridView stockInDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockInGridItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockInGridCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockInGridQuantity;
    }
}