using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;
using System.Data.SqlClient;
using Library_Manager.Models;


namespace Library_Manager.DataDelegates
{
    class Top10AuthorsDataDelegate : DataReaderDelegate<IReadOnlyList<Author>>
    {
        int memID { get; }
        public Top10AuthorsDataDelegate(int M)
            : base("Libraries.ReportTopTenAuthors")
        {
            memID = M;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("MemberID", SqlDbType.NVarChar);
            p.Value = memID;
        }

        public override IReadOnlyList<Author> Translate(SqlCommand command, SqlDataReader reader)
        {
            List <Author> authors = new List<Author>();

            while (reader.Read())
            {
                authors.Add(new Author(
                    reader.GetInt32(reader.GetOrdinal("AuthorID")),
                    reader.GetString(reader.GetOrdinal("FirstName")),
                    reader.GetString(reader.GetOrdinal("MiddleName")),
                    reader.GetString(reader.GetOrdinal("LastName")),
                    reader.GetString(reader.GetOrdinal("FullName"))));
            }
            return authors;
        }
    }
}
