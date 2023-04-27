using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemWorld : MonoBehaviour
{
    // ItemWorld holds logic for constructing an Item to spawn and spawning it
    // as well as assigning the relevant assets to the item
    public static ItemWorld SpawnItemWorld(Vector3 position, Item item)
    {
        Transform transform = Instantiate(ItemAssets.Instance.pfItemWorld, position, Quaternion.identity);
        
        ItemWorld itemWorld = transform.GetComponent<ItemWorld>();
        itemWorld.SetItem(item);

        return itemWorld;
    }
    
    
    private Item item;
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Set what kind of Item this is
    public void SetItem(Item item)
    {
        this.item = item;
        // Not implemented yet
        // https://www.youtube.com/watch?v=2WnAOV7nHW0
        // spriteRenderer.sprite = item.GetSprite()
    }

    // Fetch the Item instance
    public Item GetItem()
    {
        return item;
    }

    // Destroy this Item instance
    public void DestroySelf()
    {
        Destroy(gameObject);
    }
}
