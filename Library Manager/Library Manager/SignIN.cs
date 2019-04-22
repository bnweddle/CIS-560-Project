using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library_Manager.Repositories;
using System.Transactions;
using Library_Manager.Models;

namespace Library_Manager
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void uxNewMemberButton_Click(object sender, EventArgs e)
        {
            var member = new NewMember();
            member.Show();
        }

        private void uxSignInButton_Click(object sender, EventArgs e)
        {
            const string connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=master;Integrated Security=SSPI;";
         
            SqlMemberRepository SqlMem = new SqlMemberRepository(connectionString);
            Member m = SqlMem.GetMemberbyEmail(uxSignInTextBox.Text.Trim());
            if ((string.IsNullOrWhiteSpace(uxSignInTextBox.Text) && uxSignInTextBox.Text.Length > 0) || m == null)
            {
                MessageBox.Show("Invalid Email Value");
            }

            else
            {
                var account = new Account(m);
                account.Show();
            }
        }
    }
}
