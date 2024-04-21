using CA_18_04_ODEV3.Abstarcts;
using CA_18_04_ODEV3.Concretes;
using CA_18_04_ODEV3.Enums;

namespace CA_18_04_ODEV3
{
    public class Program
    {
        public static void Main(string[] args)
        {

            CharacterFactoryClass characterFactory = new CharacterFactoryClass();

            Message.CreateCharacterMessage();

            Message.ChooseCharacterNameMessage();
            string characterName = Console.ReadLine();

            Message.ChooseCharacterRaceMessage();
            int characterRace = int.Parse(Console.ReadLine());
            RaceType race;

            switch (characterRace)
            {
                case 1:
                    race = RaceType.Elf;
                    break;
                case 2:
                    race = RaceType.Human;
                    break;
                case 3:
                    race = RaceType.Dwarf;
                    break;
                default:
                    Message.WrongCharacterRaceMessage();
                    Console.Read();
                    return;
            }

            Message.ChooseCharacterSkillMessage();

            int characterSkill = int.Parse(Console.ReadLine());
            SkillType skill;

            switch (characterSkill)
            {
                case 1:
                    skill = SkillType.Warrior;
                    break;
                case 2:
                    skill = SkillType.Wizard;
                    break;
                case 3:
                    skill = SkillType.Rogue;
                    break;
                default:
                    Message.WrongCharacterRaceMessage();
                    Console.Read();
                    return;
            }

            BaseCharacter character1 = characterFactory.FactoryMethod(characterName, 1, race, skill);

            Message.CharacterCreatedMessage(character1);

            BaseCharacter character2 = characterFactory.FactoryMethod("Dwarf Wizard", 1, RaceType.Dwarf, SkillType.Wizard);

            Message.CharacterCreatedMessage(character2);

            BattleLocationSingleton.BattleLocation.Player1 = character1;
            BattleLocationSingleton.BattleLocation.Player2 = character2;
            BattleLocationSingleton.BattleLocation.Combat();

            Console.Read();
        }
    }
}
