using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerSpawner : MonoBehaviour
{
    public Transform pfCustomer;

    private void Awake()
    {
        OrderDelivery.SetCustomerSpawnerObject(gameObject);
        Invoke("SpawnCustomer", 5);
    }
    
    public void SpawnCustomer()
    {
        Debug.Log("Spawning customer");
        Vector3 spawnPosition = new Vector3(-9.5f, -3.5f);
        Transform transform = Instantiate(pfCustomer, spawnPosition, Quaternion.identity);
    }
}
