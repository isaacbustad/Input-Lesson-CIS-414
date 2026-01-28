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

    // Constructor
    // assign context state belongs to
    public CharacterMoveState(CharacterrMoveContext aContext)
    {
        moveContext = aContext;
    }
   
}
