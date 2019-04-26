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
    class FindBooksByAuthorDataDelegate : DataReaderDelegate<List<Title>>
    {
        string AuthorName { get; } 
        int memberID { get; }

        public FindBooksByAuthorDataDelegate(string authorName, int mem)
            : base("Libraries.FindBooksByAuthor")
        {
            AuthorName = authorName;
            memberID = mem;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("AuthorNamePattern", SqlDbType.NVarChar);
            p.Value = AuthorName;

            p = command.Parameters.Add("LibraryID", SqlDbType.Int);
            p.Value = memberID;
        }

        public override List<Title> Translate(SqlCommand command, SqlDataReader reader)
        {
            List<Title> list = new List<Title>();

            while (reader.Read())
            {
                list.Add(new Title(reader.GetInt32(reader.GetOrdinal("TitleID")),                       
                                    reader.GetString(reader.GetOrdinal("ISBN")),
                                    reader.GetString(reader.GetOrdinal("FullName")),
                                    reader.GetString(reader.GetOrdinal("Name")),   
                                    reader.GetInt32(reader.GetOrdinal("Published")),
                                    reader.GetInt32(reader.GetOrdinal("Available"))));
            }
            return list;
        }

    }
}