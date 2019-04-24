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
        public Member m;

        public Reports(int index, IBindingList bindingList,Member member)
        {
            m = member;
            InitializeComponent();
            if(index == 0)
            {

            }
            else if(index == 1)
            {
                DisplayTopAuthors(bindingList, member);
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
    }
}
