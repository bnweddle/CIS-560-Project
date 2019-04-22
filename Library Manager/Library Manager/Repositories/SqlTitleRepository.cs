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
        public List<Title> FindBooksByTitle(string titleName)
        {
            if (string.IsNullOrWhiteSpace(titleName))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(titleName));

            var d = new FindBookByTitleDataDelegate(titleName);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyDictionary<int, string> MostPopularBooks()
        {
            var d = new MostPopularBooksDataDelegate();
            return executor.ExecuteReader(d);
        }

        public IReadOnlyDictionary<int, string> NumberOfBooks()
        {
            var d = new NumberOfBooksDataDelegate();
            return executor.ExecuteReader(d);
        }

    }
}
