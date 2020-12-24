using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public bool isGameOver = false;
    public GameObject GameOverUI;
    public GameObject CanvasScore;
    public void EndGame()
    {
        if (isGameOver == false)
        {
            Time.timeScale = 0f;
            GameOverUI.SetActive(true);
            CanvasScore.SetActive(false);
            Debug.Log("GAMEOVER");
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        GameOverUI.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        Debug.Log("Loading Menu...");
        SceneManager.LoadScene(0);
    }
}
