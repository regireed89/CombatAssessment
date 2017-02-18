using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatForms
{
    public class Party
    {

        public Party()
        {
            
        }
        List<Player> players = new List<Player>();
        public Player activePlayer;
        int currentID = 0;

        public delegate void OnPartyEnd();
        public OnPartyEnd onPartyEnd;

        public void AddPlayer(Player p)
        {
            if (players.Count <= currentID)
            {
                players.Add(p);
                activePlayer = players[currentID];
                p.onEndTurn += GetNext;
                return;
            }
            players.Add(p);
            p.onEndTurn += GetNext;
        }

      
        public void GetNext()
        {
          
            if (currentID >= players.Count - 1)
            {
                currentID = 0;
                activePlayer = players[currentID];
                if (onPartyEnd != null)
                    onPartyEnd.Invoke();
                return;
            }
            currentID++;
            activePlayer = players[currentID];

        }

        public void EndTurn()
        {
            if (onPartyEnd != null)
            {
                onPartyEnd.Invoke();
            }
        }      
        public void Sort()
        {
            players.Sort((x, y) =>   x.AttackSpeed.CompareTo(y.AttackSpeed));
            activePlayer = players[currentID];
        }
    }
}
