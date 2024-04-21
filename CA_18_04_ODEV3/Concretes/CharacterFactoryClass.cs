using CA_18_04_ODEV3.Abstarcts;
using CA_18_04_ODEV3.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_18_04_ODEV3.Concretes
{
    public class CharacterFactoryClass
    {
        public BaseCharacter FactoryMethod(string characterName, int characterLevel, RaceType raceType, SkillType skillType)
        {
            BaseCharacter character = null;

            switch (raceType)
            {
                case RaceType.Human:
                    switch (skillType) 
                    {
                        case SkillType.Wizard:
                            character = new HumanWizard(characterName, characterLevel);
                            break;
                        case SkillType.Rogue:
                            character = new HumanRogue(characterName, characterLevel);
                            break;
                        case SkillType.Warrior:
                            character = new HumanWarrior(characterName, characterLevel);
                            break;
                    }
                    break;
                case RaceType.Elf:
                    switch (skillType)
                    {
                        case SkillType.Wizard:
                            character = new ElfWizard(characterName, characterLevel);
                            break;
                        case SkillType.Rogue:
                            character = new ElfRogue(characterName, characterLevel);
                            break;
                        case SkillType.Warrior:
                            character = new ElfWarrior(characterName, characterLevel);
                            break;
                    }
                    break;
                case RaceType.Dwarf:
                    switch (skillType)
                    {
                        case SkillType.Wizard:
                            character = new DwarfWizard(characterName, characterLevel);
                            break;
                        case SkillType.Rogue:
                            character = new DwarfRogue(characterName, characterLevel);
                            break;
                        case SkillType.Warrior:
                            character = new DwarfWarrior(characterName, characterLevel);
                            break;
                    }
                    break;
            }

            return character;
        }
    }
}
