using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// require rb be present
[RequireComponent(typeof(Rigidbody),typeof(InInputCapNode))]
public class InCharContext : MonoBehaviour
{
    // store rb refference
    protected Rigidbody rb = null;

    // store input captuer
    protected InInputCapNode inInputCapNode = null;

    // collect refference of rb
    protected virtual void OnEnable()
    {
        rb = GetComponent<Rigidbody>();

        // collect refference input
        inInputCapNode= GetComponent<InInputCapNode>();

        // lock rotation
        rb.freezeRotation = true;

    }

    // Define how we move
    // temp location
    protected virtual void MoveChar()
    {
        // add force to the character rb
        rb.AddForce(inInputCapNode.MovDir * 50,ForceMode.Force);
    }

    protected void FixedUpdate()
    {
        MoveChar();
    }
}
