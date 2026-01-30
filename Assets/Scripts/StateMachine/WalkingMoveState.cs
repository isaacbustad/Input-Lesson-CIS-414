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
        if (moveContext.RB.velocity.magnitude < moveContext.WalkingStateParam.MaxSpeed)
        {
            // add running specific enter code here
            moveContext.RB.AddForce(moveContext.MovDir * moveContext.WalkingStateParam.Acceleration, ForceMode.Force);
        }
        
        base.MoveCharacter();
    }


    // Constructor
    public WalkingMoveState(CharacterrMoveContext aContext) : base(aContext)
    {

    }
}
