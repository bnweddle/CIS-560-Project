using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Manager.Models
{
    class Title
    {
        int TitleID { get;  }
        int AuthorID { get; }
        string ISBN { get;  }
        string Name { get; }
        int PublicationYear { get; }

        internal Title(int titleId, int authorId, string isbn, string name, int pubYear)
        {
            TitleID = titleId;
            AuthorID = authorId;
            ISBN = isbn;
            Name = name;
            PublicationYear = pubYear;
        }
    }
}
