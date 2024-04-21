using CA_18_04_ODEV3.Abstarcts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_18_04_ODEV3.Concretes
{
    public class BattleLocation
    {
        public BaseCharacter Player1 { get; set; }
        public BaseCharacter Player2 { get; set; }

        public void Combat()
        {
            if((Player1 == null) || (Player2 == null))
            {
                Console.WriteLine("Savascilar hazir degil.");
            }
            else
            {
                Console.WriteLine(Player1.Name + " ile " + Player2.Name + " birbiri ile savasiyor");
            }
        }
    }
}
