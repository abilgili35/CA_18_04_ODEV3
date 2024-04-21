using CA_18_04_ODEV3.Abstarcts;
using CA_18_04_ODEV3.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_18_04_ODEV3.Concretes
{
    public class DwarfRogue : BaseCharacter, IDwarf, IRogue
    {
        public DwarfRogue(string name, int level) : base(name, level, 10, 80)
        {
            Race = RaceType.Dwarf;
            Skill = SkillType.Rogue;
        }

        public void AttackFromDistance()
        {
            Console.WriteLine($"{Name} karakteri uzaktan saldirdi.");
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

        public void Hide()
        {
            Console.WriteLine($"{Name} karakteri saklandi.");
        }

        public override void IncreaseLevel()
        {
            Level += 1;
        }
    }
}
