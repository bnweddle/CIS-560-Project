﻿using System;
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

        public BindingList<Title> titleBindingList { get; }

        public Member member;
        public Account(Member m)
        {
            member = m;
            InitializeComponent();
            titleBindingList = new BindingList<Title>();
            uxBindingList.DataSource = titleBindingList;
            uxDataView.DataSource = uxBindingList;
            //DisplayCheckedOutBooks(m);
        }

        public void DisplayCheckedOutBooks(Member m)
        {
            Dictionary<string, ItemsOut> dict = SqlI.CheckedOutBooksForMember(m.MemberID);
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
            const string connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=LibraryDB;Integrated Security=SSPI;";
            SqlTitleRepository SqlMem = new SqlTitleRepository(connectionString);

            string search = uxSearchBox.Text;
            if(uxByTitle.Checked == true)
            {
                List<Title> list = new List<Title>();
                list = SqlMem.FindBooksByTitle(search);

                foreach (Title t in list)
                {
                   titleBindingList.Add(t);
                }
                
            }
            else if(uxByAuthor.Checked == true)
            {

            }
            else
            {
                MessageBox.Show("Must select one of the radio buttons");
            }
            
        }

        private void uxReportButton_Click(object sender, EventArgs e)
        {

        }
    }
}
