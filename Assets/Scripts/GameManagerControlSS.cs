using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerControlSS : MonoBehaviour
{
    public int points;
    public Text textPoints;

    // Start is called before the first frame update
    void Start()
    {
        UpdatePoints(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdatePoints(int score)
    {
        points = points + score;
        textPoints.text = "Puntos: " + points;
    }
}
