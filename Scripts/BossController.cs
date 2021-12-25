using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossController : MonoBehaviour
{

    public Transform FirePoint;
    public GameObject laserPrefab;
    public float laserForce;
    public float attackSpeed;
    [SerializeField]
    private float shotTimer;
    private EnemyHP bossHP;
    public AudioSource audioShoot;

    void Start()
    {
        shotTimer = attackSpeed;
    }

    void Update()
    {
        shotTimer -= Time.deltaTime;
        if(shotTimer <= 0){
            shotTimer = attackSpeed;
            shoot();
        }
    }

    void shoot(){
        GameObject laser = Instantiate(laserPrefab, FirePoint.position, FirePoint.rotation);
        Rigidbody2D rb = laser.GetComponent<Rigidbody2D>();
        rb.AddForce(FirePoint.up * laserForce, ForceMode2D.Impulse);
        audioShoot.Play();
    }
}
