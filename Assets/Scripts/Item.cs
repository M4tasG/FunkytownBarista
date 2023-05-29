using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    // All possible Items
    public enum ItemType
    {
        Water,
        Chocolate,
        Coffee,
        Tea,
        Milk,
    }
    
    // Item class attributes
    public ItemType itemType;
    public int amount;
}
