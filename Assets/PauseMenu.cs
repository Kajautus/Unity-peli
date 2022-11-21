using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPause = false;

    public GameObject pauseMenuUI;

    public GameObject controlMenu;

    public GameObject volumeMenu;

    public GameObject quitMenu;

    public GameObject gameOver;

    public AudioSource menuSound;

    public AudioSource selectSound;

    public AudioSource pauseMenuMusic;
    // Update is called once per frame
    public AudioSource die;
    private void Start()
    {
        die.ignoreListenerPause = true;
        menuSound.ignoreListenerPause = true;
        selectSound.ignoreListenerPause = true;
        pauseMenuMusic.ignoreListenerPause = true;
        Resume();
    }
    void Update()
    {
        if (PlayerHealth.health <= 0)
        {
            
            gameOverScreen();
            Invoke("DieSound", 2f);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPause)
            {
                
                menuSound.Play();
                Resume();

            }
            else
            {   
                
                menuSound.Play();
                Pause();
                
            }
        }

        
    }

    public void Resume()
    {
        menuSound.Play();
        pauseMenuMusic.Stop();
        AudioListener.pause = false;
        quitMenu.SetActive(false);
        volumeMenu.SetActive(false);
        pauseMenuUI.SetActive(false);
        controlMenu.SetActive(false);
        Time.timeScale = 1f;
        GameIsPause = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        
    }

    void Pause()
    {
        pauseMenuMusic.Play();
        AudioListener.pause = true;
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPause = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void Controls()
    {
        selectSound.Play();
        pauseMenuUI.SetActive(false);
        controlMenu.SetActive(true );
        Time.timeScale = 0f;
        GameIsPause = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void BackButton()
    {
        selectSound.Play();
        controlMenu.SetActive(false);
        volumeMenu.SetActive(false);
        quitMenu.SetActive(false );
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPause = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void gameOverScreen()
    {
        
        AudioListener.pause = true;
        gameOver.SetActive(true);
        Time.timeScale = 0f;
        GameIsPause = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void DieSound()
    {
        die.Play();
    }
    public void Continue()
    {
        die.Play();
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.buildIndex);

    }
    public void VolumeAndMouse()
    {
        selectSound.Play();
        pauseMenuUI.SetActive(false);
        volumeMenu.SetActive(true);
        Time.timeScale = 0f;
        GameIsPause = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void QuitGame()
    {
        selectSound.Play();
        pauseMenuUI.SetActive(false);
        quitMenu.SetActive(true);
        Time.timeScale = 0f;
        GameIsPause = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

    }

    
    public void ReallyQuitGame()
    {
        selectSound.Play();
        Debug.Log("Quitting game");
        Application.Quit();
    }
}
