using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] public bool gameIsPaused;
    [SerializeField] private static bool gameOnOptions;
    [SerializeField] private GameObject pauseMenuUI;
    [SerializeField] private GameObject pauseMenuMain;
    [SerializeField] private GameObject pauseMenuOptions;
    [SerializeField] private GameObject Player;
    [SerializeField] private SFPSC_PlayerMovement PlayerScript;
    [SerializeField] public AudioMixer mixer;



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && gameOnOptions == false)
        {
            gameIsPaused = !gameIsPaused;
            PauseGame();
        }
    }


    public void SetMasterAudio(float sliderValue)
    {
        mixer.SetFloat("MasterVol", Mathf.Log10(sliderValue) * 20);
    }

    public void SetSFXAudio(float sliderValue)
    {
        mixer.SetFloat("SFXVol", Mathf.Log10(sliderValue) * 20);
    }

    public void SetAmbianceAudio(float sliderValue)
    {
        mixer.SetFloat("AmbianceVol", Mathf.Log10(sliderValue) * 20);
    }

    public void SetMusicAudio(float sliderValue)
    {
        mixer.SetFloat("MusicVol", Mathf.Log10(sliderValue) * 20);
    }

    public void ActivateMenu()
    {
        pauseMenuMain.SetActive(true);


    }

    public void DeactivateMenu()
    {
        pauseMenuMain.SetActive(false);
        gameIsPaused = false;
        AudioListener.pause = false;
        Time.timeScale = 1;
        PlayerScript.enableMovement = true;
        PlayerScript.LockMouse();

    }

    public void ActivateOptions()
    {
        pauseMenuMain.SetActive(false);
        pauseMenuOptions.SetActive(true);
        gameOnOptions = true;
    }

    public void DeactivateOptions()
    {
        pauseMenuMain.SetActive(true);
        pauseMenuOptions.SetActive(false);
        gameOnOptions = false;
    }

  


    void PauseGame()
    {
        if (gameIsPaused)
        {
            AudioListener.pause = true;
            PlayerScript.enableMovement = false;
            Time.timeScale = 0;
            PlayerScript.UnlockMouse();
            ActivateMenu();
        }
        else
        {
            AudioListener.pause = false;
            Time.timeScale = 1;
            gameIsPaused = false;
            PlayerScript.enableMovement = true;
            PlayerScript.LockMouse();
            DeactivateMenu();
        }
    }


}
