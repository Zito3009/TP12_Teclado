using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    bool pressed = false;
    float pressedOffset = 1f;
    
    void OnMouseDown()
    {
        Debug.Log("Click en " + gameObject.name);
        transform.Translate(0, -1, 0);
        pressed = true;
    }

    void OnMouseUp()
    {
        if(pressed){
            transform.Translate(0, pressedOffset, 0);
            pressed = false;
        }
    }


}
