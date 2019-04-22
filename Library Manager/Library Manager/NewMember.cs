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
            const string connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=master;Integrated Security=SSPI;";

            SqlMemberRepository SqlMem = new SqlMemberRepository(connectionString);


            if (!(uxLibraryChoose.SelectedIndex > -1) || (string.IsNullOrWhiteSpace(uxEmailText.Text) && uxEmailText.Text.Length > 0) ||
                (string.IsNullOrWhiteSpace(uxFirstNameText.Text) && uxFirstNameText.Text.Length > 0) ||
                (string.IsNullOrWhiteSpace(uxLastNameText.Text) && uxLastNameText.Text.Length > 0) ||
                (string.IsNullOrWhiteSpace(uxPhoneText.Text) && uxPhoneText.Text.Length > 0) || uxEmailText.Text.Equals("") || 
                uxFirstNameText.Text.Equals("") || uxLastNameText.Text.Equals("") || uxPhoneText.Text.Equals(""))
            {
                MessageBox.Show("Null or invalid inputs");
            }      
            else
            {
                Library2 lib = SqlMem.RetrieveLibraryByName(uxLibraryChoose.GetItemText(uxLibraryChoose.SelectedItem));
                if (lib == null)
                    MessageBox.Show("Lib is null");
                SqlMem.CreateMember(lib.LibraryID, uxFirstNameText.Text.Trim(), uxLastNameText.Text.Trim(),
                    uxEmailText.Text.Trim(), uxPhoneText.Text.Trim());
                MessageBox.Show("New membership was created for " + uxFirstNameText.Text + " " + uxLastNameText.Text + " at "
                    + uxLibraryChoose.SelectedItem.ToString());
                Close();
            }
        }
    }
}
