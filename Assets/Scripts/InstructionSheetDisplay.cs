using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionSheetDisplay : MonoBehaviour
{
    public GameObject instructionSheet;

    public void closeInstructionSheet()
    {
        instructionSheet.SetActive(false);
    }
}
