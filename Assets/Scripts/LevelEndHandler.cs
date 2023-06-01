using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEndHandler : MonoBehaviour
{

    public GameObject gameOverScreen;
    public GameObject gameWonText;
    public GameObject gameLostText;

    public GameObject levelEndScreen;
    public GameObject levelEndText;

    public int CoinsRequired;
    
    public float levelTimer;
    private void Awake()
    {
        Invoke("EndLevel", levelTimer);
    }

    void EndLevel()
    {
        if (SceneManager.GetActiveScene().name == "Level1")
        {
            levelEndScreenFunc(CoinController.Instance.Coins);
        }
        else if (SceneManager.GetActiveScene().name == "Level2")
        {
            levelEndScreenFunc(CoinController.Instance.Coins);
        }
        else if (SceneManager.GetActiveScene().name == "Level3")
        {
            isGameWon(CoinController.Instance.Coins);
        }
    }

    public void levelEndScreenFunc(int coinsGathered)
    {
        levelEndScreen.SetActive(true);
        levelEndText.GetComponent<TMP_Text>().text = "Level over! Coins collected: " + coinsGathered;
        levelEndText.SetActive(true);
    }

    public void switchToNextLevel()
    {
        if (SceneManager.GetActiveScene().name == "Level1")
        {
            SceneManager.LoadScene("Level2");
        }
        else if (SceneManager.GetActiveScene().name == "Level2")
        {
            SceneManager.LoadScene("Level3");
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
