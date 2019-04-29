using System.Collections.Generic;
using System.Data.SqlClient;
using DataAccess;
using Library_Manager.Models;

namespace Library_Manager.DataDelegates
{
    internal class OverDueDataDelegate : DataReaderDelegate<IReadOnlyList<OverDue>>
    {
        public OverDueDataDelegate() : base("Libraries.OverDueBooks")
        {
        }

        public override IReadOnlyList<OverDue> Translate(SqlCommand command, SqlDataReader reader)
        {
            List<OverDue> overdue = new List<OverDue>();

            while (reader.Read())
            {
                overdue.Add(new OverDue(
                   reader.GetString(reader.GetOrdinal("BookName")),
                   reader.GetInt32(reader.GetOrdinal("MemberID")),
                   reader.GetDateTime(reader.GetOrdinal("CheckedOutDate")),
                   reader.GetDateTime(reader.GetOrdinal("DueBackDate")),
                   reader.GetInt32(reader.GetOrdinal("Diff"))));
            }
            return overdue;
        }
    }
}
