using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("1Room");
    }

    public void Test()
    {
        SceneManager.LoadScene("3Room");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
