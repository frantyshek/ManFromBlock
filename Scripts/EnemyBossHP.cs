using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBossHP : MonoBehaviour
{
    public int enemyHP;
    private int currentHP;
    public bool isDead;
    public GameObject Finish;
    public SliderHP HealthBar;
    public GameObject Slider;

    void Start()
    {
        currentHP = enemyHP;
        HealthBar.SetHealth(currentHP, enemyHP);
    }

    void Update()
    {
        if(currentHP <= 0){
            isDead = true;
            Destroy(Slider);
            Destroy(transform.parent.gameObject);
        }
        if(isDead){
            Finish.SetActive(true);
        }
    }

    public void TakeDamage(int damage){
        currentHP -= damage;
        HealthBar.SetHealth(currentHP, enemyHP);
    }
}
