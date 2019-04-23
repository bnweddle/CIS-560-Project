namespace Library_Manager
{
    partial class Account
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
            this.uxDataView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.uxSearchBox = new System.Windows.Forms.TextBox();
            this.uxByAuthor = new System.Windows.Forms.RadioButton();
            this.uxByTitle = new System.Windows.Forms.RadioButton();
            this.uxCheckOutButton = new System.Windows.Forms.Button();
            this.uxListOfItemsDisplayed = new System.Windows.Forms.Label();
            this.uxReturnBook = new System.Windows.Forms.Button();
            this.uxReportQueries = new System.Windows.Forms.ComboBox();
            this.uxSearchButton = new System.Windows.Forms.Button();
            this.uxReportButton = new System.Windows.Forms.Button();
            this.authorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uxBindingList = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.uxDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxBindingList)).BeginInit();
            this.SuspendLayout();
            // 
            // uxDataView
            // 
            this.uxDataView.AutoGenerateColumns = false;
            this.uxDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.authorIDDataGridViewTextBoxColumn});
            this.uxDataView.DataSource = this.uxBindingList;
            this.uxDataView.Location = new System.Drawing.Point(431, 70);
            this.uxDataView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxDataView.Name = "uxDataView";
            this.uxDataView.Size = new System.Drawing.Size(753, 348);
            this.uxDataView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search Books in Library:";
            // 
            // uxSearchBox
            // 
            this.uxSearchBox.Location = new System.Drawing.Point(196, 50);
            this.uxSearchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxSearchBox.Name = "uxSearchBox";
            this.uxSearchBox.Size = new System.Drawing.Size(132, 22);
            this.uxSearchBox.TabIndex = 2;
            // 
            // uxByAuthor
            // 
            this.uxByAuthor.AutoSize = true;
            this.uxByAuthor.Location = new System.Drawing.Point(35, 89);
            this.uxByAuthor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxByAuthor.Name = "uxByAuthor";
            this.uxByAuthor.Size = new System.Drawing.Size(112, 21);
            this.uxByAuthor.TabIndex = 3;
            this.uxByAuthor.TabStop = true;
            this.uxByAuthor.Text = "Author Name";
            this.uxByAuthor.UseVisualStyleBackColor = true;
            // 
            // uxByTitle
            // 
            this.uxByTitle.AutoSize = true;
            this.uxByTitle.Location = new System.Drawing.Point(35, 128);
            this.uxByTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxByTitle.Name = "uxByTitle";
            this.uxByTitle.Size = new System.Drawing.Size(97, 21);
            this.uxByTitle.TabIndex = 4;
            this.uxByTitle.TabStop = true;
            this.uxByTitle.Text = "Title Name";
            this.uxByTitle.UseVisualStyleBackColor = true;
            // 
            // uxCheckOutButton
            // 
            this.uxCheckOutButton.Location = new System.Drawing.Point(35, 174);
            this.uxCheckOutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxCheckOutButton.Name = "uxCheckOutButton";
            this.uxCheckOutButton.Size = new System.Drawing.Size(147, 34);
            this.uxCheckOutButton.TabIndex = 5;
            this.uxCheckOutButton.Text = "Check Out Book(s)";
            this.uxCheckOutButton.UseVisualStyleBackColor = true;
            // 
            // uxListOfItemsDisplayed
            // 
            this.uxListOfItemsDisplayed.AutoSize = true;
            this.uxListOfItemsDisplayed.Location = new System.Drawing.Point(431, 32);
            this.uxListOfItemsDisplayed.Name = "uxListOfItemsDisplayed";
            this.uxListOfItemsDisplayed.Size = new System.Drawing.Size(184, 17);
            this.uxListOfItemsDisplayed.TabIndex = 6;
            this.uxListOfItemsDisplayed.Text = "Current Books Checked Out";
            // 
            // uxReturnBook
            // 
            this.uxReturnBook.Location = new System.Drawing.Point(228, 174);
            this.uxReturnBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxReturnBook.Name = "uxReturnBook";
            this.uxReturnBook.Size = new System.Drawing.Size(148, 34);
            this.uxReturnBook.TabIndex = 8;
            this.uxReturnBook.Text = "Return Book(s)";
            this.uxReturnBook.UseVisualStyleBackColor = true;
            // 
            // uxReportQueries
            // 
            this.uxReportQueries.DisplayMember = "Hello";
            this.uxReportQueries.FormattingEnabled = true;
            this.uxReportQueries.Items.AddRange(new object[] {
            "Most Popular Books",
            "Most Popular Authors",
            "Number Of Books in All",
            "Over Due Books Past a Month"});
            this.uxReportQueries.Location = new System.Drawing.Point(35, 241);
            this.uxReportQueries.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxReportQueries.Name = "uxReportQueries";
            this.uxReportQueries.Size = new System.Drawing.Size(217, 24);
            this.uxReportQueries.TabIndex = 9;
            // 
            // uxSearchButton
            // 
            this.uxSearchButton.Location = new System.Drawing.Point(336, 50);
            this.uxSearchButton.Margin = new System.Windows.Forms.Padding(4);
            this.uxSearchButton.Name = "uxSearchButton";
            this.uxSearchButton.Size = new System.Drawing.Size(40, 25);
            this.uxSearchButton.TabIndex = 11;
            this.uxSearchButton.Text = "Go";
            this.uxSearchButton.UseVisualStyleBackColor = true;
            this.uxSearchButton.Click += new System.EventHandler(this.uxSearchButton_Click);
            // 
            // uxReportButton
            // 
            this.uxReportButton.Location = new System.Drawing.Point(271, 241);
            this.uxReportButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxReportButton.Name = "uxReportButton";
            this.uxReportButton.Size = new System.Drawing.Size(105, 25);
            this.uxReportButton.TabIndex = 12;
            this.uxReportButton.Text = "Report";
            this.uxReportButton.UseVisualStyleBackColor = true;
            this.uxReportButton.Click += new System.EventHandler(this.uxReportButton_Click);
            // 
            // authorIDDataGridViewTextBoxColumn
            // 
            this.authorIDDataGridViewTextBoxColumn.DataPropertyName = "AuthorID";
            this.authorIDDataGridViewTextBoxColumn.HeaderText = "AuthorID";
            this.authorIDDataGridViewTextBoxColumn.Name = "authorIDDataGridViewTextBoxColumn";
            this.authorIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uxBindingList
            // 
            this.uxBindingList.DataMember = "authorBindingList";
            this.uxBindingList.DataSource = typeof(Library_Manager.Account);
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 450);
            this.Controls.Add(this.uxReportButton);
            this.Controls.Add(this.uxSearchButton);
            this.Controls.Add(this.uxReportQueries);
            this.Controls.Add(this.uxReturnBook);
            this.Controls.Add(this.uxListOfItemsDisplayed);
            this.Controls.Add(this.uxCheckOutButton);
            this.Controls.Add(this.uxByTitle);
            this.Controls.Add(this.uxByAuthor);
            this.Controls.Add(this.uxSearchBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxDataView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Account";
            this.Text = "Library";
            ((System.ComponentModel.ISupportInitialize)(this.uxDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxBindingList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView uxDataView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uxSearchBox;
        private System.Windows.Forms.RadioButton uxByAuthor;
        private System.Windows.Forms.RadioButton uxByTitle;
        private System.Windows.Forms.BindingSource uxBindingList;
        private System.Windows.Forms.Button uxCheckOutButton;
        private System.Windows.Forms.Label uxListOfItemsDisplayed;
        private System.Windows.Forms.Button uxReturnBook;
        private System.Windows.Forms.ComboBox uxReportQueries;
        private System.Windows.Forms.Button uxSearchButton;
        private System.Windows.Forms.Button uxReportButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorIDDataGridViewTextBoxColumn;
    }
}