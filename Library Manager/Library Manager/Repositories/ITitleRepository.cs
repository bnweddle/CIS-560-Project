using System.Collections.Generic;
using Library_Manager.Models;

namespace Library_Manager.Repositories
{
    interface ITitleRepository
    {
        List<Title> FindBooksByTitle(string titleName, int memberId); 

        IReadOnlyList<Popular> MostPopularBooks();

        IReadOnlyList<BookQuantity> NumberOfBooks(); 
    }
}
