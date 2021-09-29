using System;
using System.Collections.Generic;

namespace MethodOverriding
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            var rectangle = new Rectangle();
            rectangle.Width = 10;
            rectangle.Height = 50;
   
            shapes.Add(rectangle);
            shapes.Add(new Circle());

            var canvas = new Canvas();
            canvas.DrawShapes(shapes);
           
        }
    }
}
