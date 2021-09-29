  namespace CSharpIntermediate
{
    public class Point
    {
        public int _X;
        public int _Y;
        public Point(int x, int y)
        {
            this._X = x;
            this._Y = y;
        }

        public void Move(int x, int y)
        {
            this._X = x;
            this._Y = y;
        }
        public void Move(Point newLocation)
        {
            //this._X = newLocation._X;
            //this._Y = newLocation._Y; THIS PART IS UNECESSARY 

            Move(newLocation._X, newLocation._Y);  //NOT TO USE THİS agaın, UPPER METHOD IS CALLED
        }
    }
}
