using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupController : MonoBehaviour
{
    private Inventory inventory;
    private void Awake()
    {
        Debug.Log("Awaking CupController");
        inventory = new Inventory();
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        ItemWorld itemWorld = col.GetComponent<ItemWorld>();

        if (itemWorld != null)
        {
            inventory.AddItem(itemWorld.GetItem());
            itemWorld.DestroySelf();
        }
    }

    public Inventory GetInventory()
    {
        return inventory;
    }

    public void DestroySelf()
    {
        Destroy(gameObject);
    }

}
