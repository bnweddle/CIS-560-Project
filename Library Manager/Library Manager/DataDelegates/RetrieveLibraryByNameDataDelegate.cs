using DataAccess;
using System.Data;
using System.Data.SqlClient;
using Library_Manager.Models;
using System.Collections.Generic;

namespace Library_Manager.DataDelegates
{
     class RetrieveLibraryByNameDataDelegate : DataReaderDelegate<Library2>
    {
        string Name { get; }

        public RetrieveLibraryByNameDataDelegate (string name)
        : base("Libraries.RetrieveLibraryByName")
        {
            Name = name;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("Name", SqlDbType.NVarChar);
            p.Value = Name;
        }

        public override Library2 Translate(SqlCommand command, SqlDataReader reader)
        {
            return new Library2(
                reader.GetInt32(reader.GetOrdinal("LibraryID")),
                reader.GetString(reader.GetOrdinal("Name")),
                reader.GetString(reader.GetOrdinal("City")),
                reader.GetString(reader.GetOrdinal("State"))
            );
        }
    }
}
