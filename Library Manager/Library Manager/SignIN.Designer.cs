namespace Library_Manager
{
    partial class SignIn
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
            this.uxSignInButton = new System.Windows.Forms.Button();
            this.uxNewMemberButton = new System.Windows.Forms.Button();
            this.UxLabelEmail = new System.Windows.Forms.Label();
            this.uxSignInTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uxSignInButton
            // 
            this.uxSignInButton.Location = new System.Drawing.Point(157, 73);
            this.uxSignInButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxSignInButton.Name = "uxSignInButton";
            this.uxSignInButton.Size = new System.Drawing.Size(98, 37);
            this.uxSignInButton.TabIndex = 0;
            this.uxSignInButton.Text = "Sign In";
            this.uxSignInButton.UseVisualStyleBackColor = true;
            this.uxSignInButton.Click += new System.EventHandler(this.uxSignInButton_Click);
            // 
            // uxNewMemberButton
            // 
            this.uxNewMemberButton.Location = new System.Drawing.Point(20, 71);
            this.uxNewMemberButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxNewMemberButton.Name = "uxNewMemberButton";
            this.uxNewMemberButton.Size = new System.Drawing.Size(102, 40);
            this.uxNewMemberButton.TabIndex = 1;
            this.uxNewMemberButton.Text = "New Member";
            this.uxNewMemberButton.UseVisualStyleBackColor = true;
            this.uxNewMemberButton.Click += new System.EventHandler(this.uxNewMemberButton_Click);
            // 
            // UxLabelEmail
            // 
            this.UxLabelEmail.AutoSize = true;
            this.UxLabelEmail.Location = new System.Drawing.Point(18, 19);
            this.UxLabelEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UxLabelEmail.Name = "UxLabelEmail";
            this.UxLabelEmail.Size = new System.Drawing.Size(60, 13);
            this.UxLabelEmail.TabIndex = 2;
            this.UxLabelEmail.Text = "Enter Email";
            // 
            // uxSignInTextBox
            // 
            this.uxSignInTextBox.Location = new System.Drawing.Point(94, 19);
            this.uxSignInTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxSignInTextBox.Name = "uxSignInTextBox";
            this.uxSignInTextBox.Size = new System.Drawing.Size(161, 20);
            this.uxSignInTextBox.TabIndex = 3;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 124);
            this.Controls.Add(this.uxSignInTextBox);
            this.Controls.Add(this.UxLabelEmail);
            this.Controls.Add(this.uxNewMemberButton);
            this.Controls.Add(this.uxSignInButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SignIn";
            this.Text = "Sign In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxSignInButton;
        private System.Windows.Forms.Button uxNewMemberButton;
        private System.Windows.Forms.Label UxLabelEmail;
        private System.Windows.Forms.TextBox uxSignInTextBox;
    }
}

