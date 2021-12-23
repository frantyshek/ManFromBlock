using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour
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
        movePos.x =startPos.x + Mathf.Sin(Time.time * moveFreq) * moveDis;
        transform.position = new Vector2(movePos.x, transform.position.y);    
    }
}
