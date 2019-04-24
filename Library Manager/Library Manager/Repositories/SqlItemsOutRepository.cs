using System.Collections.Generic;
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

        public ItemsOut CreateCheckOut(int bookID, int memberID, int libraryID)
        {
            var d = new CreateCheckOutDataDelegate(bookID, memberID, libraryID);
            return executor.ExecuteNonQuery(d); //prodecure has OUTPUT parameters
        }

        public List<ItemsOut> CheckedOutBooksForMember(int memberID)
        {
            var d = new CheckedOutBooksForMemberDataDelegate(memberID);
            return executor.ExecuteReader(d); 
        }

        public void UpdateReturnDate(int titleId)
        {
            var d = new ReturnBookDataDelegate(titleId);
            executor.ExecuteNonQuery(d);
        }
    }
}
