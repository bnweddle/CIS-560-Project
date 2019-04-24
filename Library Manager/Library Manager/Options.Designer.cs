namespace Library_Manager
{
    partial class Options
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.uxReportButton = new System.Windows.Forms.Button();
            this.uxReportQueries = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Search Engine";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(215, 25);
            this.button2.TabIndex = 1;
            this.button2.Text = "View Checked Out Books";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // uxReportButton
            // 
            this.uxReportButton.Location = new System.Drawing.Point(22, 168);
            this.uxReportButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxReportButton.Name = "uxReportButton";
            this.uxReportButton.Size = new System.Drawing.Size(215, 25);
            this.uxReportButton.TabIndex = 14;
            this.uxReportButton.Text = "Report";
            this.uxReportButton.UseVisualStyleBackColor = true;
            this.uxReportButton.Click += new System.EventHandler(this.uxReportButton_Click);
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
            this.uxReportQueries.Location = new System.Drawing.Point(20, 128);
            this.uxReportQueries.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxReportQueries.Name = "uxReportQueries";
            this.uxReportQueries.Size = new System.Drawing.Size(217, 24);
            this.uxReportQueries.TabIndex = 15;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 204);
            this.Controls.Add(this.uxReportQueries);
            this.Controls.Add(this.uxReportButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Options";
            this.Text = "Options";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button uxReportButton;
        private System.Windows.Forms.ComboBox uxReportQueries;
    }
}