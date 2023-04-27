using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupController : MonoBehaviour
{
    // CupController is responsible for Cup logic
    // Inventory holds all the ingredients that go into the cup
    private Inventory inventory;
    
    // When a new Cup Awakes they get a new Inventory instance created for them
    private void Awake()
    {
        Debug.Log("Awaking CupController");
        inventory = new Inventory();
        
    }

    // Triggered when entering a Collider 2D with isTrigger true
    // This function holds logic of taking Items into inventory
    private void OnTriggerEnter2D(Collider2D col)
    {
        ItemWorld itemWorld = col.GetComponent<ItemWorld>();

        if (itemWorld != null)
        {
            inventory.AddItem(itemWorld.GetItem());
            itemWorld.DestroySelf();
        }
    }

    // Function for fetching the Inventory instance of this object
    public Inventory GetInventory()
    {
        return inventory;
    }

    // Function for deleting this object
    public void DestroySelf()
    {
        Destroy(gameObject);
    }

}
