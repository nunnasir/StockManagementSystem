namespace StockManagementSystem.UI.MainForm
{
    partial class MainForm
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
            this.CategoryButton = new System.Windows.Forms.Button();
            this.CompanyButton = new System.Windows.Forms.Button();
            this.ItemButton = new System.Windows.Forms.Button();
            this.StockInButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.StockOutButton = new System.Windows.Forms.Button();
            this.DateSearchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CategoryButton
            // 
            this.CategoryButton.Location = new System.Drawing.Point(532, 43);
            this.CategoryButton.Name = "CategoryButton";
            this.CategoryButton.Size = new System.Drawing.Size(157, 28);
            this.CategoryButton.TabIndex = 0;
            this.CategoryButton.Text = "Category Setup";
            this.CategoryButton.UseVisualStyleBackColor = true;
            this.CategoryButton.Click += new System.EventHandler(this.CategoryButton_Click);
            // 
            // CompanyButton
            // 
            this.CompanyButton.Location = new System.Drawing.Point(532, 78);
            this.CompanyButton.Name = "CompanyButton";
            this.CompanyButton.Size = new System.Drawing.Size(157, 28);
            this.CompanyButton.TabIndex = 0;
            this.CompanyButton.Text = "Companny Setup";
            this.CompanyButton.UseVisualStyleBackColor = true;
            this.CompanyButton.Click += new System.EventHandler(this.CompanyButton_Click);
            // 
            // ItemButton
            // 
            this.ItemButton.Location = new System.Drawing.Point(532, 112);
            this.ItemButton.Name = "ItemButton";
            this.ItemButton.Size = new System.Drawing.Size(157, 28);
            this.ItemButton.TabIndex = 0;
            this.ItemButton.Text = "Item Setup";
            this.ItemButton.UseVisualStyleBackColor = true;
            this.ItemButton.Click += new System.EventHandler(this.ItemButton_Click);
            // 
            // StockInButton
            // 
            this.StockInButton.Location = new System.Drawing.Point(532, 146);
            this.StockInButton.Name = "StockInButton";
            this.StockInButton.Size = new System.Drawing.Size(157, 28);
            this.StockInButton.TabIndex = 0;
            this.StockInButton.Text = "Stock in";
            this.StockInButton.UseVisualStyleBackColor = true;
            this.StockInButton.Click += new System.EventHandler(this.StockInButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(532, 214);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(157, 28);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = "Search Item";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // StockOutButton
            // 
            this.StockOutButton.Location = new System.Drawing.Point(532, 180);
            this.StockOutButton.Name = "StockOutButton";
            this.StockOutButton.Size = new System.Drawing.Size(157, 28);
            this.StockOutButton.TabIndex = 0;
            this.StockOutButton.Text = "Stock Out";
            this.StockOutButton.UseVisualStyleBackColor = true;
            this.StockOutButton.Click += new System.EventHandler(this.StockOutButton_Click);
            // 
            // DateSearchButton
            // 
            this.DateSearchButton.Location = new System.Drawing.Point(532, 248);
            this.DateSearchButton.Name = "DateSearchButton";
            this.DateSearchButton.Size = new System.Drawing.Size(157, 28);
            this.DateSearchButton.TabIndex = 0;
            this.DateSearchButton.Text = "Date Search";
            this.DateSearchButton.UseVisualStyleBackColor = true;
            this.DateSearchButton.Click += new System.EventHandler(this.DateSearchButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 351);
            this.Controls.Add(this.DateSearchButton);
            this.Controls.Add(this.StockInButton);
            this.Controls.Add(this.StockOutButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.CompanyButton);
            this.Controls.Add(this.ItemButton);
            this.Controls.Add(this.CategoryButton);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CategoryButton;
        private System.Windows.Forms.Button CompanyButton;
        private System.Windows.Forms.Button ItemButton;
        private System.Windows.Forms.Button StockInButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button StockOutButton;
        private System.Windows.Forms.Button DateSearchButton;
    }
}