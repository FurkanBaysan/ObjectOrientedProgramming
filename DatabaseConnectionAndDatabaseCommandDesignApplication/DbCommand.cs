using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnectionAndDatabaseCommandDesignApplication
{
    public class DbCommand
    {
        public string Instruction { get; set; }
        public DbConnection Connection { get; set; }

        public DbCommand(DbConnection connection, string instruction)
        {
            if (connection.Equals(null) || instruction.Equals(null))
            {
                throw new Exception("Execution of an instruction can not be possible, because connection string or instruction is null");
            }

            this.Connection = connection;
            this.Instruction = instruction;
        }

        public void Execute()
        {
            this.Connection.Open();
            Console.WriteLine("instruction is running");
            this.Connection.Close();
        }
    }
}
