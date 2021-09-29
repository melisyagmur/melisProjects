using System;

namespace DBConnection

{
    public class OracleConnection : Dbconnection
    {
        public string ConnectionStrings { get; set; }
        public OracleConnection(string connection)
            :base(connection)   
        {

        }
        public override void Close()
        {
            Console.WriteLine("Oracle is Closed");
        }

        public override void Open()
        {
            Console.WriteLine("Oracle is Opened");
        }
    }
}
