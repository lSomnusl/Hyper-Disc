using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public GameObject pausePanel;


    private void Start()
    {
        pausePanel.SetActive(false);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }

    public void ExitGame()
    {
        Debug.Log("Viva Maduro");
        Application.Quit();
    }

    public void GoMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;

    }

    public void Pausar()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ContinueGame()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1f;
    }
}
