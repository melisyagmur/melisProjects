namespace Extensibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbmigrator = new DBMigrator(new FileLogger("C:\\Desktop\\log.txt"));
            dbmigrator.Migrate();
        }
    }
}
