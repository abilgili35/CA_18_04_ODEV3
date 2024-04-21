using CA_18_04_ODEV3.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_18_04_ODEV3.Abstarcts
{
    public abstract class BaseCharacter
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int MaxDamage { get; set; }
        public int HealthLevel { get; set; }
        public RaceType Race { get; set; }
        public SkillType Skill { get; set; }

        public BaseCharacter(string name, int level, int maxDamage, int healthLevel)
        {
            Name = name;
            Level = level;
            MaxDamage = maxDamage;
            HealthLevel = healthLevel;
        }

        public abstract int GetDamage();
        public abstract void IncreaseLevel();


    }
}
