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
    public partial class CheckedOutBooks : Form
    {
        const string connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=LibraryDB;Integrated Security=SSPI;";
        SqlItemsOutRepository SqlItemsOut = new SqlItemsOutRepository(connectionString);
        public BindingList<ItemsOut> itemsBindingList { get;  }
        Member member { get; set; }

        public CheckedOutBooks(Member m)
        {
            member = m;
            itemsBindingList = new BindingList<ItemsOut>();
            InitializeComponent();
            DisplayCheckedOutBooks(m);
        }

        public void DisplayCheckedOutBooks(Member m)
        {
            itemsBindingList.Clear();
            uxBindingList.DataSource = itemsBindingList;
            uxDataView.DataSource = uxBindingList;
            List<ItemsOut> values = SqlItemsOut.CheckedOutBooksForMember(m.MemberID);

            if(values == null)
            {
                MessageBox.Show("No checked out books currently");
            }
            else
            {
                foreach (ItemsOut I in values)
                {
                    itemsBindingList.Add(I);
                }
            }
            
        }

        private void uxDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            uxReturnButton.Enabled = true;
            DataGridViewRow rows = this.uxDataView.Rows[e.RowIndex];
            uxTitleID.Text = rows.Cells["ItemsOutID"].Value.ToString();
        }

        private void uxReturnButton_Click(object sender, EventArgs e)
        {
            int itemsId = Convert.ToInt32(uxTitleID.Text);
            SqlItemsOut.UpdateReturnDate(itemsId);
            uxDataView.Refresh();
        }
    }
}
