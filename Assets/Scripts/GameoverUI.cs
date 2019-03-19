using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameoverUI : MonoBehaviour {

    public void Quit()
    {
        
        Debug.Log("Application Quit!");
        scoreScript.scoreValue = 0;
        Application.Quit();
        
    }
    public void Retry()
    {
       
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        scoreScript.scoreValue = 0;

    }
}
