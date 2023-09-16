using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] UnityEvent OnGameOver;
    public static GameManager manager;

    private void Awake()
    {
        if (!manager)
        {
            manager = this;
        }
    }

    public void TriggerGameOver()
    {
        OnGameOver.Invoke();
    }

    public void ReloadGame()
    {
        SceneManager.LoadScene(Constants.GameSceneIndex);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(Constants.MainMenuSceneIndex);
    }
}
