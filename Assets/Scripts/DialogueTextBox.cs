using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogueTextBox : MonoBehaviour
{
    public static GameObject dialogueTextBoxObject;
    public static TMP_Text dialogueText;

    private void Awake()
    {
        dialogueTextBoxObject = gameObject;
        dialogueText = gameObject.GetComponent<TMP_Text>();
    }

    public static TMP_Text fetchDialogueTextBox()
    {
        return dialogueText;
    }
}
