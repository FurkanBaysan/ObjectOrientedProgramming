using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnectionDesignApplication
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            if (connectionString.Equals(null))
            {
                throw new Exception("Can not connect to Database because Connection String is null");
            }
            this.ConnectionString = connectionString;
        }

        public abstract void Open();
        public abstract void Close();
    }
}
