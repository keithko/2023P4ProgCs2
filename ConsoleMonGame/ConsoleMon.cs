﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMonGame
{
    internal class ConsoleMon
    {
        internal int  health;
        internal int energy;
        internal string name;
        
        internal void TakeDamage(int damage)
            {
                this.health -= damage;
            }
        internal void DepleteEnergy(int energy)
        {
            this.energy -= energy;
        }
    }
}
