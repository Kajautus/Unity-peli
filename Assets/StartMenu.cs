using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    

    public GameObject startMenuUI;

    public GameObject controlMenu;

    public GameObject volumeMenu;

    public GameObject quitMenu;

    public GameObject storyBeat;

    public AudioSource menuSound;

    public AudioSource selectSound;

    public AudioSource pauseMenuMusic;
    // Update is called once per frame
    
    private void Start()
    {
        
        menuSound.ignoreListenerPause = true;
        selectSound.ignoreListenerPause = true;
        pauseMenuMusic.ignoreListenerPause = true;
        pauseMenuMusic.Play();
        startMenuUI.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Time.timeScale = 0f;
    }
    void Update()
    {

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Time.timeScale = 0f;
    }




    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Controls()
    {
        selectSound.Play();
        startMenuUI.SetActive(false);
        controlMenu.SetActive(true);
        
      
    }

    public void BackButton()
    {
        selectSound.Play();
        storyBeat.SetActive(false);
        controlMenu.SetActive(false);
        volumeMenu.SetActive(false);
        quitMenu.SetActive(false);
        startMenuUI.SetActive(true);
       
    }

   
    public void storyMenu()
    {
        selectSound.Play();
        startMenuUI.SetActive(false);
        storyBeat.SetActive(true);
    }

 
    public void VolumeAndMouse()
    {
        selectSound.Play();
        startMenuUI.SetActive(false);
        volumeMenu.SetActive(true);
        
       
    }
    public void QuitGame()
    {
        selectSound.Play();
        startMenuUI.SetActive(false);
        quitMenu.SetActive(true);
       

    }


    public void ReallyQuitGame()
    {
        selectSound.Play();
        Debug.Log("Quitting game");
        Application.Quit();
    }
}
