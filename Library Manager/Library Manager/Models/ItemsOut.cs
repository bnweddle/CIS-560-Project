using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Manager.Models
{
    class ItemsOut
    {
        int ItemsOutID { get; } //Primary Key
        int LibraryID { get; set; } //Foreign Key
        int MemberID { get; set; } //Foreign Key
        int BookId { get; set; } //Foreign Key
        DateTime CheckedOutDate { get; set; }
        DateTime DueDate { get; set; }
        DateTime ReturnedDate { get; set; }

        public BindingList<ItemsOut> list { get; }

        internal ItemsOut(int IID, int LID, int MID, int BID, DateTime COD, DateTime DD, DateTime RD)
        {
            ItemsOutID = IID;
            LibraryID = LID;
            MemberID = MID;
            BookId = BID;
            CheckedOutDate = COD;
            DueDate = DD;
            ReturnedDate = RD;
        }
    }
}
