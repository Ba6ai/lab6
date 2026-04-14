using ex1;
class DotMAX : MAX // Наследование
{
    public DotMAX(int x, int y, int z) : base(x, y, z)
    {
    }

    public int GetYmn() // Получение произведения из 3 цифр
    {
        return x * y * z;
    }

    public int GetP() // Получение периметра треугольника
    {
        return x + y + z;
    }
}

