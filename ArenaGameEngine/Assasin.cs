using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine
{
    // - Има 40% шанс да избегне напълно щетите.
    // - Има 20% шанс да причини щети, равни на 2 пъти неговата Сила.
    public class Assassin : Hero
    {
        public Assassin(string name) : base(name)
        {
        }

        public override void TakeDamage(int incomingDamage)
        {
            if (Random.Shared.Next(0, 100) < 40)
            {
                incomingDamage = 0;
            }
            base.TakeDamage(incomingDamage);
        }

        public override int Attack()
        {
            int baseAttack = base.Attack();
            if (Random.Shared.Next(0, 100) < 20)
            {
                baseAttack = Strength * 2;
            }
            return baseAttack;
        }
    }
}