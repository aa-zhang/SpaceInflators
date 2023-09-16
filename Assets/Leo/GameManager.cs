using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] UnityEvent OnGameOver;
    [SerializeField] AudioClip gameOverBGM;
    AudioManager audioManager;
    public static GameManager manager;

    private void Awake()
    {
        audioManager = FindObjectOfType<AudioManager>();

        if (!manager)
        {
            manager = this;
        }
    }

    public void TriggerGameOver()
    {
        OnGameOver.Invoke();
        Time.timeScale = 0;
        audioManager.SetAndStartBGM(gameOverBGM);
    }

    public void ReloadGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(Constants.GameSceneIndex);
    }

    public void LoadMainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(Constants.MainMenuSceneIndex);
    }
}
