using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CusAssets : MonoBehaviour
{
    public static CusAssets Instance { get; private set; }
    
    private void Awake()
    {
        Instance = this;
    }
    
    public Sprite[] spriteArray;

    public Sprite GetSprite()
    {
        int spriteNumber = Random.Range(0, spriteArray.Length);
        return spriteArray[spriteNumber];
    }
}
