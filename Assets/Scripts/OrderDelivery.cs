using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class OrderDelivery : MonoBehaviour
{
    public static ActiveOrder requiredOrder;
    public static GameObject ActiveCustomer;
    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Collider " + col + " entered the delivery area");
        Inventory cupInventory = col.GetComponent<CupController>().GetInventory();
        List<Item> cupIngredients = cupInventory.GetItemList();

        
        if (MatchIngredients(cupIngredients, requiredOrder.CurrentOrder))
        {
            Debug.Log("Match!!!!!!");
            // Implement coin addition
            ActiveCustomer.GetComponent<CustomerWorld>().DestroySelf();
        }
        else
        {
            Debug.Log("Does not match...");
            // Possibly implement citations and coin subtraction
            ActiveCustomer.GetComponent<CustomerWorld>().DestroySelf();
        }
    }

    private bool MatchIngredients(List<Item> cupContents, List<Item> requiredContents)
    {
        bool isEqual = true;
        var counter = 0;
        foreach (var item in cupContents)
        {
            if (item.itemType != requiredContents[counter].itemType || item.amount != requiredContents[counter].amount)
            {
                isEqual = false;
            }
            counter = counter + 1;
        }

        return isEqual;
    }
    public static void SetOrder(ActiveOrder order)
    {
        requiredOrder = order;
    }

    public static void SetActiveCustomer(GameObject obj)
    {
        ActiveCustomer = obj;
    }
}
