﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Manager.Models
{
    public class Author
    {
        int AuthorID { get; }
        string FirstName { get; }
        string LastName { get; }
        string MiddleName { get; }
        string FullName { get; }

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
