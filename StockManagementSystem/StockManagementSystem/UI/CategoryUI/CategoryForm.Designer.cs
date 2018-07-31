﻿namespace StockManagementSystem.UI.CategoryUI
{
    partial class CategoryForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.categoryDataGridView = new System.Windows.Forms.DataGridView();
            this.CategoryGridName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.categoryErrorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(211, 60);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(233, 20);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(369, 86);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // categoryDataGridView
            // 
            this.categoryDataGridView.AllowUserToAddRows = false;
            this.categoryDataGridView.AllowUserToDeleteRows = false;
            this.categoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.categoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategoryGridName});
            this.categoryDataGridView.Location = new System.Drawing.Point(149, 132);
            this.categoryDataGridView.Name = "categoryDataGridView";
            this.categoryDataGridView.ReadOnly = true;
            this.categoryDataGridView.Size = new System.Drawing.Size(505, 150);
            this.categoryDataGridView.TabIndex = 3;
            this.categoryDataGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.categoryDataGridView_MouseDoubleClick);
            // 
            // CategoryGridName
            // 
            this.CategoryGridName.DataPropertyName = "Name";
            this.CategoryGridName.HeaderText = "Name";
            this.CategoryGridName.Name = "CategoryGridName";
            this.CategoryGridName.ReadOnly = true;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(278, 86);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 4;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Visible = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // categoryErrorLabel
            // 
            this.categoryErrorLabel.AutoSize = true;
            this.categoryErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.categoryErrorLabel.Location = new System.Drawing.Point(450, 63);
            this.categoryErrorLabel.Name = "categoryErrorLabel";
            this.categoryErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.categoryErrorLabel.TabIndex = 5;
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 351);
            this.Controls.Add(this.categoryErrorLabel);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.categoryDataGridView);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "CategoryForm";
            this.Text = "Category Setup";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.DataGridView categoryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryGridName;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label categoryErrorLabel;
    }
}