using System;

namespace Inheritance
{
    public class PresentationObject
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public void Copy()
        {
            Console.WriteLine("text is cpoied");
        }

        public void Duplicate()
        {
            Console.WriteLine("text is duplicated");
        }
    }
}
