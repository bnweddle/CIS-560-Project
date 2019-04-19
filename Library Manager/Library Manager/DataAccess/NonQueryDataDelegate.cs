using System.Data.SqlClient;

namespace DataAccess
{
   public abstract class NonQueryDataDelegate<T> : DataDelegate, INonQueryDataDelegate<T>
   {
      public NonQueryDataDelegate(string procedureName)
         : base(procedureName)
      {
      }

      public abstract T Translate(SqlCommand command);
   }
}