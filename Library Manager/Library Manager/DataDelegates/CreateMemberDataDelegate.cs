using DataAccess;
using System.Data;
using System.Data.SqlClient;
using Library_Manager.Models;
using System;

namespace Library_Manager.DataDelegates
{
    internal class CreateMemberDataDelegate : NonQueryDataDelegate<Member>
    {
        int LibraryID { get; }
        string FirstName { get; }
        string LastName { get; }
        string Email { get; }
        string Phone { get; }

        public CreateMemberDataDelegate(int libraryId, string firstName, string lastName, string email, string phone)
            : base("Libraries.CreateMember")
        {
            LibraryID = libraryId;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("LibraryID", SqlDbType.Int);
            p.Value = LibraryID;

            p = command.Parameters.Add("FirstName", SqlDbType.NVarChar);
            p.Value = FirstName;

            p = command.Parameters.Add("LastName", SqlDbType.NVarChar);
            p.Value = LastName;

            p = command.Parameters.Add("Email", SqlDbType.NVarChar);
            p.Value = Email;

            p = command.Parameters.Add("Phone", SqlDbType.NVarChar);
            p.Value = Phone;

            p = command.Parameters.Add("MemberID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override Member Translate(SqlCommand command)
        {
            return new Member(
                (int)command.Parameters["MemberID"].Value,
                LibraryID,
                FirstName,
                LastName,
                Email,
                Phone
                );
        }
    }
}
