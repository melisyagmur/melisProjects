
using System;

namespace CSharpIntermediate
{
    public class Person
    {
        public DateTime Birthday { get ; set; }
        public Person(string name)
        {
            this.Name = name;
        }
        public string Name;
        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }
        public static Person Parse(string name)
        {
            var person = new Person("melis");
            person.Introduce("john");

            return person;
        }
    }
}
