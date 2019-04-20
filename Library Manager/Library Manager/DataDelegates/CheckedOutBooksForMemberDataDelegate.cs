using DataAccess;
using System.Data;
using System.Data.SqlClient;
using Library_Manager.Models;
using System.Collections.Generic;

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

            var p = command.Parameters.Add("MemberId", SqlDbType.Int);
            p.Value = MemberID;
        }

        public override List<ItemsOut> Translate(SqlCommand command, SqlDataReader reader)
        {
            var items = new List<ItemsOut>();

            while (reader.Read())
            {
                items.Add(new ItemsOut(
                   reader.GetInt32(reader.GetOrdinal("ItemsOutID")),
                   reader.GetInt32(reader.GetOrdinal("LibrayID")),
                   MemberID,
                   reader.GetInt32(reader.GetOrdinal("BookID")),
                   reader.GetDateTime(reader.GetOrdinal("CheckedOutDate")),
                   reader.GetDateTime(reader.GetOrdinal("DueBackDate")),
                   reader.GetDateTime(reader.GetOrdinal("ReturnedDate"))));
            }

            return items;
        }
    }
}
