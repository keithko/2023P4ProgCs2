namespace ListOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            List<string> bird = new List<string> { "uil", "kraai", "papegaai", "hond" };
            List<string> birds2 = new List<string> { "duif", "meeuw" };
            bird.AddRange(birds2);
            bird.Remove("hond");
            Console.WriteLine(bird[0]);
            Console.WriteLine(bird[1]);
            Console.WriteLine(bird[2]);
            Console.WriteLine(bird[3]);
            Console.WriteLine(bird[4]);     

        }
    }
}