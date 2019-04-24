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
        const string connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=LibraryDB;Integrated Security=SSPI;";
        SqlItemsOutRepository SqlItemsOut = new SqlItemsOutRepository(connectionString);
        SqlTitleRepository SqlTitle = new SqlTitleRepository(connectionString);
        SqlAuthorRepository SqlAuthor = new SqlAuthorRepository(connectionString);

        public BindingList<Title> titleBindingList { get; }
        public BindingList<Author> authorBindingList { get;  }

        public Member member;
        public Account(Member m)
        {
            member = m;
            InitializeComponent();
            titleBindingList = new BindingList<Title>();
            authorBindingList = new BindingList<Author>();
            //DisplayCheckedOutBooks(m);
        }

        public void DisplayCheckedOutBooks(Member m)
        {
            Dictionary<string, ItemsOut> dict = SqlItemsOut.CheckedOutBooksForMember(m.MemberID);
            List<ItemsOut> values = new List<ItemsOut>();
            List<string> keys = new List<string>();

            if (dict.Count != 0)
            {
                foreach(KeyValuePair<string, ItemsOut> k in dict)
                {
                    values.Add(k.Value);
                    keys.Add(k.Key);
                }
            }
            else
            {
                MessageBox.Show("No books checked out");
            }
            
        }

        private void uxSearchButton_Click(object sender, EventArgs e)
        {
            titleBindingList.Clear();
            uxBindingList.DataSource = titleBindingList;
            uxDataView.DataSource = uxBindingList;
            List<Title> list = new List<Title>();

            string search = uxSearchBox.Text;
            if(uxByTitle.Checked == true)
            {
                
               list = SqlTitle.FindBooksByTitle(search, member.MemberID);

                foreach (Title t in list)
                {
                   titleBindingList.Add(t);
                }
                
            }
            else if(uxByAuthor.Checked == true)
            {
                list = SqlAuthor.FindBooksByAuthor(search, member.MemberID);
                foreach (Title t in list)
                {
                    titleBindingList.Add(t);
                }
            }
            else
            {
                MessageBox.Show("Must select one of the radio buttons");
            }
            
        }

        private void uxReportButton_Click(object sender, EventArgs e)
        {
            titleBindingList.Clear();
            //Most popular book
            if (uxReportQueries.SelectedIndex == 0)  
            {
                IReadOnlyDictionary<int, string> pop = SqlTitle.MostPopularBooks();
                List<int> keys = new List<int>();
                List<string> values = new List<string>();

                foreach(KeyValuePair<int, string> k in pop)
                {
                    keys.Add(k.Key);
                    values.Add(k.Value);
                }

                uxDataView.Columns[0].HeaderText = "Number of Checkouts";
                uxDataView.Columns[1].HeaderText = "Book Title";

                foreach(string s in values)
                {
                    foreach(int i in keys)
                    {
                        uxDataView.Rows.Add(i, s);
                    }
                }
            }   

            //Most popular author
            else if(uxReportQueries.SelectedIndex == 1)
            {
                authorBindingList.Clear();
                DataGridViewColumn col = new DataGridViewTextBoxColumn();
                IReadOnlyList<Author> authors = SqlAuthor.Top10Authors(member.MemberID);
                uxBindingList.DataSource = authorBindingList;
                uxDataView.DataSource = uxBindingList;
    
      
                col.DataPropertyName = "FullName";
                col.HeaderText = "Full Name";
                col.Name = "FullName";
                uxDataView.Columns.Add(col);

                foreach (Author a in authors)
                {
                    authorBindingList.Add(a);
                }

            }

            //Number of books in all
            else if (uxReportQueries.SelectedIndex == 2)
            {

            }
            //Overdue Books past a Month
            else if (uxReportQueries.SelectedIndex == 3)
            {

            }

            else //No report was selected
            {
                MessageBox.Show("Need to select a report.");
            }
        }
    }
}
