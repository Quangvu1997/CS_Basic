namespace Models
{
    /*
        Các thành viên trong lớp (phương thức, biến, thuộc tĩnh) khi khai báo có từ khóa static ở đầu thì nó là thành viên tĩnh. Thành viên tĩnh thì nó không thuộc về đối tượng cụ thể nào, có thể sử dùng mà không cần tạo đối tượng. Truy cập đến thành viễn tĩnh thông qua:
            TÊN-LỚP.tên-thành-viên-tĩnh.
    */
    class CountNumber
    {
        public static int count = 0;
        public static void Info()
        {
            Console.WriteLine("So lan truy cap: " + count);
        }
        public void Count()
        {
            // count++;
            CountNumber.count++;
        }
    }
}