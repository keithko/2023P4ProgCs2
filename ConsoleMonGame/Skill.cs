using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMonGame
{
    internal class  Skill
    {
        public int damage { get; set; }

        public int energyCost { get; set; }

        public Element element { get; set; }

        public string name { get; set; }
    

    internal void UseOn(ConsoleMon target, ConsoleMon caster)
        {
            if (target.weakness == element)
            {
               // damage =(int)( damage *1.5);
                target.TakeDamage(damage/2);
            }

            caster.DepleteEnergy(energyCost);
            target.TakeDamage(damage);
        }
    public Skill()
        {
            
        }
    internal Skill(int damage, int energyCost, Element element, string name)
        {
            this.damage = damage;
            this.energyCost = energyCost;
            this.element = element;
            this.name = name;
        }
    }
}
