﻿using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Xml.Serialization;

namespace CombatForms
{
    [Serializable]
    public enum PlayerStates
    {
        INIT = 0,
        IDLE = 1,
        ATTACK = 2,
        ENDTURN = 3,
        DEAD = 4
    }
    public class Player : IAttacker, IPlayerState
    {
        public Player() { }
        public Player(int health, int damage, int speed, FSM<PlayerStates> fsm, string n)
        {
            Health = health;
            Damage = damage;
            AttackSpeed = speed;
            m_fsm = fsm;
            m_fsm.Start(PlayerStates.INIT);
            currentstate = m_fsm.Current.ToString();
            Name = n;
        }
        public Player(int health, int damage, int speed, FSM<PlayerStates> fsm)
        {
            Health = health;
            Damage = damage;
            AttackSpeed = speed;
            m_fsm = fsm;
            m_fsm.Start(PlayerStates.INIT);
            currentstate = m_fsm.Current.ToString();
        }
        public Player(int health, int damage, int speed)
        {
            Health = health;
            Damage = damage;
            AttackSpeed = speed;
            m_fsm = new FSM<PlayerStates>();
            m_fsm.Start(PlayerStates.INIT);
            currentstate = m_fsm.Current.ToString();
        }

        public FSM<PlayerStates> m_fsm;
        public string currentstate;
     
        
        public string Name
        {
            get; set;
        }
        public int Health
        {
            get;set;
        }
        public int Damage
        {
            get;set;
        }
        public int AttackSpeed
        {
            get;set;
        }
        public delegate void OnEndTurn();
        [XmlIgnore]
        public OnEndTurn onEndTurn;
        /// <summary>
        /// what to do when a player turn ends
        /// </summary>
        public void EndTurn()
        {
            currentstate = m_fsm.Current.ToString();
            GameManager.Instance.lastattacker = GameManager.Instance.activeplayer;
            if (m_fsm.ChangeState(PlayerStates.ENDTURN))
            {
                // Debug.WriteLine("I'M ENDING MY TURN");
                onEndTurn.Invoke();
            }
            else
                Debug.WriteLine("SOMETHING WENT WRONG :(");
        }
        /// <summary>
        /// how damage is being done to a player
        /// </summary>
        /// <param name="p"></param>
        public void DoDamage(Player p)
        {
            currentstate = m_fsm.Current.ToString();
            p.Health -= this.Damage;
        }
        /// <summary>
        /// sets the players current state  
        /// </summary>
        public void Initialize()
        {
            this.currentstate = m_fsm.Current.ToString();
        }
        /// <summary>
        /// invokes idle function
        /// </summary>
        public void ToIdle()
        {
            currentstate = m_fsm.Current.ToString();
            if (m_fsm.ChangeState(PlayerStates.IDLE))
                Idle();

        }
        /// <summary>
        /// sets players current state to idle
        /// </summary>
        public void Idle()
        {
            currentstate = m_fsm.Current.ToString();
            if (this.Health <= 0)
            {
                GameManager.Instance.playerlist.Remove(this);
                GameManager.Instance.activeplayer.EndTurn();
            }
        }
        /// <summary>
        /// players function for attacking 
        /// </summary>
        /// <returns></returns>
        public bool Attack()
        {
            if (m_fsm.ChangeState(PlayerStates.ATTACK))
            {
                DoDamage(GameManager.Instance.lastattacker);
                return true;
            }
            return false;
        }
        /// <summary>
        /// what to do when a player is dead
        /// </summary>
        public void Dead()
        {
            if (m_fsm.ChangeState(PlayerStates.ENDTURN))
                EndTurn();
        }
         
   
       
    }
}
