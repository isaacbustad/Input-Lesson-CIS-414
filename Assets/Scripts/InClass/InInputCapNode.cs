using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// using input
using UnityEngine.InputSystem;

public class InInputCapNode : MonoBehaviour
{
    // store input
    protected Vector3 movDir = Vector3.zero; 

    // recieve context from action map
    public virtual void RecievInput(InputAction.CallbackContext aCon)
    {
        // hold the passed in value
        Vector2 inV2 = aCon.ReadValue<Vector2>();

        // convert the passed in value
        Vector3 nV3 = new Vector3(inV2.x,0,inV2.y);

        // assign and store input
        movDir = nV3.normalized;
    }


    // access movDir
    public virtual Vector3 MovDir { get { return movDir; } }
    
}
