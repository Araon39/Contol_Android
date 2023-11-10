using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controler2 : MonoBehaviour
{
    public float speed;
    public float jump;
    private void Start()
    {
        speed = 0;
        jump = 0;
    }

    void FixedUpdate()
    {
        transform.Translate(Vector3.up * jump );
        transform.Translate(Vector3.right * speed );
    }
    public void MoveUpBattonClickDawn()
    {  jump = 0.1f; }
    public void MoveLeftBattonClickDawn()
    {  speed = -0.1f; }
    public void MoveRightBattonClickDawn()
    {  speed = 0.1f; }
    public void MoveBattonClickUp()
    { speed = 0; }
    public void JumpBattonClickUp()
    { jump = 0; }
}
