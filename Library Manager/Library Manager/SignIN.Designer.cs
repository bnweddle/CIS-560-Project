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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uxSignInButton
            // 
            this.uxSignInButton.Location = new System.Drawing.Point(209, 90);
            this.uxSignInButton.Name = "uxSignInButton";
            this.uxSignInButton.Size = new System.Drawing.Size(130, 46);
            this.uxSignInButton.TabIndex = 0;
            this.uxSignInButton.Text = "Sign In";
            this.uxSignInButton.UseVisualStyleBackColor = true;
            // 
            // uxNewMemberButton
            // 
            this.uxNewMemberButton.Location = new System.Drawing.Point(27, 87);
            this.uxNewMemberButton.Name = "uxNewMemberButton";
            this.uxNewMemberButton.Size = new System.Drawing.Size(136, 49);
            this.uxNewMemberButton.TabIndex = 1;
            this.uxNewMemberButton.Text = "New Member";
            this.uxNewMemberButton.UseVisualStyleBackColor = true;
            this.uxNewMemberButton.Click += new System.EventHandler(this.uxNewMemberButton_Click);
            // 
            // UxLabelEmail
            // 
            this.UxLabelEmail.AutoSize = true;
            this.UxLabelEmail.Location = new System.Drawing.Point(24, 23);
            this.UxLabelEmail.Name = "UxLabelEmail";
            this.UxLabelEmail.Size = new System.Drawing.Size(80, 17);
            this.UxLabelEmail.TabIndex = 2;
            this.UxLabelEmail.Text = "Enter Email";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(126, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 22);
            this.textBox1.TabIndex = 3;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 152);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.UxLabelEmail);
            this.Controls.Add(this.uxNewMemberButton);
            this.Controls.Add(this.uxSignInButton);
            this.Name = "SignIn";
            this.Text = "Sign In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxSignInButton;
        private System.Windows.Forms.Button uxNewMemberButton;
        private System.Windows.Forms.Label UxLabelEmail;
        private System.Windows.Forms.TextBox textBox1;
    }
}

