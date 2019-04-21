using DataAccess;
using System.Data;
using System.Data.SqlClient;
using Library_Manager.Models;
using System.Collections.Generic;

namespace Library_Manager.DataDelegates
{
    internal class NumberOfBooksDataDelegate : DataReaderDelegate<IReadOnlyDictionary<int, string>>
	{
        public NumberOfBooksDataDelegate() : base("Libraries.NumberOfBooks")
        {

        }

        public override IReadOnlyDictionary<int, string> Translate(SqlCommand command, SqlDataReader reader)
        {

        }
	}
}
