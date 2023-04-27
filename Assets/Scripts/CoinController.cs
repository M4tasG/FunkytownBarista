using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    public int Coins;

    private void Awake()
    {
        Coins = 0;
        OrderDelivery.SetCoinObject(gameObject);
    }

    public void AddCoins(int amount)
    {
        Coins = Coins + amount;
    }

    public void SubtractCoins(int amount)
    {
        Coins = Coins - amount;
    }
}
