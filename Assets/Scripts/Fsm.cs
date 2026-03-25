using FSM.Scripts;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace FSM.Scripts
{
    public class Fsm
    {
        private Dictionary<Type, FsmState> _states = new Dictionary<Type, FsmState>();
        private FsmState StateCurrent { get; set; }

        public void AddState(FsmState state)
        {
            _states.Add(state.GetType(), state);
        }

        public void SetState<T>() where T : FsmState
        {
            var type = typeof(T);

            if (StateCurrent != null && StateCurrent.GetType() == type)
            {
                return;
            }

            if (_states.TryGetValue(type, out var newState))
            {
                StateCurrent?.Exit();

                StateCurrent = newState;

                StateCurrent.Enter();
            }
        }

        public void Update()
        {
            StateCurrent?.Update();
        }
    }
}