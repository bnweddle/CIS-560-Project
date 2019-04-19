using DataAccess;
using System.Data;
using System.Data.SqlClient;
using Library_Manager.Models;
using System;

namespace Library_Manager.DataDelegates
{
    public class CreateCheckOutDataDelegate : NonQueryDataDelegate<ItemsOut>
    {
        int ItemsOutID { get; } //Primary Key
        int LibraryID { get; } //Foreign Key
        int MemberID { get; } //Foreign Key
        int BookID { get; } //Foreign Key
        DateTime CheckedOutDate { get; }
        DateTime DueDate { get; }
        DateTime ReturnedDate { get; }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("LibraryID", SqlDbType.Int);
            p.Value = LibraryID;

            p = command.Parameters.Add("MemberID", SqlDbType.Int);
            p.Value = MemberID;

            p = command.Parameters.Add("BookID", SqlDbType.Int);
            p.Value = BookID;

            p = command.Parameters.Add("ItemsOutID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override ItemsOut Translate(SqlCommand command)
        {
            return new ItemsOut((int)command.Parameters["ItemsOutID"].Value, LibraryID, MemberID,
                BookID, CheckedOutDate, DueDate, ReturnedDate);
        }
    }
}

