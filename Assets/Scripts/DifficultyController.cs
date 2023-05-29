using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DifficultyController : MonoBehaviour
{
    private Scene currentScene;
    
    public enum Difficulty
    {
        Easy,
        Medium,
        Hard,
    }

    public static Difficulty currentDifficulty;

    private void Awake()
    {
        currentScene = SceneManager.GetActiveScene();
        if (currentScene.name == "Level1")
        {
            currentDifficulty = Difficulty.Easy;
        }
        else if (currentScene.name == "Level2")
        {
            currentDifficulty = Difficulty.Medium;
        }
        else if (currentScene.name == "Level3")
        {
            currentDifficulty = Difficulty.Hard;
        }
    }
    
    public static Difficulty fetchDifficulty()
    {
        return currentDifficulty;
    }

}
