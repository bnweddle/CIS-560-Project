using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Manager.Models
{
    public class Title
    {
        public int TitleID { get;  }
        public string AuthorName { get; }
        public string ISBN { get;  }
        public string Name { get; }
        public int PublicationYear { get; }
        public int Avail { get;  }

        internal Title(int titleId, string isbn, string an, string name, int pubYear, int a)
        {
            TitleID = titleId;
            AuthorName = an;
            ISBN = isbn;
            Name = name;
            PublicationYear = pubYear;
            Avail = a;
        }
    }
}
