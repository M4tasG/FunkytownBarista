using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Random = UnityEngine.Random;

public class ActiveOrder
{
    public Order.CoffeeName coffeeName;

    public List<Item.ItemType> currentOrder;

    public ActiveOrder()
    {
        var orderNumber = Random.Range(0, Order.possibleOrders.Count);
        coffeeName = (Order.CoffeeName)orderNumber;
        currentOrder = Order.possibleOrders[coffeeName];
    }
}
