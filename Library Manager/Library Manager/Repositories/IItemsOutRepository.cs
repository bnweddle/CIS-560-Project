﻿using System.Collections.Generic;
using Library_Manager.Models;

namespace Library_Manager.Repositories
{
    interface IItemsOutRepository
    {
        ItemsOut CreateCheckOut(int bookID, int memberID, int libraryID);

        //Member should be able to select from list to return one of them
        List<ItemsOut> CheckedOutBooksForMember(int memberID);

        void UpdateReturnDate(int itemsOutId);

        IReadOnlyList<OverDue> OverDueBooks();

    }
}
