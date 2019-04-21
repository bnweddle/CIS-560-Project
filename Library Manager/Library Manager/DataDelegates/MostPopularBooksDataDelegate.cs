using DataAccess;
using System.Data;
using System.Data.SqlClient;
using Library_Manager.Models;
using System.Collections.Generic;

namespace Library_Manager.DataDelegates
{
    internal class MostPopularBooksDataDelegate : DataReaderDelegate<IReadOnlyDictionary<int, string>>
    {
        public MostPopularBooksDataDelegate() : base ("Libraries.ReportMostPopularBooks")
        {
        }

        public override IReadOnlyDictionary<int, string> Translate(SqlCommand command, SqlDataReader reader)
        {
            int NumofChecks;
            string NameofBooks;

            var dict = new Dictionary<int, string>();

            while(reader.Read()){
                NumofChecks = reader.GetInt32(reader.GetOrdinal("NumOfCheckOuts"));
                NameofBooks = reader.GetString(reader.GetOrdinal("Name"));

                dict.Add(NumofChecks, NameofBooks);
            }
            return dict;
        }       
	}
}
