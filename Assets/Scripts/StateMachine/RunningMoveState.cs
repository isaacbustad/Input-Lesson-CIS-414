// Isaac Bustad
// 1/27/2026

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunningMoveState : CharacterMoveState
{
    // Vars



    // Methods
    public override void ToWalking()
    {
        moveContext.CurrentMoveState = moveContext.WalkingMoveState;   
    }

    public override void ToRunning()
    {
        // already in running state
    }


    // Constructor
    public RunningMoveState(CharacterrMoveContext aContext) : base(aContext)
    {
        
    }
}
