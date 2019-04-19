using System;

namespace Library_Manager.Models
{
    public class Member
    {
        int MemberID { get; }
        int LibraryID { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        string Phone { get; set; }  

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
