using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CombatForms
{
    public enum GameStates
    {
        INIT,
        PAUSE,
        RUNNING,
        QUIT,
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            FSM<PlayerStates> playerfsm = new FSM<PlayerStates>();
            playerfsm.AddTransiton(PlayerStates.INIT, PlayerStates.IDLE);
            playerfsm.AddTransiton(PlayerStates.IDLE, PlayerStates.ATTACK);
            playerfsm.AddTransiton(PlayerStates.ATTACK, PlayerStates.IDLE);
            playerfsm.AddTransiton(PlayerStates.ATTACK, PlayerStates.ENDTURN);
            playerfsm.AddTransiton(PlayerStates.IDLE, PlayerStates.ENDTURN);
            playerfsm.AddTransiton(PlayerStates.ENDTURN, PlayerStates.IDLE);
            playerfsm.AddTransiton(PlayerStates.IDLE, PlayerStates.DEAD);


            Party party1 = new Party();
            Player jim = new Player(100, 10, 60, playerfsm, "jim");
            Player john = new Player(100, 10, 41, playerfsm, "john");
            Player joe = new Player(100, 10, 65, playerfsm, "joe");
            party1.AddPlayer(jim);
            party1.AddPlayer(john);
            party1.AddPlayer(joe);
            GameManager.Instance.firstparty = party1;
            GameManager.Instance.player1 = jim;
            GameManager.Instance.player2 = john;
            GameManager.Instance.player3 = joe;


            Party party2 = new Party();
            Player billy = new Player(100, 10, 9, playerfsm, "billy");
            Player bob = new Player(100, 10, 49, playerfsm, "bob");
            Player bo = new Player(100, 10, 89, playerfsm, "bo");
            party2.AddPlayer(billy);
            party2.AddPlayer(bob);
            party2.AddPlayer(bo);
            GameManager.Instance.secondparty = party2;
            GameManager.Instance.player4 = billy;
            GameManager.Instance.player5 = bob;
            GameManager.Instance.player6 = bo;


            List<Player> allplayers = new List<Player>();
            allplayers.Add(jim);
            allplayers.Add(john);
            allplayers.Add(joe);
            allplayers.Add(billy);
            allplayers.Add(bob);
            allplayers.Add(bo);
            //party1.Sort();
            //party2.Sort();
            allplayers.Sort((x, y) => x.AttackSpeed.CompareTo(y.AttackSpeed));
            

            FSM<GameStates> gamefsm = new FSM<GameStates>();
            gamefsm.AddTransiton(GameStates.INIT, GameStates.RUNNING);
            gamefsm.AddTransiton(GameStates.RUNNING, GameStates.QUIT);


            GameManager.Instance.fsm = gamefsm;
            GameManager.Instance.fsm.Start(GameStates.INIT);


            GameManager.Instance.playerlist = allplayers;
            GameManager.Instance.activeplayer = GameManager.Instance.playerlist[0];
            GameManager.Instance.activeplayer.ToIdle();



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
    }
}
