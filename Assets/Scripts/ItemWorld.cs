using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemWorld : MonoBehaviour
{
    
    public static ItemWorld SpawnItemWorld(Vector3 position, Item item)
    {
        //Debug.Log(position);
        //Debug.Log(item);
        Debug.Log(ItemAssets.Instance);
        Debug.Log(ItemAssets.Instance.pfItemWorld);
        Transform transform = Instantiate(ItemAssets.Instance.pfItemWorld, position, Quaternion.identity);

        Debug.Log(transform);
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

    public void SetItem(Item item)
    {
        this.item = item;
        // Not implemented yet
        // https://www.youtube.com/watch?v=2WnAOV7nHW0
        // spriteRenderer.sprite = item.GetSprite()
    }

    public Item GetItem()
    {
        return item;
    }

    public void DestroySelf()
    {
        Destroy(gameObject);
    }
}
