using System;

namespace DatabaseConnectionDesignApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            DbConnection oracleDbConnection = new OracleConnection("Oracle Connection String");
            oracleDbConnection.Open();
            oracleDbConnection.Close();

            DbConnection sqlServerDbConnection = new SqlConnection("SqlServer Connection String");
            sqlServerDbConnection.Open();
            sqlServerDbConnection.Close();
        }
    }
}
