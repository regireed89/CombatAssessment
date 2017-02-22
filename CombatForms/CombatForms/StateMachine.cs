using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace CombatForms
{
    [Serializable]
    public class FSM<T>
    {
        public FSM()
        {
            states = new Dictionary<string, State>();
            var e = Enum.GetValues(typeof(T));
            foreach(var v in e)
            {
                State s = new State(v as Enum);
                states.Add(s.name, s);
            }
        }
        
        Dictionary<string, State> states;
        private Dictionary<string, List<State>> transitions = new Dictionary<string, List<State>>();

        /// <summary>
        /// addsd transitions to a dictionary of transitions
        /// </summary>
        /// <param name="current"></param>
        /// <param name="next"></param>
        public void AddTransiton(T current, T next)
        {
            State s1 = new State(current as Enum);
            State s2 = new State(next as Enum);
            List<State> tmp = new List<State>();
            tmp.Add(s1);
            tmp.Add(s2);
            transitions.Add(s1.name + "->" + s2.name, tmp);
        }
        /// <summary>
        /// checks if a transition is valid
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public bool ValidTransition(State s1, State s2)
        {
            return (transitions.ContainsKey(s1.name + "->" + s2.name));
        }
        private State current;
        
   
        public State Current
        {
            get { return current; }
            set { current = value; }
        }
        /// <summary>
        /// changes the current state
        /// </summary>
        /// <param name="to"></param>
        /// <returns></returns>
        public bool ChangeState(T to)
        {
            State next = new State(to as Enum);
            if(!ValidTransition(current, next))
            {
                return false;
            }
            current = states[next.name];
            return true;
        }

        public void Start(T state)
        {
            current = states[new State(state as Enum).name];
        }

        public void Update()
        {

        }
    }



    public class State
    {
        public State() { }
        public State(Enum e)
        {
            name = e.ToString();         
        }
        public string name;      
    }
}
