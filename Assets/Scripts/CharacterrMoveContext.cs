using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

// Isaac Bustad
// 1/20/2026
// CIS 414 Lesson

[RequireComponent(typeof(Rigidbody))]
public class CharacterrMoveContext : MonoBehaviour
{
    // temp test key
    [SerializeField] protected KeyCode testKey = KeyCode.K;

    // Get Ref to RB to move player
    protected Rigidbody rb = null;
    
    // Get ref for player input
    protected InputCaptureNode icp = null;

    // create current state Enum
    protected MoveStateType curMoveStateType = MoveStateType.Walking;

    // create last state enum
    protected MoveStateType lastMoveStateType = MoveStateType.Idle;

    // create move states
    protected CharacterMoveState currentMoveState = null;
    protected CharacterMoveState walkingMoveState = null;
    protected CharacterMoveState runningMoveState = null;



    // test on update to remove later
    protected virtual void Update()
    {
        
    }

    // collect ref
    protected virtual void OnEnable()
    {
        // collect icp ref
        icp = GetComponent<InputCaptureNode>();

        // collect rb ref
        rb = GetComponent<Rigidbody>();

        // freeze rotation
        rb.freezeRotation = true;
    }

    

    // move every fixed update frame
    protected virtual void FixedUpdate()
    {

        MoveCharacter();
        
    }


    // Move the player method
    protected virtual void MoveCharacter()
    {
        rb.AddForce(icp.MovDir * 50, ForceMode.Force);
    }

    // Accessors and Mutators
    public CharacterMoveState CurrentMoveState { get { return currentMoveState; } set { currentMoveState = value; } }
    public CharacterMoveState WalkingMoveState { get { return walkingMoveState; } }
    public CharacterMoveState RunningMoveState { get { return runningMoveState; } }
}
