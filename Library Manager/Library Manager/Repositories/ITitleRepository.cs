using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Manager.Models;

namespace Library_Manager.Repositories
{
    interface ITitleRepository
    {
        List<Title> FindBooksByTitle(string titleName, int memberId); 

        IReadOnlyList<Popular> MostPopularBooks(); //NumOfChecks, NameOfBook

        IReadOnlyDictionary<int, string> NumberOfBooks(); //Quantity, NameOfBook
    }
}
