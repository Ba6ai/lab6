namespace ex2
{
    internal class Point
    {
        double _x;
        double _y;

        public Point(double x, double y)
        {
            this._x = x;
            this._y = y;
        }

        public Point(Point p)
        {
            this._x = p._x;
            this._y = p._y;
        }

        public double X
        {
            get 
            { 
                return _x; 
            }
            set
            {
                _x = value; 
            }
        }

        public double Y
        {
            get 
            { 
                return _y; 
            }
            set 
            {
                _y = value; 
            }
        }

        public override string ToString()
        {
            return _x + " " + _y;
        }

        public double GetDistance(Point p2)
        {
            return Math.Sqrt(Math.Pow(p2._x - this._x, 2) + Math.Pow(p2._y - this._y, 2));
        }


    }
}
