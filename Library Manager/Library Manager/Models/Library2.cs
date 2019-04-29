

namespace Library_Manager.Models
{
    public class Library2
    {
        public int LibraryID { get; }
        public string Name { get; }
        public string City { get; }
        public string State { get; }

        internal Library2(int libraryID, string name, string city, string state)
        {
            LibraryID = libraryID;
            Name = name;
            City = city;
            State = state;
        }
    }
}
