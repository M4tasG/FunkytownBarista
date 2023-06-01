using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionSheet : MonoBehaviour
{
    public GameObject instructionSheet;
    
    private void OnMouseDown()
    {
        instructionSheet.SetActive(true);
    }
}
