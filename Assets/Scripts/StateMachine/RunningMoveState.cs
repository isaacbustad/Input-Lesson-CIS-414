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
    

    // methods to call from context
    // done on update
    public override void OnUpdate()
    {
        // add running specific update code here
    }

    // done on fixed update
    public override void OnFixedUpdate()
    {
        MoveCharacter();
        // add running specific fixed update code here
    }

    public override void MoveCharacter()
    {
        // add running specific enter code here
        moveContext.RB.AddForce(moveContext.MovDir * 50, ForceMode.Force);
    }


    // Constructor
    public RunningMoveState(CharacterrMoveContext aContext) : base(aContext)
    {
        
    }
}
