using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Flapy player;
    private int score;
    public Text scoreText;
    public GameObject PlayButton;
    public GameObject gameOver;

    private void Awake()
    {
        Application.targetFrameRate = 60;
        Pause();
    }
    public void Play ()
    {
        score = 0;
        scoreText.text = score.ToString();
        PlayButton.SetActive(false);
        gameOver.SetActive(false);

        Time.timeScale = 1f;
        player.enabled = true;

        Pipes[] pipes = FindObjectsOfType<Pipes>();
        foreach (var item in pipes)
        {
            Destroy(item.gameObject);
        }
    }
    public void Pause()
    {
        
        Time.timeScale = 0f;
        player.enabled = false;
    }

    public void GameOver()
    {
        gameOver.SetActive(true);
        PlayButton.SetActive(true);
        Pause();
    }
    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
