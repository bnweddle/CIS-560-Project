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
    public partial class Account : Form
    {
        public Member member;
        public Account(Member m)
        {
            member = m;
            InitializeComponent();
        }
    }
}
