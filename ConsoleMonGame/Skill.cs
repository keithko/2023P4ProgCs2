using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMonGame
{
    internal class  Skill
    {
        internal int damage;

        internal int energyCost;

        internal Element element;

        string name;

        private List<Skill> skills;
    

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
    }
}
