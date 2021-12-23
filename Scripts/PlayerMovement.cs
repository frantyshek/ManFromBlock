using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 5f;
    public float jump = 50;
    private Rigidbody2D rb;
    float movement = 0f;
    public GameObject GameOverScreen;

    public Animator animator;
    public AudioSource audioJump;
    public AudioSource audioDied;
    public AudioSource audioCoin;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();       
    }

    void Update()
    {
        movement = Input.GetAxisRaw("Horizontal");
        animator.SetFloat("Speed", Mathf.Abs(movement));    
        transform.position += new Vector3(movement, 0, 0) * speed * Time.deltaTime;
        if(!Mathf.Approximately(0,movement)){
            transform.rotation = movement < 0 ? Quaternion.Euler (0,180 ,0) : Quaternion.identity;
        }
        if(Input.GetButtonDown("Jump") && Mathf.Abs(rb.velocity.y) < 0.001f){
            rb.AddForce(new Vector2 (0, jump), ForceMode2D.Impulse);
            audioJump.Play();
        }
        if(Mathf.Abs(rb.velocity.y) < 0.001f){
            animator.SetBool("Grounded", true);
        }
        else{
            animator.SetBool("Grounded", false);
        }
    }

    public void OnTriggerEnter2D(Collider2D other){
        if((other.gameObject.tag == "Enemy") ||(other.gameObject.tag == "Spike")){
            Debug.Log("Game Over");
            Time.timeScale = 0f;
            GameOverScreen.SetActive(true);
            audioDied.Play();
        }

        if(other.gameObject.tag == "Coins"){
            Destroy(other.gameObject);
            audioCoin.Play();
        }
    }
}
