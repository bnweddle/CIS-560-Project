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
        List<Title> FindBooksByTitle(string titleName);

        IReadOnlyList<Title> MostPopularBooks();

        IReadOnlyList<Title> NumberOfBooks();

        List<Title> CheckedOutBooksForMember(int memberId);

        void UpdateReturnDate(int itemOutId);
    }
}
