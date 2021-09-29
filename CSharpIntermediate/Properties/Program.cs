
using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void PropertySet()
        {
            var person = new PropertySetter();
            person.SetBirthday(new DateTime(1986, 1, 1));

        }
    }
}
