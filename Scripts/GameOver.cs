using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    void Start(){
        Time.timeScale = 0f;
    }

    public void Retry(){
        int scene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
        Time.timeScale = 1f;
    }

     public void MainMenu(){
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
    }

     public void Quit(){
        Application.Quit();
        Debug.Log("Quit");
    }

}
