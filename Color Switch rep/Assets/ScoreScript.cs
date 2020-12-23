using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    [SerializeField] private Transform Player;
    public Text scoreText;
    float score_tmp = 0f;
   
    void Update()
    {
        //float score_tmp = 0f;
        //Player.transform.position = new Vector3(0, Player.transform.position.y, Player.transform.position.z);
        //Debug.Log(Player.transform.position);
        if ((int)Player.transform.position.y > (int)score_tmp)
        {
            //score_tmp = Player.transform.position.y / 5;
            score_tmp++;
        }
        //scoreText.text = Player.transform.y.ToString("0");
        scoreText.text = score_tmp.ToString("0");
    }
}
