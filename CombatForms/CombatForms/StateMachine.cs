using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CombatForms
{

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


        public void AddTransiton(T current, T next)
        {
            State s1 = new State(current as Enum);
            State s2 = new State(next as Enum);
            List<State> tmp = new List<State>();
            tmp.Add(s1);
            tmp.Add(s2);
            transitions.Add(s1.name + "->" + s2.name, tmp);
        }

        public bool ValidTransition(State s1, State s2)
        {
            return (transitions.ContainsKey(s1.name + "->" + s2.name));
        }
        private State current;
        public Enum Current
        {
            get { return current.state_enum; }
            private set { }
        }
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
            state_enum = e;
        }
        public string name;
        public Enum state_enum;
    }
}
