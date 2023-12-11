using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerControl : MonoBehaviour
{
    public GameObject menuContainer;
    public GameObject howtoplayContainer;
    public GameObject creditsContainer;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ChangeStateHowToPlayContainer()
    {
        if (howtoplayContainer.activeSelf == true)
        {
            howtoplayContainer.SetActive(false);
            menuContainer.SetActive(true);
        }
        else
        {
            howtoplayContainer.SetActive(true);
            menuContainer.SetActive(false);
        }
    }

    public void ChangeStateCreditsContainer()
    {
        if (creditsContainer.activeSelf == true)
        {
            creditsContainer.SetActive(false);
            menuContainer.SetActive(true);
        }
        else
        {
            creditsContainer.SetActive(true);
            menuContainer.SetActive(false);
        }
    }
}
