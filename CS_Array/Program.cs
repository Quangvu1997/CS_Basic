using System;
using System.Linq;
namespace CS_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // string[] ds;
            // ds = new string[5];

            // ds[0] = "Nguyen Van A";
            // ds[1] = "Nguyen Van B";
            // ds[2] = "Nguyen Van C";
            // ds[3] = "Nguyen Van D";
            // ds[4] = "Nguyen Van E";

            // Console.WriteLine(ds[0]);
            // Console.WriteLine(ds[1]);
            // Console.WriteLine(ds[2]);
            // Console.WriteLine(ds[3]);
            // Console.WriteLine(ds[4]);
            // for (int i = 0; i < ds.Length; i++)
            // {
            //     Console.WriteLine(ds[i]);
            // }

            // int[] arrSoNguyen;
            // string[] mang1 = new string[2];
            // Console.WriteLine($"mang1[0] = {mang1[1]}");
            // // double[] mang2;

            // arrSoNguyen = new int[3];

            //Mang 1 chieu 
            // int[] numbers = { 1, 4, 7, 4, 3, 7, 34, 7 };
            // Console.WriteLine($"So phan tu: {numbers.Length}");
            // Console.WriteLine($"Chieu: {numbers.Rank}");
            // Console.WriteLine($"Min: {numbers.Min()}");
            // Console.WriteLine($"Max: {numbers.Max()}");
            // Console.WriteLine($"Sum: {numbers.Sum()}");
            // Console.WriteLine($"Average: {numbers.Average()}");

            // Array.Sort(numbers);
            // foreach (var item in numbers)
            // {
            //     Console.WriteLine(item);
            // }

            //Mang 2 chieu
            /*
                    0,1,2
                0   2,3,4,5
                1   1,9,8

                [0,1] = 3
                [0,2] = 4
                [1,1] = 9

            */
            int[,] mang2 = new int[2, 3];
            mang2[0, 0] = 1;
            mang2[0, 1] = 2;
            mang2[0, 2] = 3;
            mang2[1, 0] = 4;
            mang2[1, 1] = 5;
            mang2[1, 2] = 6;

            double[,] numberDs = new double[2, 3] { { 4.4, 2, 5.3 }, { 9, 34, 12 } };
            // Console.WriteLine($"numberDs[0,2] = {numberDs[0, 2]}"); // numberDs[0,2]

            int hang = 2;
            int cot = 3;
            for (int i = 0; i < hang; i++)
            {
                for (int j = 0; j < cot; j++)
                {
                    Console.Write($"{numberDs[i, j]}");
                    Console.Write("\t");
                }
                Console.WriteLine();
            }
        }
    }
}