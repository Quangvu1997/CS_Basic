namespace CS_Delegate
{
    //Delegate (hàm ủy quyền) là một kiểu dữ liệu, nó dùng để tham chiếu (trỏ đến) đến các hàm (phương thức) có tham số và kiểu trả về phù hợp với khai báo kiểu
    // internal delegate void ShowLog(string message);
    // internal delegate void ShowLogMultiple(string message1, string message2);
    class Program
    {
        static void Main(string[] args)
        {
            Dowloader dowloader = new Dowloader();
            dowloader.DowloadFile("https://www.google.com", () => Console.WriteLine("File da duoc xu ly sau khi tai"));
        }
    }
    // {
    //     static void Info(string message)
    //     {
    //         Console.ForegroundColor = ConsoleColor.Green;
    //         Console.WriteLine(message);
    //         Console.ResetColor();
    //     }
    //     static void Warning(string message)
    //     {
    //         Console.ForegroundColor = ConsoleColor.Red;
    //         Console.WriteLine(message);
    //         Console.ResetColor();
    //     }
    //     static void TestShowLogMul(string message1, string message2)
    //     {
    //         Console.ForegroundColor = ConsoleColor.Green;
    //         Console.WriteLine($"{message1} {message2}");
    //         Console.ResetColor();
    //     }
    //     static void TestShowWarningMul(string message1, string message2)
    //     {
    //         Console.ForegroundColor = ConsoleColor.Red;
    //         Console.WriteLine($"{message1} {message2}");
    //         Console.ResetColor();
    //     }
    //     static void Main(string[] args)
    //     {
    //         ShowLog log = Info;

    //         // if (log != null)
    //         //     log("Hello");
    //         // log?.Invoke("Xin chao Abc"); // 2 cach thuc tuong tu nhau

    //         // log = Warning;
    //         // log?.Invoke("Hoc ve Delegate");

    //         // //Gán nhiều phương thức vào delegate 
    //         // ShowLogMultiple logMultiple = null;
    //         // logMultiple += TestShowLogMul;
    //         // logMultiple += TestShowLogMul;
    //         // logMultiple += TestShowLogMul;
    //         // logMultiple += TestShowWarningMul;
    //         // logMultiple += TestShowWarningMul;
    //         // logMultiple += TestShowLogMul;
    //         // logMultiple?.Invoke("Hello", "Abc");

    //         // //Action Func : delegate Generic
    //         // Action action; // delegate void KIEU()
    //         // Action<string, int> actionParam; // delegate void KIEU(string s, int i)
    //         // Action<string> action1; // delegate void KIEU(string s)
    //         // action1 = Warning;
    //         // action1 += Info;
    //         // action1?.Invoke("Thong bao tu Action Delegate");

    //         // Func<int> func; // delegate int KIEU()
    //         // Func<string, double, string> f2; // delegate string KIEU(string s, double d)
    //         // Func<int, int, int> func1; // delegate int KIEU(int a, int b)
    //         // func1 = Tong;
    //         // int kq = func1(10, 5);
    //         // Console.WriteLine(kq);

    //         ShowTong(10, 5, null);
    //         ShowTong(10, 5, Info);
    //         ShowTong(10, 5, Warning);

    //     }
    //     static int Tong(int a, int b) => a + b;
    //     static int Hieu(int a, int b) => a - b;
    //     static void ShowTong(int a, int b, ShowLog log) => log?.Invoke($"{a} + {b} = {a + b}");
}