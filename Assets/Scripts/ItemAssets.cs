using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAssets : MonoBehaviour
{
    // No clue lol I was following a tutorial for this so idk what do
    public static ItemAssets Instance { get; private set; }

    // Sets the ItemAssets instance to this
    private void Awake()
    {
        Instance = this;
    }

    public Transform pfItemWorld;

    public Sprite waterSprite;
    public Sprite chocolateSprite;
    public Sprite coffeeSprite;
    public Sprite teaSprite;
    public Sprite milkSprite;
}
