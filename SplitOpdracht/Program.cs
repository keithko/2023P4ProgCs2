using System.Diagnostics;
using System.Security.Cryptography;

namespace SplitOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string content = File.ReadAllText("C:\\Users\\Student\\Desktop\\2023P4ProgCs2\\SplitOpdracht\\bin\\Debug\\net7.0\\stringsplit.txt");
            
            string[]  keyvalue = content.Split(',');

            foreach (string key in keyvalue)
            {
                Console.WriteLine(key);
            }

            string[] cijferPerVak = keyvalue[1].Split(",");
                foreach (string cijfer in cijferPerVak)
            {
                Console.WriteLine(cijfer);
            }

        }
    }
}