using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class OrderDelivery : MonoBehaviour
{
    public static ActiveOrder requiredOrder;
    public static GameObject ActiveCustomer;
    public static GameObject CustomerSpawnerObject;
    public static GameObject CoinObject;
    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Collider " + col + " entered the delivery area");
        Inventory cupInventory = col.GetComponent<CupController>().GetInventory();
        List<Item> cupIngredients = cupInventory.GetItemList();

        
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
            ActiveCustomer.GetComponent<CustomerWorld>().DestroySelf();
            col.GetComponent<CupController>().DestroySelf();
            //CustomerSpawnerObject.GetComponent<CustomerSpawner>().SpawnCustomer(CustomerSpawnerObject.transform.position);
            CustomerSpawnerObject.GetComponent<CustomerSpawner>().Invoke("SpawnCustomer", 3);
        }
    }

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
