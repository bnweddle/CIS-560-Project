using DataAccess;
using System.Data;
using System.Data.SqlClient;
using Library_Manager.Models;
using System.Collections.Generic;

namespace Library_Manager.DataDelegates
{
    internal class FindBookByTitleDataDelegate : DataReaderDelegate<List<Title>>
    {
        string TitleName { get; }
        int memberID { get; }

        public FindBookByTitleDataDelegate(string titleName, int mem) : base("Libraries.FindBooksByTitle")
        {
            TitleName = titleName;
            memberID = mem;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("TitleNamePattern", SqlDbType.NVarChar);
            p.Value = TitleName;

            p = command.Parameters.Add("LibraryID", SqlDbType.Int);
            p.Value = memberID;
        }

        public override List<Title> Translate(SqlCommand command, SqlDataReader reader)
        {
            var books = new List<Title>();

            while (reader.Read())
            {
                books.Add(new Title(
                    reader.GetInt32(reader.GetOrdinal("TitleID")),
                    reader.GetString(reader.GetOrdinal("ISBN")),
                    reader.GetString(reader.GetOrdinal("FullName")),
                    reader.GetString(reader.GetOrdinal("Name")),
                    reader.GetInt32(reader.GetOrdinal("Published")),
                    reader.GetInt32(reader.GetOrdinal("Available"))));
            }
            return books;
        }
    }
}
