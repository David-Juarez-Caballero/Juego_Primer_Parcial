using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    [SerializeField] private AudioSource clickSoundEffect;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused){
                Resume();
            } else
            {
                Pause();
            }
        }    
    }

    public void Resume(){
        clickSoundEffect.Play();
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void LoadMenu(){
        clickSoundEffect.Play();
        Time.timeScale = 1f;
        Debug.Log("Loading Menu");
        SceneManager.LoadScene(0);
    }

    public void QuitGame(){
        //Debug.Log("Quitting Game");
        Application.Quit();
    }

    void Pause(){
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

}
