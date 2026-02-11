using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Rigidbody), typeof(Collider))]
public class Poolable : MonoBehaviour
{
    #region Vars
    // pool refference
    private GenericPool pool = null;
    #endregion // Vars


    #region Methods
    public virtual void PoolSelf()
    {
        pool.AddToPool(this);
    }

    public virtual void Use(Transform aTF)
    {
        this.gameObject.SetActive(true);
        this.transform.position = aTF.position;
        this.transform.rotation = aTF.rotation;
    }
    #endregion // Methods

    #region Accessors
    public virtual GenericPool Pool
    {
        get { return pool; }
        set { pool = value; }
        
    }
    #endregion // Accessors 
}
