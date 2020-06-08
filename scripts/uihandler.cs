using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class uihandler : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(3);
    }
    public void quitgame()
    {
        Application.Quit();
    }
    public void help()
    {
        SceneManager.LoadScene(2);
    }
    public void menu()
    {
        SceneManager.LoadScene(0);
    }
}
