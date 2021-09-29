namespace MethodOverriding
{
    public class Shape
    {
        private double _width;
        private double _height;
        public double Width { get {return _width; } set {_width = value; } }
        public double Height { get {return _height; } set {_height = value; } }

        public virtual void Draw()
        {
           
        }
    }
}
