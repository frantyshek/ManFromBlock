using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public GameObject SettingsScreen;
    public GameObject CreditsScreen;
    public GameObject SelectLevelScreen;

    public void Play(){
        SceneManager.LoadScene("Game1");
    }

    public void Quit(){
        Application.Quit();
    }

    public void Settings(){
        SettingsScreen.SetActive(true);
    }

    public void Credits(){
        CreditsScreen.SetActive(true);
    }
    
    public void LevelSelect(){
        SelectLevelScreen.SetActive(true);
    }

}
