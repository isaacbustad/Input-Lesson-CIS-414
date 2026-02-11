using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemFactory", menuName = "ScriptableObjects/ItemFactory")]
public class ItemFactory : ScriptableObject
{
    #region Vars
    
    [SerializeField] private GameObject factoryItem;

    // pool refference
    private GenericPool pool = new GenericPool();

    #endregion // Vars

    #region Methods
    public GameObject CreateItem(Transform aTF)
    {
        // ref for new item
        GameObject newItem = null;

        // try to get item from pool
        Poolable poolable = pool.GetFromPool();

        // if pool is empty, create new item
        if (poolable == null)
        {
            newItem = Instantiate(factoryItem, aTF.position, Quaternion.identity);
            newItem.GetComponent<Poolable>().Pool = pool;
        }

        // if pool is not empty, get item from pool and set it active
        else
        {
            poolable.Use(aTF);
        }
        return newItem;
    }
    #endregion // Methods
}
