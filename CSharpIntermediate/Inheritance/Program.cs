namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        public static void migrator()
        {
            var DBMigrator = new DBMigrator(new Logger());
            DBMigrator.Migrate();
        }
        public static void installer()
        {
            var logger = new Logger();
            var installer = new Installer(logger);
            installer.Install();
        }
    }
}
