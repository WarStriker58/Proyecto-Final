using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerControlSS : MonoBehaviour
{
    public int points;
    public Text textPoints;
    private bool isPaused = false;

    // Start is called before the first frame update
    void Start()
    {
        UpdatePoints(0);
    }

    // Update is called once per frame
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
}
