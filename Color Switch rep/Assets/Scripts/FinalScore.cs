using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    public Text score;
    public Text fin_score;
    public GameObject theScoreScript;

    void Start()
    {
        //GameObject theScoreScript = GameObject.Find("ScoreScript");
        if (theScoreScript.GetComponent<ScoreScript>().isNewHighScore)
        {
            fin_score.text = PlayerPrefs.GetFloat("HighScore", 0).ToString("0");
        }
        //PlayerScript playerScript = thePlayer.GetComponent<PlayerScript>();
        else
        {
            fin_score.text = score.text;
        }
        
        //if (PlayerPrefs.GetFloat("HighScore") >)
        //fin_score.text = score.text;
    }

   
}
