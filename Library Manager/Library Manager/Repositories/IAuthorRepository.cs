using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Manager.Models;

namespace Library_Manager.Repositories
{
    interface IAuthorRepository
    {
        List<Title> FindBooksByAuthor(string authorName);
        IReadOnlyList<string> Top10Authors();
    }
}
