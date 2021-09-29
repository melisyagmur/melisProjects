using System;

namespace DBConnection

{
    public class SQlConection : Dbconnection
    {
        public string MyProperty { get; set; }
        public SQlConection(string connection)
            :base(connection)
        {
            MyProperty = connection;
        }

        public override void Close()
        {
            Console.WriteLine("SQL is Closed");
        }

        public override void Open()
        {
            Console.WriteLine("SQL is Opened");
        }
    }
}
