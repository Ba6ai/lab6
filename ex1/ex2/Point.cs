namespace ex2
{
    internal class Point
    {
        double x;
        double y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public Point(Point p)
        {
            this.x = p.x;
            this.y = p.y;
        }

        public double getX
        {
            get { return x; }
            set { x = value; }
        }

        public double getY
        {
            get { return y; }
            set { y = value; }
        }

        public override string ToString()
        {
            return x + " " + y;
        }

        public double GetDistance(Point p2)
        {
            return Math.Sqrt(Math.Pow(p2.x - this.x, 2) + Math.Pow(p2.y - this.y, 2));
        }


    }
}
