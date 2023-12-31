using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerControlSS : MonoBehaviour
{
    public int points;
    public Text textPoints;
    private bool isPaused = false;
    public int lives;
    public Text textLives;
    public float victoryTime = 120f;  
    private float elapsedTime = 0f;

    void Start()
    {
        UpdatePoints(0);
        UpdateLives();
    }

    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void ChangeSceneVictory()
    {
        ChangeScene("VictoryScene");
    }

    public void ChangeSceneDefeat()
    {
        ChangeScene("DefeatScene");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
        elapsedTime = elapsedTime + Time.deltaTime;
        if (elapsedTime >= victoryTime)
        {
            ChangeSceneVictory();
        }
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        isPaused = true;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        isPaused = false;
    }

    public void UpdatePoints(int score)
    {
        points = points + score;
        textPoints.text = "Puntaje: " + points;
    }

    public void UpdateLives()
    {
        lives = lives - 1;
        textLives.text = "Vidas: " + lives;
    }

    public void PlayerDefeated()
    {
        ChangeSceneDefeat();
    }
}