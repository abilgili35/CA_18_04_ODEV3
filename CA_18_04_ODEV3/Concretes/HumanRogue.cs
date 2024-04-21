using CA_18_04_ODEV3.Abstarcts;
using CA_18_04_ODEV3.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_18_04_ODEV3.Concretes
{
    public class HumanRogue : BaseCharacter, IHuman, IRogue
    {
        public HumanRogue(string name, int level) : base(name, level, 10, 120)
        {
            Race = RaceType.Human;
            Skill = SkillType.Rogue;
        }

        public void AttackFromDistance()
        {
            Console.WriteLine($"{Name} karakteri uzaktan saldirdi.");
        }

        public void BlockAttack(int damage)
        {
            Console.WriteLine($"{Name} karakteri saldiriyi blokladi.");
        }

        public override int GetDamage()
        {
            int damage = 0;
            Random rand = new Random();

            damage = (int)rand.Next(0, damage);

            if (damage > MaxDamage)
            {
                damage = MaxDamage;
            }

            return damage;
        }

        public override void IncreaseLevel()
        {
            Level += 1;
        }
    }
}
