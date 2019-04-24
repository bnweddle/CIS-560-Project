using DataAccess;
using System.Data;
using System.Data.SqlClient;
using Library_Manager.Models;
using System.Collections.Generic;

namespace Library_Manager.DataDelegates
{
    internal class NumberOfBooksDataDelegate : DataReaderDelegate<IReadOnlyList<BookQuantity>>
	{
        public NumberOfBooksDataDelegate() : base("Libraries.ReportNumberOfBooks")
        {
        }

        public override IReadOnlyList<BookQuantity> Translate(SqlCommand command, SqlDataReader reader)
        {
            List<BookQuantity> bq = new List<BookQuantity>();

            while(reader.Read())
            {
                bq.Add(new BookQuantity(
                    reader.GetString(reader.GetOrdinal("LibraryName")),
                    reader.GetString(reader.GetOrdinal("TitleName")),
                    reader.GetInt32(reader.GetOrdinal("Quantity")),
                    reader.GetInt32(reader.GetOrdinal("TotalNumOfBooks"))));
            }
            return bq;
        }
	}
}
