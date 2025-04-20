namespace CS_Lambda
{
    /*
    Lambda -> Anonymous function
    1)
    (tham_so) => bieu_thuc;
    2)
    (tham_so) => {
        bieu_thuc;
        return ket_qua;
    }
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            // Action<string> thongbao;
            // thongbao = (string s) => Console.WriteLine(s); //~ delegate void KIEU(string s) = Action<string>
            // // thongbao?.Invoke("Xin Chao");
            // for (int i = 0; i < 10; i++)
            // {
            //     thongbao?.Invoke($"Xin Chao {i}");
            // }

            // Action thongBao1;
            // thongBao1 = () => Console.WriteLine("Xin chao cac ban");
            // thongBao1?.Invoke();

            // Action<string> welcome;
            // welcome = (string s) => Console.WriteLine($"Xin chao {s}");
            // welcome?.Invoke("Nguyen Van A");

            // Action<string> action;
            // action = s => Console.WriteLine(s);
            // action?.Invoke("Nguyen Van B xin chao");

            // Action<string, string> action1;
            // action1 = (msg, name) =>
            // {
            //     Console.ForegroundColor = ConsoleColor.Yellow;
            //     Console.WriteLine($"{msg} {name}");
            //     // Console.ResetColor();
            // };
            // action1?.Invoke("Xin Chao", "Anh Quang");

            // Func<int> tinhtoan;
            // tinhtoan = () => 10;
            // Console.WriteLine(tinhtoan?.Invoke());

            // Func<int, int, int> tinhtoan1;
            // tinhtoan1 = (a, b) => a + b;
            // Console.WriteLine(tinhtoan1?.Invoke(3, 4));

            int[] mang = { 2, 4, 64, 5, 7, 8, 10, 35 };
            // mang.ToList().ForEach(
            //     x =>
            //     {
            //         if (x % 2 != 0)
            //             Console.WriteLine(x);
            //     }
            // );
            var kq = mang.Where(
                x => x >= 10 && x <= 50
            );
            // var kq = mang.Select(
            //     (int x) =>
            //     {
            //         // return Math.Sqrt(x);
            //         return Math.PI;
            //     }
            // );

            foreach (var item in kq)
            {
                Console.WriteLine(item);
            }
        }
        // (int a, int b) =>
        // {
        //     int kq = a + b;
        //     return kq;
        // }
    }
}