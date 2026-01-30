// Isaac Bustad
// 1/27/2026
// CIS 414 Lesson

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMoveState 
{
    // Vars
    // reference to move context
    protected CharacterrMoveContext moveContext = null;

    // Methods
    public virtual void ToWalking()
    {
        // default implementation
        moveContext.CurrentMoveState = moveContext.WalkingMoveState;
    }

    public virtual void ToRunning()
    {
        // default implementation
        moveContext.CurrentMoveState = moveContext.RunningMoveState;
    }

    public virtual void OnUpdate()
    {
        // add running specific update code here
    }

    // done on fixed update
    public virtual void OnFixedUpdate()
    {
        MoveCharacter();
        // add running specific fixed update code here
    }

    public virtual void MoveCharacter()
    {
        // clamp to world speed
        moveContext.RB.velocity.LimitToWorldVelocity();
    }

    // Constructor
    // assign context state belongs to
    public CharacterMoveState(CharacterrMoveContext aContext)
    {
        moveContext = aContext;
    }
   
}
