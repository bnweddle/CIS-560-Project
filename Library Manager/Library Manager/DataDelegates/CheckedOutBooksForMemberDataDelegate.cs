using DataAccess;
using System.Data;
using System.Data.SqlClient;
using Library_Manager.Models;
using System.Collections.Generic;

namespace Library_Manager.DataDelegates
{
    internal class CheckedOutBooksForMemberDataDelegate : DataReaderDelegate<Dictionary<string, ItemsOut>>
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

        public override Dictionary<string, ItemsOut> Translate(SqlCommand command, SqlDataReader reader)
        {
            if (!reader.Read())
                return null;

            ItemsOut values;
            var dict = new Dictionary<string, ItemsOut>();
            
            while (reader.Read())
            {
                values = new ItemsOut(
                   reader.GetInt32(reader.GetOrdinal("ItemsOutID")),
                   8, //should be number 8
                   //reader.GetInt32(reader.GetOrdinal("LibrayID")),
                   MemberID,
                   reader.GetInt32(reader.GetOrdinal("BookID")),
                   reader.GetDateTime(reader.GetOrdinal("CheckedOutDate")),
                   reader.GetDateTime(reader.GetOrdinal("DueBackDate")),
                   reader.GetDateTime(reader.GetOrdinal("ReturnedDate")));

                dict.Add(reader.GetString(reader.GetOrdinal("Name")), values);
            }

            return dict;
        }
    }
}
