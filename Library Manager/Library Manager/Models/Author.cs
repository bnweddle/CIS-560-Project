using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Manager.Models
{
    public class Author
    {
        public int AuthorID { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string MiddleName { get; }
        public string FullName { get; }

        internal Author(int authorId, string firstName, string middleName, string lastName, string fullName)
        {
            AuthorID = authorId;
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            FullName = fullName;
        }
    }
}
