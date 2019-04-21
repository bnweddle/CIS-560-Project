using DataAccess;
using System.Data;
using System.Data.SqlClient;
using Library_Manager.Models;
using System.Collections.Generic;

namespace Library_Manager.DataDelegates
{
    internal class NumberOfBooksDataDelegate : DataReaderDelegate<IReadOnlyDictionary<int, string>>
	{
        public NumberOfBooksDataDelegate() : base("Libraries.ReportNumberOfBooks")
        {
        }

        public override IReadOnlyDictionary<int, string> Translate(SqlCommand command, SqlDataReader reader)
        {
            int quantity;
            string NameofBooks;

            var dict = new Dictionary<int, string>();

            while(reader.Read())
            {
                quantity = reader.GetInt32(reader.GetOrdinal("Quantity"));
                NameofBooks = reader.GetString(reader.GetOrdinal("T.[Name]"));

                dict.Add(quantity, NameofBooks);
            }
            return dict;
        }
	}
}
