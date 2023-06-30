using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleMonGame
{
    internal class ConsoleMonFactory
    {
        internal void Load(string datafile)
        {
            string[] lines = File.ReadAllLines("C:\\Users\\Student\\Desktop\\2023P4ProgCs2\\ConsoleMonGame\\bin\\Debug\\net7.0\\monsterdata.txt");

            foreach (string line in lines)
            {
                string[] typeSplit = line.Split('|');
                string[] consoleMonData = typeSplit[0].Split(',');
                Console.WriteLine(line);
                ConsoleMon datamon = new ConsoleMon();
                datamon.name = consoleMonData[0];
                datamon.energy = Convert.ToInt32(consoleMonData[2]);
                datamon.health = Convert.ToInt32(consoleMonData[4]);

                Console.WriteLine(datamon.name);
                Console.WriteLine(datamon.energy);
                Console.WriteLine(datamon.health);
            }
        }
        internal List<ConsoleMon> LoadJson(string datafile)
        {
            string json = File.ReadAllText("C:\\Users\\Student\\Desktop\\2023P4ProgCs2\\ConsoleMonGame\\bin\\Debug\\net7.0\\monsterdata.json");

            List<ConsoleMon> templates = JsonSerializer.Deserialize<List<ConsoleMon>>(json);
            Console.WriteLine(templates[0].name);
            return templates;
        }
        internal Skill CopySkill(Skill Copyfrom)
        {
            Skill copyResult = new Skill();
            copyResult.name = Copyfrom.name;
            copyResult.damage = Copyfrom.damage;
            copyResult.element = Copyfrom.element;
            copyResult.energyCost = Copyfrom.energyCost;

            return copyResult;
        }
        internal ConsoleMon CopyConsoleMon(ConsoleMon copyFrom)
        {
            ConsoleMon copyResult = new ConsoleMon();
            copyResult.name = copyFrom.name;
            copyResult.health = copyFrom.health;
            copyResult.energy = copyFrom.energy;
            copyResult.weakness = copyFrom.weakness;
            copyResult.skills = new List<Skill>();
            foreach (Skill skill in copyFrom.skills)
            {
                Skill skillnew = new Skill();
                skillnew.element = skillnew.element;
                skillnew.energyCost = skillnew.energyCost;
                skillnew.damage = skillnew.damage;
                skillnew.name = skillnew.name;

                copyResult.skills.Add(skillnew);
            }
            return copyResult;
        }
    }
}

