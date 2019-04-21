using DataAccess;
using System.Data;
using System.Data.SqlClient;
using Library_Manager.Models;
using System.Collections.Generic;

namespace Library_Manager.DataDelegates
{
    internal class FindBookByTitleDataDelegate : DataReaderDelegate<List<string>>
    {
        string TitleName { get; }

        public FindBookByTitleDataDelegate(string titleName) : base("Libraries.FindBookByTitle")
        {
            if (string.IsNullOrWhiteSpace(titleName))
            {
                throw new ArgumentException("The title name cannot be null or empty.", nameof(titleName));
            }
            TitleName = titleName;
        }

        public override List<string> Translate(SqlCommand command, SqlDataReader reader)
        {
            var books = new List<Book>();

            while (reader.Read())
            {
                books.Add(new Book(
                    reader.GetString(reader.GetOriginal("Name"),
                    reader.GetInt(reader.GetOriginal("TitleID"),
                    reader.GetString(reader.GetOriginal("ISBN"),
                    reader.GetString(reader.GetOriginal("AuthorID"),
                    reader.GetString(reader.GetOriginal("PublicationYear"))));
            }
            return books;
        }
    }
}
