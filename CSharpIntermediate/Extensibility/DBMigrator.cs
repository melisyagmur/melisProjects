using System;

namespace Extensibility
{
    public interface ILogger
    {
        void LogError(string message);
        void LogInfo(string message);
    }
    
    public class DBMigrator
    {
        private readonly ILogger _logger;

        public DBMigrator(ILogger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            _logger.LogInfo("migration started at:" + " " + DateTime.Now);
            _logger.LogInfo("migration finished at:" + " " + DateTime.Now);
        }


    }
}
