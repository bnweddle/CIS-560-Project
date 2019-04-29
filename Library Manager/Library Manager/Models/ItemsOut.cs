using System;

namespace Library_Manager.Models
{
    public class ItemsOut
    {
        public int ItemsOutID { get; } //Primary Key
        public int LibraryID { get; set; } //Foreign Key
        public int MemberID { get; set; } //Foreign Key
        public int BookId { get; set; } //Foreign Key
        public string Title { get; }
        public DateTime CheckedOutDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnedDate { get; set; }

        internal ItemsOut(int IID, int LID, int MID, int BID, string titleName, DateTime COD, DateTime DD, DateTime? RD)
        {
            ItemsOutID = IID;
            LibraryID = LID;
            MemberID = MID;
            BookId = BID;
            Title = titleName;
            CheckedOutDate = COD;
            DueDate = DD;
            ReturnedDate = RD;
        }
    }
}
