using System;

namespace DBConnection
{ 
    class Program
    {
        static void Main(string[] args)
        {
            var DBcommand = new DbCommand("asd", new OracleConnection("asd"));
            DBcommand.Excecute();


        }
    }
}

