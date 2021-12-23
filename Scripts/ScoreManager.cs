using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public static ScoreManager instance;
    int score;
    public Text text;

    void Start()
    {
        if(instance == null){
            instance = this;
        }
    }

    public void ChangeScore(int coin){
        score += coin;
        text.text = score.ToString();
    }
}
