using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{

    public GameObject SettingsScreen;

    public AudioMixer audioMixer;

    public void SetVolume (float volume){
        audioMixer.SetFloat("volume", volume);
    }

    public void SetFullScreen(bool isFullScreen){
        Screen.fullScreen = isFullScreen;
    }

    public void Back(){
        SettingsScreen.SetActive(false);
    }
}
