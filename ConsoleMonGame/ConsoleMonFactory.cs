using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMonGame
{
    internal class ConsoleMonFactory
    {
        internal void Load(string datafile)
        {
            string[] lines= File.ReadAllLines("C:\\Users\\Student\\Desktop\\2023P4ProgCs2\\ConsoleMonGame\\bin\\Debug\\net7.0\\monsterdata.txt");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }

    }
}
