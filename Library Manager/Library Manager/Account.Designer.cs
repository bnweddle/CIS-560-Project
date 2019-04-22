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
            this.uxBindingList = new System.Windows.Forms.BindingSource(this.components);
            this.uxCheckOutButton = new System.Windows.Forms.Button();
            this.uxListOfItemsDisplayed = new System.Windows.Forms.Label();
            this.uxReturnBook = new System.Windows.Forms.Button();
            this.uxReportQueries = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uxSearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uxDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxBindingList)).BeginInit();
            this.SuspendLayout();
            // 
            // uxDataView
            // 
            this.uxDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxDataView.Location = new System.Drawing.Point(323, 57);
            this.uxDataView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxDataView.Name = "uxDataView";
            this.uxDataView.Size = new System.Drawing.Size(565, 283);
            this.uxDataView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search Books in Library:";
            // 
            // uxSearchBox
            // 
            this.uxSearchBox.Location = new System.Drawing.Point(147, 41);
            this.uxSearchBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxSearchBox.Name = "uxSearchBox";
            this.uxSearchBox.Size = new System.Drawing.Size(100, 20);
            this.uxSearchBox.TabIndex = 2;
            // 
            // uxByAuthor
            // 
            this.uxByAuthor.AutoSize = true;
            this.uxByAuthor.Location = new System.Drawing.Point(26, 72);
            this.uxByAuthor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxByAuthor.Name = "uxByAuthor";
            this.uxByAuthor.Size = new System.Drawing.Size(87, 17);
            this.uxByAuthor.TabIndex = 3;
            this.uxByAuthor.TabStop = true;
            this.uxByAuthor.Text = "Author Name";
            this.uxByAuthor.UseVisualStyleBackColor = true;
            // 
            // uxByTitle
            // 
            this.uxByTitle.AutoSize = true;
            this.uxByTitle.Location = new System.Drawing.Point(26, 104);
            this.uxByTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxByTitle.Name = "uxByTitle";
            this.uxByTitle.Size = new System.Drawing.Size(76, 17);
            this.uxByTitle.TabIndex = 4;
            this.uxByTitle.TabStop = true;
            this.uxByTitle.Text = "Title Name";
            this.uxByTitle.UseVisualStyleBackColor = true;
            // 
            // uxCheckOutButton
            // 
            this.uxCheckOutButton.Location = new System.Drawing.Point(26, 141);
            this.uxCheckOutButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxCheckOutButton.Name = "uxCheckOutButton";
            this.uxCheckOutButton.Size = new System.Drawing.Size(110, 28);
            this.uxCheckOutButton.TabIndex = 5;
            this.uxCheckOutButton.Text = "Check Out Book(s)";
            this.uxCheckOutButton.UseVisualStyleBackColor = true;
            // 
            // uxListOfItemsDisplayed
            // 
            this.uxListOfItemsDisplayed.AutoSize = true;
            this.uxListOfItemsDisplayed.Location = new System.Drawing.Point(323, 26);
            this.uxListOfItemsDisplayed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxListOfItemsDisplayed.Name = "uxListOfItemsDisplayed";
            this.uxListOfItemsDisplayed.Size = new System.Drawing.Size(140, 13);
            this.uxListOfItemsDisplayed.TabIndex = 6;
            this.uxListOfItemsDisplayed.Text = "Current Books Checked Out";
            // 
            // uxReturnBook
            // 
            this.uxReturnBook.Location = new System.Drawing.Point(171, 141);
            this.uxReturnBook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxReturnBook.Name = "uxReturnBook";
            this.uxReturnBook.Size = new System.Drawing.Size(111, 28);
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
            "Over Due Books Past 3 Weeks"});
            this.uxReportQueries.Location = new System.Drawing.Point(118, 194);
            this.uxReportQueries.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxReportQueries.Name = "uxReportQueries";
            this.uxReportQueries.Size = new System.Drawing.Size(164, 21);
            this.uxReportQueries.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 197);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Report Queries";
            // 
            // uxSearchButton
            // 
            this.uxSearchButton.Location = new System.Drawing.Point(252, 41);
            this.uxSearchButton.Name = "uxSearchButton";
            this.uxSearchButton.Size = new System.Drawing.Size(30, 20);
            this.uxSearchButton.TabIndex = 11;
            this.uxSearchButton.Text = "Go";
            this.uxSearchButton.UseVisualStyleBackColor = true;
            this.uxSearchButton.Click += new System.EventHandler(this.uxSearchButton_Click);
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 366);
            this.Controls.Add(this.uxSearchButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uxReportQueries);
            this.Controls.Add(this.uxReturnBook);
            this.Controls.Add(this.uxListOfItemsDisplayed);
            this.Controls.Add(this.uxCheckOutButton);
            this.Controls.Add(this.uxByTitle);
            this.Controls.Add(this.uxByAuthor);
            this.Controls.Add(this.uxSearchBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxDataView);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button uxSearchButton;
    }
}