using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Manager.Models
{
    class Book
    {
        int TitleID { get; }
        int LibraryID { get; }
        int BookID { get; }
        int Quantity { get; }

        internal Book(int TID, int LID, int BID, int Q)
        {
            TitleID = TID;
            LibraryID = LID;
            BookID = BID;
            Quantity = Q;
        }
    }
}
