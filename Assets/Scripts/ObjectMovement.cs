using System;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    // Contains ObjectMovement logic
    private Vector3 _offset;
    private float _zCoord;

    // These 3 functions handle how you move an object (Drag and Drop)
    private void OnMouseDown()
    {
        _zCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        _offset = gameObject.transform.position - GetMouseWorldPos();
    }

    private Vector3 GetMouseWorldPos()
    {
        var mousePoint = Input.mousePosition;
        mousePoint.z = _zCoord;
        
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    private void OnMouseDrag()
    {
        transform.position = GetMouseWorldPos() + _offset;
    }
}