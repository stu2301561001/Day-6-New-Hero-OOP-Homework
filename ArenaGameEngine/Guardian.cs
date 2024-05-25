using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine

{
    // - Има броня, която намалява входящите щети с между 30 и 70%.
    // - Всеки 4-ти удар може да причини двойни щети.
    public class Guardian : Hero
    {
        public Guardian() : this("Protector") // По подразбиране всички защитници са наречени 'Protector'
        {
        }

        public Guardian(string name) : base(name) // С именуван защитник, ние подаваме името
        {
            hitCount = 0;
        }

        private int hitCount;

        public override int Attack()
        {
            hitCount++;
            int damage = base.Attack();
            if (hitCount == 4)
            {
                damage *= 2;
                hitCount = 0;
            }
            return damage;
        }

        public override void TakeDamage(int incomingDamage)
        {
            int reduction = Random.Shared.Next(30, 71);
            int reducedDamage = incomingDamage * (100 - reduction) / 100;
            base.TakeDamage(reducedDamage);
        }
    }
}