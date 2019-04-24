using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Manager.Models
{
    public class BookQuantity
    {
        public string LibraryName { get; }
        public string TitleName { get; }
        public int Quantity { get; }
        public int Total { get; }

        internal BookQuantity(string ln, string tn, int q, int t)
        {
            LibraryName = ln;
            TitleName = tn;
            Quantity = q;
            Total = t;
        }
    }
}
