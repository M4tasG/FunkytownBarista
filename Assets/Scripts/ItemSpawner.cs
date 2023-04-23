using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public Item.ItemType itemName;
    private Vector3 spawnPosition;

    private void Awake()
    {
        Vector3 currentPosition = gameObject.transform.position;
        spawnPosition = new Vector3(currentPosition.x, currentPosition.y - 1);
    }

    private void OnMouseDown()
    {
        ItemWorld.SpawnItemWorld(spawnPosition, new Item { itemType = itemName, amount = 1 });
    }
}
