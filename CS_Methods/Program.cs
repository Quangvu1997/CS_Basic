using System;
namespace CS_Methods
{
    class Program
    {

        static void XinChao(string ten = "Nguyen Van A")
        {
            Console.WriteLine($"Xin chao: {ten}");
        }
        static double BinhPhuong(double a) => a * a;


        /*
        Có hai hình thức truyền tham số cho phương thức khi nó được gọi là tham trị và tham chiếu

            - tham trị là cách thức mặc định, ta đã sử dụng ở phần trên. Có nghĩa là gán tham số bằng một biến, thì giá trị của biến được copy và sử dụng trong phương thức như biến cục bộ, còn bản thân biến bên ngoài không hề ảnh hưởng.
            - tham chiếu thì bản thân biến ở tham số sẽ được hàm sử dụng trực tiếp (tham chiếu) chứ không tạo ra một biến cục bộ trong hàm, nên nó có tác động trực tiếp đến biến này bên ngoài. Để sử dụng được tham chiếu thì khai báo tham số ở phương thức, cũng như khi gọi cần cho thêm từ khóa ref
        */
        public static void ThamTri(int a)
        {
            a = a * a;
            Console.WriteLine(a + " tham tri");
        }
        public static void ThamChieu(ref int a)
        {
            a = a * a;
            Console.WriteLine(a + " tham chieu");
        }
        /*
        Tham chiếu với out
        Ngoài dùng từ khóa ref trong khai báo tham chiếu, bạn cũng có thể thay thế nó bằng từ khóa out, điểm khác biệt duy nhất là nếu dùng từ khóa out thì tham số không cần khởi tạo khi truyền cho phương thức, còn dùng ref thì biến làm tham số phải khởi tạo.
        */
        public static void ThamChieuOut(out int a)
        {
            a = 24;
        }
        /*
        Phương thức Đệ quy
        Đệ quy là phương thức khai báo, trong thân của nó có gọi lại chính nó.
        */
        public static int GiaiThua(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            else
                return n * GiaiThua(n - 1);
        }
        /// <summary>
        /// Entry point of the program.
        /// Demonstrates different parameter passing methods in C#.
        /// </summary>
        /// <param name="args">Array of command-line arguments.</param>
        static void Main(string[] args)
        {
            // Declare an integer variable 'a' and initialize it to 10
            int a = 10;

            // Call ThamTri method with 'a' passed by value
            ThamTri(a);
            // Output the value of 'a' after ThamTri call
            Console.WriteLine(a);

            // Call ThamChieu method with 'a' passed by reference
            ThamChieu(ref a);
            // Output the value of 'a' after ThamChieu call
            Console.WriteLine(a);

            // Call ThamChieuOut method with 'a' passed by reference using 'out'
            ThamChieuOut(out a);
            // Output the value of 'a' after ThamChieuOut call
            Console.WriteLine(a);

            long b = 10;
            Console.WriteLine($"Giai thua {b} la: {GiaiThua(10)}");
        }
    }
}