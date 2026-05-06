using ex2;

internal class Program
{
    private static void Main(string[] args)
    {
        double x1 = 0;
        double y1 = 0;
        double x2 = 0;
        double y2 = 0;

        Console.Write("Введите x1: ");
        x1 = Enter();

        Console.Write("Введите y1: ");
        y1 = Enter();

        Console.Write("Введите x2: ");
        x2 = Enter();

        Console.Write("Введите y2: ");
        y2 = Enter();

        Point p1 = new Point(x1, y1);
        Point p2 = new Point(x2, y2);

        double d = p1.GetDistance(p2);

        Console.WriteLine("Расстояние = " + d);

        
        p1++;
        Console.WriteLine("\nУвеличение координаты х на 1: " + p1);
        //p1--;
        //Console.WriteLine(p1);

        double neavn = p1;
        Console.WriteLine("Неявное double(коорд У): " + neavn);

        int xInt = (int)p1;
        Console.WriteLine("Явное int(целая часть Х): " + xInt);

        double distance = p1 + p2;

        Point moove = p1 + 5.4;

        Console.WriteLine("Дистанция = " + distance);
        Console.WriteLine("Прибавление вещественного к Х = " + moove);
    }

    private static double Enter()
    {
        double x1;
        while (!double.TryParse(Console.ReadLine(), out x1))
        {
            Console.WriteLine("Ошибка ввода, введите ещё раз:");
        }

        return x1;
    }
}