using DataAccess;
using System.Data;
using System.Data.SqlClient;
using Library_Manager.Models;
using System;

namespace Library_Manager.DataDelegates
{
    internal class FindBookByTitleDataDelegate : DataReaderDelegate<List<Title>>
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
    }
    public virtual void PrepareCommand(SqlCommand command)
    {

    }
}
