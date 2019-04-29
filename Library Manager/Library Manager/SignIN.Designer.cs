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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.uxSignInButton = new System.Windows.Forms.Button();
            this.uxNewMemberButton = new System.Windows.Forms.Button();
            this.UxLabelEmail = new System.Windows.Forms.Label();
            this.uxSignInTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uxSignInButton
            // 
            this.uxSignInButton.Location = new System.Drawing.Point(209, 90);
            this.uxSignInButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxSignInButton.Name = "uxSignInButton";
            this.uxSignInButton.Size = new System.Drawing.Size(131, 46);
            this.uxSignInButton.TabIndex = 0;
            this.uxSignInButton.Text = "Sign In";
            this.uxSignInButton.UseVisualStyleBackColor = true;
            this.uxSignInButton.Click += new System.EventHandler(this.uxSignInButton_Click);
            // 
            // uxNewMemberButton
            // 
            this.uxNewMemberButton.Location = new System.Drawing.Point(27, 87);
            this.uxNewMemberButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.UxLabelEmail.BackColor = System.Drawing.Color.Transparent;
            this.UxLabelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UxLabelEmail.Location = new System.Drawing.Point(24, 26);
            this.UxLabelEmail.Name = "UxLabelEmail";
            this.UxLabelEmail.Size = new System.Drawing.Size(91, 17);
            this.UxLabelEmail.TabIndex = 2;
            this.UxLabelEmail.Text = "Enter Email";
            // 
            // uxSignInTextBox
            // 
            this.uxSignInTextBox.Location = new System.Drawing.Point(125, 23);
            this.uxSignInTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxSignInTextBox.Name = "uxSignInTextBox";
            this.uxSignInTextBox.Size = new System.Drawing.Size(213, 22);
            this.uxSignInTextBox.TabIndex = 3;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(376, 153);
            this.Controls.Add(this.uxSignInTextBox);
            this.Controls.Add(this.UxLabelEmail);
            this.Controls.Add(this.uxNewMemberButton);
            this.Controls.Add(this.uxSignInButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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

