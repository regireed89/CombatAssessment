using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatForms
{
    interface IPlayerState
    {
        void Initialize();
        void Idle();
        bool Attack();
        void EndTurn();
        void Dead();
        void Update();
    }
}
