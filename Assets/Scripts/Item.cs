using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    // All possible Items
    public enum ItemType
    {
        Cup,
        Water,
        Sugar,
        Coffee,
        Milk,
    }
    
    // Item class attributes
    public ItemType itemType;
    public int amount;
}
