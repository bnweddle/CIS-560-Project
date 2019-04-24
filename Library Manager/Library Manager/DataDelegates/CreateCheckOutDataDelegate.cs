using DataAccess;
using System.Data;
using System.Data.SqlClient;
using Library_Manager.Models;
using System;

namespace Library_Manager.DataDelegates
{
    internal class CreateCheckOutDataDelegate : NonQueryDataDelegate<ItemsOut>
    {
        int LibraryID { get; }
        int MemberID { get; } 
        int BookID { get; } 

        public CreateCheckOutDataDelegate(int bookID, int memberID, int libraryID)
         : base("Libraries.CreateCheckOut")
        {
            LibraryID = libraryID;
            MemberID = memberID;
            BookID = bookID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("LibraryID", SqlDbType.Int);
            p.Value = LibraryID;

            p = command.Parameters.Add("MemberID", SqlDbType.Int);
            p.Value = MemberID;

            p = command.Parameters.Add("TitleID", SqlDbType.Int);
            p.Value = BookID;

            p = command.Parameters.Add("Title", SqlDbType.NVarChar);
            p.Direction = ParameterDirection.Output;

            p = command.Parameters.Add("ItemsOutID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;

            p = command.Parameters.Add("CheckedOutDate", SqlDbType.DateTime);
            p.Direction = ParameterDirection.Output;

            p = command.Parameters.Add("DueBackDate", SqlDbType.DateTime);
            p.Direction = ParameterDirection.Output;

            p = command.Parameters.Add("ReturnedDate", SqlDbType.DateTime);
            p.Direction = ParameterDirection.Output;
        }

        public override ItemsOut Translate(SqlCommand command)
        {
            return new ItemsOut((int)command.Parameters["ItemsOutID"].Value, LibraryID,
                MemberID,
                BookID,
                (string)command.Parameters["Title"].Value,
                (DateTime)command.Parameters["CheckedOutDate"].Value, 
                (DateTime)command.Parameters["DueBackDate"].Value, 
                (DateTime)command.Parameters["ReturnedDate"].Value);
        }
    }
}

