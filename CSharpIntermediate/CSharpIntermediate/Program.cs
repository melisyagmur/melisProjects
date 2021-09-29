using System;

namespace CSharpIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {

            var person = new Person1();

            person.Birthday = new DateTime(1988, 1, 1);
            Console.WriteLine(person.Age);
            Console.ReadLine();
        }
    

        static void ObjectInıtalizer()
        {
            var person = new Person("melis");
            person.Introduce("melis");

            //var customer = new Customer1
            //{ _Id = 5, _Name = "melis" }; //OBJECT INITIALIZER 

            //Console.WriteLine(customer._Id);
            //Console.WriteLine(customer._Name);


        }
        static void Calculate()
        {
            var calculator = new Calculator();
            calculator.Add(1, 2, 3, 5, 6);
            calculator.Add(1, 2);
            calculator.Add(new int[] { 1, 2, 3, 4, 5 }); //INSTEAD OF THIS ONE USE UPPER

        }

        static void usepoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(new Point(30, 40)); //Object Parameter
                Console.WriteLine("point is at {0} and {1}", point._X, point._Y);
            }
            catch (Exception)
            {

                Console.WriteLine("THERE İS AN ERROR");
            }
        }
    }
}
