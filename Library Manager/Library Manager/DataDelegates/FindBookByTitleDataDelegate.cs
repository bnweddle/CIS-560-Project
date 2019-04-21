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

        public FindBookByTitleDataDelegate(string titleName) : base("Libraries.FindBookByTitle")
        {
            TitleName = titleName;
        }

        public override List<Title> Translate(SqlCommand command, SqlDataReader reader)
        {
            var books = new List<Title>();

            while (reader.Read())
            {
                books.Add(new Title(
                    reader.GetInt(reader.GetOrdinal("TitleID")),
                    reader.GetString(reader.GetOrdinal("ISBN")),
                    reader.GetInt(reader.GetOrdinal("AuthorID")),
                    "%" + TitleName + "%",
                    reader.GetInt(reader.GetOrdinal("PublicationYear"))));
            }
            return books;
        }
    }
}

//It doesn't acknowledge Title (from Title.cs) and it doesn't acknowledge SqlCommand/Reader 
//Also doesn't acknowledge DataReaderDelegate