using System;

namespace Library_Manager.Models
{
   
    public class OverDue
    {
        public string Title { get;}
        public int MemberID { get;}
        public DateTime CheckedOutDate { get;}
        public DateTime DueBackDate { get;}
        public int Diff { get; }

        internal OverDue(string bookname, int memberId, DateTime checkedOut, DateTime due, int diff)
        {
            Title = bookname;
            MemberID = memberId;
            CheckedOutDate = checkedOut;
            DueBackDate = due;
            Diff = diff;
        }
    }
}
