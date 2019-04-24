using System;
using System.Collections.Generic;
using DataAccess;
using Library_Manager.Models;
using Library_Manager.DataDelegates;

namespace Library_Manager.Repositories
{
    class SqlTitleRepository : ITitleRepository
	{
        private readonly SqlCommandExecutor executor;

        public SqlTitleRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public List<Title> FindBooksByTitle(string titleName, int memberId)
        {
            if (string.IsNullOrWhiteSpace(titleName))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(titleName));

            var d = new FindBookByTitleDataDelegate(titleName, memberId);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<Popular> MostPopularBooks()
        {
            var d = new MostPopularBooksDataDelegate();
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<BookQuantity> NumberOfBooks()
        {
            var d = new NumberOfBooksDataDelegate();
            return executor.ExecuteReader(d);
        }

    }
}
