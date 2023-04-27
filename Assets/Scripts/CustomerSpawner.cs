using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerSpawner : MonoBehaviour
{
    public Transform pfCustomer;

    private void OnMouseDown()
    {
        Debug.Log("Spawning customer");
        Vector3 currentPosition = gameObject.transform.position;
        Vector3 spawnPosition = new Vector3(currentPosition.x, currentPosition.y - 1);
        
        Transform transform = Instantiate(pfCustomer, spawnPosition, Quaternion.identity);
    }
}
