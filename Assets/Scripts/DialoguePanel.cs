using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialoguePanel : MonoBehaviour
{
    public static GameObject dialoguePanelObject;

    private void Awake()
    {
        Debug.Log("Awaking DialoguePanel");
        dialoguePanelObject = gameObject;
        gameObject.SetActive(false);
        Debug.Log(dialoguePanelObject);
    }

    public static GameObject fetchDialoguePanel()
    {
        Debug.Log(dialoguePanelObject);
        return dialoguePanelObject;
    }
}
