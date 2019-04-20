using DataAccess;
using System.Data;
using System.Data.SqlClient;
using Library_Manager.Models;
using System.Collections.Generic;

namespace Library_Manager.DataDelegates
{
    internal class ReturnBookDataDelegate : DataDelegate
    {
        int ItemsOutID { get;  }
        public ReturnBookDataDelegate(int IID)
        : base("Libraries.UpdateReturnDate")
        {
            ItemsOutID = IID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("ItemsOutID", SqlDbType.Int);
            p.Value = ItemsOutID;
        }
    }
}
