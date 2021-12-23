using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour
{

    public void Next(){
        SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1f;
    }

    public void Replay(){
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
