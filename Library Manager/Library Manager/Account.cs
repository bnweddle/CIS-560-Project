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
    public partial class Account : Form
    {
        public Member member;
        public Account(Member m)
        {
            member = m;
            InitializeComponent();
        }

        private void uxSearchButton_Click(object sender, EventArgs e)
        {
            const string connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=master;Integrated Security=SSPI;";
            SqlTitleRepository SqlMem = new SqlTitleRepository(connectionString);

            string search = uxSearchBox.Text;
            List<Title> list = new List<Title>();

            list = SqlMem.FindBooksByTitle(search);
            uxDataView.Columns.Add()
        }
    }
}
