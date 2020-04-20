using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour
{
    [SerializeField]
    private Text playerScore;
    private int playerHolder;
    [SerializeField]
    private Text nanoScore;
    private int nanoHolder;

    [SerializeField]
    private Text winText;
    [SerializeField]
    private Text loseText;

    public int winScore;
    public int loseScore;

    public RectTransform gamePanel;
    public Button resetButton;
    
    private void GameOverLose()
    {
        gamePanel.gameObject.SetActive(true);
        loseText.gameObject.SetActive(true);
        resetButton.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
    private void GameOverWin()
    {
        gamePanel.gameObject.SetActive(true);
        winText.gameObject.SetActive(true);
        resetButton.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // loads current scene
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver)
        {
            GameOverLose();
        }
        else if (gameWon)
        {
            GameOverWin();
        }
    }

    public bool gameOver
    {
        get
        {
            if (nanoHolder == loseScore)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }

    public bool gameWon
    {
        get
        {
            if (playerHolder == winScore)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

    public void SetPlayerScore()
    {
        playerHolder++;
        playerScore.text = "Player: " + playerHolder;
    }
    public void SetNanoScore(int score)
    {
        nanoScore.text = "Nanobots: " + score;
        nanoHolder = score;
    }
}
