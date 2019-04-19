using System;

namespace Library_Manager.Models
{
    public class Library
    {
        public int LibraryID { get; }
        public string Name { get; }
        public string City { get; }
        public string State { get; }

        internal Library(int libraryID, string name, string city, string state)
        {
            LibraryID = libraryID;
            Name = name;
            City = city;
            State = state;
        }
    }
}
