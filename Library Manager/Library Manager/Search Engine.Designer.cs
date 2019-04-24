namespace Library_Manager
{
    partial class Search_Engine
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
            this.uxSearchButton = new System.Windows.Forms.Button();
            this.uxByTitle = new System.Windows.Forms.RadioButton();
            this.uxByAuthor = new System.Windows.Forms.RadioButton();
            this.uxSearchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uxDataView = new System.Windows.Forms.DataGridView();
            this.uxCheckOutButton = new System.Windows.Forms.Button();
            this.uxBindingList = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.uxDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxBindingList)).BeginInit();
            this.SuspendLayout();
            // 
            // uxSearchButton
            // 
            this.uxSearchButton.Location = new System.Drawing.Point(317, 6);
            this.uxSearchButton.Margin = new System.Windows.Forms.Padding(4);
            this.uxSearchButton.Name = "uxSearchButton";
            this.uxSearchButton.Size = new System.Drawing.Size(40, 25);
            this.uxSearchButton.TabIndex = 18;
            this.uxSearchButton.Text = "Go";
            this.uxSearchButton.UseVisualStyleBackColor = true;
            this.uxSearchButton.Click += new System.EventHandler(this.uxSearchButton_Click);
            // 
            // uxByTitle
            // 
            this.uxByTitle.AutoSize = true;
            this.uxByTitle.Location = new System.Drawing.Point(16, 84);
            this.uxByTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxByTitle.Name = "uxByTitle";
            this.uxByTitle.Size = new System.Drawing.Size(97, 21);
            this.uxByTitle.TabIndex = 16;
            this.uxByTitle.TabStop = true;
            this.uxByTitle.Text = "Title Name";
            this.uxByTitle.UseVisualStyleBackColor = true;
            // 
            // uxByAuthor
            // 
            this.uxByAuthor.AutoSize = true;
            this.uxByAuthor.Location = new System.Drawing.Point(16, 45);
            this.uxByAuthor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxByAuthor.Name = "uxByAuthor";
            this.uxByAuthor.Size = new System.Drawing.Size(112, 21);
            this.uxByAuthor.TabIndex = 15;
            this.uxByAuthor.TabStop = true;
            this.uxByAuthor.Text = "Author Name";
            this.uxByAuthor.UseVisualStyleBackColor = true;
            // 
            // uxSearchBox
            // 
            this.uxSearchBox.Location = new System.Drawing.Point(177, 6);
            this.uxSearchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxSearchBox.Name = "uxSearchBox";
            this.uxSearchBox.Size = new System.Drawing.Size(132, 22);
            this.uxSearchBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Search Books in Library:";
            // 
            // uxDataView
            // 
            this.uxDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxDataView.Location = new System.Drawing.Point(16, 126);
            this.uxDataView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxDataView.Name = "uxDataView";
            this.uxDataView.Size = new System.Drawing.Size(753, 348);
            this.uxDataView.TabIndex = 12;
            // 
            // uxCheckOutButton
            // 
            this.uxCheckOutButton.Enabled = false;
            this.uxCheckOutButton.Location = new System.Drawing.Point(622, 487);
            this.uxCheckOutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxCheckOutButton.Name = "uxCheckOutButton";
            this.uxCheckOutButton.Size = new System.Drawing.Size(147, 34);
            this.uxCheckOutButton.TabIndex = 19;
            this.uxCheckOutButton.Text = "Check Out Book";
            this.uxCheckOutButton.UseVisualStyleBackColor = true;
            // 
            // uxBindingList
            // 
            this.uxBindingList.DataMember = "titleBindingList";
            this.uxBindingList.DataSource = typeof(Library_Manager.Search_Engine);
            // 
            // Search_Engine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 532);
            this.Controls.Add(this.uxCheckOutButton);
            this.Controls.Add(this.uxSearchButton);
            this.Controls.Add(this.uxByTitle);
            this.Controls.Add(this.uxByAuthor);
            this.Controls.Add(this.uxSearchBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxDataView);
            this.Name = "Search_Engine";
            this.Text = "Search Engine";
            ((System.ComponentModel.ISupportInitialize)(this.uxDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxBindingList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxSearchButton;
        private System.Windows.Forms.RadioButton uxByTitle;
        private System.Windows.Forms.RadioButton uxByAuthor;
        private System.Windows.Forms.TextBox uxSearchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView uxDataView;
        private System.Windows.Forms.BindingSource uxBindingList;
        private System.Windows.Forms.Button uxCheckOutButton;
    }
}