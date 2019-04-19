using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Library_Manager.Models;
using Library_Manager.DataDelegates;

namespace Library_Manager.Repositories
{
    class SqlItemsOutRepository : IItemsOutRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlItemsOutRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public List<ItemsOut> CheckedOutBooksForMember(int memberID)
        {
            var d = new CheckedOutBooksForMemberDelegate(memberID);
            return executor.ExecuteReader(d);
        }

        public ItemsOut CreateCheckOut(int bookID, int memberID, int libraryID)
        {
            var d = new CreateCheckOutDataDelegate(bookID, memberID, libraryID);
            return executor.ExecuteReader(d);
        }


    }
}
