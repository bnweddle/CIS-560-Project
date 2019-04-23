using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Manager.Models
{
    class Title
    {
        public int TitleID { get;  }
        public int AuthorID { get; }
        public string ISBN { get;  }
        public string Name { get; }
        public int PublicationYear { get; }

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
