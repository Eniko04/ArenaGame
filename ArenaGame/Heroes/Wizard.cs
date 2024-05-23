using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Wizard : Hero
    {
        private double hitCount;
        private double damageCoef;

        public Wizard(string name, double armor, double strength, IWeapon weapon)
            : base(name, armor, strength, weapon)
        {
            hitCount = 0;
            damageCoef = 0.5;
        }

        public override double Attack()
        {
            double damage = base.Attack() * 1.5;
            return damage;
        }

        public override double Defend(double damage)
        {
            hitCount++;
            if (hitCount == 3)
            {
                hitCount = 0;
                return 0;
            }
            return base.Defend(damage);
        }
    }
}