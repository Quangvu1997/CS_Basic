using Models;

namespace CS_OverLoading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CountNumber.Info();
            // Console.WriteLine(CountNumber.count);

            // CountNumber countNumber = new CountNumber();
            // CountNumber countNumber1 = new CountNumber();

            // countNumber.Count();
            // countNumber1.Count();
            // CountNumber.Info();

            // Student s = new Student("Nguyen Van B");
            // Console.WriteLine(s.name);

            // Vector vector1 = new Vector(1, 2);
            // // vector1.Info();
            // Vector vector2 = new Vector(3, 4);
            // // vector2.Info();

            // var vector3 = vector1 + vector2;
            // vector3.Info();
            // var vector4 = vector3 + 10;
            // vector4.Info();

            Vector v = new Vector(1, 2);
            v.Info();
            Console.WriteLine(v[1]);
            Console.WriteLine(v[0]);
            Console.WriteLine(v[2]);
        }
    }
}