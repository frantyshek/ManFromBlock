using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stomper : MonoBehaviour
{
    public int damageToDeal;
    private Rigidbody2D rb;
    public float Force;
    public AudioSource enemyDied;

    void Start()
    {
        rb = transform.parent.GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "Hitbox"){
        other.gameObject.GetComponent<EnemyHP>().TakeDamage(damageToDeal);
        rb.AddForce(transform.up * Force, ForceMode2D.Impulse);
        enemyDied.Play();
        }
        if(other.gameObject.tag == "HitBox"){
        other.gameObject.GetComponent<EnemyBossHP>().TakeDamage(damageToDeal);        
        rb.AddForce(transform.up * Force, ForceMode2D.Impulse);
        enemyDied.Play();
        }
    }
}
