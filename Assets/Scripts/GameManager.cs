using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int score = 0;
    private bool isGameOver = false;

    void Start()
    {
        score = 0;
    }

    public int getScore() { return score; }
    public bool getGameOver() { return isGameOver; }
    public void IncrementScore(int value)
    {
        score += value;
    }
    void GameOver()
    {
        isGameOver = true;
    }

    void Update()
    {
        if (!isGameOver)
        {
            // Gameloop stuff
        }
    }
}
