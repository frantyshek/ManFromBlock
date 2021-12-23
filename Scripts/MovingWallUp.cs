using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingWallUp : MonoBehaviour
{

    Vector2 movePos;
    Vector2 startPos;
    public float moveFreq;
    public float moveDis;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        movePos.y =startPos.y + Mathf.Sin(Time.time * moveFreq) * moveDis;
        transform.position = new Vector2(transform.position.x, movePos.y);    
    }
}