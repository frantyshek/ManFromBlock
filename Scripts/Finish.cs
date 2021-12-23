using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{

    public GameObject WinScreen;
    public AudioSource audioWin;
    int sceneIndex;
    int levelPassed;

    void Start(){
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        levelPassed = PlayerPrefs.GetInt("LevelPassed");
    }


    public void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "Player"){
            Debug.Log("Win");
            Time.timeScale = 0f;
            WinScreen.SetActive(true);
            audioWin.Play();
            if(levelPassed < sceneIndex){
                PlayerPrefs.SetInt("LevelPassed", sceneIndex);
            }
        }
    }

}
