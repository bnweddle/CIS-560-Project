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

namespace Library_Manager
{
    public partial class Options : Form
    {
        public BindingList<Author> authors;
        public Member member;
        public Options(Member m)
        {
            member = m;
            authors = new BindingList<Author>();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var search = new Search_Engine(member);
            search.Show();
        }

        private void uxReportButton_Click(object sender, EventArgs e)
        {
            //Most popular book
            if (uxReportQueries.SelectedIndex == 0)
            {

            }

            //Most popular author
            else if (uxReportQueries.SelectedIndex == 1)
            {
                var reports = new Reports(1,authors,member);
                reports.Show(); 

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

        private void button2_Click(object sender, EventArgs e)
        {
            var books = new CheckedOutBooks(member);
            books.Show();
        }
    }
}
