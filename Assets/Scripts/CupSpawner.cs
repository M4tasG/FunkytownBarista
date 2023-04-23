using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CupSpawner : MonoBehaviour
{
    public Transform pfCoffeCup;

    private void OnMouseDown()
    {
        Debug.Log("Spawning cup");
        Vector3 currentPosition = gameObject.transform.position;
        Vector3 spawnPosition = new Vector3(currentPosition.x, currentPosition.y - 1);
        
        Transform transform = Instantiate(pfCoffeCup, spawnPosition, Quaternion.identity);
    }
}
