using CommonConstants;
using CommonFiles;

namespace CS_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Thư viện .NET cung cấp lớp DriveInfo tại namespace System.IO giúp đọc thông tin các ổ đĩa có trong hệ thống. Phương thức DriveInfo.GetDrives() trả về mảng gồm các đối tượng DriveInfo, mỗi đối tượng chứa thông tin về một ổ đĩa.
            */
            // var drives = DriveInfo.GetDrives();
            // foreach (var driveInfo in drives)
            // {
            //     Console.WriteLine("Name: {0}", driveInfo.Name);
            //     Console.WriteLine("Type: {0}", driveInfo.DriveType);
            //     Console.WriteLine("Format: {0}", driveInfo.DriveFormat);
            //     Console.WriteLine("Total size: {0}", driveInfo.TotalSize);
            //     Console.WriteLine("Free space: {0}", driveInfo.AvailableFreeSpace);
            //     Console.WriteLine();
            // }

            //string path = "abc";
            // if (Directory.Exists(path))
            // {
            //     Console.WriteLine($"{path} - is exists");
            // }
            // else
            // {
            //     Console.WriteLine($"{path} - is not exists");
            // }
            // string path = "obj";
            // var files = Directory.GetFiles(path);
            // var directories = Directory.GetDirectories(path);
            // foreach (var directory in directories)
            // {
            //     Console.WriteLine(directory);
            // }
            // foreach (var file in files)
            // {
            //     Console.WriteLine(file);
            // }

            // ListFileDirectory.GetFileDirectories(StringConst.PATH_OBJ);

            Console.WriteLine(Path.DirectorySeparatorChar);
            var path = Path.Combine("Dir1", "Tenfile.txt");
            Console.WriteLine(path);
        }
    }
}