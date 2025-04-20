using MyExceptions;

namespace CS_Exception
{
    class Program
    {
        static void Register(string name, int age)
        {
            //...
            if (string.IsNullOrEmpty(name))
            {
                //Exception exception = new Exception("Ten khac rong");
                throw new NameEmptyException();
            }
            if (age < 18 || age > 100)
            {
                throw new AgeException(age);
            }
            Console.WriteLine($"Xin chao {name} ({age})");
        }
        static void Main(string[] args)
        {
            try
            {
                Register("aaaa", 1001);
            }
            catch (NameEmptyException ex)
            {
                Console.WriteLine($"Program error: {ex.Message}; StackTrace: {ex.StackTrace}");
            }
            catch (AgeException ex)
            {
                Console.WriteLine(ex.Message);
                ex.Detail();
            }
            // catch (Exception ex)
            // {
            //     Console.WriteLine($"Program error: {ex.Message}; StackTrace: {ex.StackTrace}");
            // }
            // int a = 5;
            // int b = 0;

            // //Exception
            // try
            // {
            //     Console.WriteLine(a / b);
            // }
            // catch (Exception ex)
            // {
            //     Console.WriteLine($"Program error: {ex.Message}; StackTrace: {ex.StackTrace}");
            // }

            // string path = "1.txt";
            // try
            // {
            //     string s = File.ReadAllText(path);
            //     Console.WriteLine(s);
            // }
            // catch (ArgumentNullException ane)
            // {
            //     Console.WriteLine(ane.Message);
            //     Console.WriteLine($"Duong dan file null");
            // }
            // catch (FileNotFoundException fnfe)
            // {
            //     Console.WriteLine(fnfe.Message);
            //     Console.WriteLine($"File khong tom tai");
            // }
            // catch (Exception ex)
            // {
            //     Console.WriteLine($"Program error: {ex.Message}; StackTrace: {ex.StackTrace}");
            // }
        }
    }
}