using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Isaac Bustad
// 1/20/2026
// CIS 414 Lesson

[RequireComponent(typeof(Rigidbody))]
public class CharacterrMoveContext : MonoBehaviour
{
    // Get Ref to RB to move player
    protected Rigidbody rb = null;
    
    // Get ref for player input
    protected InputCaptureNode icp = null;

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
}
