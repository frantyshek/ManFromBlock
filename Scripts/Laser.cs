using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{

    public GameObject particles;

    private void OnTriggerEnter2D(Collider2D other){
        GameObject effect = Instantiate(particles, transform.position, Quaternion.identity);
        Destroy(effect, 1f);
        Destroy(gameObject);
    }
}
