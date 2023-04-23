using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    // List containing all Items within the Inventory
    // This will track all items put in a cup to determine if it suits the customers request
    private List<Item> itemList;

    // Constructor for Inventory class
    public Inventory()
    {
        itemList = new List<Item>();
        
        //AddItem(new Item {itemType = Item.ItemType.Cup, amount = 1});
        //Debug.Log("Inventory initialized");
        //Debug.Log(itemList.Count);
    }

    public void AddItem(Item item)
    {
        bool isInInventory = false;
        foreach (Item inventoryItem in itemList)
        {
            if (inventoryItem.itemType == item.itemType)
            {
                isInInventory = true;
                inventoryItem.amount += item.amount;
            }
        }

        if (!isInInventory)
        {
            itemList.Add(item);
        }
    }

    public int GetItemCount()
    {
        return itemList.Count;
    }

    public List<Item> GetItemList()
    {
        return itemList;
    }
}
