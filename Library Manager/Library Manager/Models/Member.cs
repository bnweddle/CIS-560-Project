
namespace Library_Manager.Models
{
    public class Member
    {
        public int MemberID { get; }
        public int LibraryID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }  

        internal Member(int memberId, int libraryId, string firstName, string lastName, string email, string phone)
        {
            MemberID = memberId;
            LibraryID = libraryId;
            firstName = FirstName;
            lastName = LastName;
            email = Email;
            phone = Phone;
        }
    }
}
