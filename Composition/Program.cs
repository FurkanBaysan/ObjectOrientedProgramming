namespace Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();

            DbMigrator dbMigrator = new DbMigrator(logger);
            Installer installer = new Installer(logger);

            dbMigrator.Migrate();
            installer.Install();

        }
    }
}
