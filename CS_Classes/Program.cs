using Models;

namespace CS_Classes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            VuKhi vuKhi = new VuKhi("Vu khon", 19);
            vuKhi.TanCong();

            // Product product = new Product();
            // Console.WriteLine(product.Name);
            // Product product1 = new Product("Dien thoai", 1000);
            // Console.WriteLine(product1.Name);

            CategoryMobile cat1 = new CategoryMobile("Điện thoại", "Danh mục các loại điện thoại");
            Console.WriteLine(cat1.Name);
            Console.WriteLine(cat1.Description);
        }
    }
}