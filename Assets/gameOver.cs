using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour
{
    public GameObject GameOver;

    public AudioSource die;
    // Start is called before the first frame update
    void Awake()
    {
        die.ignoreListenerPause = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerHealth.health <= 0)
        {

            gameOverScreen();

        }
    }

    public void gameOverScreen()
    {

        AudioListener.pause = true;
        GameOver.SetActive(true);
        Time.timeScale = 0f;
        
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void Continue()
    {
        
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.buildIndex);

    }
}
