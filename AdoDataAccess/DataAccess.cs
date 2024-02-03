using AdoDataAccess;
using System.Data.SqlClient;


namespace AdoDataAccess
{
  public enum ExecutionType
    {
        NonQuery,DataReader,Scalar
    }
    public class DataAccess: IDataAccess
    {
       private  SqlConnection sqlConnection;
        public DataAccess(string connectionString)
        {
            sqlConnection = new SqlConnection(connectionString);
        }
        private object ExecuteCommand(string query, ExecutionType executionType)
        {
            using (sqlConnection)
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlConnection.Open();
                    switch (executionType)
                    {
                        case ExecutionType.NonQuery:
                            var effectedRow = sqlCommand.ExecuteNonQuery();
                            return effectedRow;
                            
                        case ExecutionType.DataReader:
                            var reader= sqlCommand.ExecuteReader();
                            return reader; 
                        case ExecutionType.Scalar:
                            var scalar = sqlCommand.ExecuteScalar();
                           return scalar;
                        
                    }

                   
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex);
                }
                return new object();
            }

          
        }

        SqlDataReader IDataAccess.SqlDataReaderExecuteReader(string query)
        {
            return (SqlDataReader)ExecuteCommand(query, ExecutionType.DataReader);
        }

        string IDataAccess.SqlExecuteScalar(string query)
        {
            return ExecuteCommand(query, ExecutionType.Scalar).ToString();
        }

        string IDataAccess.SqlExecuteNonQuery(string query)
        {
            return ExecuteCommand(query, ExecutionType.NonQuery).ToString();
        }
    }
}
