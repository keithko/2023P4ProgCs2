using System;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleMonGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, me!");
            Program.TestConsoleMonFunctions();
            Program.TestSkillFunctions();
            Program.TestFactoryFunctions();
            Program.TestConstructors();
            Program.TestCopyConsoleMon();
            Program.TestArena();
            Colors myMainThemeColors = Colors.blue ;

            if (myMainThemeColors == Colors.blue) 
            {
                Console.WriteLine("dat is mijn kleur!");
            }
            
        }
        static void TestConsoleMonFunctions()
        {
            Console.WriteLine("TestConsoleMonFunctions");
            ConsoleMon mon = new ConsoleMon();
            mon.TakeDamage(100);
            mon.DepleteEnergy(20);

            Console.WriteLine(mon.health == -100);

            Console.WriteLine(mon.energy == -20);

        }
        static void TestSkillFunctions()
        {
            Console.WriteLine("TestSkillFunctions");
            ConsoleMon casterMon = new ConsoleMon();
            ConsoleMon targetMon = new ConsoleMon();
            Skill skill = new Skill()
            {
                damage = 100,
                energyCost = 20,
            };
            skill.UseOn(targetMon, casterMon);

            Console.WriteLine(targetMon.health == -150);

            Console.WriteLine(casterMon.energy == -20);
        }
        static void TestFactoryFunctions()
        {
            Console.WriteLine("TestFactoryFunctions");
            ConsoleMonFactory factory = new ConsoleMonFactory();
            factory.Load("monsterdata.txt");
            factory.LoadJson("monsterdata.json");
        }
        static void TestConstructors()
        {
            Console.WriteLine("TestConstructors");
            ConsoleMon mon = new ConsoleMon(200, 200, "ConsoleColorMon", Element.Earth);

            Console.WriteLine(mon.energy == 200);
            Console.WriteLine(mon.name == "ConsoleColorMon");
            Console.WriteLine(mon.health == 200);
            Console.WriteLine(mon.weakness == Element.Earth);


            Skill skill = new Skill(90, 80, Element.Fire, "FireBlade");
            Console.WriteLine(skill.energyCost == 80);
            Console.WriteLine(skill.name == "FireBlade");
            Console.WriteLine(skill.damage == 90);
            Console.WriteLine(skill.element == Element.Fire);
        }
        static void TestCopyConsoleMon()
        {
            Console.WriteLine("TestCopyConsoleMon");
            ConsoleMonFactory factory = new ConsoleMonFactory();
            List<ConsoleMon> templates = factory.LoadJson("monsterdata.json");
            ConsoleMon copyFrom = templates[0];

            ConsoleMon copy = factory.CopyConsoleMon(copyFrom);
            Console.WriteLine(copy.name == copyFrom.name);
            Console.WriteLine(copy.health == copyFrom.health);
            Console.WriteLine(copy.skills == copyFrom.skills);
            Console.WriteLine(copy.skills[0] == copyFrom.skills[0]);
            copy.name = "anders";
            copy.skills[0].name = "newskill";
            Console.WriteLine(copy.name != copyFrom.name);
            Console.WriteLine(copy.skills[0].name != copyFrom.skills[0].name);
        }
        static void TestArena()
        {
            Console.WriteLine("TestArena");

            ConsoleMonFactory factory = new ConsoleMonFactory();
            List<ConsoleMon> templates = factory.LoadJson("monsterdata.json");

            Arena fight = new Arena();
            ConsoleMon fighterA = templates[0];

            ConsoleMon fighterB = templates[1];

            Arena.ReferenceEquals(fighterA, fighterB);
            Console.ReadKey();
        }
    }
}