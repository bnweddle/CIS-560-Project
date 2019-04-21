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
    class SqlTitleRepository : ITitleRepository
	{
        private readonly SqlCommandExecutor executor;
        public List<Title> FindBooksByTitle(string titleName)
        {
            var d = new FindBooksByTitleDataDelegate(titleName);
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
