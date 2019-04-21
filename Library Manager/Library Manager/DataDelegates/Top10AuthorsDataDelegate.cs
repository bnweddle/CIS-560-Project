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
    class Top10AuthorsDataDelegate : DataReaderDelegate<IReadOnlyList<string>>
    {
        public Top10AuthorsDataDelegate()
            : base("Libraries.ReportTopTenAuthors")
        {
            //intentionally left blank
        }

        public override IReadOnlyList<string> Translate(SqlCommand command, SqlDataReader reader)
        {
            List<string> list = new List<string>();
            IReadOnlyList<string> listFinished;

            while (reader.Read())
            {
                list.Add(reader.GetString(reader.GetOrdinal("FirstName")) + reader.GetString(reader.GetOrdinal("MiddleName")) + reader.GetString(reader.GetOrdinal("LastName")));
            }
            listFinished = list;
            return listFinished;
        }
    }
}
