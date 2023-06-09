using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class OrderDelivery : MonoBehaviour
{
    // OrderDelivery logic
    
    public static ActiveOrder requiredOrder;
    public static GameObject ActiveCustomer;
    public static GameObject CustomerSpawnerObject;
    public static GameObject CoinObject;
    
    // When a Collider2D enters the OrderDelivery, it checks if the Collider matches the required order
    // TODO: Add a check to make sure the collider that entered is instance of Cup
    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Collider " + col + " entered the delivery area");
        Inventory cupInventory = col.GetComponent<CupController>().GetInventory();
        List<Item> cupIngredients = cupInventory.GetItemList();

        foreach (var item in cupIngredients)
        {
            Debug.Log(item.itemType);
        }
        
        if (MatchIngredients(cupIngredients, requiredOrder.CurrentOrder))
        {
            Debug.Log("Match!!!!!!");
            // Implement coin addition
            CoinObject.GetComponent<CoinController>().AddCoins(5);
            ActiveCustomer.GetComponent<CustomerWorld>().DestroySelf();
            col.GetComponent<CupController>().DestroySelf();
            //.GetComponent<CustomerSpawner>().SpawnCustomer(CustomerSpawnerObject.transform.position);
            CustomerSpawnerObject.GetComponent<CustomerSpawner>().Invoke("SpawnCustomer", 3);
        }
        else
        {
            Debug.Log("Does not match...");
            // Possibly implement citations and coin subtraction
            CoinObject.GetComponent<CoinController>().SubtractCoins(3);
            ActiveCustomer.GetComponent<CustomerWorld>().DestroySelf();
            col.GetComponent<CupController>().DestroySelf();
            //CustomerSpawnerObject.GetComponent<CustomerSpawner>().SpawnCustomer(CustomerSpawnerObject.transform.position);
            CustomerSpawnerObject.GetComponent<CustomerSpawner>().Invoke("SpawnCustomer", 3);
        }
    }

    // A function to check if the Cups contents match the required recipe
    private bool MatchIngredients(List<Item> cupContents, List<Item> requiredContents)
    {
        bool isEqual = true;
        var counter = 0;
        if (cupContents.Count != requiredContents.Count)
        {
            isEqual = false;
        }
        else
        {
            foreach (var item in cupContents)
            {
                if (item.itemType != requiredContents[counter].itemType || item.amount != requiredContents[counter].amount)
                {
                    isEqual = false;
                }
                counter = counter + 1;
            }   
        }

        return isEqual;
    }
    
    // Functions to assign values to the variables at the top of the script
    public static void SetOrder(ActiveOrder order)
    {
        requiredOrder = order;
    }

    public static void SetActiveCustomer(GameObject obj)
    {
        ActiveCustomer = obj;
    }

    public static void SetCustomerSpawnerObject(GameObject obj)
    {
        CustomerSpawnerObject = obj;
    }

    public static void SetCoinObject(GameObject obj)
    {
        CoinObject = obj;
    }
}
