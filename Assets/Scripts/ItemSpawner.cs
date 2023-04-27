using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    // Logic for spawning Items
    
    public Item.ItemType itemName;
    private Vector3 spawnPosition;

    // On Awake calculates the spawnPosition for item relative to it's spawner
    private void Awake()
    {
        Vector3 currentPosition = gameObject.transform.position;
        spawnPosition = new Vector3(currentPosition.x, currentPosition.y - 1);
    }

    // Function to spawn the item
    private void OnMouseDown()
    {
        ItemWorld.SpawnItemWorld(spawnPosition, new Item { itemType = itemName, amount = 1 });
    }
}
