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
    }

    private void OnMouseDown()
    {
        SpawnCustomer(gameObject.transform.position);
    }

    public void SpawnCustomer(Vector3 spawnPosition)
    {
        Debug.Log("Spawning customer");
        spawnPosition.y = spawnPosition.y - 2;
        Transform transform = Instantiate(pfCustomer, spawnPosition, Quaternion.identity);
    }
}
