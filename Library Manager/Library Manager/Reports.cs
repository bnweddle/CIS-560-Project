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
    public partial class Reports : Form
    {
        const string connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=LibraryDB;Integrated Security=SSPI;";
        SqlAuthorRepository SqlAuthor = new SqlAuthorRepository(connectionString);
        SqlItemsOutRepository SqlItems = new SqlItemsOutRepository(connectionString);
        SqlTitleRepository SqlTitle = new SqlTitleRepository(connectionString);
        public Member m;

        public Reports(int index, IBindingList bindingList,Member member)
        {
            m = member;
            InitializeComponent();
            if(index == 0)
            {
                DisplayTopBooks(bindingList);
            }
            else if(index == 1)
            {
                DisplayTopAuthors(bindingList, member);
            }
            else if(index == 2)
            {
                MessageBox.Show("Uncomplete");
            }
            else
            {
                DisplayOverDue(bindingList);
            }

        }

        public void DisplayTopAuthors(IBindingList bindingList, Member member)
        {
            bindingList.Clear();
            IReadOnlyList<Author> authors = SqlAuthor.Top10Authors(member.MemberID);
            uxbindingList.DataSource = bindingList;
            uxDataView.DataSource = uxbindingList;

            foreach (Author a in authors)
            {
                bindingList.Add(a);
            }
        }

        public void DisplayTopBooks(IBindingList bind)
        {
            bind.Clear();
            IReadOnlyList<Popular> pop = SqlTitle.MostPopularBooks();
            uxbindingList.DataSource = bind;
            uxDataView.DataSource = uxbindingList;
            foreach (Popular p in pop)
            {
                bind.Add(p);
            }
        }

        public void DisplayOverDue(IBindingList binding)
        {
            binding.Clear();
            IReadOnlyList<OverDue> due = SqlItems.OverDueBooks();
            uxbindingList.DataSource = binding;
            uxDataView.DataSource = uxbindingList;
            foreach (OverDue o in due)
            {
                binding.Add(o);
            }
        }
    }
}
