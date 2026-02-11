using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class GenericPool 
{
    #region Vars
    private Queue<Poolable> pool = new Queue<Poolable>();

    #endregion // Vars

    #region Methods
    public virtual void AddToPool(Poolable aPoolable)
    {
        pool.Enqueue(aPoolable);
        
    }

    public virtual Poolable GetFromPool()
    {
        Poolable aPoolable = null;

        if (pool.Count > 0)
        {
            aPoolable = pool.Dequeue();
        }
        
        return aPoolable;
    }
    #endregion // Methods

    #region Accessors
    public Poolable[] Pool
    {
        get { return pool.ToArray(); }
    }
    #endregion // Accessors
}
