using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerWorld : MonoBehaviour
{
    // CustomerWorld controls Customer logic
    private ActiveOrder CustomerCoffeeOrder;

    // When a new Customer Awakes:
    // They get set a new order
    // OrderDelivery receives information about their order
    private void Awake()
    {
        CustomerCoffeeOrder = new ActiveOrder();
        OrderDelivery.SetOrder(CustomerCoffeeOrder);
        OrderDelivery.SetActiveCustomer(gameObject);
        
        // Replace these with UI elements later (Dialogue box)
        Debug.Log(CustomerCoffeeOrder.CoffeeName);
        Debug.Log(CustomerCoffeeOrder.CurrentOrder);
    }

    // Function to destroy the object (after order submission)
    public void DestroySelf()
    {
        Destroy(gameObject);
    }
    public ActiveOrder GetCustomerOrder()
    {
        return CustomerCoffeeOrder;
    }
    
}
