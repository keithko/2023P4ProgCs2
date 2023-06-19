namespace FileIOOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string[] content = File.ReadAllLines("leesdezefile.txt");
           
            foreach(string line in content)
            {
                Console.WriteLine(line);
            }

            File.WriteAllText("C:\\Users\\Student\\Desktop\\2023P4ProgCs2\\FileIOOpdracht\\mijnnieuwefile.txt", "hello");
            Directory.CreateDirectory("output");

            File.WriteAllText("C:\\Users\\Student\\Desktop\\2023P4ProgCs2\\FileIOOpdracht\\bin\\Debug\\net7.0\\output\\mijnnieuwefile.txt", "cool");


        }
    }
}