using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMonGame
{
    internal class Arena
    {
        internal void Fight(ConsoleMon fighterA, ConsoleMon fighterB)
        {
            fighterA.skills[0].UseOn(fighterA, fighterB);
            Thread.SpinWait(1000);
            Console.WriteLine("{fighterA.name} Attack {fighterB.name}aan");

            fighterB.skills[0].UseOn(fighterB, fighterA);
            Thread.GetDomainID();
            Console.WriteLine("{fighterB.name} Don't Attack {fighterA.name}aan");

            fighterA.skills[0].UseOn(fighterA, fighterB);
            Thread.Yield();
            Console.WriteLine("{fighterA.name} give up");
            Console.WriteLine("{fighterB.name} is convust");


        }
    }
}
