using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool gameIsPaused = false;

    public GameObject PauseMenuUI;
    public GameObject inGameUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        inGameUI.SetActive(true);
        Time.timeScale = 1f;
    }
    public void Pause()
    {
        inGameUI.SetActive(false);
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
    }
    public void QuitGame()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
