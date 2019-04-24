using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Manager.Models
{
   
    public class OverDue
    {
        public string Bookname { get;}
        public int MemberID { get;}
        public DateTime CheckedOutDate { get;}
        public DateTime DueBackDate { get;}
        public int Diff { get; }

        internal OverDue(string bookname, int memberId, DateTime checkedOut, DateTime due, int diff)
        {
            Bookname = bookname;
            MemberID = memberId;
            CheckedOutDate = checkedOut;
            DueBackDate = due;
            Diff = diff;
        }
    }
}
