using ex2;

internal class Program
{
    private static void Main(string[] args)
    {
        double x1, y1, x2, y2;

        Console.WriteLine("Введите x1: ");
        while(!double.TryParse(Console.ReadLine(), out x1))
        {
            Console.WriteLine("Ошибка ввода, введите ещё раз: ");
        }
        Console.WriteLine("Введите y1: ");
        while (!double.TryParse(Console.ReadLine(), out y1))
        {
            Console.WriteLine("Ошибка ввода, введите ещё раз: ");
        }
        Console.WriteLine("Введите x2: ");
        while (!double.TryParse(Console.ReadLine(), out x2))
        {
            Console.WriteLine("Ошибка ввода, введите ещё раз: ");
        }
        Console.WriteLine("Введите y2: ");
        while (!double.TryParse(Console.ReadLine(), out y2))
        {
            Console.WriteLine("Ошибка ввода, введите ещё раз: ");
        }

        Point p1 = new Point(x1, y1);
        Point p2 = new Point(x2, y2);

        double d = p1.GetDistance(p2);

        Console.WriteLine("Расстояние = " + d);

    }
}