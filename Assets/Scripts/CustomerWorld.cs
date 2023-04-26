using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerWorld : MonoBehaviour
{
    private ActiveOrder CustomerCoffeeOrder;

    private void Awake()
    {
        CustomerCoffeeOrder = new ActiveOrder();
        Debug.Log(CustomerCoffeeOrder.CoffeeName);
        Debug.Log(CustomerCoffeeOrder.CurrentOrder);
    }

    public void DestroySelf()
    {
        Destroy(gameObject);
    }
    public ActiveOrder GetCustomerOrder()
    {
        return CustomerCoffeeOrder;
    }
    
}
