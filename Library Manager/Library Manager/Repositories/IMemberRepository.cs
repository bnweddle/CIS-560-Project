using Library_Manager.Models;

namespace Library_Manager.Repositories
{
    public interface IMemberRepository
    {
        Member GetMemberbyEmail(string email);

        Member CreateMember(int libraryId, string firstName, string lastName, string email, string phone);

        Library2 RetrieveLibraryByName(string name);
    }
}
