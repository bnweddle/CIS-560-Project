using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Manager.Models
{
    public class Popular
    {
        public int NumOfCheckOuts { get; }
        public string Name { get; }
        public DateTime LastCheckedOut { get; }
        public int NewerBooks { get; }

        internal Popular(int num, string name, DateTime lastDate, int newer)
        {
            NumOfCheckOuts = num;
            Name = name;
            LastCheckedOut = lastDate;
            NewerBooks = newer;
        }
    }
}
