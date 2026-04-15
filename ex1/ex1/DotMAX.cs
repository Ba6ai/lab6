using ex1;
class DotMAX : MAX
{
    public DotMAX(int x, int y, int z) : base(x, y, z)
    {
    }

    public int GetYmn()
    {
        return x * y * z;
    }

    public int GetP()
    {
        return x + y + z;
    }
}

