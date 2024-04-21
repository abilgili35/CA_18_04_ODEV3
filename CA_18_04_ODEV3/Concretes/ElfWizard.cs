﻿using CA_18_04_ODEV3.Abstarcts;
using CA_18_04_ODEV3.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_18_04_ODEV3.Concretes
{
    public class ElfWizard : BaseCharacter, IElf, IWizard
    {
        public ElfWizard(string name, int level) : base(name, level, 7, 100)
        {
            Race = RaceType.Elf;
            Skill = SkillType.Wizard;
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

        public void RegenerateHealth()
        {
            Console.WriteLine($"{Name} karakteri sagligini yeniledi.");
        }

        public void SpellMagic()
        {
            Console.WriteLine($"{Name} karakteri buyu yapti.");
        }
    }
}
