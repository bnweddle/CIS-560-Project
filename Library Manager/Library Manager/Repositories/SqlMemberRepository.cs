using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Library_Manager.Models;
using Library_Manager.DataDelegates;

namespace Library_Manager.Repositories
{
    class SqlMemberRepository : IMemberRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlMemberRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public Member GetMemberbyEmail(string email)
        {
            var d = new GetMemberbyEmailDataDelegate(email);
            return executor.ExecuteReader(d);
        }

        public Member CreateMember(int libraryId, string firstName, string lastName, string email, string phone)
        {
            var d = new CreateMemberDataDelegate(libraryId, firstName, lastName, email, phone);
            return executor.ExecuteNonQuery(d); //prodecure has OUTPUT parameters
        }

        public Library2 RetrieveLibraryByName(string name)
        {
            var d = new RetrieveLibraryByNameDataDelegate(name);
            return executor.ExecuteReader(d);
        }
    }
}