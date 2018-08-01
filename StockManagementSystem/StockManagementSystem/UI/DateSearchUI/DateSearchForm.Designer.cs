namespace StockManagementSystem.UI.DateSearchUI
{
    partial class DateSearchForm
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
            this.summeryIttemDataGridView = new System.Windows.Forms.DataGridView();
            this.SearchButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DateSearchGridItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateSearchGridQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.summeryIttemDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // summeryIttemDataGridView
            // 
            this.summeryIttemDataGridView.AllowUserToAddRows = false;
            this.summeryIttemDataGridView.AllowUserToDeleteRows = false;
            this.summeryIttemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.summeryIttemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateSearchGridItem,
            this.DateSearchGridQuantity});
            this.summeryIttemDataGridView.Location = new System.Drawing.Point(46, 146);
            this.summeryIttemDataGridView.Name = "summeryIttemDataGridView";
            this.summeryIttemDataGridView.ReadOnly = true;
            this.summeryIttemDataGridView.Size = new System.Drawing.Size(713, 164);
            this.summeryIttemDataGridView.TabIndex = 20;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(495, 101);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 19;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(208, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "From Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "To Date";
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDateTimePicker.Location = new System.Drawing.Point(296, 40);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(274, 20);
            this.fromDateTimePicker.TabIndex = 21;
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDateTimePicker.Location = new System.Drawing.Point(296, 71);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(274, 20);
            this.toDateTimePicker.TabIndex = 22;
            // 
            // DateSearchGridItem
            // 
            this.DateSearchGridItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateSearchGridItem.DataPropertyName = "ItemName";
            this.DateSearchGridItem.HeaderText = "Item";
            this.DateSearchGridItem.Name = "DateSearchGridItem";
            this.DateSearchGridItem.ReadOnly = true;
            // 
            // DateSearchGridQuantity
            // 
            this.DateSearchGridQuantity.DataPropertyName = "Quantity";
            this.DateSearchGridQuantity.HeaderText = "Sale Quantity";
            this.DateSearchGridQuantity.Name = "DateSearchGridQuantity";
            this.DateSearchGridQuantity.ReadOnly = true;
            this.DateSearchGridQuantity.Width = 135;
            // 
            // DateSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 351);
            this.Controls.Add(this.toDateTimePicker);
            this.Controls.Add(this.fromDateTimePicker);
            this.Controls.Add(this.summeryIttemDataGridView);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DateSearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Sales Between Two Dates";
            ((System.ComponentModel.ISupportInitialize)(this.summeryIttemDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView summeryIttemDataGridView;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.DateTimePicker toDateTimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateSearchGridItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateSearchGridQuantity;
    }
}