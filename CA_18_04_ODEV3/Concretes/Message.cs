using CA_18_04_ODEV3.Abstarcts;
using CA_18_04_ODEV3.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_18_04_ODEV3.Concretes
{
    public class Message
    {
        public static void CreateCharacterMessage()
        {
            Console.WriteLine("MMORPG oyununa hosgeldiniz.Lutfen bir karakter olusturun.");
        }

        public static void CharacterCreatedMessage(BaseCharacter character)
        {
            string race = "";
            string skill = "";

            switch(character.Race)
            {
                case RaceType.Human:
                    race = "Insan";
                    break;
                case RaceType.Elf:
                    race = "Elf";
                    break;
                case RaceType.Dwarf:
                    race = "Cuce";
                    break;
            }

            switch (character.Skill)
            {
                case SkillType.Warrior:
                    skill = "Savasci";
                    break;
                case SkillType.Wizard:
                    skill = "Buyucu";
                    break;
                case SkillType.Rogue:
                    skill = "Rogue";
                    break;
            }

            Console.WriteLine($"{race} irkina ait {skill} karakteriniz {character.Name} ismi ile level {character.Level} olarak olusturuldu.\n");

        }

        public static void WrongCharacterRaceMessage()
        {
            Console.WriteLine("\nYanlis bir secim yaptiniz.Program sonlandiriliyor.\n");
        }

        public static void WrongCharacterSkillMessage()
        {
            Console.WriteLine("\nYanlis bir yetenek secimi yaptiniz.Program sonlandiriliyor.\n");
        }

        public static void ChooseCharacterNameMessage()
        {
            Console.WriteLine("\nLutfen karakterinizin adini giriniz.\n");
        }

        public static void ChooseCharacterRaceMessage()
        {
            Console.WriteLine("\nLutfen karakterinizin irkini seciniz.\n\n1-Elf\n2-Insan\n3-Dwarf.");
        }

        public static void ChooseCharacterSkillMessage()
        {
            Console.WriteLine("\nLutfen karakterinizin yetenegini seciniz.\n\n1-Savasci\n2-Buyucu\n3-Rogue.");
        }


    }
}
