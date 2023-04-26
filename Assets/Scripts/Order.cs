using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Order
{
    public enum CoffeeName 
    {
        Black,
        White,
    }

    public static Dictionary<CoffeeName, List<Item>> possibleOrders;
    
    
    static Order()
    {
        possibleOrders = new Dictionary<CoffeeName, List<Item>>();
        possibleOrders.Add(CoffeeName.Black, new List<Item>()
        {
            new Item()
            {
                itemType = Item.ItemType.Coffee,
                amount = 1
            },
            new Item()
            {
                itemType = Item.ItemType.Water,
                amount = 1
            }
        }
        );
        possibleOrders.Add(CoffeeName.White, new List<Item>()
            {
                new Item()
                {
                    itemType = Item.ItemType.Coffee,
                    amount = 1
                },
                new Item()
                {
                    itemType = Item.ItemType.Water,
                    amount = 1
                },
                new Item()
                {
                    itemType = Item.ItemType.Milk,
                    amount = 1
                }
            }
        );
    }
}
