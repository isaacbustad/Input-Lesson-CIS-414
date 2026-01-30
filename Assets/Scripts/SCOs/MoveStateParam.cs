// created by Isaac Bustad
// created on 1/29/2026
// CIS 414 Lesson

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MoveStateParam", menuName = "ScriptableObject/MoveStateParam")]
public class MoveStateParam : ScriptableObject
{
    #region Variables
    // set acceleration parameter
    [Header("Movement Parameters")]
    [SerializeField, Range(0f, 100f)] protected float acceleration = 10f;

    // set max speed parameter
    [SerializeField, Range(0f, 100f)] protected float  maxSpeed= 4f;

    //
    #endregion
    
    #region Accessors
    // get acceleration
    public float Acceleration { get { return acceleration; } }

    // get max speed
    public float MaxSpeed { get { return maxSpeed; } }
    #endregion
}
