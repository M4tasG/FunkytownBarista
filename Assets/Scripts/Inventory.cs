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

    // Function to AddItem into the inventory
    // Foreach used to find if the item already exists in the Inventory instance and then only adds the amount of it
    // instead of adding a whole new item
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

    // Function to get the amount of unique items in Inventory
    public int GetItemCount()
    {
        return itemList.Count;
    }

    // Function to fetch the ItemList in the Inventory instance
    public List<Item> GetItemList()
    {
        return itemList;
    }
}
