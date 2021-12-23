using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{

    public int coin = 100;

    public void OnTriggerEnter2D (Collider2D other){
        if(other.gameObject.tag =="Player"){
            ScoreManager.instance.ChangeScore(coin);
        }
    }

}
