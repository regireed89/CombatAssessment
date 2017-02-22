using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatForms
{
    public class Party
    {

        public Party(){}
        List<Player> players = new List<Player>();
        //public Player activePlayer;
        int currentID = 0;

        public delegate void OnPartyEnd();
        public OnPartyEnd onPartyEnd;

        /// <summary>
        /// function to add player to a party
        /// </summary>
        /// <param name="p"></param>
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

        /// <summary>
        /// gets the next player
        /// </summary>
        public void GetNext()
        {

            if (currentID >= GameManager.Instance.playerlist.Count -1)
            {
                currentID = 0;
                GameManager.Instance.activeplayer = GameManager.Instance.playerlist[currentID];
                if (onPartyEnd != null)
                    onPartyEnd.Invoke();
                return;
            }
            if (GameManager.Instance.activeplayer.Health <= 0)
            {
                GameManager.Instance.playerlist.Remove(GameManager.Instance.activeplayer);
                GameManager.Instance.activeplayer.Dead();
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
        /// <summary>
        /// sorts players in the party
        /// </summary>
        public void Sort()
        {
            players.Sort((x, y) => x.AttackSpeed.CompareTo(y.AttackSpeed));
            GameManager.Instance.activeplayer = players[currentID];
        }
    }
}
