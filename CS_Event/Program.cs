namespace CS_Event
{
    public class DuLieuNhap : EventArgs
    {
        public int data { get; set; }
        public DuLieuNhap(int data)
        {
            this.data = data;
        }
    }
    public delegate void SukienNhapSo(int x);
    /*
        publisher -> class -> phat su kien
        subscriber -> class -> nhan su kien
    */
    // publisher
    class UserInput
    {
        // public event SukienNhapSo sukienNhapSo;
        public event EventHandler sukienNhapSo; // ~delegate void KIEU(object sender, EventArgs e)
        public void Input()
        {
            do
            {
                Console.Write("Nhap so nguyen: ");
                string s = Console.ReadLine();
                int i = Int32.Parse(s);
                //phat su kien
                sukienNhapSo?.Invoke(this, new DuLieuNhap(i));
            } while (true);
        }
    }
    // subscriber
    class TinhCan
    {
        public void Sub(UserInput userInput)
        {
            userInput.sukienNhapSo += Can;
        }
        public void Can(object sender, EventArgs e)
        {
            DuLieuNhap duLieuNhap = (DuLieuNhap)e;
            int i = duLieuNhap.data;
            Console.WriteLine($"Can bac 2 cua {i} la: {Math.Sqrt(i)}");
        }
    }
    // subscriber
    class BinhPhuong
    {
        public void Sub(UserInput userInput)
        {
            userInput.sukienNhapSo += TinhBinhPhuong;
        }
        public void TinhBinhPhuong(object sender, EventArgs e)
        {
            DuLieuNhap duLieuNhap = (DuLieuNhap)e;
            int i = duLieuNhap.data;
            Console.WriteLine($"Binh phuong cua {i} la: {i * i}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CancelKeyPress += (sender, e) =>
            {
                Console.WriteLine("Dang thoat");
                Environment.Exit(1);
            };
            //publisher
            UserInput userInput = new UserInput();

            userInput.sukienNhapSo += (sender, e) =>
            {
                DuLieuNhap duLieuNhap = (DuLieuNhap)e;
                int x = duLieuNhap.data;
                Console.WriteLine("Ban vua nhap so:" + x);
            };
            //subscriber
            TinhCan tinhCan = new TinhCan();
            tinhCan.Sub(userInput);

            BinhPhuong binhPhuong = new BinhPhuong();
            binhPhuong.Sub(userInput);

            userInput.Input();
        }
    }
}