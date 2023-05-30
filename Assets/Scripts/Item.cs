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

    public Sprite GetSprite()
    {
        switch (itemType)
        {
            default:
            case ItemType.Chocolate: return ItemAssets.Instance.chocolateSprite;
            case ItemType.Coffee: return ItemAssets.Instance.coffeeSprite;
            case ItemType.Milk: return ItemAssets.Instance.milkSprite;
            case ItemType.Tea: return ItemAssets.Instance.teaSprite;
            case ItemType.Water: return ItemAssets.Instance.waterSprite;
        }
    }
    
    
}
