using DataAccess;
using System.Data;
using System.Data.SqlClient;
using Library_Manager.Models;
using System.Collections.Generic;

namespace Library_Manager.DataDelegates
{
    internal class GetMemberbyEmailDataDelegate : DataReaderDelegate<Member>
    {
        string Email { get; }

        public GetMemberbyEmailDataDelegate(string email)
        : base("Libraries.GetMemberForEmail")
        {
            Email = email;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("Email", SqlDbType.NVarChar);
            p.Value = Email;
        }

        public override Member Translate(SqlCommand command, SqlDataReader reader)
        {
            if (!reader.Read())
                return null;

            return new Member(reader.GetInt32(reader.GetOrdinal("MemberID")),
                    reader.GetInt32(reader.GetOrdinal("LibraryID")),
                    reader.GetString(reader.GetOrdinal("FirstName")),
                    reader.GetString(reader.GetOrdinal("LastName")),
                    Email,
                    reader.GetString(reader.GetOrdinal("Phone")));
        }
    }
}
