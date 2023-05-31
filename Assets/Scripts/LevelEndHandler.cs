using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEndHandler : MonoBehaviour
{

    public GameObject gameOverScreen;
    public GameObject gameWonText;
    public GameObject gameLostText;

    public int CoinsRequired;
    
    public float levelTimer;
    private void Awake()
    {
        Invoke("SwitchLevel", levelTimer);
    }

    void SwitchLevel()
    {
        if (SceneManager.GetActiveScene().name == "Level1")
        {
            SceneManager.LoadScene("Level2");
        }
        else if (SceneManager.GetActiveScene().name == "Level2")
        {
            SceneManager.LoadScene("Level3");
        }
        else if (SceneManager.GetActiveScene().name == "Level3")
        {
            isGameWon(CoinController.Instance.Coins);
        }
    }
    public void isGameWon(int coinsGathered)
    {
        gameOverScreen.SetActive(false);
        gameWonText.SetActive(false);
        gameLostText.SetActive(false);
        gameOverScreen.SetActive(true);
        if (coinsGathered >= CoinsRequired)
        {
            gameWonText.SetActive(true);
        }
        else
        {
            gameLostText.SetActive(true);
        }
    }
}
