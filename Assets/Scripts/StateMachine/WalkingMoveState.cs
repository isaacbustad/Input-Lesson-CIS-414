using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingMoveState : CharacterMoveState
{
    // Vars


    // Methods
    // move to running state from walking state
    public override void ToRunning()
    {
        moveContext.CurrentMoveState = moveContext.RunningMoveState;
    }

    public override void ToWalking()
    {
        // already in walking state
    }


    // Constructor
    public WalkingMoveState(CharacterrMoveContext aContext) : base(aContext)
    {

    }
}
