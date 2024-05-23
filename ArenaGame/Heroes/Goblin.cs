using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Goblin : Hero
    {
        public Goblin(string name, double armor, double strength, IWeapon weapon)
            : base(name, armor, strength, weapon)
        {
        }

        public override double Attack()
        {
            double damage = base.Attack();
            double probability = random.NextDouble();
            if (probability < 0.10)
            {
                damage *= 1.5;
            }
            return damage;
        }

        public override double Defend(double damage)
        {
            double realDamage = base.Defend(damage * 0.5);
            return realDamage;
        }
    }
}
