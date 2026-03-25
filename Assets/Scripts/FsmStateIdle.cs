using System;
using System.Collections.Generic;
using UnityEngine;

namespace FSM.Scripts
{
    public class FsmStateIdle : FsmState
    {
        public FsmStateIdle(Fsm fsm) : base(fsm)
        {

        }

        public override void Enter()
        {
            Debug.Log("Idle State: [ENTER]");
        }

        public override void Exit()
        {
            Debug.Log("Idle State: [EXIT]");
        }

        public override void Update()
        {
            Debug.Log("Idle State: [UPDATE]");

            if(Input.GetAxis("Horizontal") != 0f || Input.GetAxis("Vertical") != 0)
            {
                Fsm.SetState<FsmStateWalk>();
            }
        }
    }
}
