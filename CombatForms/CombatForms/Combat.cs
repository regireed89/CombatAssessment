using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CombatForms
{

    public enum PlayerStates
    {
        INIT = 0,
        IDLE = 1,
        ATTACK = 2,
        ENDTURN = 3,
        DEAD = 4,
    }

    public class Combat
    {

        //new up when we access the property Instance
        private static Combat instance;
        //private because someone to new up this instance
        public Combat() { parties = new List<Party>(); }
        //this is actually how we access it
        //how u use it Singleton.Instance."some variable"
        public static Combat Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Combat();
                }
                return instance;
            }
        }
        List<Party> parties;

        public void AddParty(Party p)
        {
            parties.Add(p);
        }
        public Party activeParty;
    }
}


