using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Random = UnityEngine.Random;

public class ActiveOrder
{
    public Order.CoffeeName CoffeeName;

    public List<Item> CurrentOrder;

    public ActiveOrder()
    {
        var orderNumber = Random.Range(0, Order.possibleOrders.Count);
        CoffeeName = (Order.CoffeeName)orderNumber;
        CurrentOrder = Order.possibleOrders[CoffeeName];
    }
}
