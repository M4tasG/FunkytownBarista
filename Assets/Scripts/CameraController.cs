using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CameraController : MonoBehaviour
{
    public enum possibleCameraStates
    {
        Left,
        Middle,
        Right,
    }

    public Camera sceneCamera;

    public Button leftButton;
    public Button rightButton;

    private GameObject dialoguePanel;

    private static bool isFirstDialogue = true;
    
    //public GameObject dialoguePanel;
    
    public possibleCameraStates currentCameraState;
    
    void Awake()
    {
        Invoke("SetDialoguePanel", 0.02f);
        currentCameraState = possibleCameraStates.Left;
        Invoke("resolveButtonsForCameraState", 0.3f);
    }

    void SetDialoguePanel()
    {
        dialoguePanel = DialoguePanel.fetchDialoguePanel();
    }
    
    public void resolveButtonsForCameraState()
    {
        if (currentCameraState == possibleCameraStates.Left)
        {
            if (isFirstDialogue)
            {
                //dialoguePanel.SetActive(true);
                isFirstDialogue = false;
            }
            else
            {
                dialoguePanel.SetActive(true);
            }
            //dialoguePanel.SetActive(true);
            leftButton.gameObject.SetActive(false);
            rightButton.gameObject.SetActive(true);
            //dialoguePanel.SetActive(true);
        }
        else if (currentCameraState == possibleCameraStates.Middle)
        {
            dialoguePanel.SetActive(false);
            leftButton.gameObject.SetActive(true);
            rightButton.gameObject.SetActive(true);
            //dialoguePanel.SetActive(false);
        }
        else if (currentCameraState == possibleCameraStates.Right)
        {
            dialoguePanel.SetActive(false);
            leftButton.gameObject.SetActive(true);
            rightButton.gameObject.SetActive(false);
            //dialoguePanel.SetActive(false);
        }
    }
    
    public void moveCameraLeft()
    {
        sceneCamera.transform.position =
            new Vector3(sceneCamera.transform.position.x - 17.78f, sceneCamera.transform.position.y, sceneCamera.transform.position.z);
        if (currentCameraState == possibleCameraStates.Middle)
        {
            currentCameraState = possibleCameraStates.Left;
        }
        else if (currentCameraState == possibleCameraStates.Right)
        {
            currentCameraState = possibleCameraStates.Middle;
        }
        resolveButtonsForCameraState();
    }
    public void moveCameraRight()
    {
        sceneCamera.transform.position =
            new Vector3(sceneCamera.transform.position.x + 17.78f, sceneCamera.transform.position.y, sceneCamera.transform.position.z);
        if (currentCameraState == possibleCameraStates.Middle)
        {
            currentCameraState = possibleCameraStates.Right;
        }
        else if (currentCameraState == possibleCameraStates.Left)
        {
            currentCameraState = possibleCameraStates.Middle;
        }
        resolveButtonsForCameraState();
    }

    public static void setFirstDialogue(bool val)
    {
        isFirstDialogue = val;
    }
    
}
