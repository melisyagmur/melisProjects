using System;

namespace MethodOverriding
{
    public class Rectangle : Shape
    { 
        public override void Draw()
        {
            Console.WriteLine("Draw a rectangle with width:{0} and height:{1}", Width,Height);
        }

    }
}
