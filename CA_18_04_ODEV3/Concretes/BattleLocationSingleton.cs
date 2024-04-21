using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_18_04_ODEV3.Concretes
{
    public class BattleLocationSingleton
    {
        private BattleLocationSingleton()
        {

        }

        private static BattleLocation _battleLocation;

        public static BattleLocation BattleLocation { 
            get
            {
                if(_battleLocation == null)
                {
                    _battleLocation = new BattleLocation();
                }

                return _battleLocation;
            }
                
        }

    }
}
