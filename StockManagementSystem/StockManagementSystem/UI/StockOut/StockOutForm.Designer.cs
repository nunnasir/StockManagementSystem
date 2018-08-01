namespace StockManagementSystem.UI.StockOut
{
    partial class StockOutForm
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
            this.AddButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.reorderErrorLabel = new System.Windows.Forms.Label();
            this.itemErrorLabel = new System.Windows.Forms.Label();
            this.stockQuantityTextBox = new System.Windows.Forms.TextBox();
            this.availableTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.reorderTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.companyComboBox = new System.Windows.Forms.ComboBox();
            this.itemComboBox = new System.Windows.Forms.ComboBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.stockOutDataGridView = new System.Windows.Forms.DataGridView();
            this.DamageButton = new System.Windows.Forms.Button();
            this.SellButton = new System.Windows.Forms.Button();
            this.LostButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stockOutDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(494, 179);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 28;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(575, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 25;
            // 
            // reorderErrorLabel
            // 
            this.reorderErrorLabel.AutoSize = true;
            this.reorderErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.reorderErrorLabel.Location = new System.Drawing.Point(575, 128);
            this.reorderErrorLabel.Name = "reorderErrorLabel";
            this.reorderErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.reorderErrorLabel.TabIndex = 26;
            // 
            // itemErrorLabel
            // 
            this.itemErrorLabel.AutoSize = true;
            this.itemErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.itemErrorLabel.Location = new System.Drawing.Point(576, 102);
            this.itemErrorLabel.Name = "itemErrorLabel";
            this.itemErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.itemErrorLabel.TabIndex = 27;
            // 
            // stockQuantityTextBox
            // 
            this.stockQuantityTextBox.Location = new System.Drawing.Point(295, 153);
            this.stockQuantityTextBox.Name = "stockQuantityTextBox";
            this.stockQuantityTextBox.Size = new System.Drawing.Size(274, 20);
            this.stockQuantityTextBox.TabIndex = 22;
            // 
            // availableTextBox
            // 
            this.availableTextBox.Location = new System.Drawing.Point(295, 125);
            this.availableTextBox.Name = "availableTextBox";
            this.availableTextBox.ReadOnly = true;
            this.availableTextBox.Size = new System.Drawing.Size(274, 20);
            this.availableTextBox.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(147, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Stock Out Quantity";
            // 
            // reorderTextBox
            // 
            this.reorderTextBox.Location = new System.Drawing.Point(295, 98);
            this.reorderTextBox.Name = "reorderTextBox";
            this.reorderTextBox.ReadOnly = true;
            this.reorderTextBox.Size = new System.Drawing.Size(274, 20);
            this.reorderTextBox.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(152, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Available Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(176, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Reorder Level";
            // 
            // companyComboBox
            // 
            this.companyComboBox.DisplayMember = "Name";
            this.companyComboBox.FormattingEnabled = true;
            this.companyComboBox.Location = new System.Drawing.Point(295, 16);
            this.companyComboBox.Name = "companyComboBox";
            this.companyComboBox.Size = new System.Drawing.Size(274, 21);
            this.companyComboBox.TabIndex = 16;
            this.companyComboBox.ValueMember = "Id";
            // 
            // itemComboBox
            // 
            this.itemComboBox.DisplayMember = "Name";
            this.itemComboBox.FormattingEnabled = true;
            this.itemComboBox.Location = new System.Drawing.Point(295, 70);
            this.itemComboBox.Name = "itemComboBox";
            this.itemComboBox.Size = new System.Drawing.Size(274, 21);
            this.itemComboBox.TabIndex = 17;
            this.itemComboBox.ValueMember = "Id";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DisplayMember = "Name";
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(295, 43);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(274, 21);
            this.categoryComboBox.TabIndex = 18;
            this.categoryComboBox.ValueMember = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(240, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(207, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Company";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Category";
            // 
            // stockOutDataGridView
            // 
            this.stockOutDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockOutDataGridView.Location = new System.Drawing.Point(67, 214);
            this.stockOutDataGridView.Name = "stockOutDataGridView";
            this.stockOutDataGridView.Size = new System.Drawing.Size(667, 150);
            this.stockOutDataGridView.TabIndex = 29;
            // 
            // DamageButton
            // 
            this.DamageButton.Location = new System.Drawing.Point(576, 371);
            this.DamageButton.Name = "DamageButton";
            this.DamageButton.Size = new System.Drawing.Size(75, 23);
            this.DamageButton.TabIndex = 28;
            this.DamageButton.Text = "Damage";
            this.DamageButton.UseVisualStyleBackColor = true;
            // 
            // SellButton
            // 
            this.SellButton.Location = new System.Drawing.Point(492, 371);
            this.SellButton.Name = "SellButton";
            this.SellButton.Size = new System.Drawing.Size(75, 23);
            this.SellButton.TabIndex = 28;
            this.SellButton.Text = "Sell";
            this.SellButton.UseVisualStyleBackColor = true;
            // 
            // LostButton
            // 
            this.LostButton.Location = new System.Drawing.Point(659, 371);
            this.LostButton.Name = "LostButton";
            this.LostButton.Size = new System.Drawing.Size(75, 23);
            this.LostButton.TabIndex = 28;
            this.LostButton.Text = "Lost";
            this.LostButton.UseVisualStyleBackColor = true;
            // 
            // StockOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 420);
            this.Controls.Add(this.stockOutDataGridView);
            this.Controls.Add(this.SellButton);
            this.Controls.Add(this.LostButton);
            this.Controls.Add(this.DamageButton);
            this.Controls.Add(this.AddButton);
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
            this.Name = "StockOutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Out";
            ((System.ComponentModel.ISupportInitialize)(this.stockOutDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label reorderErrorLabel;
        private System.Windows.Forms.Label itemErrorLabel;
        private System.Windows.Forms.TextBox stockQuantityTextBox;
        private System.Windows.Forms.TextBox availableTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox reorderTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox companyComboBox;
        private System.Windows.Forms.ComboBox itemComboBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView stockOutDataGridView;
        private System.Windows.Forms.Button DamageButton;
        private System.Windows.Forms.Button SellButton;
        private System.Windows.Forms.Button LostButton;
    }
}