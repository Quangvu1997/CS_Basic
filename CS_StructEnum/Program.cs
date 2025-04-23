namespace CS_StructEnum
{
    //Struct
    public struct Product
    {
        //constructor
        public Product(int id, string name, double price)
        {
            Id = id;
            this.Name = name;
            this.Price = price;
        }

        //du lieu
        public int Id;
        public string Name;
        public double Price;

        public string Info
        {
            get
            {
                return $"Id: {Id}, Name: {Name}, Price: {Price}";
            }
        }
        //phuong thuc

        public string GetInfo()
        {
            return $"Id: {Id}, Name: {Name}, Price: {Price}";
        }
    }
    //Kieu liet ke enum
    /*
        0 - kem
        1 - trung binh 
        2 - kha
        3 - gioi
    */
    enum HOCLUC
    {
        Kem,        //0
        TrungBinh,  //1
        Kha,        //2
        Gioi        //3
    }
    enum HOCLUCDEFAULT
    {
        Kem = 0,        //0
        TrungBinh = 1,  //1
        Kha = 10,        //2
        Gioi = 11        //3
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Product product;
            // product.Id = 1;
            // product.Name = "Laptop";
            // product.Price = 1000;
            // // Console.WriteLine(product.GetInfo());

            // Product product1 = new Product(2, "Tablet", 500);
            // product1 = product;
            // Console.WriteLine(product1.GetInfo());
            // Console.WriteLine(product1.Info);

            // HOCLUC hocLuc = HOCLUC.Kha;
            // switch (hocLuc)
            // {
            //     case HOCLUC.Kem:
            //         Console.WriteLine("Kem");
            //         break;
            //     case HOCLUC.TrungBinh:
            //         Console.WriteLine("Trung binh");
            //         break;
            //     case HOCLUC.Kha:
            //         Console.WriteLine("Kha");
            //         break;
            //     case HOCLUC.Gioi:
            //         Console.WriteLine("Gioi");
            //         break;
            //     default:
            //         Console.WriteLine("Khong hop le");
            //         break;
            // }
            HOCLUCDEFAULT hOCLUCDEFAULT = HOCLUCDEFAULT.Gioi;
            int so = (int)hOCLUCDEFAULT;
            Console.WriteLine(so);
        }
    }
}