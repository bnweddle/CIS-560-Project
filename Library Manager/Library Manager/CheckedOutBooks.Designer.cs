namespace Library_Manager
{
    partial class CheckedOutBooks
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
            this.uxReturnButton = new System.Windows.Forms.Button();
            this.uxDataView = new System.Windows.Forms.DataGridView();
            this.uxBindingList = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.uxDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxBindingList)).BeginInit();
            this.SuspendLayout();
            // 
            // uxReturnButton
            // 
            this.uxReturnButton.Enabled = false;
            this.uxReturnButton.Location = new System.Drawing.Point(630, 389);
            this.uxReturnButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxReturnButton.Name = "uxReturnButton";
            this.uxReturnButton.Size = new System.Drawing.Size(147, 34);
            this.uxReturnButton.TabIndex = 21;
            this.uxReturnButton.Text = "Return Book";
            this.uxReturnButton.UseVisualStyleBackColor = true;
            // 
            // uxDataView
            // 
            this.uxDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxDataView.Location = new System.Drawing.Point(24, 28);
            this.uxDataView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxDataView.Name = "uxDataView";
            this.uxDataView.Size = new System.Drawing.Size(753, 348);
            this.uxDataView.TabIndex = 20;
            // 
            // uxBindingList
            // 
            this.uxBindingList.DataSource = typeof(Library_Manager.CheckedOutBooks);
            // 
            // CheckedOutBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxReturnButton);
            this.Controls.Add(this.uxDataView);
            this.Name = "CheckedOutBooks";
            this.Text = "Checked Out Books";
            ((System.ComponentModel.ISupportInitialize)(this.uxDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxBindingList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uxReturnButton;
        private System.Windows.Forms.DataGridView uxDataView;
        private System.Windows.Forms.BindingSource uxBindingList;
    }
}