using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Manager.Models;

namespace Library_Manager.Repositories
{
    interface IItemsOutRepository
    {
        ItemsOut CreateCheckOut(int bookID, int memberID, int libraryID);

        List<ItemsOut> CheckedOutBooksForMember(int memberID);
    }
}
