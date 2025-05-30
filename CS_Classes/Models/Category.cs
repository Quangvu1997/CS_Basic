namespace Models
{
    public class Category
    {
        private string categoryname;

        // Dùng thân biểu thức cho phương thức khởi tạo
        public Category(string nameofCategory) => categoryname = nameofCategory;
        public String Name
        {
            // Dùng thân biểu thức cho setter, getter
            set => categoryname = value;
            get => categoryname;
        }
    }
    public class CategoryMobile : Category
    {
        private string description;
        // Khi phương thức khởi tạo này được gọi, nó gọi phương thức khởi tạo có
        // một tham số của lớp cơ sở (Category) trước, rồi mới thi hành các code
        // trong thân của phương thức khởi tạo này
        public CategoryMobile(string nameofCategory, string mota) : base(nameofCategory)
        {
            description = mota;
        }
        public string Description
        {
            set => description = value;
            get => description;
        }
    }
}