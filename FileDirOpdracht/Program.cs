using System.Security.AccessControl;

namespace FileDirOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            DirectoryInfo dir;
            {
                dir = new DirectoryInfo(@"C:\\Users\\Student\\Desktop\\2023P4ProgCs2");
                FileInfo[] files = dir.GetFiles();
                 
                foreach (FileInfo file in files)
                {
                    Console.WriteLine(file.Name);
                }

                foreach(DirectoryInfo dirs in dir.GetDirectories())
                {
                    Console.WriteLine(dirs.Name);
                }
                
            }
        }
    }
}
