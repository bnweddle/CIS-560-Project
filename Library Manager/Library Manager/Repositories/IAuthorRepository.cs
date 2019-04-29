using System.Collections.Generic;
using Library_Manager.Models;

namespace Library_Manager.Repositories
{
    interface IAuthorRepository
    {
        List<Title> FindBooksByAuthor(string authorName, int memberID);
        IReadOnlyList<Author> Top10Authors(int mem);
    }
}
