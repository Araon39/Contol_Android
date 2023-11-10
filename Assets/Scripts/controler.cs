using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controler : MonoBehaviour
{
    public Joystick joystick;
    public float speed = 0.1f;
    void FixedUpdate()
    {
        float moveHorizontal = joystick.Horizontal;
        float moveVertical = joystick.Vertical;
        
        transform.Translate(Vector3.up * moveVertical * speed );
        transform.Translate(Vector3.right * moveHorizontal * speed );
    }
}
