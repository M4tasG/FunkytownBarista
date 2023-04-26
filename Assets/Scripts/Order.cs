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

    public static Dictionary<CoffeeName, List<Item.ItemType>> possibleOrders;
    
    
    static Order()
    {
        possibleOrders = new Dictionary<CoffeeName, List<Item.ItemType>>();
        possibleOrders.Add(CoffeeName.Black, new List<Item.ItemType>(){Item.ItemType.Water, Item.ItemType.Coffee});
        possibleOrders.Add(CoffeeName.White, new List<Item.ItemType>(){Item.ItemType.Water, Item.ItemType.Coffee, Item.ItemType.Milk});
    }
}
