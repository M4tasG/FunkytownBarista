using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerSpawner : MonoBehaviour
{
    // CustomerSpawner holds logic for spawning Customers (CustomerWorld)
    
    public Transform pfCustomer;

    // On Awake this script specifies to OrderDelivery this CustomerSpawner
    // That allows the OrderDelivery area to continue spawning customers after using the SpawnCustomer
    // from this script
    // Invoke delays the Customer spawn by 5 seconds
    private void Awake()
    {
        OrderDelivery.SetCustomerSpawnerObject(gameObject);
        Invoke("SpawnCustomer", 5);
    }
    
    // Spawns a new Customer at specified position using the Customer prefab
    public void SpawnCustomer()
    {
        Debug.Log("Spawning customer");
        Vector3 spawnPosition = new Vector3(-20.1949f, 1.819514f, -2);
        Transform transform = Instantiate(pfCustomer, spawnPosition, Quaternion.identity);
        
    }
}
