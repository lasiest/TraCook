using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SateSceneManager : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Clicked(){
        Debug.Log("Clicked");
    }

    public void MainMenu(){
        SceneManager.LoadScene(0);
    }
}
