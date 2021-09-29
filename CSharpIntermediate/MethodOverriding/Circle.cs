using System;

namespace MethodOverriding
{
    public class Circle : Shape
    {
        private object _circle = "circle";
        public object CircleObject { get { return _circle; } set { _circle = value; } }
        public override void Draw()
        {
            Console.WriteLine("Draw a circle");
        }

    }
}
