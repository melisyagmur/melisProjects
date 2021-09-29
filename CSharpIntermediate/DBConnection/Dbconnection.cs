using System;

namespace DBConnection

{
    public abstract class Dbconnection
    {
        private string _connectionString;
        private TimeSpan _timeOut;
        public string ConnectionString { get {return _connectionString; } set {_connectionString= value; } }
        public TimeSpan TimeOut { get {return _timeOut; } set {_timeOut=value; } }
        public Dbconnection(string ConnectionString)
        {
            if (!(ConnectionString == null || ConnectionString == string.Empty))
            {
                _connectionString = ConnectionString;
            }
            else
            {    
                throw new ArgumentNullException();
            }
            
        }
        public abstract void Open();
        public abstract void Close();

    }
}
