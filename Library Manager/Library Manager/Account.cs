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
        const string connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=master;Integrated Security=SSPI;";
        SqlItemsOutRepository SqlI = new SqlItemsOutRepository(connectionString);

        public Member member;
        public Account(Member m)
        {
            member = m;
            InitializeComponent();
            DisplayCheckedOutBooks(m);
        }

        public void DisplayCheckedOutBooks(Member m)
        {
            Dictionary<string, ItemsOut> dict = SqlI.CheckedOutBooksForMember(m.MemberID);
            
            if (dict.Count != 0)
            {
                foreach(KeyValuePair<string, ItemsOut> k in dict)
                {
                    uxDataView.Rows.Add(k.Key, k.Value);
                }
                uxDataView.Refresh();
            }
            else
            {
                MessageBox.Show("No books checked out");
            }
            
        }
    }
}
