using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI_CoinCounter : MonoBehaviour
{
    private static TextMeshProUGUI UICoinCounter;

    private void Awake()
    {
        UICoinCounter = gameObject.GetComponent<TextMeshProUGUI>();
        changeCoinCount(CoinController.Instance.Coins);
    }

    public static void changeCoinCount(int amount)
    {
        UICoinCounter.text = amount.ToString();
    }
    
}
