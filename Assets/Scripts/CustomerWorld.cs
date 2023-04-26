using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerWorld : MonoBehaviour
{
    public ActiveOrder CustomerCoffeeOrder;

    private void Awake()
    {
        CustomerCoffeeOrder = new ActiveOrder();
        Debug.Log(CustomerCoffeeOrder.CoffeeName);
        Debug.Log(CustomerCoffeeOrder.CurrentOrder);
    }
}
