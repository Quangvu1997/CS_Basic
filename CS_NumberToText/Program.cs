using System;

namespace CS_NumberToText
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kiểm tra ngẫu nhiên 1000 số
            int ntest = 1000;
            Random rn = new Random();
            for (int i = 0; i < ntest; i++)
            {
                var number = rn.NextDouble() * rn.Next(1, Int32.MaxValue);
                var text = XTL.Utils.NumberToText(number);
                var ntext = number.ToString("###,###,###,###,###");
                Console.WriteLine($"{ntext,20} --> {text}");
            }
        }
    }
}