using System;

namespace DatabaseConnectionAndDatabaseCommandDesignApplication
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

            Console.WriteLine();

            DbCommand command = new DbCommand(oracleDbConnection, "Select * from Customer");
            command.Execute();
            DbCommand dbCommand = new DbCommand(sqlServerDbConnection, "Select * from Product");
            dbCommand.Execute();
        }
    }
}
