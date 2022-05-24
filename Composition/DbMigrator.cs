using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    public class DbMigrator
    {
        private readonly Logger logger;

        public DbMigrator(Logger logger)
        {
            this.logger = logger;
        }

        public void Migrate()
        {
            //..
            logger.Log("We're migrating..");
        }
    }
}
