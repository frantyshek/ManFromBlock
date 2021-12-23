using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    public float speed;
    public float rayLength;
    private bool moveLeft;
    public Transform contactChecker;

    void Start()
    {
        moveLeft = true;        
    }

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    private void FixedUpdate(){
        int layerMask = 7 << 6;
        layerMask = ~layerMask;

        RaycastHit2D contactCheck = Physics2D.Raycast(contactChecker.position, Vector2.down, rayLength, layerMask);
        if(contactCheck == false){
            if(moveLeft == true){
                transform.eulerAngles = new Vector2(0,-180);
                moveLeft = false;
            }
            else{
                transform.eulerAngles = new Vector2(0,0);
                moveLeft = true;
            }
        }
    }

}