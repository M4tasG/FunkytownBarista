using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public Item.ItemType itemName;
    private void OnMouseDown()
    {
        ItemWorld.SpawnItemWorld(new Vector3(0, 0), new Item { itemType = itemName, amount = 1 });
    }
}
