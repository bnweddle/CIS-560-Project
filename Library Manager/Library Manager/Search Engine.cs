﻿using System;
using System.Collections.Generic;
using Library_Manager.Repositories;
using Library_Manager.Models;
using System.Windows.Forms;
using System.ComponentModel;

namespace Library_Manager
{
    public partial class Search_Engine : Form
    {
        const string connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=LibraryDB;Integrated Security=SSPI;";
        SqlItemsOutRepository SqlItemsOut = new SqlItemsOutRepository(connectionString);
        SqlTitleRepository SqlTitle = new SqlTitleRepository(connectionString);
        SqlAuthorRepository SqlAuthor = new SqlAuthorRepository(connectionString);

        public BindingList<Title> titleBindingList { get; }

        public Member member;
        public Search_Engine(Member m)
        {
            member = m;
            titleBindingList = new BindingList<Title>();
            InitializeComponent();
        }

        private void uxSearchButton_Click(object sender, EventArgs e)
        {
            titleBindingList.Clear();
            this.uxDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            uxBindingList.DataSource = titleBindingList;
            uxDataView.DataSource = uxBindingList;
            List<Title> list = new List<Title>();

            string search = uxSearchBox.Text;
            if (uxByTitle.Checked == true)
            {

                list = SqlTitle.FindBooksByTitle(search, member.LibraryID);

                foreach (Title t in list)
                {
                    titleBindingList.Add(t);
                }

            }
            else if (uxByAuthor.Checked == true)
            {
                list = SqlAuthor.FindBooksByAuthor(search, member.LibraryID);
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

        private void uxCheckOutButton_Click(object sender, EventArgs e)
        {
            
            Title title = (Title) uxDataView.SelectedRows[0].DataBoundItem;
            if(title.Available == 0)
            {
                MessageBox.Show(title.Name + " is not available currently");
            }
            else
            {
                ItemsOut I = SqlItemsOut.CreateCheckOut(title.TitleID, member.MemberID, member.LibraryID);
                uxSearchButton_Click(sender, e);
                if (title.Available == 1)
                {
                    titleBindingList.Remove(title);
                }

                MessageBox.Show(title.Name + " was checked out");
            }
           
        }

        private void uxDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*Ignore this*/
        }
    }
}
