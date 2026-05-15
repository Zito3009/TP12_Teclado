using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    bool pressed = false;
    
    void OnMouseDown()
    {
        Debug.Log("Click en " + gameObject.name);
        transform.Translate(0, -1, 0);
        pressed = true;
    }

    void OnMouseUp()
    {
        if(pressed)
    }
}
