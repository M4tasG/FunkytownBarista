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

        ItemWorld.SpawnItemWorld(new Vector3(0, 0), new Item { itemType = Item.ItemType.Sugar, amount = 1 });
        ItemWorld.SpawnItemWorld(new Vector3(1, 1), new Item { itemType = Item.ItemType.Coffee, amount = 1 });
        ItemWorld.SpawnItemWorld(new Vector3(-2, -1), new Item { itemType = Item.ItemType.Sugar, amount = 1 });
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        ItemWorld itemWorld = col.GetComponent<ItemWorld>();
        if (itemWorld != null)
        {
            inventory.AddItem(itemWorld.GetItem());
            itemWorld.DestroySelf();
            Debug.Log(inventory.GetItemCount());
        }
    }
    
}
