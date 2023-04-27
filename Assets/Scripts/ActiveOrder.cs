using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Random = UnityEngine.Random;

public class ActiveOrder
{
    // ActiveOrder class creates an instace of Order and assigns a random recipe
    public Order.CoffeeName CoffeeName;
    public List<Item> CurrentOrder;

    // This constructor is responsible for assigning a random recipe to ActiveOrder
    public ActiveOrder()
    {
        var orderNumber = Random.Range(0, Order.possibleOrders.Count);
        CoffeeName = (Order.CoffeeName)orderNumber;
        CurrentOrder = Order.possibleOrders[CoffeeName];
    }
}
