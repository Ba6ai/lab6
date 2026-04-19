using ex1;

internal class Program
{
    private static void Main(string[] args)
    {
        int x = 0;
        int y = 0;
        int z = 0;

        Console.WriteLine("Введите число x:");
        while(!int.TryParse(Console.ReadLine(), out x))
        {
            Console.WriteLine("Ошибка ввода, введите ещё раз:");
        }

        Console.WriteLine("Введите число y: ");
        while (!int.TryParse(Console.ReadLine(), out y))
        {
            Console.WriteLine("Ошибка ввода, введите ещё раз:");
        }

        Console.WriteLine("Введите число z: ");
        while (!int.TryParse(Console.ReadLine(), out z))
        {
            Console.WriteLine("Ошибка ввода, введите ещё раз:");
        }

        MAX count1 = new MAX(x, y, z);
        MAX count2 = new MAX(count1);

        int max1 = count1.GetMAX();

        Console.Write("Максимальное число = ");
        Console.WriteLine(max1);
        
        Console.Write("Результат умножения 3 цифр: ");
        DotMAX dot1 = new DotMAX(x, y, z);
        Console.WriteLine(dot1.GetYmn());

        Console.Write("Периметр треугольника 'x' 'y' 'z' = ");
        DotMAX dot2 = new DotMAX(x, y, z);
        Console.WriteLine(dot2.GetP());


        Console.Write("Замена 'x' : ");
        while (!int.TryParse(Console.ReadLine(), out x))
        {
            Console.WriteLine("Ошибка ввода, введите ещё раз:");
        }
        count2.X = x;

        Console.Write("Все введённые числа count1: ");
        Console.WriteLine(count1);
        Console.Write("Все введённые числа count2: ");
        Console.WriteLine(count2);
    }
}