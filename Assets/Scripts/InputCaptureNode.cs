using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Add using statement
using UnityEngine.InputSystem;

// Isaac Bustad
// 1/20/2026
// CIS 414 Lesson

public enum MoveStateType
{
    Idle,
    Walking,
    Running,
    Jumping
}

public class InputCaptureNode : MonoBehaviour
{
    // Add Vars for colletion and storing values
    // stored direction a character should move
    protected Vector3 movDir = Vector3.zero;

    

    // Recieves input from outside the class
    public virtual void RecieveMoveDir(InputAction.CallbackContext aCon)
    {
        // hold the input Direction
        Vector2 inDir = aCon.ReadValue<Vector2>();

        // create a new Direction
        Vector3 nDir = new Vector3(inDir.x,0, inDir.y);

        // update MoveDir
        movDir = nDir.normalized;


    }

    // Add access for information necessary
    public virtual Vector3 MovDir { get { return movDir; } }



}
