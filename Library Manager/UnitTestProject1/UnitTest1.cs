using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Library_Manager.Models;
using Library_Manager.Repositories;
using Library_Manager;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Library_Manager.Testing
{
    [TestClass]
    class Test1
    {
        const string connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=knzeiler;Integrated Security=SSPI;";

        private static string GetTestString() => Guid.NewGuid().ToString("N");

        private SqlMemberRepository mem;

        [TestInitialize]
        public void InitializeTest()
        {
            mem = new SqlMemberRepository(connectionString);
        }
    }
