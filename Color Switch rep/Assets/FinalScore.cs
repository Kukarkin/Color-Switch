using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    public Text score;
    public Text fin_score;
    void Start()
    {
        fin_score.text = score.text;
    }

   
}
