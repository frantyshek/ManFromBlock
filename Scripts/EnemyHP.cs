using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    private int coin = 100;
    public int enemyHP;
    private int currentHP;
    public bool isDead;

    void Start()
    {
        currentHP = enemyHP;
    }

    void Update()
    {
        if(currentHP <= 0){
            isDead = true;
            Destroy(transform.parent.gameObject);
            ScoreManager.instance.ChangeScore(coin);
        }
    }

    public void TakeDamage(int damage){
        currentHP -= damage;
    }
}
