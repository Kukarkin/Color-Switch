using UnityEngine;
using UnityEngine.UI;

public class ShowRecord : MonoBehaviour
{
    public Text record;
    void Start()
    {
        record.text = PlayerPrefs.GetFloat("HighScore").ToString("0");
    }

}
