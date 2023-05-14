using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainManu : MonoBehaviour
{
    public void playGame()  //play gomb event
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);

    }
    public void QuitGame()
    { 
      Application.Quit();  //kilépés gomb event
    }
    public void backtomenu()  //play gomb event
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);

    }

}
