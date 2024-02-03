using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoDataAccess
{
    public interface IDataAccess
    {
        SqlDataReader SqlDataReaderExecuteReader(string query);
         string SqlExecuteScalar(string query);
         string SqlExecuteNonQuery(string query);

    }
}
