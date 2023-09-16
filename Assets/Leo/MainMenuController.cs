using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void EnterGame()
    {
        SceneManager.LoadScene(Constants.GameSceneIndex);
    }

    public void ExitGame()
    {
#if UNITY_EDITOR
        Debug.Log("Application quit");
#endif
        Application.Quit();
    }
}
