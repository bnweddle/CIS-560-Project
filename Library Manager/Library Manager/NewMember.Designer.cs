namespace Library_Manager
{
    partial class NewMember
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.uxLibraryChoose = new System.Windows.Forms.ComboBox();
            this.uxFirstNameText = new System.Windows.Forms.TextBox();
            this.uxLastNameText = new System.Windows.Forms.TextBox();
            this.uxEmailText = new System.Windows.Forms.TextBox();
            this.uxPhoneText = new System.Windows.Forms.TextBox();
            this.uxSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Email Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter Phone Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Choose Library";
            // 
            // uxLibraryChoose
            // 
            this.uxLibraryChoose.FormattingEnabled = true;
            this.uxLibraryChoose.Items.AddRange(new object[] {
            "Manhattan Public Library",
            "Wichita Public Library",
            "Topeka Public Library",
            "Lawrence Public Library",
            "Park City Public Library",
            "Evergreen Branch Library",
            "Rockwell Branch Library",
            "Alford Branch Library"});
            this.uxLibraryChoose.Location = new System.Drawing.Point(174, 34);
            this.uxLibraryChoose.Name = "uxLibraryChoose";
            this.uxLibraryChoose.Size = new System.Drawing.Size(196, 24);
            this.uxLibraryChoose.TabIndex = 5;
            // 
            // uxFirstNameText
            // 
            this.uxFirstNameText.Location = new System.Drawing.Point(174, 73);
            this.uxFirstNameText.Name = "uxFirstNameText";
            this.uxFirstNameText.Size = new System.Drawing.Size(196, 22);
            this.uxFirstNameText.TabIndex = 6;
            // 
            // uxLastNameText
            // 
            this.uxLastNameText.Location = new System.Drawing.Point(174, 113);
            this.uxLastNameText.Name = "uxLastNameText";
            this.uxLastNameText.Size = new System.Drawing.Size(196, 22);
            this.uxLastNameText.TabIndex = 7;
            // 
            // uxEmailText
            // 
            this.uxEmailText.Location = new System.Drawing.Point(174, 156);
            this.uxEmailText.Name = "uxEmailText";
            this.uxEmailText.Size = new System.Drawing.Size(196, 22);
            this.uxEmailText.TabIndex = 8;
            // 
            // uxPhoneText
            // 
            this.uxPhoneText.Location = new System.Drawing.Point(174, 196);
            this.uxPhoneText.Name = "uxPhoneText";
            this.uxPhoneText.Size = new System.Drawing.Size(196, 22);
            this.uxPhoneText.TabIndex = 9;
            // 
            // uxSubmit
            // 
            this.uxSubmit.Location = new System.Drawing.Point(264, 236);
            this.uxSubmit.Name = "uxSubmit";
            this.uxSubmit.Size = new System.Drawing.Size(106, 33);
            this.uxSubmit.TabIndex = 10;
            this.uxSubmit.Text = "Submit";
            this.uxSubmit.UseVisualStyleBackColor = true;
            this.uxSubmit.Click += new System.EventHandler(this.uxSubmit_Click);
            // 
            // NewMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 281);
            this.Controls.Add(this.uxSubmit);
            this.Controls.Add(this.uxPhoneText);
            this.Controls.Add(this.uxEmailText);
            this.Controls.Add(this.uxLastNameText);
            this.Controls.Add(this.uxFirstNameText);
            this.Controls.Add(this.uxLibraryChoose);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewMember";
            this.Text = "New Member";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox uxLibraryChoose;
        private System.Windows.Forms.TextBox uxFirstNameText;
        private System.Windows.Forms.TextBox uxLastNameText;
        private System.Windows.Forms.TextBox uxEmailText;
        private System.Windows.Forms.TextBox uxPhoneText;
        private System.Windows.Forms.Button uxSubmit;
    }
}