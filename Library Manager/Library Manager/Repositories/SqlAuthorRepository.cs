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

        public SqlAuthorRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public List<Title> FindBooksByAuthor(string authorName, int memberID)
        {
             if (string.IsNullOrWhiteSpace(authorName))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(authorName));

            var d = new FindBooksByAuthorDataDelegate(authorName, memberID);
            return executor.ExecuteReader(d); //prodecure has OUTPUT parameters
        }

        public IReadOnlyList<Author> Top10Authors(int mem)
        {
            var d = new Top10AuthorsDataDelegate(mem);
            return executor.ExecuteReader(d); //prodecure has OUTPUT parameters
        }

    }
}