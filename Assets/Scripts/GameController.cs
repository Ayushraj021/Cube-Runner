using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject tapTostart;
    public GameObject scoreText;
    public void Start()
    {
        gameOverPanel.SetActive(false);
        PauseGame();
        tapTostart.SetActive(true);
        scoreText.SetActive(false);
        
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            StartGame();
        }
    }
    public void gameOver()
    {
        gameOverPanel.SetActive(true);
        scoreText.SetActive(false);

    }
    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }
    public void Quitgame()
    {
        Application.Quit();
    }
    public void PauseGame()
    {
        Time.timeScale = 0f;

    }
    public void StartGame()
    {
        Time.timeScale = 1f;
        tapTostart.SetActive(false);
        scoreText.SetActive(true);
    }
}
