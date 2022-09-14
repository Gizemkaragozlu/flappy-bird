using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameoverCanvas;
    public GameObject scoreCanvas;
    public int score = 0;
    public Text ScoreText;

    public void addScore()
    {
        score++;
        ScoreText.text = score.ToString();
    }
    private void Start()
    {
        score = 0;
        scoreCanvas.SetActive(true);
        Time.timeScale = 1;
    }
    
    public void GameOver()
    {
        scoreCanvas.SetActive(false);
        gameoverCanvas.SetActive(true);
        Time.timeScale = 0;
    }
    public void Replay()
    {
        SceneManager.LoadScene(0);
    }
}