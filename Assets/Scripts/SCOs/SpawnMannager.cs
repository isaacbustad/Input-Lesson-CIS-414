using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMannager : MonoBehaviour
{
    #region Vars
    [SerializeField] private ItemFactory itemFactory;

    // testing keykode
    private KeyCode spawnKey = KeyCode.S;
    #endregion // Vars

    #region Methods
    private void Update()
    {
        if (Input.GetKeyDown(spawnKey))
        {
            SpawnItem();
        }
    }
    public void SpawnItem()
    {
        itemFactory.CreateItem(this.gameObject.transform);
    }
    #endregion // Methods
}
