using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class ActiveOrder
{
    // Fetch the Current Difficulty to determine what order to construct
    private DifficultyController.Difficulty difficulty;
    
    // for displaying the coffee/tea name in dialogue box
    private Dictionary<Order.CoffeeName, String> dialogueNames;
    
    // ActiveOrder class creates an instace of Order and assigns a random recipe
    public Order.CoffeeName CoffeeName;
    public List<Item> CurrentOrder;
    public String DialogueName;

    // This constructor is responsible for assigning a random recipe to ActiveOrder
    public ActiveOrder()
    {
        difficulty = DifficultyController.fetchDifficulty();
        var orderNumber = Random.Range(0, Order.possibleOrders.Count);
        CoffeeName = (Order.CoffeeName)orderNumber;
        CurrentOrder = Order.possibleOrders[CoffeeName];
        SetDrinkNames();
        DialogueName = dialogueNames[CoffeeName];
    }

    private void SetDrinkNames()
    {
        dialogueNames = new Dictionary<Order.CoffeeName, String>();
        dialogueNames.Add(Order.CoffeeName.Black, "black coffee");
        dialogueNames.Add(Order.CoffeeName.StrongBlack, "strong black coffee");
        dialogueNames.Add(Order.CoffeeName.BlackChocolate, "black coffee with chocolate");
        dialogueNames.Add(Order.CoffeeName.StrongBlackChocolate, "strong black coffee with chocolate");
        dialogueNames.Add(Order.CoffeeName.White, "white coffee");
        dialogueNames.Add(Order.CoffeeName.StrongWhite, "strong white coffee");
        dialogueNames.Add(Order.CoffeeName.WhiteChocolate, "white coffee with chocolate");
        dialogueNames.Add(Order.CoffeeName.StrongWhiteChocolate, "strong white coffee with chocolate");
        dialogueNames.Add(Order.CoffeeName.Tea, "tea");
        dialogueNames.Add(Order.CoffeeName.StrongTea, "strong tea");
        dialogueNames.Add(Order.CoffeeName.ChocolateTea, "tea with chocolate");
        dialogueNames.Add(Order.CoffeeName.StrongChocolateTea, "strong tea with chocolate");
        dialogueNames.Add(Order.CoffeeName.WhiteTea, "white tea");
        dialogueNames.Add(Order.CoffeeName.StrongWhiteTea, "strong white tea");
        dialogueNames.Add(Order.CoffeeName.ChocolateWhiteTea, "white tea with chocolate");
        dialogueNames.Add(Order.CoffeeName.StrongChocolateWhiteTea, "strong white tea with chocolate");
    }
}
