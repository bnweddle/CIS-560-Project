using DataAccess;
using System.Data;
using System.Data.SqlClient;
using Library_Manager.Models;
using System.Collections.Generic;

namespace Library_Manager.DataDelegates
{
    internal class MostPopularBooksDataDelegate : DataReaderDelegate<IReadOnlyList<Popular>>
    {
        public MostPopularBooksDataDelegate() : base ("Libraries.ReportMostPopularBooks")
        {
        }

        public override IReadOnlyList<Popular> Translate(SqlCommand command, SqlDataReader reader)
        {
            List<Popular> pop = new List<Popular>();

            while(reader.Read()){
                pop.Add(new Popular(
                    reader.GetInt32(reader.GetOrdinal("NumOfCheckOuts")),
                    reader.GetString(reader.GetOrdinal("Name")),
                    reader.GetDateTime(reader.GetOrdinal("LastCheckedOut")),
                    reader.GetInt32(reader.GetOrdinal("NewerBooks"))));
            }
            return pop;
        }       
	}
}
