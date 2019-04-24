using DataAccess;
using System.Data;
using System.Data.SqlClient;
using Library_Manager.Models;
using System.Collections.Generic;

namespace Library_Manager.DataDelegates
{
    internal class ReturnBookDataDelegate : DataDelegate
    {
        int TitleID { get;  }
        public ReturnBookDataDelegate(int TID)
        : base("Libraries.UpdateReturnDate")
        {
            TitleID = TID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("TitleID", SqlDbType.Int);
            p.Value = TitleID;
        }
    }
}
