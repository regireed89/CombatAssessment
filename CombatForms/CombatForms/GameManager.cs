using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatForms
{
    
    class GameManager
    {

        public Party firstparty;
        public Party secondparty;
        public Player player1;
        public Player player2;
        public Player player3;
        public Player player4;
        public Player player5;
        public Player player6;
        public Player activeplayer;
        public FSM<GameStates> fsm;
        public List<Player> playerlist;
        public Player lastattacker;


        //new up when we access the property Instance
        private static GameManager instance;
        //private because someone to new up this instance
        private GameManager() { }
        //this is actually how we access it
        //how u use it Singleton.Instance."some variable"
        public static GameManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GameManager();
                }
                return instance;
            }
        }
    }
}
