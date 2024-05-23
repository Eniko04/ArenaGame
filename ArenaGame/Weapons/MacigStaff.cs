using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class MagicStaff : IWeapon
    {
        public string Name { get; set; }
        public double AttackDamage { get; private set; }
        public double BlockingPower { get; private set; } = 0; 

        public MagicStaff(string name)
        {
            Name = name;
            AttackDamage = 40; 
        }
    }
}
