using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    // CoinController is responsible for tracking and adjusting the current coin value (Score tracking)
    // Coins variable holds the current Coin value
    public int Coins;
    
    // When the Object in the game awakes this gets called
    // The function sets the initial value of 0
    // SetCoinObject gets called to specify the object with this script to OrderDelivery script
    private void Awake()
    {
        Coins = 0;
        OrderDelivery.SetCoinObject(gameObject);
    }

    // A Function to AddCoins to the current value
    public void AddCoins(int amount)
    {
        Coins = Coins + amount;
        UI_CoinCounter.changeCoinCount(Coins);
    }

    // A Function to Subtract coins from the current value
    public void SubtractCoins(int amount)
    {
        Coins = Coins - amount;
        UI_CoinCounter.changeCoinCount(Coins);
    }
}
