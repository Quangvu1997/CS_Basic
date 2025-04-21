namespace CommonFiles;

public class ListFileDirectory
{
    public static void GetFileDirectories(string path)
    {
        if (Directory.Exists(path))
        {
            var files = Directory.GetFiles(path);
            var directories = Directory.GetDirectories(path);

            foreach (var file in files)
            {
                Console.WriteLine(file);
            }
            foreach (var directory in directories)
            {
                Console.WriteLine(directory + ":");
                GetFileDirectories(directory);
                Console.WriteLine();
            }
        }
    }
}