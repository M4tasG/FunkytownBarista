using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CupSpawner : MonoBehaviour
{
    // CupSpawner holds logic for spawning Cups (CupController)
    public Transform pfCoffeeCup;

    // This function gets called when you click on the object in game
    // It calculates the spawn position for the cup (right below the spawner)
    // and instantiates a new Cup instance using the prefab
    private void OnMouseDown()
    {
        Debug.Log("Spawning cup");
        Vector3 currentPosition = gameObject.transform.position;
        Vector3 spawnPosition = new Vector3(currentPosition.x, currentPosition.y - 1);
        
        Transform transform = Instantiate(pfCoffeeCup, spawnPosition, Quaternion.identity);
    }
}
