using System;

namespace Library_Manager.Models
{
    public class Member
    {
        int MemberID { get; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        string Phone { get; set; }  

        internal Member(int memberId, string firstName, string lastName, string email, string phone)
        {
            MemberID = memberId;
            firstName = FirstName;
            lastName = LastName;
            email = Email;
            phone = Phone;
        }
    }
}
