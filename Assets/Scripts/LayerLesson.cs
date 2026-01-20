using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Isaac Bustad
// 1/20/2026
// CIS 414 Lesson

[RequireComponent(typeof(Collider))]
public class LayerLesson : MonoBehaviour
{
    // layer to check collision
    [SerializeField] protected LayerMask struckBy;
    [SerializeField] protected int smoothCriminal;


    protected void OnCollisionEnter(Collision collision)
    {
        // display that we have hit somthing
        Debug.Log("You Have Been Hit by! ");
        //Debug.Log(LayerMask.LayerToName(collision.gameObject.layer) == LayerMask.LayerToName(struckBy));

        if (collision.gameObject.layer == smoothCriminal)
        {
            
            // We have been hit by not ground
            Debug.LogWarning("You Have Been Struck by!!");

            // We Have been hit by a .........
            Debug.LogError("A " + LayerMask.LayerToName(smoothCriminal) + "!!!");
        }

        else
        {
            Debug.LogWarning("The " + LayerMask.LayerToName(collision.gameObject.layer) + "!!");
        }


    }
}
