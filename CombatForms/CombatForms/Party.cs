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
        //public Player activePlayer;
        int currentID = 0;

        public delegate void OnPartyEnd();
        public OnPartyEnd onPartyEnd;

        public void AddPlayer(Player p)
        {
            if (players.Count <= currentID)
            {
                players.Add(p);
                GameManager.Instance.activeplayer = players[currentID];
                p.onEndTurn += GetNext;
                return;
            }
            players.Add(p);
            p.onEndTurn += GetNext;
        }


        public void GetNext()
        {

            if (currentID <= GameManager.Instance.playerlist.Count)
            {
                currentID = 0;
                GameManager.Instance.activeplayer = GameManager.Instance.playerlist[currentID];
                if (onPartyEnd != null)
                    onPartyEnd.Invoke();
                return;
            }

            currentID++;
            GameManager.Instance.activeplayer = GameManager.Instance.playerlist[currentID];
            GameManager.Instance.activeplayer.ToIdle();

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
            players.Sort((x, y) => x.AttackSpeed.CompareTo(y.AttackSpeed));
            GameManager.Instance.activeplayer = players[currentID];
        }
    }
}
