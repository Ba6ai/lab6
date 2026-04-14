namespace ex2
{
    internal class Point
    {
        double x, y;

        // Конструктор
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        // Копирование
        public Point(Point p)
        {
            this.x = p.x;
            this.y = p.y;
        }

        // Свойства
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

        // Методы
        public override string ToString()
        {
            return x + " " + y;
        }

        // Расчёт расстояния
        public double GetDistance(Point p2)
        {
            return Math.Sqrt(Math.Pow(p2.x - this.x, 2) + Math.Pow(p2.y - this.y, 2));
        }


    }
}
