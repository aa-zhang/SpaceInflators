using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioClip mainMenuBGM;
    [SerializeField] AudioClip inGameBGM;

    public bool toggle = true;

    AudioSource source;

    private void OnEnable()
    {
        SceneManager.activeSceneChanged += UpdateBGM;
    }

    public void UpdateBGM(Scene current, Scene next)
    {
        if (next.buildIndex == Constants.GameSceneIndex)
        {
            SetAndStartBGM(inGameBGM);
        }
        if (next.buildIndex == Constants.MainMenuSceneIndex)
        {
            SetAndStartBGM(mainMenuBGM);
        }
    }

    public void SetAndStartBGM(AudioClip clip)
    {
        source.Stop();
        source.clip = clip;
        source.Play();
    }

    private void Awake()
    {
        source = GetComponent<AudioSource>();
        SetAndStartBGM(mainMenuBGM);
        DontDestroyOnLoad(this);
    }

    private void Update()
    {
        source.loop = toggle;
    }
}
