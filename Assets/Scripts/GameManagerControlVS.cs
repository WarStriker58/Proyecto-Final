using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerControlVS : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeSceneMenu()
    {
        SceneManager.LoadScene("OpeningScene");
    }
    public void ChangeSceneGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
