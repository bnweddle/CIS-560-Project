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
        public Member member;
        public Options(Member m)
        {
            member = m;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var search = new Search_Engine(member);
            search.Show();
        }
    }
}
