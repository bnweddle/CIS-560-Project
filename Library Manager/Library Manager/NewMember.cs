using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library_Manager.Models;
using Library_Manager.Repositories;

namespace Library_Manager
{
    public partial class NewMember : Form
    {
        public NewMember()
        {
            InitializeComponent();
        }

        private void uxSubmit_Click(object sender, EventArgs e)
        {
            const string connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=LibraryDB;Integrated Security=SSPI;";

            SqlMemberRepository SqlMem = new SqlMemberRepository(connectionString);

            if (uxLibraryChoose.SelectedIndex == -1 || (string.IsNullOrWhiteSpace(uxEmailText.Text) && uxEmailText.Text.Length > 0) ||
                (string.IsNullOrWhiteSpace(uxFirstNameText.Text) && uxFirstNameText.Text.Length > 0) ||
                (string.IsNullOrWhiteSpace(uxLastNameText.Text) && uxLastNameText.Text.Length > 0) ||
                (string.IsNullOrWhiteSpace(uxPhoneText.Text) && uxPhoneText.Text.Length > 0))
                MessageBox.Show("Invalid Values");
            else
            {
                SqlMem.CreateMember(uxLibraryChoose.SelectedIndex + 1, uxFirstNameText.Text.Trim(), uxLastNameText.Text.Trim(),
                    uxEmailText.Text.Trim(), uxPhoneText.Text.Trim());
                MessageBox.Show("Member was created");
            }



        }
    }
}
