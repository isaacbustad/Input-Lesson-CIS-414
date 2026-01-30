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
    [SerializeField] protected KeyCode testKey2 = KeyCode.L;

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

    // refference movestateparam scriptable object
    [SerializeField] protected MoveStateParam runningStateParam = null;
    [SerializeField] protected MoveStateParam walkingStateParam = null;



    void Awake()
    {
        
    }

    void Start()
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

        // create states
        walkingMoveState = new WalkingMoveState(this);
        runningMoveState = new RunningMoveState(this);
        // set starting state
        currentMoveState = walkingMoveState;
    }

    protected virtual void Update()
    {
        //
        currentMoveState.OnUpdate();
        
        // test switching to running
        if (Input.GetKeyDown(testKey))
        {
            currentMoveState.ToRunning();
        }
        // test switching back to walking
        else if (Input.GetKeyDown(testKey2))
        {
            currentMoveState.ToWalking();
        }
    }

    // move every fixed update frame
    protected virtual void FixedUpdate()
    {
        currentMoveState.OnFixedUpdate();        
    }

    


    

    // Accessors and Mutators
    public CharacterMoveState CurrentMoveState { get { return currentMoveState; } set { currentMoveState = value; } }
    public CharacterMoveState WalkingMoveState { get { return walkingMoveState; } }
    public CharacterMoveState RunningMoveState { get { return runningMoveState; } }


    // access move state params
    public MoveStateParam RunningStateParam { get { return runningStateParam; } }
    public MoveStateParam WalkingStateParam { get { return walkingStateParam; } }

    // access to rb
    public Rigidbody RB { get { return rb; } }
    // access to mov dir
    public Vector3 MovDir { get { return icp.MovDir; } }
}
