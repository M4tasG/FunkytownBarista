using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CameraController : MonoBehaviour
{
    private enum possibleCameraStates
    {
        Left,
        Middle,
        Right,
    }

    public Camera sceneCamera;

    public Button leftButton;
    public Button rightButton;
    
    private possibleCameraStates currentCameraState;
    
    // Start is called before the first frame update
    void Start()
    {
        currentCameraState = possibleCameraStates.Left;
    }

    public void resolveButtonsForCameraState()
    {
        if (currentCameraState == possibleCameraStates.Left)
        {
            leftButton.gameObject.SetActive(false);
            rightButton.gameObject.SetActive(true);
        }
        else if (currentCameraState == possibleCameraStates.Middle)
        {
            leftButton.gameObject.SetActive(true);
            rightButton.gameObject.SetActive(true);
        }
        else if (currentCameraState == possibleCameraStates.Right)
        {
            leftButton.gameObject.SetActive(true);
            rightButton.gameObject.SetActive(false);
        }
    }
    
    public void moveCameraLeft()
    {
        sceneCamera.transform.position =
            new Vector3(sceneCamera.transform.position.x - 10, sceneCamera.transform.position.y, sceneCamera.transform.position.z);
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
            new Vector3(sceneCamera.transform.position.x + 10, sceneCamera.transform.position.y, sceneCamera.transform.position.z);
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
}
