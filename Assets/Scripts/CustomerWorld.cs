using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CustomerWorld : MonoBehaviour
{
    // CustomerWorld controls Customer logic
    private ActiveOrder CustomerCoffeeOrder;
    public GameObject dialoguePanel;
    public TMP_Text dialogueText;

    private SpriteRenderer spriteRenderer;
    
    // When a new Customer Awakes:
    // They get set a new order
    // OrderDelivery receives information about their order
    private void Awake()
    {
        CustomerCoffeeOrder = new ActiveOrder();
        OrderDelivery.SetOrder(CustomerCoffeeOrder);
        OrderDelivery.SetActiveCustomer(gameObject);

        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        SetSprite();
        
        // Replace these with UI elements later (Dialogue box)
        //Debug.Log(CustomerCoffeeOrder.CoffeeName);
        //Debug.Log(CustomerCoffeeOrder.CurrentOrder);
        dialoguePanel = DialoguePanel.fetchDialoguePanel();
        dialogueText = DialogueTextBox.fetchDialogueTextBox();
        
        dialoguePanel.SetActive(true);
        dialogueText.text = "I want a " + CustomerCoffeeOrder.DialogueName;
    }

    public void SetSprite()
    {
        spriteRenderer.sprite = CusAssets.Instance.GetSprite();
    }
    
    // Function to destroy the object (after order submission)
    public void DestroySelf()
    {
        Destroy(gameObject);
    }
    public ActiveOrder GetCustomerOrder()
    {
        return CustomerCoffeeOrder;
    }
    
}
