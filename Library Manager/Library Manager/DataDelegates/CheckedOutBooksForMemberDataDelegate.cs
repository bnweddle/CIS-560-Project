using DataAccess;
using System.Data;
using System.Data.SqlClient;
using Library_Manager.Models;
using System.Collections.Generic;
using System;

namespace Library_Manager.DataDelegates
{
    internal class CheckedOutBooksForMemberDataDelegate : DataReaderDelegate<List<ItemsOut>>
    {
        int MemberID { get; }

        public CheckedOutBooksForMemberDataDelegate(int memberID)
        : base("Libraries.CheckedOutBooksForMember")
        {
            MemberID = memberID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("MemberID", SqlDbType.Int);
            p.Value = MemberID;
        }

        public override List<ItemsOut> Translate(SqlCommand command, SqlDataReader reader)
        {
            if (!reader.Read())
                return null;

            List<ItemsOut> items = new List<ItemsOut>();

            while (reader.Read())
            {
                items.Add(new ItemsOut(
                   reader.GetInt32(reader.GetOrdinal("ItemsOutID")),
                   reader.GetInt32(reader.GetOrdinal("LibraryID")),
                   MemberID,
                   reader.GetInt32(reader.GetOrdinal("BookID")),
                   reader.GetString(reader.GetOrdinal("Name")),
                   reader.GetDateTime(reader.GetOrdinal("CheckedOutDate")),
                   reader.GetDateTime(reader.GetOrdinal("DueBackDate")),
                   reader.IsDBNull(reader.GetOrdinal("ReturnedDate"))
                      ? (DateTime?)null
                      : reader.GetDateTime(reader.GetOrdinal("ReturnedDate"))));

            }

            return items;
        }
    }
}
