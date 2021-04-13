using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    bool gameOver = false;
    int score = 0;
    public Text scoreNumber;

    public GameObject gameOverPanel;
    

    private void Awake()
    {
        instance = this;
    }
    public void GameOver()
    {
        gameOver = true;

        GameObject.Find("ObstacleSpawner").GetComponent<ObstacleSpawner>().StopSpawning();

        gameOverPanel.SetActive(true);
    }
    public void IncreatmentScore()
    {
        if (!gameOver)
        {
            score++;
            scoreNumber.text = score.ToString(); 
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
