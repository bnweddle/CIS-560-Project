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
    class SqlAuthorRepository : IAuthorRepository
    {
        private readonly SqlCommandExecutor executor;

        public List<Title> FindBooksByAuthor(string authorName)
        {
             if (string.IsNullOrWhiteSpace(authorName))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(authorName));

            var d = new FindBooksByAuthorDataDelegate(authorName);
            return executor.ExecuteReader(d); //prodecure has OUTPUT parameters
        }

        public IReadOnlyList<string> Top10Authors()
        {
            var d = new Top10AuthorsDataDelegate();
            return executor.ExecuteReader(d); //prodecure has OUTPUT parameters
        }

    }
}