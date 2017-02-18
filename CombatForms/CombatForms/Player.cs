using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;

namespace CombatForms
{
    public class Player : IAttacker, IPlayerState
    {
        public Player() { }
        public Player(int health, int damage, int speed, FSM<PlayerStates> fsm, string n)
        {
            m_health = health;
            m_damage = damage;
            m_attackspeed = speed;
            m_fsm = fsm;
            m_fsm.Start(PlayerStates.INIT);
            currentstate = m_fsm.Current.ToString();
            m_name = n;
        }
        public Player(int health, int damage, int speed, FSM<PlayerStates> fsm)
        {
            m_health = health;
            m_damage = damage;
            m_attackspeed = speed;
            m_fsm = fsm;
            m_fsm.Start(PlayerStates.INIT);
            currentstate = m_fsm.Current.ToString();
        }
        public Player(int health, int damage, int speed)
        {
            m_health = health;
            m_damage = damage;
            m_attackspeed = speed;
            m_fsm = new FSM<PlayerStates>();
            m_fsm.Start(PlayerStates.INIT);
            currentstate = m_fsm.Current.ToString();
        }
        public string Name
        {
            get { return m_name; }
        }
        FSM<PlayerStates> m_fsm;
        public string currentstate;
        private string m_name;
        private int m_health;
        private int m_damage;
        private int m_attackspeed;

        public int Health
        {
            get { return m_health; }
            set { m_health = value; }
        }
        public int Damage
        {
            get { return m_damage; }
            set { m_damage = value; }
        }
        public int AttackSpeed
        {
            get { return m_attackspeed; }
            set { m_attackspeed = value; }
        }

        public delegate void OnEndTurn();
        public OnEndTurn onEndTurn;
        public void EndTurn()
        {
            currentstate = m_fsm.Current.ToString();            
            if(m_fsm.ChangeState(PlayerStates.ENDTURN))          
                Debug.WriteLine("I'M ENDING MY TURN");            
            else
                Debug.WriteLine("SOMETHING WENT WRONG :(");
        }

        public void DoDamage(Player p)
        {
            currentstate = m_fsm.Current.ToString();
            p.Health -= this.Damage;
        }

        public void Initialize()
        {
            this.currentstate = m_fsm.Current.ToString();
        }
        public void ToIdle()
        {
            currentstate = m_fsm.Current.ToString();
            if(m_fsm.ChangeState(PlayerStates.IDLE))            
                Idle();
            
        }
        public void Idle()
        {
            currentstate = m_fsm.Current.ToString();
            if (this.Health <= 0)
                GameManager.Instance.playerlist.Remove(this);
            
        }

        public bool Attack()
        {
            if(m_fsm.ChangeState(PlayerStates.ATTACK))
            {
                DoDamage(this);
                return true;
            }
            return false;
        }

        public void Dead()
        {
            if(m_fsm.ChangeState(PlayerStates.ENDTURN ))
                EndTurn();
        }

        public void Update()
        {
            currentstate = m_fsm.Current.ToString();
        }
    }
}
