using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Manager.Models;

namespace Library_Manager.Repositories
{
    public interface IMemberRepository
    {
        Member GetMemberbyEmail(string email);

        Member CreateMember(int libraryId, string firstName, string lastName, string email, string phone);

        Library RetrieveLibraryByName(string name);
    }
}
