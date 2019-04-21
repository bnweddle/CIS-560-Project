using DataAccess;
using System.Data;
using System.Data.SqlClient;
using Library_Manager.Models;
using System.Collections.Generic;

namespace Library_Manager.DataDelegates
{
    internal class MostPopularBooksDataDelegate : DataReaderDelegate<IReadOnlyDictionary<int, string>>
    {

	}
}
