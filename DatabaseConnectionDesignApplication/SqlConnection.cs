using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnectionDesignApplication
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {

        }

        public override void Open()
        {
            Console.WriteLine("SQL Server Database connection Opened");
        }

        public override void Close()
        {
            Console.WriteLine("SQL Server Database connection Closed");
        }
    }
}
