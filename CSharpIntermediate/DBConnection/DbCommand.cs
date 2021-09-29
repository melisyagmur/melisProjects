using System;

namespace DBConnection

{
    public class DbCommand
    {
        private Dbconnection _dbconnection;

        public Dbconnection DBconnection { get { return _dbconnection; } set { _dbconnection = value; } }
        public string Instruction { get; set; }
        public DbCommand(Dbconnection dbconnection)
           
        {
            if (!(dbconnection == null))
            {
                _dbconnection = dbconnection;
            }
            else
            {
                throw new ArgumentNullException();
            }
        }
        public DbCommand(string insruction, Dbconnection dbconnection) :this(dbconnection)
        {
            if (!(insruction== null || insruction == string.Empty))
            {
                Instruction = insruction;
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public void Excecute( )
        {
            DBconnection.Open();
            Console.WriteLine(Instruction);
            DBconnection.Close();
        }


    }
}
