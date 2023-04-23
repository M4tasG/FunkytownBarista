using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAssets : MonoBehaviour
{
    
    public static ItemAssets Instance { get; private set; }

    private void Awake()
    {
        Debug.Log("Awaking ItemAssets");
        Debug.Log(this);
        Instance = this;
        Debug.Log(Instance);
    }

    public Transform pfItemWorld;
    
}
