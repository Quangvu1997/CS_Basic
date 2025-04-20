namespace Models;

public class Vector
{
    public int X { get; set; }
    public int Y { get; set; }
    public Vector(int _x, int _y)
    {
        this.X = _x;
        this.Y = _y;
    }
    public void Info()
    {
        Console.WriteLine($"X: {X}, Y: {Y}");
    }
    //vector + vector = vector
    public static Vector operator +(Vector v1, Vector v2)
    {
        return new Vector(v1.X + v2.X, v1.Y + v2.Y);
    }

    //vector + value = vector
    public static Vector operator +(Vector v1, int value)
    {
        return new Vector(v1.X + value, v1.Y + value);
    }

    //Indexer [chi_so]
    public int this[int index]
    {
        set
        {
            switch (index)
            {
                case 0:
                    this.X = value;
                    break;
                case 1:
                    this.Y = value;
                    break;
                default:
                    throw new Exception("Chi so khong hop le");
            }
        }
        get
        {
            switch (index)
            {
                case 0:
                    return this.X;
                case 1:
                    return this.Y;
                default:
                    throw new Exception("Chi so khong hop le");
            }
        }
    }
}