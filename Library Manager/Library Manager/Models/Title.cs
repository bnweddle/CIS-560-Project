
namespace Library_Manager.Models
{
    public class Title
    {
        public int TitleID { get;  }
        public string Author { get; }
        public string ISBN { get;  }
        public string Name { get; }
        public int Published { get; }
        public int Available { get;  }

        internal Title(int titleId, string isbn, string an, string name, int pubYear, int a)
        {
            TitleID = titleId;
            Author = an;
            ISBN = isbn;
            Name = name;
            Published = pubYear;
            Available = a;
        }
    }
}
